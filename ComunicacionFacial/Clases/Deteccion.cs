using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;
using System.IO;
using System.Runtime.InteropServices;
using System.Media;

namespace ComunicacionFacial
{
	public class Deteccion
    {
        public enum Modos
        {
            Administrador, //No realiza acciones con gestos detectados por la camara
            Despierto, //Ejecuta clicks con gestos de la boca, cambia de modo cerrando los ojos
            Vigilia, //No ejecuta clicks, cambia de modo abriendo los ojos
            Zumbar //Ejecuta clicks con gestos de la boca, cambia de modo cerrando los ojos
        }

        public enum PartesRostro
        {
            Boca,
            Ojos
        }

		private Modos modoActual = Modos.Administrador;
        private DateTime inicioGestoOjosActivo = DateTime.MinValue;
        private DateTime inicioGestoOjosInactivo = DateTime.MinValue;
        private DateTime inicioEntreGestosBocaActivo = DateTime.MinValue;
        private DateTime inicioGestoBocaActivo = DateTime.MinValue;
        private DateTime inicioGestoBocaInactivo = DateTime.MinValue;
        public Captura captura { get; set; }
        public Configuracion configuracion { get; set; }
        private EigenObjectRecognizer reconocedorBoca;
        private EigenObjectRecognizer reconocedorOjos;
        private List<Gesto> gestosEntrenamiento = new List<Gesto>();
        private ushort iCantBocaActivo = 1;
        private ushort iCantBocaInactivo = 1;
        private ushort iCantOjosActivo = 1;
        private ushort iCantOjosInactivo = 1;
        private SoundPlayer oSonidoZumbar;
        private FileStream oArchivo;
        private BinaryWriter writer;

        public Deteccion()
        {
            //Abro el archivo para guardar los eventos
            oArchivo = File.Open("Datos/Eventos.dat", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            writer = new BinaryWriter(oArchivo, Encoding.Default);
            
            //Limpio los eventos de ejecuciones anteriores
            writer.BaseStream.Position = 0;
            //Registro 0: boca
            writer.Write((int)0);
            writer.Write((int)0);
            //Registro 1: ojos
            writer.Write((int)1);
            writer.Write((int)0);
            //Registro 2: modos
            writer.Write((int)2);
            writer.Write((int)0);
            writer.Flush();
		}

        public void generarCaptura()
        {
            configuracion.camaraActual.obtenerCaptura(reconocedorBoca, reconocedorOjos);
            captura = configuracion.camaraActual.capturaActual;

            //Guardo a archivo los estados detectados
            if (captura != null)
            {
                if (captura.gestoBoca != null)
                {
                    //Registro 0: boca
                    writer.BaseStream.Position = 4;
                    writer.Write((int)(captura.gestoBoca.gestoActivo ? 1 : 0)); //Si detecte una sonrisa guardo un 1, sino 0
                    writer.Flush();
                }
                if (captura.gestoOjos != null)
                {
                    //Registro 1: ojos
                    writer.BaseStream.Position = 12;
                    writer.Write((int)(captura.gestoOjos.gestoActivo ? 1 : 0)); //Si detecte ojos cerrados guardo 1, sino 0
                    writer.Flush();
                }
            }
        }

        public bool guardarGestosEntrenamiento(PartesRostro oParteRostro, bool bGestoActivo)
        {
            bool bRes = false;

            if (configuracion.habilitadaBoca && oParteRostro == PartesRostro.Boca)
                bRes = guardarGestoBoca(bGestoActivo);

            if (configuracion.habilitadaOjos && oParteRostro == PartesRostro.Ojos)
                bRes = guardarGestoOjos(bGestoActivo);

            return bRes;
        }

        private bool guardarGestoBoca(bool bGestoActivo)
        {
            bool bRes = false;

            if (captura.gestoBoca.imagen != null)
            {
                string sGesto;
                ushort iCant;

                if (bGestoActivo)
                {
                    sGesto = "Activo";
                    iCant = iCantBocaActivo;
                    iCantBocaActivo++;
                }
                else
                {
                    sGesto = "Inactivo";
                    iCant = iCantBocaInactivo;
                    iCantBocaInactivo++;
                }

                captura.gestoBoca.imagen.Save("Gestos/Boca/" + sGesto + iCant.ToString().PadLeft(3, '0') + ".png");
                bRes = true;
            }

            return bRes;
        }

        private bool guardarGestoOjos(bool bGestoActivo)
        {
            bool bRes = false;

            if (captura.gestoOjos.imagen != null)
            {
                string sGesto;
                ushort iCant;

                if (bGestoActivo)
                {
                    sGesto = "Activo";
                    iCant = iCantOjosActivo;
                    iCantOjosActivo++;
                }
                else
                {
                    sGesto = "Inactivo";
                    iCant = iCantOjosInactivo;
                    iCantOjosInactivo++;
                }

                captura.gestoOjos.imagen.Save("Gestos/Ojos/" + sGesto + iCant.ToString().PadLeft(3, '0') + ".png");
                bRes = true;
            }

            return bRes;
        }

        public void actualizarEntrenamiento()
        {
            reconocedorBoca = actualizarUnEntrenamiento(PartesRostro.Boca);
            reconocedorOjos = actualizarUnEntrenamiento(PartesRostro.Ojos);
        }

        private EigenObjectRecognizer actualizarUnEntrenamiento(PartesRostro oParteRostro)
        {
            //Cargo las imagenes de entrenamiento
            string sPath = "Gestos/" + ((oParteRostro == PartesRostro.Boca) ? "Boca" : "Ojos");
            DirectoryInfo oDirectorio = new DirectoryInfo(sPath);
            FileInfo[] oImagenes = oDirectorio.GetFiles("*.png");
            Image<Gray, Byte>[] oGestos = new Image<Gray, Byte>[oImagenes.Length];
            String[] oDescripciones = new String[oImagenes.Length];
            int i = 0;

            foreach (FileInfo oArchivo in oImagenes)
            {
                oGestos[i] = new Image<Gray, Byte>(oArchivo.FullName);
                oDescripciones[i] = oArchivo.Name.Substring(0, 3);
                i++;
            }

            //Creo el objeto para luego realizar las comparaciones
            MCvTermCriteria termCrit = new MCvTermCriteria(i, 0.1);
            return new EigenObjectRecognizer(oGestos, oDescripciones, 3000, ref termCrit);
        }

		public void cambiarModo(Modos modo)
        {
            if (modoActual == Modos.Zumbar && modo == Modos.Administrador)
                detenerZumbido();

            modoActual = modo;

            //Guardo a archivo el cambio de modo
            //Registro 2: modos
            writer.BaseStream.Position = 20;
            writer.Write((int)modo); //Si detecte una sonrisa guardo un 1, sino 0
            writer.Flush();
        }

        public void evaluarAcciones()
        {
            switch (modoActual)
            {
                case Modos.Administrador:
                    //En este modo no hago ninguna deteccion
                    break;

                case Modos.Despierto:
                    //Cuando esta despierto, evaluo los clicks y si se duerme
                    evaluarEjecucionClick();
                    evaluarModoVigilia();
                    break;

                case Modos.Vigilia:
                    //Si esta dormido (estoy en vigilia), envaluo si se despierta
                    evaluarModoZumbar();
                    break;

                case Modos.Zumbar:
                    //Si esta sonando la alarma, evaluo los clicks y si quiere apagarla
                    evaluarEjecucionClick();
                    evaluarModoDespierto();
                    break;

                default:
                    //Si se agrega un modo, viene por aca
                    break;
            }
        }

        private void evaluarModoDespierto()
        {//Evaluo si tengo que dejar de zumbar y pasar al modo despierto
            if (configuracion.habilitadaOjos)
            {
                if (modoActual == Modos.Zumbar)
                {
                    //Si tiene los ojos cerrados
                    if (captura.gestoOjos.gestoActivo)
                    {
                        //Si no tenia tiempo de gesto ojos activo (ojos cerrados), lo inicio y vacio el tiempo gesto ojos inactivos
                        if (inicioGestoOjosActivo.Equals(DateTime.MinValue))
                        {
                            inicioGestoOjosActivo = DateTime.Now;
                            inicioGestoOjosInactivo = DateTime.MinValue;
                        }
                        else
                        {
                            //Verifico si se cumplio el tiempo para dejar de zumbar
                            if (DateTime.Now.Subtract(inicioGestoOjosActivo).TotalMilliseconds >= configuracion.cantMilisegGestoOjosActivoModoDespierto)
                            {
                                detenerZumbido();
                                cambiarModo(Modos.Despierto);
                                inicioGestoOjosActivo = DateTime.MinValue;
                                inicioGestoOjosInactivo = DateTime.MinValue;
                            }
                        }

                        //Como detecte el gesto activo, al gesto inactivo lo vacio
                        inicioGestoOjosInactivo = DateTime.MinValue;
                    }
                    else
                    {
                        //Si comence alguna deteccion, entra en juego la tolerancia, sino no hago nada
                        if (!inicioGestoOjosActivo.Equals(DateTime.MinValue))
                        {
                            //Si no tenia tiempo de gesto ojos inactivo (ojos abiertos), lo inicio
                            if (inicioGestoOjosInactivo.Equals(DateTime.MinValue))
                            {
                                inicioGestoOjosInactivo = DateTime.Now;
                            }
                            else
                            {
                                //Verifico si se cumplio el tiempo de tolerancia
                                if (DateTime.Now.Subtract(inicioGestoOjosInactivo).TotalMilliseconds >= configuracion.cantMilisegGestoOjosToleranciaInactivo)
                                {
                                    inicioGestoOjosActivo = DateTime.MinValue;
                                    inicioGestoOjosInactivo = DateTime.MinValue;
                                }
                            }
                        }
                    }
                }
            }
		}

        private void evaluarModoVigilia()
        {//Evaluo desde el modo despierto si tengo pasar al modo vigilia
            if (configuracion.habilitadaOjos)
            {
                if (modoActual == Modos.Despierto)
                {
                    //Si tiene los ojos cerrados
                    if (captura.gestoOjos.gestoActivo)
                    {
                        //Si no tenia tiempo de gesto ojos activo (ojos cerrados), lo inicio y vacio el tiempo gesto ojos inactivos
                        if (inicioGestoOjosActivo.Equals(DateTime.MinValue))
                        {
                            inicioGestoOjosActivo = DateTime.Now;
                            inicioGestoOjosInactivo = DateTime.MinValue;
                        }
                        else
                        {
                            //Verifico si se cumplio el tiempo para dejar pasar a modo vigilia
                            if (DateTime.Now.Subtract(inicioGestoOjosActivo).TotalMilliseconds >= configuracion.cantMilisegGestoOjosActivoModoVigilia)
                            {
                                cambiarModo(Modos.Vigilia);
                                inicioGestoOjosActivo = DateTime.MinValue;
                                inicioGestoOjosInactivo = DateTime.MinValue;
                            }
                        }

                        //Como detecte el gesto activo, al gesto inactivo lo vacio
                        inicioGestoOjosInactivo = DateTime.MinValue;
                    }
                    else
                    {
                        //Si comence alguna deteccion, entra en juego la tolerancia, sino no hago nada
                        if (!inicioGestoOjosActivo.Equals(DateTime.MinValue))
                        {
                            //Si no tenia tiempo de gesto ojos inactivo (ojos abiertos), lo inicio
                            if (inicioGestoOjosInactivo.Equals(DateTime.MinValue))
                            {
                                inicioGestoOjosInactivo = DateTime.Now;
                            }
                            else
                            {
                                //Verifico si se cumplio el tiempo de tolerancia
                                if (DateTime.Now.Subtract(inicioGestoOjosInactivo).TotalMilliseconds >= configuracion.cantMilisegGestoOjosToleranciaInactivo)
                                {
                                    inicioGestoOjosActivo = DateTime.MinValue;
                                    inicioGestoOjosInactivo = DateTime.MinValue;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void evaluarModoZumbar()
        {//Evaluo desde el modo vigilia si tengo pasar al modo zumbar
            if (configuracion.habilitadaOjos)
            {
                if (modoActual == Modos.Vigilia)
                {
                    //Si tiene los ojos abiertos
                    if (!captura.gestoOjos.gestoActivo)
                    {
                        //Si no tenia tiempo de gesto ojos inactivo (ojos abiertos), lo inicio y vacio el tiempo gesto ojos activo
                        if (inicioGestoOjosInactivo.Equals(DateTime.MinValue))
                        {
                            inicioGestoOjosInactivo = DateTime.Now;
                            inicioGestoOjosActivo = DateTime.MinValue;
                        }
                        else
                        {
                            //Verifico si se cumplio el tiempo para dejar pasar a modo zumbar
                            if (DateTime.Now.Subtract(inicioGestoOjosInactivo).TotalMilliseconds >= configuracion.cantMilisegGestoOjosActivoModoZumbar)
                            {
                                cambiarModo(Modos.Zumbar);
                                iniciarZumbido();
                                inicioGestoOjosActivo = DateTime.MinValue;
                                inicioGestoOjosInactivo = DateTime.MinValue;
                            }
                        }

                        //Como detecte el gesto inactivo, al gesto activo lo vacio
                        inicioGestoOjosActivo = DateTime.MinValue;
                    }
                    else
                    {
                        //Si comence alguna deteccion, entra en juego la tolerancia, sino no hago nada
                        if (!inicioGestoOjosInactivo.Equals(DateTime.MinValue))
                        {
                            //Si no tenia tiempo de gesto ojos activo (ojos cerrados), lo inicio
                            if (inicioGestoOjosActivo.Equals(DateTime.MinValue))
                            {
                                inicioGestoOjosActivo = DateTime.Now;
                            }
                            else
                            {
                                //Verifico si se cumplio el tiempo de tolerancia
                                if (DateTime.Now.Subtract(inicioGestoOjosActivo).TotalMilliseconds >= configuracion.cantMilisegGestoOjosToleranciaInactivo)
                                {
                                    inicioGestoOjosActivo = DateTime.MinValue;
                                    inicioGestoOjosInactivo = DateTime.MinValue;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void evaluarEjecucionClick()
        {//Evaluo desde el modo despierto o zumbar si tengo que hacer click
            if (configuracion.habilitadaBoca)
            {
                if (modoActual == Modos.Despierto || modoActual == Modos.Zumbar)
                {
                    //Si esta sonriendo
                    if (captura.gestoBoca.gestoActivo)
                    {
                        //Si no tenia tiempo de gesto boca activo (sonrisa), lo inicio y vacio el tiempo gesto boca inactivo
                        if (inicioGestoBocaActivo.Equals(DateTime.MinValue))
                        {
                            inicioGestoBocaActivo = DateTime.Now;
                            inicioGestoBocaInactivo = DateTime.MinValue;
                        }
                        else
                        {
                            //Verifico si se cumplio el tiempo para ejecutar el click
                            if (DateTime.Now.Subtract(inicioGestoBocaActivo).TotalMilliseconds >= configuracion.cantMilisegGestoBocaActivo)
                            {
                                ejecutarClick();
                                inicioGestoBocaActivo = DateTime.MinValue;
                                inicioGestoBocaInactivo = DateTime.MinValue;
                            }
                        }

                        //Como detecte el gesto activo, al gesto inactivo lo vacio
                        inicioGestoBocaInactivo = DateTime.MinValue;
                    }
                    else
                    {
                        //Si comence alguna deteccion, entra en juego la tolerancia, sino no hago nada
                        if (!inicioGestoBocaActivo.Equals(DateTime.MinValue))
                        {
                            //Si no tenia tiempo de gesto boca inactivo (triste), lo inicio
                            if (inicioGestoBocaInactivo.Equals(DateTime.MinValue))
                            {
                                inicioGestoBocaInactivo = DateTime.Now;
                            }
                            else
                            {
                                //Verifico si se cumplio el tiempo de tolerancia
                                if (DateTime.Now.Subtract(inicioGestoBocaInactivo).TotalMilliseconds >= configuracion.cantMilisegGestoBocaToleranciaInactivo)
                                {
                                    inicioGestoBocaActivo = DateTime.MinValue;
                                    inicioGestoBocaInactivo = DateTime.MinValue;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void iniciarZumbido()
        {
            oSonidoZumbar = new SoundPlayer("Datos/Sonido.wav");
            oSonidoZumbar.PlayLooping();
        }

        private void detenerZumbido()
        {
            oSonidoZumbar.Stop();
        }

        [DllImport("USER32.dll", CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x2;
        private const int MOUSEEVENTF_LEFTUP = 0x4;

        private void ejecutarClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
	}
}