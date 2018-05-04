using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ComunicacionFacial
{
	public class Gesto
    {
        public Image<Gray, Byte> imagen { get; set; }
        public bool gestoActivo { get; set; }

		public Gesto(Image<Gray, Byte> oImagen)
        {
            imagen = oImagen;
		}

        public void detectarGesto(EigenObjectRecognizer reconocedor)
        {
            gestoActivo = false;

            if (imagen != null)
            { //Si tengo una imagen, intento reconocer el gesto
                EigenObjectRecognizer.RecognitionResult oRes = reconocedor.Recognize(imagen);

                if (oRes != null)
                {
                    gestoActivo = oRes.Label.StartsWith("Act");
                }
            }
        }
    }
}