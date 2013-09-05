namespace LibraryBasicForm
{
    partial class FormBaseEmpty
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
            this.laTitle = new System.Windows.Forms.Label();
            this.paTitle = new DevExpress.XtraEditors.PanelControl();
            this.paBottom = new DevExpress.XtraEditors.PanelControl();
            this.paCenter = new DevExpress.XtraEditors.PanelControl();
            this.paTop = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            this.paTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // laTitle
            // 
            this.laTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.laTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(170)))));
            this.laTitle.Location = new System.Drawing.Point(2, 2);
            this.laTitle.Name = "laTitle";
            this.laTitle.Padding = new System.Windows.Forms.Padding(20, 7, 0, 0);
            this.laTitle.Size = new System.Drawing.Size(280, 39);
            this.laTitle.TabIndex = 4;
            this.laTitle.Text = "label1";
            // 
            // paTitle
            // 
            this.paTitle.Controls.Add(this.laTitle);
            this.paTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTitle.Location = new System.Drawing.Point(0, 14);
            this.paTitle.Name = "paTitle";
            this.paTitle.Size = new System.Drawing.Size(284, 43);
            this.paTitle.TabIndex = 5;
            this.paTitle.Text = "panelControl1";
            // 
            // paBottom
            // 
            this.paBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBottom.Location = new System.Drawing.Point(0, 216);
            this.paBottom.Name = "paBottom";
            this.paBottom.Size = new System.Drawing.Size(284, 46);
            this.paBottom.TabIndex = 6;
            this.paBottom.Text = "panelControl2";
            // 
            // paCenter
            // 
            this.paCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paCenter.Location = new System.Drawing.Point(0, 108);
            this.paCenter.Name = "paCenter";
            this.paCenter.Size = new System.Drawing.Size(284, 108);
            this.paCenter.TabIndex = 7;
            this.paCenter.Text = "panelControl3";
            // 
            // paTop
            // 
            this.paTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTop.Location = new System.Drawing.Point(0, 57);
            this.paTop.Name = "paTop";
            this.paTop.Size = new System.Drawing.Size(284, 51);
            this.paTop.TabIndex = 8;
            this.paTop.Text = "panelControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(284, 14);
            this.panelControl1.TabIndex = 9;
            this.panelControl1.Text = "panelControl1";
            // 
            // FormBaseEmpty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.paCenter);
            this.Controls.Add(this.paTop);
            this.Controls.Add(this.paBottom);
            this.Controls.Add(this.paTitle);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "FormBaseEmpty";
            this.Text = "FormBaseEmpty";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormBaseEmpty_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            this.paTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label laTitle;
        public DevExpress.XtraEditors.PanelControl paTitle;
        public DevExpress.XtraEditors.PanelControl paBottom;
        public DevExpress.XtraEditors.PanelControl paCenter;
        public DevExpress.XtraEditors.PanelControl paTop;
        public DevExpress.XtraEditors.PanelControl panelControl1;

    }
}