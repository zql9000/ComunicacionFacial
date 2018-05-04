using System;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ComunicacionFacial
{
    public class Camara
    {
		private Captura m_capturaActual;
        public bool habilitada { get; set; }
        public byte? idCamara { get; set; }
        public string nombre { get; set; }
        private Capture handler;
        public Captura capturaActual { get { return m_capturaActual; } }

        public Camara()
        {
            idCamara = null;
		}

        public bool iniciar()
        {
            habilitada = false;

            try
            {
                if (handler == null)
                    handler = new Capture((int)idCamara);
                else
                    handler.Start();

                habilitada = true;
            }
            catch (Exception)
            {
                //Si dio error, no queda habilitada
            }

            return habilitada;
        }

        public void detener(bool salir)
        {
            habilitada = false;

            if (handler != null)
            {
                handler.Pause();

                if (salir)
                {
                    handler.Stop();
                    handler.Dispose();
                }
            }
        }

		public void obtenerCaptura(EigenObjectRecognizer reconocedorBoca, EigenObjectRecognizer reconocedorOjos)
        {
            m_capturaActual = null;

            if (habilitada)
            {
                try
                {
                    //Tomo un frame de la webcam
                    m_capturaActual = new Captura(handler.QueryFrame());
                    //Evaluo el frame para hacer un recuadro del rostro y obtener los gestos
                    m_capturaActual.evaluarRostro(reconocedorBoca, reconocedorOjos);
                }
                catch (Exception) { }
            }
		}
	}
}