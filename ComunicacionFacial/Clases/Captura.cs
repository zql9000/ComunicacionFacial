using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV;
using Emgu.CV.GPU;
using Emgu.CV.Structure;
using System.Drawing;

namespace ComunicacionFacial
{
	public class Captura
    {
		private Image<Bgr, Byte> m_imagen;
        private bool m_rostroRecuadrado = false;
        private bool bTieneCuda = GpuInvoke.HasCuda;
        public Gesto gestoBoca { get; set; }
        public Gesto gestoOjos { get; set; }

        public Image<Bgr, Byte> imagen
        {
            get { return m_imagen; }
        }

        public bool rostroRecuadrado
        {
            get { return m_rostroRecuadrado; }
        }

        public Captura(Image<Bgr, Byte> oImagen)
        {
            m_imagen = oImagen;
		}

        public void evaluarRostro(EigenObjectRecognizer reconocedorBoca, EigenObjectRecognizer reconocedorOjos)
        {
            //Obtengo la captura actua en escala de grises
            object oImagenGris = pasarAGrises();

            //Detecto el rostro y los gestos, ademas recuadro el rostro en la imagen color
            detectarRostro(oImagenGris);
            
            //Analizo los gestos para detectar si son activos o inactivos
            gestoBoca.detectarGesto(reconocedorBoca);
            gestoOjos.detectarGesto(reconocedorOjos);
		}

        private object pasarAGrises()
        {
            object oGris;

            if (bTieneCuda)
            {
                oGris = new GpuImage<Bgr, Byte>(imagen).Convert<Gray, Byte>();
            }
            else
            {
                oGris = imagen.Convert<Gray, Byte>();
            }

            return oGris;
        }

        private void detectarRostro(object oImagenGris)
        {

            String sPathClasificadorRostro = "Datos/haarcascade_frontalface_default.xml";
            Rectangle oRostro = new Rectangle();

            if (bTieneCuda)
            {
                using(GpuImage<Gray, Byte> imagenGris = (GpuImage<Gray, Byte>)oImagenGris)
                using (GpuCascadeClassifier oDetectaRostro = new GpuCascadeClassifier(sPathClasificadorRostro))
                {
                    //Detecto los rostros en la imagen gris
                    Rectangle[] regionRostro = oDetectaRostro.DetectMultiScale(imagenGris, 1.1, 10, new Size(100, 100));

                    //Recorro cada rostro detectado
                    foreach (Rectangle f in regionRostro)
                    {
                        //Busco el rectangulo mas grande, que es con el que voy a trabajar
                        if (oRostro.IsEmpty || (oRostro.Width * oRostro.Height < f.Width * f.Height)) oRostro = f;
                    }

                    if (oRostro.IsEmpty)
                    {
                        //En el caso de no detectar ningun rostro, limpio las imagenes asociadas a rostros
                        gestoBoca = new Gesto(null);
                        gestoOjos = new Gesto(null);
                        m_rostroRecuadrado = false;
                    }
                    else
                    {
                        //Dibujo un rectangulo en rostro que voy a trabajar
                        imagen.Draw(oRostro, new Bgr(Color.Red), 2);
                        m_rostroRecuadrado = true;

                        //Boca
                        //Del rectangulo detectado como rostro solo tomo la parte inferior y central, que es donde esta la boca
                        int X = oRostro.X + (int)(oRostro.Width * 0.2 / 2);
                        int Y = oRostro.Y + (int)(oRostro.Height * 0.6);
                        int Ancho = oRostro.Width - (int)(oRostro.Width * 0.2);
                        int Alto = oRostro.Height - (int)(oRostro.Height * 0.6);

                        Image<Gray, Byte> oBoca;

                        using (GpuImage<Gray, Byte> oBocaAux = imagenGris.GetSubRect(new Rectangle(X, Y, Ancho, Alto)))
                        {
                            oBoca = oBocaAux.ToImage().Resize(100, 70, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
                            oBoca._EqualizeHist();
                            gestoBoca = new Gesto(oBoca);
                        }

                        //Ojos
                        //Del rectangulo detectado como rostro solo tomo la parte superior y central, que es donde estan los ojos
                        X = oRostro.X + (int)(oRostro.Width * 0.25 / 2);
                        Y = oRostro.Y + (int)(oRostro.Height * 0.25);
                        Ancho = oRostro.Width - (int)(oRostro.Width * 0.2);
                        Alto = oRostro.Height - (int)(oRostro.Height * 0.7);

                        Image<Gray, Byte> oOjos;

                        using (GpuImage<Gray, Byte> oOjosAux = imagenGris.GetSubRect(new Rectangle(X, Y, Ancho, Alto)))
                        {
                            oOjos = oOjosAux.ToImage().Resize(100, 70, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
                            oOjos._EqualizeHist();
                            gestoOjos = new Gesto(oOjos);
                        }
                    }
                }
            }
            else
            {
                using(Image<Gray, Byte> imagenGris = (Image<Gray, Byte>)oImagenGris)
                using (CascadeClassifier oDetectaRostro = new CascadeClassifier(sPathClasificadorRostro))
                {
                    //Detecto los rostros en la imagen gris
                    Rectangle[] regionRostro = oDetectaRostro.DetectMultiScale(imagenGris, 1.1, 10, new Size(100, 100), Size.Empty);

                    //Recorro cada rostro detectado
                    foreach (Rectangle f in regionRostro)
                    {
                        //Busco el rectangulo mas grande, que es con el que voy a trabajar
                        if (oRostro.IsEmpty || (oRostro.Width * oRostro.Height < f.Width * f.Height)) oRostro = f;
                    }

                    if (oRostro.IsEmpty)
                    {
                        //En el caso de no detectar ningun rostro, limpio las imagenes asociadas a rostros
                        gestoBoca = new Gesto(null);
                        gestoOjos = new Gesto(null);
                        m_rostroRecuadrado = false;
                    }
                    else
                    {
                        //Dibujo un rectangulo en rostro que voy a trabajar
                        imagen.Draw(oRostro, new Bgr(Color.Red), 2);
                        m_rostroRecuadrado = true;

                        //Boca
                        //Del rectangulo detectado como rostro solo tomo la parte inferior y central, que es donde esta la boca
                        int X = oRostro.X + (int)(oRostro.Width * 0.2 / 2);
                        int Y = oRostro.Y + (int)(oRostro.Height * 0.6);
                        int Ancho = oRostro.Width - (int)(oRostro.Width * 0.2);
                        int Alto = oRostro.Height - (int)(oRostro.Height * 0.6);

                        Image<Gray, Byte> oBoca;

                        using (Image<Gray, Byte> oBocaAux = imagenGris.GetSubRect(new Rectangle(X, Y, Ancho, Alto)))
                        {
                            oBoca = oBocaAux.Resize(100, 70, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
                            oBoca._EqualizeHist();
                            gestoBoca = new Gesto(oBoca);
                        }

                        //Ojos
                        //Del rectangulo detectado como rostro solo tomo la parte inferior y central, que es donde estan los ojos
                        X = oRostro.X + (int)(oRostro.Width * 0.25 / 2);
                        Y = oRostro.Y + (int)(oRostro.Height * 0.25);
                        Ancho = oRostro.Width - (int)(oRostro.Width * 0.2);
                        Alto = oRostro.Height - (int)(oRostro.Height * 0.7);

                        Image<Gray, Byte> oOjos;

                        using (Image<Gray, Byte> oOjosAux = imagenGris.GetSubRect(new Rectangle(X, Y, Ancho, Alto)))
                        {
                            oOjos = oOjosAux.Resize(100, 70, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
                            oOjos._EqualizeHist();
                            gestoOjos = new Gesto(oOjos);
                        }

                    }
                }
            }
        }
	}
}