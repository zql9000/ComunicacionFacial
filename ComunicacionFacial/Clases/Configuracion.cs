using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using DirectShowLib;

namespace ComunicacionFacial
{
	public class Configuracion
    {
        private const string LICENCIA = "comunicacionFacia1";
        private Camara m_camaraActual;
        private List<Camara> m_camarasDetectadas;
        private ushort m_cantMilisegGestoBocaActivo = 1000;
		private ushort m_cantMilisegGestoBocaToleranciaInactivo = 500;
        private ushort m_cantMilisegGestoOjosActivoModoDespierto = 3000;
        private ushort m_cantMilisegGestoOjosActivoModoZumbar = 3000;
        private ushort m_cantMilisegGestoOjosActivoModoVigilia = 5000;
        private ushort m_cantMilisegGestoOjosToleranciaInactivo = 500;
        private bool m_habilitadaBoca;
        private bool m_habilitadaOjos;

        [DllImport("avicap32.dll")]
        static extern bool capGetDriverDescriptionA(short wDriverIndex, [MarshalAs(UnmanagedType.VBByRefStr)]ref String lpszName, int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszVer, int cbVer);

		public Configuracion()
        {
            listarCamaras();
            ushort.TryParse(leerParametro("cantMilisegGestoBocaActivo"), out m_cantMilisegGestoBocaActivo);
            if (m_cantMilisegGestoBocaActivo == 0) m_cantMilisegGestoBocaActivo = 1000;
            ushort.TryParse(leerParametro("cantMilisegGestoBocaToleranciaInactivo"), out m_cantMilisegGestoBocaToleranciaInactivo);
            if (m_cantMilisegGestoBocaToleranciaInactivo == 0) m_cantMilisegGestoBocaToleranciaInactivo = 500;
            ushort.TryParse(leerParametro("cantMilisegGestoOjosActivoModoDespierto"), out m_cantMilisegGestoOjosActivoModoDespierto);
            if (m_cantMilisegGestoOjosActivoModoDespierto == 0) m_cantMilisegGestoOjosActivoModoDespierto = 3000;
            ushort.TryParse(leerParametro("cantMilisegGestoOjosActivoModoZumbar"), out m_cantMilisegGestoOjosActivoModoZumbar);
            if (m_cantMilisegGestoOjosActivoModoZumbar == 0) m_cantMilisegGestoOjosActivoModoZumbar = 3000;
            ushort.TryParse(leerParametro("cantMilisegGestoOjosActivoModoVigilia"), out m_cantMilisegGestoOjosActivoModoVigilia);
            if (m_cantMilisegGestoOjosActivoModoVigilia == 0) m_cantMilisegGestoOjosActivoModoVigilia = 5000;
            ushort.TryParse(leerParametro("cantMilisegGestoOjosToleranciaInactivo"), out m_cantMilisegGestoOjosToleranciaInactivo);
            if (m_cantMilisegGestoOjosToleranciaInactivo == 0) m_cantMilisegGestoOjosToleranciaInactivo = 500;
            m_habilitadaBoca = leerParametro("habilitadaBoca").ToLower().Equals("true");
            m_habilitadaOjos = leerParametro("habilitadaOjos").ToLower().Equals("true");
		}

		public Camara camaraActual
        {
            get { return m_camaraActual; }
		}

        public List<Camara> camarasDetectadas
        {
            get { return m_camarasDetectadas; }
		}

        public bool cambiarCamaraActual(byte idCamara)
        {
            bool bRes = false;

            if (m_camarasDetectadas.Count > idCamara)
            {
                Camara camaraAux = camaraActual;
                //Deshabilito la camara para que no se obtengan mas capturas
                if (camaraActual != null)
                    camaraActual.habilitada = false;

                //Creo el objeto para la camara seleccionada
                m_camaraActual = m_camarasDetectadas[idCamara];
                if (camaraActual.iniciar())
                    //Guardo la ultima camara seleccionada
                    guardarParametro("Webcam", idCamara.ToString());
                else
                    MessageBox.Show("Error al intentar iniciar la cámara", "Seleccionar cámara");

                if (camaraAux != null)
                    camaraAux.detener(false);

                bRes = true;
            }

            return bRes;
        }

        public ushort cantMilisegGestoBocaActivo
        {
            get { return m_cantMilisegGestoBocaActivo; }
            set
            {
                guardarParametro("cantMilisegGestoBocaActivo", value.ToString());
                m_cantMilisegGestoBocaActivo = value;
            }
        }

        public ushort cantMilisegGestoBocaToleranciaInactivo
        {
            get { return m_cantMilisegGestoBocaToleranciaInactivo; }
            set
            {
                guardarParametro("cantMilisegGestoBocaToleranciaInactivo", value.ToString());
                m_cantMilisegGestoBocaToleranciaInactivo = value;
            }
        }

        public ushort cantMilisegGestoOjosActivoModoDespierto
        {
            get { return m_cantMilisegGestoOjosActivoModoDespierto; }
            set
            {
                guardarParametro("cantMilisegGestoOjosActivoModoDespierto", value.ToString());
                m_cantMilisegGestoOjosActivoModoDespierto = value;
            }
		}

        public ushort cantMilisegGestoOjosActivoModoZumbar
        {
            get { return m_cantMilisegGestoOjosActivoModoZumbar; }
            set
            {
                guardarParametro("cantMilisegGestoOjosActivoModoZumbar", value.ToString());
                m_cantMilisegGestoOjosActivoModoZumbar = value;
            }
        }

        public ushort cantMilisegGestoOjosActivoModoVigilia
        {
            get { return m_cantMilisegGestoOjosActivoModoVigilia; }
            set
            {
                guardarParametro("cantMilisegGestoOjosActivoModoVigilia", value.ToString());
                m_cantMilisegGestoOjosActivoModoVigilia = value;
            }
        }

        public ushort cantMilisegGestoOjosToleranciaInactivo
        {
            get { return m_cantMilisegGestoOjosToleranciaInactivo; }
            set
            {
                guardarParametro("cantMilisegGestoOjosToleranciaInactivo", value.ToString());
                m_cantMilisegGestoOjosToleranciaInactivo = value;
            }
        }

        public bool habilitadaBoca
        {
            get { return m_habilitadaBoca; }
            set
            {
                guardarParametro("habilitadaBoca", value.ToString());
                m_habilitadaBoca = value;
            }
        }

        public bool habilitadaOjos
        {
            get { return m_habilitadaOjos; }
            set
            {
                guardarParametro("habilitadaOjos", value.ToString());
                m_habilitadaOjos = value;
            }
        }

        //Escribe la clave en el registro de Windows que indica que la aplicacion ya fue activada (solo si el codigo de licencia es correcto)
		public bool escribirClaveRegistro(string sClave)
        {
            bool bRes = false;

            if (sClave != null)
            {
                if (sClave.Equals(LICENCIA))
                    bRes = guardarParametro("RCF", "true");
                else
                    MessageBox.Show("El código suministrado no es correcto.", "Validación de licencia");
            }
            return bRes;
		}

        //Verifica si existe la clave en el registro de Windows que indica que la aplicacion ya fue activada
		public bool existeClaveRegistro()
        {
            string sValor = leerParametro("RCF");

            return sValor.Equals("true");
		}

        public bool guardarParametro(string sClave, string sValor)
        {
            bool bRes = false;

            try
            {
                //Guardo el valor de la configuración
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
                key.CreateSubKey("Rcf");
                key = key.OpenSubKey("Rcf", true);
                key.SetValue(sClave, sValor);
                key.Close();

                bRes = true;
            }
            catch (Exception)
            {
                //Si da error, devuelvo falso
            }

            return bRes;
        }

        public string leerParametro(string sClave)
        {
            string sRes = "";

            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", false);

            if (key != null)
            {
                key = key.OpenSubKey("Rcf", false);

                if (key != null)
                {
                    object oValor = key.GetValue(sClave);
                    if (oValor != null)
                    {
                        sRes = oValor.ToString();
                    }
                }
            }

            return sRes;
        }

        public void salir()
        {
            foreach (Camara oCamara in m_camarasDetectadas)
            {
                oCamara.detener(true);
            }
        }

		private void listarCamaras()
        {
            m_camarasDetectadas = new List<Camara>();
            
//#if DEBUG
            DsDevice[] oCamaras = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            byte i = 0;
            foreach (DsDevice oCamara in oCamaras)
            {
                Camara oCamAux = new Camara();
                oCamAux.idCamara = i;
                oCamAux.nombre = oCamara.Name;
                oCamAux.habilitada = false;

                m_camarasDetectadas.Add(oCamAux);
                i++;
            }
/*#else
            string dName;
            string dVersion;
            bool bRes = true;
            byte i = 0;

            while (i < 10)
            {
                dName = "".PadRight(100);
                dVersion = "".PadRight(100);
                bRes = capGetDriverDescriptionA(i, ref dName, 100, ref dVersion, 100);

                if (bRes)
                {
                    Camara oCamAux = new Camara();
                    oCamAux.idCamara = i;
                    oCamAux.nombre = dName;
                    oCamAux.habilitada = false;

                    camarasDetectadas.Add(oCamAux);
                }

                i++;
            }
#endif*/
        }
	}
}