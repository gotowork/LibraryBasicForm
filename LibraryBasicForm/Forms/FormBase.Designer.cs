namespace LibraryBasicForm
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.paInferior = new System.Windows.Forms.Panel();
            this.paSupBotones = new System.Windows.Forms.Panel();
            this.paTitulo = new System.Windows.Forms.Panel();
            this.laTitulo = new System.Windows.Forms.Label();
            this.paCentral = new System.Windows.Forms.Panel();
            this.paSuperior = new System.Windows.Forms.Panel();
            this.thePanelTab1 = new Theia.Panels.ThePanelTab();
            this.tpDatos = new System.Windows.Forms.TabPage();
            this.paTitulo.SuspendLayout();
            this.thePanelTab1.SuspendLayout();
            this.tpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // paInferior
            // 
            this.paInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.paInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paInferior.Location = new System.Drawing.Point(3, 128);
            this.paInferior.Name = "paInferior";
            this.paInferior.Size = new System.Drawing.Size(426, 45);
            this.paInferior.TabIndex = 7;
            // 
            // paSupBotones
            // 
            this.paSupBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.paSupBotones.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSupBotones.Location = new System.Drawing.Point(0, 0);
            this.paSupBotones.Name = "paSupBotones";
            this.paSupBotones.Size = new System.Drawing.Size(440, 32);
            this.paSupBotones.TabIndex = 8;
            // 
            // paTitulo
            // 
            this.paTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.paTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paTitulo.BackgroundImage")));
            this.paTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paTitulo.Controls.Add(this.laTitulo);
            this.paTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTitulo.Location = new System.Drawing.Point(3, 3);
            this.paTitulo.Name = "paTitulo";
            this.paTitulo.Size = new System.Drawing.Size(426, 37);
            this.paTitulo.TabIndex = 9;
            // 
            // laTitulo
            // 
            this.laTitulo.BackColor = System.Drawing.Color.Tan;
            this.laTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitulo.Location = new System.Drawing.Point(0, 0);
            this.laTitulo.Name = "laTitulo";
            this.laTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.laTitulo.Size = new System.Drawing.Size(426, 37);
            this.laTitulo.TabIndex = 0;
            this.laTitulo.Text = "label1";
            this.laTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paCentral
            // 
            this.paCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.paCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paCentral.Location = new System.Drawing.Point(3, 84);
            this.paCentral.Name = "paCentral";
            this.paCentral.Size = new System.Drawing.Size(426, 44);
            this.paCentral.TabIndex = 6;
            // 
            // paSuperior
            // 
            this.paSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.paSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.paSuperior.Location = new System.Drawing.Point(3, 40);
            this.paSuperior.Name = "paSuperior";
            this.paSuperior.Size = new System.Drawing.Size(426, 44);
            this.paSuperior.TabIndex = 10;
            // 
            // thePanelTab1
            // 
            this.thePanelTab1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.thePanelTab1.Controls.Add(this.tpDatos);
            this.thePanelTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thePanelTab1.Location = new System.Drawing.Point(0, 32);
            this.thePanelTab1.Margin = new System.Windows.Forms.Padding(0);
            this.thePanelTab1.Name = "thePanelTab1";
            this.thePanelTab1.Padding = new System.Drawing.Point(0, 0);
            this.thePanelTab1.SelectedIndex = 0;
            this.thePanelTab1.Size = new System.Drawing.Size(440, 205);
            this.thePanelTab1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.thePanelTab1.TabIndex = 0;
            // 
            // tpDatos
            // 
            this.tpDatos.Controls.Add(this.paCentral);
            this.tpDatos.Controls.Add(this.paSuperior);
            this.tpDatos.Controls.Add(this.paInferior);
            this.tpDatos.Controls.Add(this.paTitulo);
            this.tpDatos.Location = new System.Drawing.Point(4, 25);
            this.tpDatos.Name = "tpDatos";
            this.tpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatos.Size = new System.Drawing.Size(432, 176);
            this.tpDatos.TabIndex = 0;
            this.tpDatos.Text = "Datos";
            this.tpDatos.UseVisualStyleBackColor = true;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(440, 237);
            this.Controls.Add(this.thePanelTab1);
            this.Controls.Add(this.paSupBotones);
            this.KeyPreview = true;
            this.Name = "FormBase";
            this.Text = "FormBase";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormBase_KeyPress);
            this.paTitulo.ResumeLayout(false);
            this.thePanelTab1.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel paInferior;
        public System.Windows.Forms.Panel paTitulo;
        public System.Windows.Forms.Panel paCentral;
        public System.Windows.Forms.Panel paSuperior;
        public System.Windows.Forms.Label laTitulo;
        public Theia.Panels.ThePanelTab thePanelTab1;
        public System.Windows.Forms.TabPage tpDatos;
        public System.Windows.Forms.Panel paSupBotones;




    }
}