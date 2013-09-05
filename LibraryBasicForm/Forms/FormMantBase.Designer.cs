namespace LibraryBasicForm
{
    partial class FormMantBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMantBase));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btSalir2 = new System.Windows.Forms.Button();
            this.tpBusqueda = new System.Windows.Forms.TabPage();
            this.paMiddleFind = new System.Windows.Forms.Panel();
            this.dgvMasterSearch = new System.Windows.Forms.DataGridView();
            this.paBottomSearch = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.paTopSearch = new System.Windows.Forms.Panel();
            this.paSearchGen = new System.Windows.Forms.Panel();
            this.btFiltroBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.paTitleSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btEditar = new System.Windows.Forms.Button();
            this.paTopBasicButtons = new System.Windows.Forms.Panel();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btNuevo2 = new System.Windows.Forms.Button();
            this.btEliminar2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paInferior.SuspendLayout();
            this.paTitulo.SuspendLayout();
            this.thePanelTab1.SuspendLayout();
            this.tpDatos.SuspendLayout();
            this.tpBusqueda.SuspendLayout();
            this.paMiddleFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterSearch)).BeginInit();
            this.paBottomSearch.SuspendLayout();
            this.paTopSearch.SuspendLayout();
            this.paSearchGen.SuspendLayout();
            this.paTitleSearch.SuspendLayout();
            this.panel3.SuspendLayout();
            this.paTopBasicButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paInferior
            // 
            this.paInferior.Controls.Add(this.panel1);
            this.paInferior.Controls.Add(this.paTopBasicButtons);
            this.paInferior.Location = new System.Drawing.Point(3, 192);
            this.paInferior.Size = new System.Drawing.Size(526, 45);
            this.paInferior.TabIndex = 4;
            // 
            // paTitulo
            // 
            this.paTitulo.Controls.Add(this.panel2);
            this.paTitulo.Size = new System.Drawing.Size(526, 36);
            this.paTitulo.TabIndex = 1;
            this.paTitulo.Controls.SetChildIndex(this.panel2, 0);
            this.paTitulo.Controls.SetChildIndex(this.laTitulo, 0);
            // 
            // paCentral
            // 
            this.paCentral.Location = new System.Drawing.Point(3, 76);
            this.paCentral.Size = new System.Drawing.Size(526, 116);
            this.paCentral.TabIndex = 3;
            // 
            // paSupBotones
            // 
            this.paSupBotones.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.paSupBotones.Size = new System.Drawing.Size(540, 32);
            this.paSupBotones.Visible = false;
            // 
            // paSuperior
            // 
            this.paSuperior.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paSuperior.Location = new System.Drawing.Point(3, 39);
            this.paSuperior.Size = new System.Drawing.Size(526, 37);
            this.paSuperior.TabIndex = 2;
            // 
            // laTitulo
            // 
            this.laTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.laTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.laTitulo.Size = new System.Drawing.Size(442, 36);
            // 
            // thePanelTab1
            // 
            this.thePanelTab1.Controls.Add(this.tpBusqueda);
            this.thePanelTab1.Size = new System.Drawing.Size(540, 269);
            this.thePanelTab1.Controls.SetChildIndex(this.tpBusqueda, 0);
            this.thePanelTab1.Controls.SetChildIndex(this.tpDatos, 0);
            // 
            // tpDatos
            // 
            this.tpDatos.Size = new System.Drawing.Size(532, 240);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "save.png");
            this.imageList1.Images.SetKeyName(1, "nuevo.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "buscar.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            this.imageList1.Images.SetKeyName(5, "cancelar.png");
            this.imageList1.Images.SetKeyName(6, "ok.png");
            this.imageList1.Images.SetKeyName(7, "deshacer.png");
            this.imageList1.Images.SetKeyName(8, "editar.png");
            // 
            // btSalir2
            // 
            this.btSalir2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btSalir2.FlatAppearance.BorderSize = 0;
            this.btSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalir2.ImageIndex = 4;
            this.btSalir2.ImageList = this.imageList1;
            this.btSalir2.Location = new System.Drawing.Point(10, 9);
            this.btSalir2.Name = "btSalir2";
            this.btSalir2.Size = new System.Drawing.Size(57, 25);
            this.btSalir2.TabIndex = 4;
            this.btSalir2.Text = "&Salir";
            this.btSalir2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSalir2.UseVisualStyleBackColor = true;
            this.btSalir2.Click += new System.EventHandler(this.btSalir2_Click);
            // 
            // tpBusqueda
            // 
            this.tpBusqueda.Controls.Add(this.paMiddleFind);
            this.tpBusqueda.Controls.Add(this.paBottomSearch);
            this.tpBusqueda.Controls.Add(this.paTopSearch);
            this.tpBusqueda.Controls.Add(this.paTitleSearch);
            this.tpBusqueda.Location = new System.Drawing.Point(4, 25);
            this.tpBusqueda.Name = "tpBusqueda";
            this.tpBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tpBusqueda.Size = new System.Drawing.Size(432, 176);
            this.tpBusqueda.TabIndex = 1;
            this.tpBusqueda.Text = "Busqueda";
            this.tpBusqueda.UseVisualStyleBackColor = true;
            // 
            // paMiddleFind
            // 
            this.paMiddleFind.Controls.Add(this.dgvMasterSearch);
            this.paMiddleFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paMiddleFind.Location = new System.Drawing.Point(3, 97);
            this.paMiddleFind.Name = "paMiddleFind";
            this.paMiddleFind.Size = new System.Drawing.Size(426, 33);
            this.paMiddleFind.TabIndex = 13;
            // 
            // dgvMasterSearch
            // 
            this.dgvMasterSearch.BackgroundColor = System.Drawing.Color.White;
            this.dgvMasterSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMasterSearch.Location = new System.Drawing.Point(0, 0);
            this.dgvMasterSearch.Name = "dgvMasterSearch";
            this.dgvMasterSearch.Size = new System.Drawing.Size(426, 33);
            this.dgvMasterSearch.TabIndex = 0;
            this.dgvMasterSearch.DoubleClick += new System.EventHandler(this.dgvMasterSearch_DoubleClick);
            // 
            // paBottomSearch
            // 
            this.paBottomSearch.Controls.Add(this.btCancel);
            this.paBottomSearch.Controls.Add(this.btOk);
            this.paBottomSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBottomSearch.Location = new System.Drawing.Point(3, 130);
            this.paBottomSearch.Name = "paBottomSearch";
            this.paBottomSearch.Size = new System.Drawing.Size(426, 43);
            this.paBottomSearch.TabIndex = 12;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCancel.ImageIndex = 7;
            this.btCancel.ImageList = this.imageList1;
            this.btCancel.Location = new System.Drawing.Point(101, 9);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 25);
            this.btCancel.TabIndex = 5;
            this.btCancel.Text = "&Cancelar";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btOk.ImageIndex = 6;
            this.btOk.ImageList = this.imageList1;
            this.btOk.Location = new System.Drawing.Point(20, 9);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 25);
            this.btOk.TabIndex = 4;
            this.btOk.Text = "&Aceptar";
            this.btOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // paTopSearch
            // 
            this.paTopSearch.Controls.Add(this.paSearchGen);
            this.paTopSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTopSearch.Location = new System.Drawing.Point(3, 40);
            this.paTopSearch.Name = "paTopSearch";
            this.paTopSearch.Size = new System.Drawing.Size(426, 57);
            this.paTopSearch.TabIndex = 11;
            // 
            // paSearchGen
            // 
            this.paSearchGen.Controls.Add(this.btFiltroBuscar);
            this.paSearchGen.Controls.Add(this.label3);
            this.paSearchGen.Controls.Add(this.label2);
            this.paSearchGen.Controls.Add(this.txtBuscar);
            this.paSearchGen.Controls.Add(this.cbCampo);
            this.paSearchGen.Location = new System.Drawing.Point(12, 12);
            this.paSearchGen.Name = "paSearchGen";
            this.paSearchGen.Size = new System.Drawing.Size(497, 32);
            this.paSearchGen.TabIndex = 2;
            // 
            // btFiltroBuscar
            // 
            this.btFiltroBuscar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btFiltroBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btFiltroBuscar.FlatAppearance.BorderSize = 0;
            this.btFiltroBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltroBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFiltroBuscar.ImageIndex = 3;
            this.btFiltroBuscar.ImageList = this.imageList1;
            this.btFiltroBuscar.Location = new System.Drawing.Point(413, 4);
            this.btFiltroBuscar.Name = "btFiltroBuscar";
            this.btFiltroBuscar.Size = new System.Drawing.Size(75, 25);
            this.btFiltroBuscar.TabIndex = 5;
            this.btFiltroBuscar.Text = "&Buscar";
            this.btFiltroBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFiltroBuscar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Campo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Texto:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Location = new System.Drawing.Point(68, 6);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(157, 21);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(280, 6);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 21);
            this.cbCampo.TabIndex = 0;
            this.cbCampo.DropDownClosed += new System.EventHandler(this.cbCampo_DropDownClosed);
            // 
            // paTitleSearch
            // 
            this.paTitleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.paTitleSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paTitleSearch.BackgroundImage")));
            this.paTitleSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paTitleSearch.Controls.Add(this.label1);
            this.paTitleSearch.Controls.Add(this.panel3);
            this.paTitleSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTitleSearch.Location = new System.Drawing.Point(3, 3);
            this.paTitleSearch.Name = "paTitleSearch";
            this.paTitleSearch.Size = new System.Drawing.Size(426, 37);
            this.paTitleSearch.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(343, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.btEditar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(343, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 37);
            this.panel3.TabIndex = 6;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Transparent;
            this.btEditar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditar.ImageIndex = 8;
            this.btEditar.ImageList = this.imageList1;
            this.btEditar.Location = new System.Drawing.Point(11, 7);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(67, 25);
            this.btEditar.TabIndex = 5;
            this.btEditar.Text = "&Editar";
            this.btEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // paTopBasicButtons
            // 
            this.paTopBasicButtons.Controls.Add(this.btGuardar);
            this.paTopBasicButtons.Controls.Add(this.btNuevo2);
            this.paTopBasicButtons.Controls.Add(this.btEliminar2);
            this.paTopBasicButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.paTopBasicButtons.Location = new System.Drawing.Point(0, 0);
            this.paTopBasicButtons.Name = "paTopBasicButtons";
            this.paTopBasicButtons.Size = new System.Drawing.Size(282, 45);
            this.paTopBasicButtons.TabIndex = 8;
            // 
            // btGuardar
            // 
            this.btGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btGuardar.FlatAppearance.BorderSize = 0;
            this.btGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGuardar.ImageIndex = 0;
            this.btGuardar.ImageList = this.imageList1;
            this.btGuardar.Location = new System.Drawing.Point(5, 9);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(73, 25);
            this.btGuardar.TabIndex = 0;
            this.btGuardar.Text = "&Guardar";
            this.btGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btNuevo2
            // 
            this.btNuevo2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btNuevo2.FlatAppearance.BorderSize = 0;
            this.btNuevo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNuevo2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNuevo2.ImageIndex = 1;
            this.btNuevo2.ImageList = this.imageList1;
            this.btNuevo2.Location = new System.Drawing.Point(84, 9);
            this.btNuevo2.Name = "btNuevo2";
            this.btNuevo2.Size = new System.Drawing.Size(73, 25);
            this.btNuevo2.TabIndex = 1;
            this.btNuevo2.Text = "&Nuevo";
            this.btNuevo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNuevo2.UseVisualStyleBackColor = true;
            this.btNuevo2.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btEliminar2
            // 
            this.btEliminar2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btEliminar2.FlatAppearance.BorderSize = 0;
            this.btEliminar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminar2.ImageIndex = 2;
            this.btEliminar2.ImageList = this.imageList1;
            this.btEliminar2.Location = new System.Drawing.Point(163, 9);
            this.btEliminar2.Name = "btEliminar2";
            this.btEliminar2.Size = new System.Drawing.Size(73, 25);
            this.btEliminar2.TabIndex = 2;
            this.btEliminar2.Text = "&Eliminar";
            this.btEliminar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEliminar2.UseVisualStyleBackColor = true;
            this.btEliminar2.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSalir2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(454, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 45);
            this.panel1.TabIndex = 9;
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btBuscar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btBuscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btBuscar.FlatAppearance.BorderSize = 0;
            this.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.btBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btBuscar.ImageIndex = 3;
            this.btBuscar.ImageList = this.imageList1;
            this.btBuscar.Location = new System.Drawing.Point(12, 7);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(67, 25);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "&Buscar";
            this.btBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.btBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(442, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 36);
            this.panel2.TabIndex = 7;
            // 
            // FormMantBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 301);
            this.Name = "FormMantBase";
            this.Text = "FormMantBase";
            this.paInferior.ResumeLayout(false);
            this.paTitulo.ResumeLayout(false);
            this.thePanelTab1.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            this.tpBusqueda.ResumeLayout(false);
            this.paMiddleFind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterSearch)).EndInit();
            this.paBottomSearch.ResumeLayout(false);
            this.paTopSearch.ResumeLayout(false);
            this.paSearchGen.ResumeLayout(false);
            this.paSearchGen.PerformLayout();
            this.paTitleSearch.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.paTopBasicButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tpBusqueda;
        public System.Windows.Forms.Panel paTitleSearch;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.ComboBox cbCampo;
        public System.Windows.Forms.Panel paTopBasicButtons;
        public System.Windows.Forms.Button btSalir2;
        public System.Windows.Forms.Button btGuardar;
        public System.Windows.Forms.Button btNuevo2;
        public System.Windows.Forms.Button btEliminar2;
        public System.Windows.Forms.Panel paTopSearch;
        public System.Windows.Forms.Panel paBottomSearch;
        public System.Windows.Forms.Button btBuscar;
        public System.Windows.Forms.Button btEditar;
        public System.Windows.Forms.Button btCancel;
        public System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btFiltroBuscar;
        public System.Windows.Forms.Panel paSearchGen;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel paMiddleFind;
        public System.Windows.Forms.DataGridView dgvMasterSearch;
        public System.Windows.Forms.Panel panel2;
    }
}