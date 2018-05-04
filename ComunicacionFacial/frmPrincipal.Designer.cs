namespace ComunicacionFacial
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabEntrenamiento = new System.Windows.Forms.TabPage();
            this.grpBoca = new System.Windows.Forms.GroupBox();
            this.txtLogBoca = new System.Windows.Forms.TextBox();
            this.btnTriste = new System.Windows.Forms.Button();
            this.btnSonrisa = new System.Windows.Forms.Button();
            this.imgEstadoBoca = new Emgu.CV.UI.ImageBox();
            this.imgBoca = new Emgu.CV.UI.ImageBox();
            this.grpOjos = new System.Windows.Forms.GroupBox();
            this.txtLogOjos = new System.Windows.Forms.TextBox();
            this.btnOjosCerrados = new System.Windows.Forms.Button();
            this.btnOjosAbiertos = new System.Windows.Forms.Button();
            this.imgEstadoOjos = new Emgu.CV.UI.ImageBox();
            this.imgOjos = new Emgu.CV.UI.ImageBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.imgCamara = new Emgu.CV.UI.ImageBox();
            this.tabConfiguracion = new System.Windows.Forms.TabPage();
            this.chkOjos = new System.Windows.Forms.CheckBox();
            this.chkBoca = new System.Windows.Forms.CheckBox();
            this.grpConfigBoca = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtMilisegGestoBocaInactivo = new System.Windows.Forms.TextBox();
            this.txtMilisegGestoBocaActivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trbMilisegGestoBocaInactivo = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trbMilisegGestoBocaActivo = new System.Windows.Forms.TrackBar();
            this.grpConfigOjos = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtMilisegGestoOjosInactivo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.trbMilisegGestoOjosInactivo = new System.Windows.Forms.TrackBar();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMilisegGestoOjosZumbar = new System.Windows.Forms.TextBox();
            this.txtMilisegGestoOjosVigilia = new System.Windows.Forms.TextBox();
            this.txtMilisegGestoOjosDespierto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.trbMilisegGestoOjosZumbar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trbMilisegGestoOjosVigilia = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.trbMilisegGestoOjosDespierto = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCamaras = new System.Windows.Forms.ComboBox();
            this.tabPrincipal.SuspendLayout();
            this.tabEntrenamiento.SuspendLayout();
            this.grpBoca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstadoBoca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoca)).BeginInit();
            this.grpOjos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstadoOjos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOjos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamara)).BeginInit();
            this.tabConfiguracion.SuspendLayout();
            this.grpConfigBoca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoBocaInactivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoBocaActivo)).BeginInit();
            this.grpConfigOjos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoOjosInactivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoOjosZumbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoOjosVigilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoOjosDespierto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabEntrenamiento);
            this.tabPrincipal.Controls.Add(this.tabConfiguracion);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1105, 618);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabEntrenamiento
            // 
            this.tabEntrenamiento.BackColor = System.Drawing.SystemColors.Control;
            this.tabEntrenamiento.Controls.Add(this.grpBoca);
            this.tabEntrenamiento.Controls.Add(this.grpOjos);
            this.tabEntrenamiento.Controls.Add(this.btnActualizar);
            this.tabEntrenamiento.Controls.Add(this.imgCamara);
            this.tabEntrenamiento.Location = new System.Drawing.Point(4, 25);
            this.tabEntrenamiento.Name = "tabEntrenamiento";
            this.tabEntrenamiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntrenamiento.Size = new System.Drawing.Size(1097, 589);
            this.tabEntrenamiento.TabIndex = 1;
            this.tabEntrenamiento.Text = "Entrenamiento";
            // 
            // grpBoca
            // 
            this.grpBoca.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoca.Controls.Add(this.txtLogBoca);
            this.grpBoca.Controls.Add(this.btnTriste);
            this.grpBoca.Controls.Add(this.btnSonrisa);
            this.grpBoca.Controls.Add(this.imgEstadoBoca);
            this.grpBoca.Controls.Add(this.imgBoca);
            this.grpBoca.Location = new System.Drawing.Point(811, 6);
            this.grpBoca.Name = "grpBoca";
            this.grpBoca.Size = new System.Drawing.Size(270, 257);
            this.grpBoca.TabIndex = 24;
            this.grpBoca.TabStop = false;
            this.grpBoca.Text = "Boca";
            // 
            // txtLogBoca
            // 
            this.txtLogBoca.Location = new System.Drawing.Point(153, 116);
            this.txtLogBoca.Multiline = true;
            this.txtLogBoca.Name = "txtLogBoca";
            this.txtLogBoca.ReadOnly = true;
            this.txtLogBoca.Size = new System.Drawing.Size(100, 126);
            this.txtLogBoca.TabIndex = 22;
            this.txtLogBoca.WordWrap = false;
            // 
            // btnTriste
            // 
            this.btnTriste.Location = new System.Drawing.Point(148, 31);
            this.btnTriste.Margin = new System.Windows.Forms.Padding(4);
            this.btnTriste.Name = "btnTriste";
            this.btnTriste.Size = new System.Drawing.Size(100, 28);
            this.btnTriste.TabIndex = 21;
            this.btnTriste.Text = "Triste";
            this.btnTriste.UseVisualStyleBackColor = true;
            this.btnTriste.Click += new System.EventHandler(this.btnTriste_Click);
            // 
            // btnSonrisa
            // 
            this.btnSonrisa.Location = new System.Drawing.Point(148, 67);
            this.btnSonrisa.Margin = new System.Windows.Forms.Padding(4);
            this.btnSonrisa.Name = "btnSonrisa";
            this.btnSonrisa.Size = new System.Drawing.Size(100, 28);
            this.btnSonrisa.TabIndex = 20;
            this.btnSonrisa.Text = "Sonrisa";
            this.btnSonrisa.UseVisualStyleBackColor = true;
            this.btnSonrisa.Click += new System.EventHandler(this.btnSonrisa_Click);
            // 
            // imgEstadoBoca
            // 
            this.imgEstadoBoca.BackColor = System.Drawing.SystemColors.Control;
            this.imgEstadoBoca.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imgEstadoBoca.Location = new System.Drawing.Point(7, 116);
            this.imgEstadoBoca.Margin = new System.Windows.Forms.Padding(4);
            this.imgEstadoBoca.Name = "imgEstadoBoca";
            this.imgEstadoBoca.Size = new System.Drawing.Size(133, 126);
            this.imgEstadoBoca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEstadoBoca.TabIndex = 18;
            this.imgEstadoBoca.TabStop = false;
            // 
            // imgBoca
            // 
            this.imgBoca.BackColor = System.Drawing.SystemColors.Control;
            this.imgBoca.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imgBoca.Location = new System.Drawing.Point(7, 22);
            this.imgBoca.Margin = new System.Windows.Forms.Padding(4);
            this.imgBoca.Name = "imgBoca";
            this.imgBoca.Size = new System.Drawing.Size(133, 86);
            this.imgBoca.TabIndex = 19;
            this.imgBoca.TabStop = false;
            // 
            // grpOjos
            // 
            this.grpOjos.BackColor = System.Drawing.SystemColors.Control;
            this.grpOjos.Controls.Add(this.txtLogOjos);
            this.grpOjos.Controls.Add(this.btnOjosCerrados);
            this.grpOjos.Controls.Add(this.btnOjosAbiertos);
            this.grpOjos.Controls.Add(this.imgEstadoOjos);
            this.grpOjos.Controls.Add(this.imgOjos);
            this.grpOjos.Location = new System.Drawing.Point(811, 282);
            this.grpOjos.Name = "grpOjos";
            this.grpOjos.Size = new System.Drawing.Size(270, 257);
            this.grpOjos.TabIndex = 23;
            this.grpOjos.TabStop = false;
            this.grpOjos.Text = "Ojos";
            // 
            // txtLogOjos
            // 
            this.txtLogOjos.Location = new System.Drawing.Point(153, 116);
            this.txtLogOjos.Multiline = true;
            this.txtLogOjos.Name = "txtLogOjos";
            this.txtLogOjos.ReadOnly = true;
            this.txtLogOjos.Size = new System.Drawing.Size(100, 126);
            this.txtLogOjos.TabIndex = 27;
            this.txtLogOjos.WordWrap = false;
            // 
            // btnOjosCerrados
            // 
            this.btnOjosCerrados.Location = new System.Drawing.Point(153, 67);
            this.btnOjosCerrados.Margin = new System.Windows.Forms.Padding(4);
            this.btnOjosCerrados.Name = "btnOjosCerrados";
            this.btnOjosCerrados.Size = new System.Drawing.Size(100, 28);
            this.btnOjosCerrados.TabIndex = 26;
            this.btnOjosCerrados.Text = "Cerrados";
            this.btnOjosCerrados.UseVisualStyleBackColor = true;
            this.btnOjosCerrados.Click += new System.EventHandler(this.btnOjosCerrados_Click);
            // 
            // btnOjosAbiertos
            // 
            this.btnOjosAbiertos.Location = new System.Drawing.Point(153, 31);
            this.btnOjosAbiertos.Margin = new System.Windows.Forms.Padding(4);
            this.btnOjosAbiertos.Name = "btnOjosAbiertos";
            this.btnOjosAbiertos.Size = new System.Drawing.Size(100, 28);
            this.btnOjosAbiertos.TabIndex = 25;
            this.btnOjosAbiertos.Text = "Abiertos";
            this.btnOjosAbiertos.UseVisualStyleBackColor = true;
            this.btnOjosAbiertos.Click += new System.EventHandler(this.btnOjosAbiertos_Click);
            // 
            // imgEstadoOjos
            // 
            this.imgEstadoOjos.BackColor = System.Drawing.SystemColors.Control;
            this.imgEstadoOjos.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imgEstadoOjos.Location = new System.Drawing.Point(12, 116);
            this.imgEstadoOjos.Margin = new System.Windows.Forms.Padding(4);
            this.imgEstadoOjos.Name = "imgEstadoOjos";
            this.imgEstadoOjos.Size = new System.Drawing.Size(133, 126);
            this.imgEstadoOjos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEstadoOjos.TabIndex = 23;
            this.imgEstadoOjos.TabStop = false;
            // 
            // imgOjos
            // 
            this.imgOjos.BackColor = System.Drawing.SystemColors.Control;
            this.imgOjos.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imgOjos.Location = new System.Drawing.Point(12, 22);
            this.imgOjos.Margin = new System.Windows.Forms.Padding(4);
            this.imgOjos.Name = "imgOjos";
            this.imgOjos.Size = new System.Drawing.Size(133, 86);
            this.imgOjos.TabIndex = 24;
            this.imgOjos.TabStop = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(823, 552);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(241, 28);
            this.btnActualizar.TabIndex = 18;
            this.btnActualizar.Text = "Fin del entrenamiento";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // imgCamara
            // 
            this.imgCamara.BackColor = System.Drawing.SystemColors.Control;
            this.imgCamara.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imgCamara.Location = new System.Drawing.Point(4, 4);
            this.imgCamara.Margin = new System.Windows.Forms.Padding(4);
            this.imgCamara.Name = "imgCamara";
            this.imgCamara.Size = new System.Drawing.Size(791, 581);
            this.imgCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCamara.TabIndex = 15;
            this.imgCamara.TabStop = false;
            // 
            // tabConfiguracion
            // 
            this.tabConfiguracion.BackColor = System.Drawing.SystemColors.Control;
            this.tabConfiguracion.Controls.Add(this.chkOjos);
            this.tabConfiguracion.Controls.Add(this.chkBoca);
            this.tabConfiguracion.Controls.Add(this.grpConfigBoca);
            this.tabConfiguracion.Controls.Add(this.grpConfigOjos);
            this.tabConfiguracion.Controls.Add(this.label4);
            this.tabConfiguracion.Controls.Add(this.cmbCamaras);
            this.tabConfiguracion.Location = new System.Drawing.Point(4, 25);
            this.tabConfiguracion.Name = "tabConfiguracion";
            this.tabConfiguracion.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguracion.Size = new System.Drawing.Size(1097, 589);
            this.tabConfiguracion.TabIndex = 0;
            this.tabConfiguracion.Text = "Configuración";
            // 
            // chkOjos
            // 
            this.chkOjos.AutoSize = true;
            this.chkOjos.Location = new System.Drawing.Point(33, 119);
            this.chkOjos.Name = "chkOjos";
            this.chkOjos.Size = new System.Drawing.Size(283, 21);
            this.chkOjos.TabIndex = 22;
            this.chkOjos.Text = "Habilitar la detección de los ojos (vigilia)";
            this.chkOjos.UseVisualStyleBackColor = true;
            this.chkOjos.CheckedChanged += new System.EventHandler(this.chkOjos_CheckedChanged);
            // 
            // chkBoca
            // 
            this.chkBoca.AutoSize = true;
            this.chkBoca.Checked = true;
            this.chkBoca.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoca.Location = new System.Drawing.Point(33, 97);
            this.chkBoca.Name = "chkBoca";
            this.chkBoca.Size = new System.Drawing.Size(319, 21);
            this.chkBoca.TabIndex = 21;
            this.chkBoca.Text = "Habilitar la detección de la boca (realiza click)";
            this.chkBoca.UseVisualStyleBackColor = true;
            this.chkBoca.CheckedChanged += new System.EventHandler(this.chkBoca_CheckedChanged);
            // 
            // grpConfigBoca
            // 
            this.grpConfigBoca.BackColor = System.Drawing.SystemColors.Control;
            this.grpConfigBoca.Controls.Add(this.label18);
            this.grpConfigBoca.Controls.Add(this.label17);
            this.grpConfigBoca.Controls.Add(this.txtMilisegGestoBocaInactivo);
            this.grpConfigBoca.Controls.Add(this.txtMilisegGestoBocaActivo);
            this.grpConfigBoca.Controls.Add(this.label5);
            this.grpConfigBoca.Controls.Add(this.label6);
            this.grpConfigBoca.Controls.Add(this.label7);
            this.grpConfigBoca.Controls.Add(this.trbMilisegGestoBocaInactivo);
            this.grpConfigBoca.Controls.Add(this.label3);
            this.grpConfigBoca.Controls.Add(this.label2);
            this.grpConfigBoca.Controls.Add(this.label1);
            this.grpConfigBoca.Controls.Add(this.trbMilisegGestoBocaActivo);
            this.grpConfigBoca.Location = new System.Drawing.Point(8, 185);
            this.grpConfigBoca.Name = "grpConfigBoca";
            this.grpConfigBoca.Size = new System.Drawing.Size(522, 398);
            this.grpConfigBoca.TabIndex = 20;
            this.grpConfigBoca.TabStop = false;
            this.grpConfigBoca.Text = "Boca";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(333, 244);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(163, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "Predeterminado: 500 ms";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(333, 104);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 17);
            this.label17.TabIndex = 26;
            this.label17.Text = "Predeterminado: 1000 ms";
            // 
            // txtMilisegGestoBocaInactivo
            // 
            this.txtMilisegGestoBocaInactivo.BackColor = System.Drawing.SystemColors.Control;
            this.txtMilisegGestoBocaInactivo.Enabled = false;
            this.txtMilisegGestoBocaInactivo.Location = new System.Drawing.Point(336, 209);
            this.txtMilisegGestoBocaInactivo.Name = "txtMilisegGestoBocaInactivo";
            this.txtMilisegGestoBocaInactivo.Size = new System.Drawing.Size(100, 22);
            this.txtMilisegGestoBocaInactivo.TabIndex = 25;
            // 
            // txtMilisegGestoBocaActivo
            // 
            this.txtMilisegGestoBocaActivo.BackColor = System.Drawing.SystemColors.Control;
            this.txtMilisegGestoBocaActivo.Enabled = false;
            this.txtMilisegGestoBocaActivo.Location = new System.Drawing.Point(336, 69);
            this.txtMilisegGestoBocaActivo.Name = "txtMilisegGestoBocaActivo";
            this.txtMilisegGestoBocaActivo.Size = new System.Drawing.Size(100, 22);
            this.txtMilisegGestoBocaActivo.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "3000 ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "0 ms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tolerancia a cambios de estado:";
            // 
            // trbMilisegGestoBocaInactivo
            // 
            this.trbMilisegGestoBocaInactivo.LargeChange = 500;
            this.trbMilisegGestoBocaInactivo.Location = new System.Drawing.Point(22, 209);
            this.trbMilisegGestoBocaInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.trbMilisegGestoBocaInactivo.Maximum = 3000;
            this.trbMilisegGestoBocaInactivo.Minimum = 1;
            this.trbMilisegGestoBocaInactivo.Name = "trbMilisegGestoBocaInactivo";
            this.trbMilisegGestoBocaInactivo.Size = new System.Drawing.Size(267, 56);
            this.trbMilisegGestoBocaInactivo.SmallChange = 10;
            this.trbMilisegGestoBocaInactivo.TabIndex = 20;
            this.trbMilisegGestoBocaInactivo.TickFrequency = 500;
            this.trbMilisegGestoBocaInactivo.Value = 500;
            this.trbMilisegGestoBocaInactivo.ValueChanged += new System.EventHandler(this.trbMilisegGestoBocaInactivo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "3000 ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "0 ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tiempo de sonrisa para hacer click:";
            // 
            // trbMilisegGestoBocaActivo
            // 
            this.trbMilisegGestoBocaActivo.LargeChange = 500;
            this.trbMilisegGestoBocaActivo.Location = new System.Drawing.Point(22, 69);
            this.trbMilisegGestoBocaActivo.Margin = new System.Windows.Forms.Padding(4);
            this.trbMilisegGestoBocaActivo.Maximum = 3000;
            this.trbMilisegGestoBocaActivo.Minimum = 1;
            this.trbMilisegGestoBocaActivo.Name = "trbMilisegGestoBocaActivo";
            this.trbMilisegGestoBocaActivo.Size = new System.Drawing.Size(267, 56);
            this.trbMilisegGestoBocaActivo.SmallChange = 10;
            this.trbMilisegGestoBocaActivo.TabIndex = 12;
            this.trbMilisegGestoBocaActivo.TickFrequency = 500;
            this.trbMilisegGestoBocaActivo.Value = 1000;
            this.trbMilisegGestoBocaActivo.ValueChanged += new System.EventHandler(this.trbMilisegGestoBocaActivo_ValueChanged);
            // 
            // grpConfigOjos
            // 
            this.grpConfigOjos.BackColor = System.Drawing.SystemColors.Control;
            this.grpConfigOjos.Controls.Add(this.label22);
            this.grpConfigOjos.Controls.Add(this.txtMilisegGestoOjosInactivo);
            this.grpConfigOjos.Controls.Add(this.label23);
            this.grpConfigOjos.Controls.Add(this.label24);
            this.grpConfigOjos.Controls.Add(this.label25);
            this.grpConfigOjos.Controls.Add(this.trbMilisegGestoOjosInactivo);
            this.grpConfigOjos.Controls.Add(this.label21);
            this.grpConfigOjos.Controls.Add(this.label20);
            this.grpConfigOjos.Controls.Add(this.label19);
            this.grpConfigOjos.Controls.Add(this.txtMilisegGestoOjosZumbar);
            this.grpConfigOjos.Controls.Add(this.txtMilisegGestoOjosVigilia);
            this.grpConfigOjos.Controls.Add(this.txtMilisegGestoOjosDespierto);
            this.grpConfigOjos.Controls.Add(this.label14);
            this.grpConfigOjos.Controls.Add(this.label15);
            this.grpConfigOjos.Controls.Add(this.label16);
            this.grpConfigOjos.Controls.Add(this.trbMilisegGestoOjosZumbar);
            this.grpConfigOjos.Controls.Add(this.label8);
            this.grpConfigOjos.Controls.Add(this.label9);
            this.grpConfigOjos.Controls.Add(this.label10);
            this.grpConfigOjos.Controls.Add(this.trbMilisegGestoOjosVigilia);
            this.grpConfigOjos.Controls.Add(this.label11);
            this.grpConfigOjos.Controls.Add(this.label12);
            this.grpConfigOjos.Controls.Add(this.label13);
            this.grpConfigOjos.Controls.Add(this.trbMilisegGestoOjosDespierto);
            this.grpConfigOjos.Location = new System.Drawing.Point(548, 6);
            this.grpConfigOjos.Name = "grpConfigOjos";
            this.grpConfigOjos.Size = new System.Drawing.Size(534, 577);
            this.grpConfigOjos.TabIndex = 19;
            this.grpConfigOjos.TabStop = false;
            this.grpConfigOjos.Text = "Ojos";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(340, 520);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(171, 17);
            this.label22.TabIndex = 47;
            this.label22.Text = "Predeterminado: 1000 ms";
            // 
            // txtMilisegGestoOjosInactivo
            // 
            this.txtMilisegGestoOjosInactivo.BackColor = System.Drawing.SystemColors.Control;
            this.txtMilisegGestoOjosInactivo.Enabled = false;
            this.txtMilisegGestoOjosInactivo.Location = new System.Drawing.Point(343, 485);
            this.txtMilisegGestoOjosInactivo.Name = "txtMilisegGestoOjosInactivo";
            this.txtMilisegGestoOjosInactivo.Size = new System.Drawing.Size(100, 22);
            this.txtMilisegGestoOjosInactivo.TabIndex = 46;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(256, 520);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 17);
            this.label23.TabIndex = 45;
            this.label23.Text = "3000 ms";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(30, 520);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(38, 17);
            this.label24.TabIndex = 44;
            this.label24.Text = "0 ms";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(30, 452);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(214, 17);
            this.label25.TabIndex = 43;
            this.label25.Text = "Tolerancia a cambios de estado:";
            // 
            // trbMilisegGestoOjosInactivo
            // 
            this.trbMilisegGestoOjosInactivo.LargeChange = 500;
            this.trbMilisegGestoOjosInactivo.Location = new System.Drawing.Point(30, 485);
            this.trbMilisegGestoOjosInactivo.Margin = new System.Windows.Forms.Padding(4);
            this.trbMilisegGestoOjosInactivo.Maximum = 3000;
            this.trbMilisegGestoOjosInactivo.Minimum = 1;
            this.trbMilisegGestoOjosInactivo.Name = "trbMilisegGestoOjosInactivo";
            this.trbMilisegGestoOjosInactivo.Size = new System.Drawing.Size(267, 56);
            this.trbMilisegGestoOjosInactivo.SmallChange = 10;
            this.trbMilisegGestoOjosInactivo.TabIndex = 42;
            this.trbMilisegGestoOjosInactivo.TickFrequency = 500;
            this.trbMilisegGestoOjosInactivo.Value = 500;
            this.trbMilisegGestoOjosInactivo.ValueChanged += new System.EventHandler(this.trbMilisegGestoOjosInactivo_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(340, 386);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(171, 17);
            this.label21.TabIndex = 41;
            this.label21.Text = "Predeterminado: 3000 ms";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(340, 244);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(171, 17);
            this.label20.TabIndex = 40;
            this.label20.Text = "Predeterminado: 5000 ms";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(340, 104);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(171, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "Predeterminado: 3000 ms";
            // 
            // txtMilisegGestoOjosZumbar
            // 
            this.txtMilisegGestoOjosZumbar.BackColor = System.Drawing.SystemColors.Control;
            this.txtMilisegGestoOjosZumbar.Enabled = false;
            this.txtMilisegGestoOjosZumbar.Location = new System.Drawing.Point(343, 351);
            this.txtMilisegGestoOjosZumbar.Name = "txtMilisegGestoOjosZumbar";
            this.txtMilisegGestoOjosZumbar.Size = new System.Drawing.Size(100, 22);
            this.txtMilisegGestoOjosZumbar.TabIndex = 38;
            // 
            // txtMilisegGestoOjosVigilia
            // 
            this.txtMilisegGestoOjosVigilia.BackColor = System.Drawing.SystemColors.Control;
            this.txtMilisegGestoOjosVigilia.Enabled = false;
            this.txtMilisegGestoOjosVigilia.Location = new System.Drawing.Point(343, 209);
            this.txtMilisegGestoOjosVigilia.Name = "txtMilisegGestoOjosVigilia";
            this.txtMilisegGestoOjosVigilia.Size = new System.Drawing.Size(100, 22);
            this.txtMilisegGestoOjosVigilia.TabIndex = 37;
            // 
            // txtMilisegGestoOjosDespierto
            // 
            this.txtMilisegGestoOjosDespierto.BackColor = System.Drawing.SystemColors.Control;
            this.txtMilisegGestoOjosDespierto.Enabled = false;
            this.txtMilisegGestoOjosDespierto.Location = new System.Drawing.Point(343, 69);
            this.txtMilisegGestoOjosDespierto.Name = "txtMilisegGestoOjosDespierto";
            this.txtMilisegGestoOjosDespierto.Size = new System.Drawing.Size(100, 22);
            this.txtMilisegGestoOjosDespierto.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(253, 386);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "5000 ms";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 386);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 17);
            this.label15.TabIndex = 34;
            this.label15.Text = "2000 ms";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 318);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(274, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "Tiempo de ojos abiertos antes de zumbar:";
            // 
            // trbMilisegGestoOjosZumbar
            // 
            this.trbMilisegGestoOjosZumbar.LargeChange = 500;
            this.trbMilisegGestoOjosZumbar.Location = new System.Drawing.Point(27, 351);
            this.trbMilisegGestoOjosZumbar.Margin = new System.Windows.Forms.Padding(4);
            this.trbMilisegGestoOjosZumbar.Maximum = 5000;
            this.trbMilisegGestoOjosZumbar.Minimum = 2000;
            this.trbMilisegGestoOjosZumbar.Name = "trbMilisegGestoOjosZumbar";
            this.trbMilisegGestoOjosZumbar.Size = new System.Drawing.Size(267, 56);
            this.trbMilisegGestoOjosZumbar.SmallChange = 10;
            this.trbMilisegGestoOjosZumbar.TabIndex = 32;
            this.trbMilisegGestoOjosZumbar.TickFrequency = 500;
            this.trbMilisegGestoOjosZumbar.Value = 3000;
            this.trbMilisegGestoOjosZumbar.ValueChanged += new System.EventHandler(this.trbMilisegGestoOjosZumbar_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 244);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "6000 ms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 244);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "3000 ms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(295, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Tiempo de ojos cerrados para pasar a Vigilia:";
            // 
            // trbMilisegGestoOjosVigilia
            // 
            this.trbMilisegGestoOjosVigilia.LargeChange = 500;
            this.trbMilisegGestoOjosVigilia.Location = new System.Drawing.Point(24, 209);
            this.trbMilisegGestoOjosVigilia.Margin = new System.Windows.Forms.Padding(4);
            this.trbMilisegGestoOjosVigilia.Maximum = 6000;
            this.trbMilisegGestoOjosVigilia.Minimum = 3000;
            this.trbMilisegGestoOjosVigilia.Name = "trbMilisegGestoOjosVigilia";
            this.trbMilisegGestoOjosVigilia.Size = new System.Drawing.Size(267, 56);
            this.trbMilisegGestoOjosVigilia.SmallChange = 10;
            this.trbMilisegGestoOjosVigilia.TabIndex = 28;
            this.trbMilisegGestoOjosVigilia.TickFrequency = 500;
            this.trbMilisegGestoOjosVigilia.Value = 5000;
            this.trbMilisegGestoOjosVigilia.ValueChanged += new System.EventHandler(this.trbMilisegGestoOjosVigilia_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 104);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "5000 ms";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 104);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "2000 ms";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 36);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(300, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Tiempo de pestaneo para detener el zumbido:";
            // 
            // trbMilisegGestoOjosDespierto
            // 
            this.trbMilisegGestoOjosDespierto.LargeChange = 500;
            this.trbMilisegGestoOjosDespierto.Location = new System.Drawing.Point(24, 69);
            this.trbMilisegGestoOjosDespierto.Margin = new System.Windows.Forms.Padding(4);
            this.trbMilisegGestoOjosDespierto.Maximum = 5000;
            this.trbMilisegGestoOjosDespierto.Minimum = 2000;
            this.trbMilisegGestoOjosDespierto.Name = "trbMilisegGestoOjosDespierto";
            this.trbMilisegGestoOjosDespierto.Size = new System.Drawing.Size(267, 56);
            this.trbMilisegGestoOjosDespierto.SmallChange = 10;
            this.trbMilisegGestoOjosDespierto.TabIndex = 24;
            this.trbMilisegGestoOjosDespierto.TickFrequency = 500;
            this.trbMilisegGestoOjosDespierto.Value = 3000;
            this.trbMilisegGestoOjosDespierto.ValueChanged += new System.EventHandler(this.trbMilisegGestoOjosDespierto_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Seleccione la cámara a utilizar:";
            // 
            // cmbCamaras
            // 
            this.cmbCamaras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCamaras.FormattingEnabled = true;
            this.cmbCamaras.Location = new System.Drawing.Point(30, 47);
            this.cmbCamaras.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCamaras.Name = "cmbCamaras";
            this.cmbCamaras.Size = new System.Drawing.Size(265, 24);
            this.cmbCamaras.TabIndex = 17;
            this.cmbCamaras.SelectedIndexChanged += new System.EventHandler(this.cmbCamaras_SelectedIndexChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 618);
            this.Controls.Add(this.tabPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Comunicación Facial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.Resize += new System.EventHandler(this.frmPrincipal_Resize);
            this.tabPrincipal.ResumeLayout(false);
            this.tabEntrenamiento.ResumeLayout(false);
            this.grpBoca.ResumeLayout(false);
            this.grpBoca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstadoBoca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoca)).EndInit();
            this.grpOjos.ResumeLayout(false);
            this.grpOjos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEstadoOjos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOjos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamara)).EndInit();
            this.tabConfiguracion.ResumeLayout(false);
            this.tabConfiguracion.PerformLayout();
            this.grpConfigBoca.ResumeLayout(false);
            this.grpConfigBoca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoBocaInactivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoBocaActivo)).EndInit();
            this.grpConfigOjos.ResumeLayout(false);
            this.grpConfigOjos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoOjosInactivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoOjosZumbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoOjosVigilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbMilisegGestoOjosDespierto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPrincipal;
        private System.Windows.Forms.TabPage tabConfiguracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCamaras;
        private System.Windows.Forms.TabPage tabEntrenamiento;
        private System.Windows.Forms.GroupBox grpBoca;
        private System.Windows.Forms.Button btnTriste;
        private System.Windows.Forms.Button btnSonrisa;
        private Emgu.CV.UI.ImageBox imgEstadoBoca;
        private Emgu.CV.UI.ImageBox imgBoca;
        private System.Windows.Forms.GroupBox grpOjos;
        private System.Windows.Forms.Button btnOjosCerrados;
        private System.Windows.Forms.Button btnOjosAbiertos;
        private Emgu.CV.UI.ImageBox imgEstadoOjos;
        private Emgu.CV.UI.ImageBox imgOjos;
        private System.Windows.Forms.Button btnActualizar;
        private Emgu.CV.UI.ImageBox imgCamara;
        private System.Windows.Forms.CheckBox chkOjos;
        private System.Windows.Forms.CheckBox chkBoca;
        private System.Windows.Forms.GroupBox grpConfigBoca;
        private System.Windows.Forms.GroupBox grpConfigOjos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbMilisegGestoBocaActivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trbMilisegGestoBocaInactivo;
        private System.Windows.Forms.TextBox txtMilisegGestoBocaInactivo;
        private System.Windows.Forms.TextBox txtMilisegGestoBocaActivo;
        private System.Windows.Forms.TextBox txtMilisegGestoOjosZumbar;
        private System.Windows.Forms.TextBox txtMilisegGestoOjosVigilia;
        private System.Windows.Forms.TextBox txtMilisegGestoOjosDespierto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TrackBar trbMilisegGestoOjosZumbar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trbMilisegGestoOjosVigilia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trbMilisegGestoOjosDespierto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtMilisegGestoOjosInactivo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TrackBar trbMilisegGestoOjosInactivo;
        private System.Windows.Forms.TextBox txtLogBoca;
        private System.Windows.Forms.TextBox txtLogOjos;
    }
}

