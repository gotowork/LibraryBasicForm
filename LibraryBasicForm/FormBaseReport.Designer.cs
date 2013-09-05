namespace LibraryBasicForm
{
    partial class FormBaseReport
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
            this.paParamsVisor = new DevComponents.DotNetBar.ExpandablePanel();
            this.paVisor = new DevComponents.DotNetBar.ExpandablePanel();
            this.paTitulo.SuspendLayout();
            this.paCentral.SuspendLayout();
            this.paSuperior.SuspendLayout();
            this.thePanelTab1.SuspendLayout();
            this.tpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // paInferior
            // 
            this.paInferior.Location = new System.Drawing.Point(3, 362);
            this.paInferior.Size = new System.Drawing.Size(493, 45);
            // 
            // paTitulo
            // 
            this.paTitulo.Size = new System.Drawing.Size(493, 37);
            // 
            // paCentral
            // 
            this.paCentral.Controls.Add(this.paVisor);
            this.paCentral.Location = new System.Drawing.Point(3, 115);
            this.paCentral.Size = new System.Drawing.Size(493, 247);
            // 
            // paSupBotones
            // 
            this.paSupBotones.Size = new System.Drawing.Size(507, 32);
            // 
            // paSuperior
            // 
            this.paSuperior.Controls.Add(this.paParamsVisor);
            this.paSuperior.Size = new System.Drawing.Size(493, 75);
            // 
            // laTitulo
            // 
            this.laTitulo.Size = new System.Drawing.Size(493, 37);
            // 
            // thePanelTab1
            // 
            this.thePanelTab1.Size = new System.Drawing.Size(507, 439);
            // 
            // tpDatos
            // 
            this.tpDatos.Size = new System.Drawing.Size(499, 410);
            // 
            // paParamsVisor
            // 
            this.paParamsVisor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.paParamsVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paParamsVisor.Location = new System.Drawing.Point(0, 0);
            this.paParamsVisor.Name = "paParamsVisor";
            this.paParamsVisor.Size = new System.Drawing.Size(493, 75);
            this.paParamsVisor.TabIndex = 0;
            this.paParamsVisor.Text = "expandablePanel1";
            this.paParamsVisor.TitleText = "Title Bar";
            // 
            // paVisor
            // 
            this.paVisor.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.paVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paVisor.Expanded = false;
            this.paVisor.ExpandedBounds = new System.Drawing.Rectangle(0, 0, 426, 148);
            this.paVisor.Location = new System.Drawing.Point(0, 0);
            this.paVisor.Name = "paVisor";
            this.paVisor.Size = new System.Drawing.Size(493, 247);
            this.paVisor.TabIndex = 0;
            this.paVisor.Text = "expandablePanel2";
            this.paVisor.TitleText = "Title Bar";
            // 
            // FormBaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 471);
            this.Name = "FormBaseReport";
            this.Text = "FormBaseReport";
            this.paTitulo.ResumeLayout(false);
            this.paCentral.ResumeLayout(false);
            this.paSuperior.ResumeLayout(false);
            this.thePanelTab1.ResumeLayout(false);
            this.tpDatos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ExpandablePanel paParamsVisor;
        public DevComponents.DotNetBar.ExpandablePanel paVisor;
    }
}