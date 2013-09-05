namespace LibraryBasicForm
{
    partial class FormConfirm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.paTop = new DevExpress.XtraEditors.PanelControl();
            this.laTitle = new System.Windows.Forms.Label();
            this.paCenter = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).BeginInit();
            this.paTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btCancel);
            this.panelControl1.Controls.Add(this.btOk);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 122);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(284, 34);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Text = "paBottom";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(52, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(68, 23);
            this.btCancel.TabIndex = 0;
            this.btCancel.Text = "Cancelar";
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(5, 5);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(41, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "Ok";
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.laTitle);
            this.paTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTop.Location = new System.Drawing.Point(0, 0);
            this.paTop.Name = "paTop";
            this.paTop.Size = new System.Drawing.Size(284, 44);
            this.paTop.TabIndex = 1;
            this.paTop.Text = "panelControl2";
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
            this.laTitle.Size = new System.Drawing.Size(280, 40);
            this.laTitle.TabIndex = 0;
            this.laTitle.Text = "label1";
            // 
            // paCenter
            // 
            this.paCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paCenter.Location = new System.Drawing.Point(0, 44);
            this.paCenter.Name = "paCenter";
            this.paCenter.Size = new System.Drawing.Size(284, 78);
            this.paCenter.TabIndex = 2;
            this.paCenter.Text = "panelControl2";
            // 
            // FormConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.paCenter);
            this.Controls.Add(this.paTop);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "FormConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmación";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormConfirm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paTop)).EndInit();
            this.paTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl panelControl1;
        public DevExpress.XtraEditors.SimpleButton btCancel;
        public DevExpress.XtraEditors.SimpleButton btOk;
        public DevExpress.XtraEditors.PanelControl paTop;
        public DevExpress.XtraEditors.PanelControl paCenter;
        public System.Windows.Forms.Label laTitle;


    }
}