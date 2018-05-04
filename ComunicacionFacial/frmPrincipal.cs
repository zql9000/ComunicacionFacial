using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading;

namespace ComunicacionFacial
{
    public partial class frmPrincipal : Form
    {
        private Configuracion oConfiguracion;
        private Deteccion oDeteccion;
        private bool bProcesar = true;
        Image<Bgr, Byte> oSonrisa = new Image<Bgr, Byte>("Gestos/Boca/Sonrisa.jpg");
        Image<Bgr, Byte> oTriste = new Image<Bgr, Byte>("Gestos/Boca/Triste.jpg");
        Image<Bgr, Byte> oCerrados = new Image<Bgr, Byte>("Gestos/Ojos/Cerrados.jpg");
        Image<Bgr, Byte> oAbiertos = new Image<Bgr, Byte>("Gestos/Ojos/Abiertos.jpg");

        public frmPrincipal()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Verifico la licencia, si no es valida cierro la aplicacion
            oConfiguracion = new Configuracion();

            if (!oConfiguracion.existeClaveRegistro())
            {
                string sClave = Inputbox.Show("Validación de licencia", "Ingrese el código suministrado:", FormStartPosition.CenterScreen, true);
                if (!oConfiguracion.escribirClaveRegistro(sClave))
                    Application.Exit();               
            }

            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;

            //Completo el combo con las camaras disponibles
            List<Camara> oCamaras = oConfiguracion.camarasDetectadas;
            foreach (Camara oCamara in oCamaras)
            {
                cmbCamaras.Items.Add(oCamara.nombre);
            }

            //Busco cual fue la ultima camara usada para intentar seleccionarla
            int iCamara;

            string sValor = oConfiguracion.leerParametro("Webcam");
            int.TryParse(sValor, out iCamara);

            if (cmbCamaras.Items.Count > iCamara)
            {//Puede que exista, asi que la selecciono
                cmbCamaras.SelectedIndex = iCamara;
            }
            else if (cmbCamaras.Items.Count > 0)
            {//Hay menos valores en el combo que el que iba a seleccionar, asi que selecciono la primera
                cmbCamaras.SelectedIndex = 0;
            }

            //Leo los valores de la configuracion
            chkOjos.Checked = oConfiguracion.habilitadaOjos;
            chkBoca.Checked = oConfiguracion.habilitadaBoca;
            trbMilisegGestoBocaActivo.Value = oConfiguracion.cantMilisegGestoBocaActivo;
            trbMilisegGestoBocaInactivo.Value = oConfiguracion.cantMilisegGestoBocaToleranciaInactivo;
            trbMilisegGestoOjosDespierto.Value = oConfiguracion.cantMilisegGestoOjosActivoModoDespierto;
            trbMilisegGestoOjosVigilia.Value = oConfiguracion.cantMilisegGestoOjosActivoModoVigilia;
            trbMilisegGestoOjosZumbar.Value = oConfiguracion.cantMilisegGestoOjosActivoModoZumbar;
            trbMilisegGestoOjosInactivo.Value = oConfiguracion.cantMilisegGestoOjosToleranciaInactivo;
            visualizarConfiguracion();

            //Configuro la deteccion de gestos
            oDeteccion = new Deteccion();
            oDeteccion.configuracion = oConfiguracion;
            oDeteccion.actualizarEntrenamiento();
        }

        private void visualizarConfiguracion()
        {
            txtMilisegGestoBocaActivo.Text = trbMilisegGestoBocaActivo.Value.ToString() + " ms";
            txtMilisegGestoBocaInactivo.Text = trbMilisegGestoBocaInactivo.Value.ToString() + " ms";
            txtMilisegGestoOjosDespierto.Text = trbMilisegGestoOjosDespierto.Value.ToString() + " ms";
            txtMilisegGestoOjosVigilia.Text = trbMilisegGestoOjosVigilia.Value.ToString() + " ms";
            txtMilisegGestoOjosZumbar.Text = trbMilisegGestoOjosZumbar.Value.ToString() + " ms";
            txtMilisegGestoOjosInactivo.Text = trbMilisegGestoOjosInactivo.Value.ToString() + " ms";
            grpConfigBoca.Enabled = chkBoca.Checked;
            grpBoca.Enabled = chkBoca.Checked;
            grpConfigOjos.Enabled = chkOjos.Checked;
            grpOjos.Enabled = chkOjos.Checked;
        }

        private void cmbCamaras_SelectedIndexChanged(object sender, EventArgs e)
        {
            oConfiguracion.cambiarCamaraActual((byte)cmbCamaras.SelectedIndex);
        }

        private void chkBoca_CheckedChanged(object sender, EventArgs e)
        {
            oConfiguracion.habilitadaBoca = chkBoca.Checked;
            visualizarConfiguracion();
        }

        private void chkOjos_CheckedChanged(object sender, EventArgs e)
        {
            oConfiguracion.habilitadaOjos = chkOjos.Checked;
            visualizarConfiguracion();
        }

        private void trbMilisegGestoBocaActivo_ValueChanged(object sender, EventArgs e)
        {
            oConfiguracion.cantMilisegGestoBocaActivo = (ushort)trbMilisegGestoBocaActivo.Value;
            visualizarConfiguracion();
        }

        private void trbMilisegGestoBocaInactivo_ValueChanged(object sender, EventArgs e)
        {
            oConfiguracion.cantMilisegGestoBocaToleranciaInactivo = (ushort)trbMilisegGestoBocaInactivo.Value;
            visualizarConfiguracion();
        }

        private void trbMilisegGestoOjosDespierto_ValueChanged(object sender, EventArgs e)
        {
            oConfiguracion.cantMilisegGestoOjosActivoModoDespierto = (ushort)trbMilisegGestoOjosDespierto.Value;
            visualizarConfiguracion();
        }

        private void trbMilisegGestoOjosVigilia_ValueChanged(object sender, EventArgs e)
        {
            oConfiguracion.cantMilisegGestoOjosActivoModoVigilia = (ushort)trbMilisegGestoOjosVigilia.Value;
            visualizarConfiguracion();
        }

        private void trbMilisegGestoOjosZumbar_ValueChanged(object sender, EventArgs e)
        {
            oConfiguracion.cantMilisegGestoOjosActivoModoZumbar = (ushort)trbMilisegGestoOjosZumbar.Value;
            visualizarConfiguracion();
        }

        private void trbMilisegGestoOjosInactivo_ValueChanged(object sender, EventArgs e)
        {
            oConfiguracion.cantMilisegGestoOjosActivoModoZumbar = (ushort)trbMilisegGestoOjosZumbar.Value;
            visualizarConfiguracion();
        }

        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //Al minimizar la ventana, cambio al modo despierto
                if (oDeteccion != null)
                    oDeteccion.cambiarModo(Deteccion.Modos.Despierto);
            }
            else
            {
                //Al restaurar la ventana, cambio al modo administrador
                if (oDeteccion != null)
                    oDeteccion.cambiarModo(Deteccion.Modos.Administrador);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            oDeteccion.actualizarEntrenamiento();
            MessageBox.Show("Entrenamiento actualizado correctamente.", "Fin del entrenamiento");
            txtLogBoca.Text = "";
            txtLogOjos.Text = "";
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            //Proceso los frames
            while (bProcesar)
            {
                Application.DoEvents();

                //Obtengo las imagenes
                oDeteccion.generarCaptura();

                if (oDeteccion.captura != null && oDeteccion.captura.imagen != null)
                {
                    if (WindowState != FormWindowState.Minimized)
                    {//Si la ventana esta visible, muestro las imagenes
                        actualizarImagenes();
                    }
                    else
                    {//Si la ventana no esta visible, se debe realizar la deteccion
                        oDeteccion.evaluarAcciones();
                    }
                }
            }
        }

        private void actualizarImagenes()
        {
            imgCamara.Image = oDeteccion.captura.imagen;
            imgBoca.Image = oDeteccion.captura.gestoBoca.imagen;
            imgOjos.Image = oDeteccion.captura.gestoOjos.imagen;

            if (oConfiguracion.habilitadaBoca && oDeteccion.captura.gestoBoca.imagen != null)
            {
                if (oDeteccion.captura.gestoBoca.gestoActivo)
                    imgEstadoBoca.Image = oSonrisa;
                else
                    imgEstadoBoca.Image = oTriste;
            }
            else
            {
                imgBoca.Image = null;
                imgEstadoBoca.Image = null;
            }

            if (oConfiguracion.habilitadaOjos && oDeteccion.captura.gestoOjos.imagen != null)
            {
                if (oDeteccion.captura.gestoOjos.gestoActivo)
                    imgEstadoOjos.Image = oCerrados;
                else
                    imgEstadoOjos.Image = oAbiertos;
            }
            else
            {
                imgOjos.Image = null;
                imgEstadoOjos.Image = null;
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            bProcesar = false;
            Application.DoEvents();
            oConfiguracion.salir();
            Application.DoEvents();
        }

        private void btnTriste_Click(object sender, EventArgs e)
        {
            bool bAux;
            bAux = oDeteccion.guardarGestosEntrenamiento(Deteccion.PartesRostro.Boca, false);
            txtLogBoca.Text = txtLogBoca.Text.Insert(0, DateTime.Now.ToString("HH:mm:ss ") + (bAux ? "OK" : "Error") + Environment.NewLine);
        }

        private void btnSonrisa_Click(object sender, EventArgs e)
        {
            bool bAux;
            bAux = oDeteccion.guardarGestosEntrenamiento(Deteccion.PartesRostro.Boca, true);
            txtLogBoca.Text = txtLogBoca.Text.Insert(0, DateTime.Now.ToString("HH:mm:ss ") + (bAux ? "OK" : "Error") + Environment.NewLine);
        }

        private void btnOjosAbiertos_Click(object sender, EventArgs e)
        {
            bool bAux;
            bAux = oDeteccion.guardarGestosEntrenamiento(Deteccion.PartesRostro.Ojos, false);
            txtLogOjos.Text = txtLogOjos.Text.Insert(0, DateTime.Now.ToString("HH:mm:ss ") + (bAux ? "OK" : "Error") + Environment.NewLine);
        }

        private void btnOjosCerrados_Click(object sender, EventArgs e)
        {
            bool bAux;
            bAux = oDeteccion.guardarGestosEntrenamiento(Deteccion.PartesRostro.Ojos, true);
            txtLogOjos.Text = txtLogOjos.Text.Insert(0, DateTime.Now.ToString("HH:mm:ss ") + (bAux ? "OK" : "Error") + Environment.NewLine);
        }
    }
}
