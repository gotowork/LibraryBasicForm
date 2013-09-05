namespace Test
{
    partial class Form1
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.ctrlCliente2 = new Test.ctrlCliente();
            this.ctrlCliente1 = new Test.ctrlCliente();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCliente2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCliente1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "textEdit1";
            this.textEdit1.Location = new System.Drawing.Point(63, 31);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(133, 21);
            this.textEdit1.TabIndex = 0;
            // 
            // ctrlCliente2
            // 
            this.ctrlCliente2.EditValue = "ctrlCliente2";
            this.ctrlCliente2.FocusColor = System.Drawing.Color.Khaki;
            this.ctrlCliente2.Location = new System.Drawing.Point(63, 86);
            this.ctrlCliente2.Name = "ctrlCliente2";
            // 
            // 
            // 
            this.ctrlCliente2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "", -1, true, true, true, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.ViewStyle("EditorButtonStyle", null, new System.Drawing.Font("Microsoft Sans Serif", 8F), "", ((DevExpress.Utils.StyleOptions)((((((((((DevExpress.Utils.StyleOptions.StyleEnabled | DevExpress.Utils.StyleOptions.UseBackColor) 
                                | DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) 
                                | DevExpress.Utils.StyleOptions.UseDrawFocusRect) 
                                | DevExpress.Utils.StyleOptions.UseFont) 
                                | DevExpress.Utils.StyleOptions.UseForeColor) 
                                | DevExpress.Utils.StyleOptions.UseHorzAlignment) 
                                | DevExpress.Utils.StyleOptions.UseImage) 
                                | DevExpress.Utils.StyleOptions.UseWordWrap) 
                                | DevExpress.Utils.StyleOptions.UseVertAlignment))), true, false, false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, null, System.Drawing.Color.White, System.Drawing.SystemColors.ControlText)),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ctrlCliente2.Size = new System.Drawing.Size(75, 21);
            this.ctrlCliente2.TabIndex = 2;
            this.ctrlCliente2.UnFocusColor = System.Drawing.Color.White;
            // 
            // ctrlCliente1
            // 
            this.ctrlCliente1.EditValue = "ctrlCliente1";
            this.ctrlCliente1.FocusColor = System.Drawing.Color.Khaki;
            this.ctrlCliente1.Location = new System.Drawing.Point(63, 58);
            this.ctrlCliente1.Name = "ctrlCliente1";
            // 
            // 
            // 
            this.ctrlCliente1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Left, "", -1, true, true, true, DevExpress.Utils.HorzAlignment.Center, null, new DevExpress.Utils.ViewStyle("EditorButtonStyle", null, new System.Drawing.Font("Microsoft Sans Serif", 8F), "", ((DevExpress.Utils.StyleOptions)((((((((((DevExpress.Utils.StyleOptions.StyleEnabled | DevExpress.Utils.StyleOptions.UseBackColor) 
                                | DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) 
                                | DevExpress.Utils.StyleOptions.UseDrawFocusRect) 
                                | DevExpress.Utils.StyleOptions.UseFont) 
                                | DevExpress.Utils.StyleOptions.UseForeColor) 
                                | DevExpress.Utils.StyleOptions.UseHorzAlignment) 
                                | DevExpress.Utils.StyleOptions.UseImage) 
                                | DevExpress.Utils.StyleOptions.UseWordWrap) 
                                | DevExpress.Utils.StyleOptions.UseVertAlignment))), true, false, false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, null, System.Drawing.Color.White, System.Drawing.SystemColors.ControlText)),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ctrlCliente1.Size = new System.Drawing.Size(75, 21);
            this.ctrlCliente1.TabIndex = 1;
            this.ctrlCliente1.UnFocusColor = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.ctrlCliente2);
            this.Controls.Add(this.ctrlCliente1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCliente2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCliente1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCliente ctrlCliente1;
        private ctrlCliente ctrlCliente2;
        private DevExpress.XtraEditors.TextEdit textEdit1;


    }
}