namespace LibraryBasicForm
{
    partial class FormMasterSearch
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
            this.paTitle = new DevExpress.XtraEditors.PanelControl();
            this.paFilter = new DevExpress.XtraEditors.PanelControl();
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository();
            this.repButton = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcFindMaster = new DevExpress.XtraGrid.GridControl();
            this.gvFindMaster = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFindMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFindMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // paTitle
            // 
            this.paTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTitle.Location = new System.Drawing.Point(0, 0);
            this.paTitle.Name = "paTitle";
            this.paTitle.Size = new System.Drawing.Size(808, 27);
            this.paTitle.TabIndex = 0;
            this.paTitle.Text = "panelControl1";
            // 
            // paFilter
            // 
            this.paFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.paFilter.Location = new System.Drawing.Point(0, 27);
            this.paFilter.Name = "paFilter";
            this.paFilter.Size = new System.Drawing.Size(808, 19);
            this.paFilter.TabIndex = 1;
            this.paFilter.Text = "panelControl2";
            this.paFilter.Visible = false;
            // 
            // persistentRepository1
            // 
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repButton});
            // 
            // repButton
            // 
            this.repButton.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Select", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, null)});
            this.repButton.Name = "repButton";
            this.repButton.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repButton.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repButton_ButtonClick);
            // 
            // gcFindMaster
            // 
            this.gcFindMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.gcFindMaster.EmbeddedNavigator.Name = "";
            this.gcFindMaster.Location = new System.Drawing.Point(0, 46);
            this.gcFindMaster.MainView = this.gvFindMaster;
            this.gcFindMaster.Name = "gcFindMaster";
            this.gcFindMaster.Size = new System.Drawing.Size(808, 361);
            this.gcFindMaster.TabIndex = 0;
            this.gcFindMaster.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFindMaster});
            // 
            // gvFindMaster
            // 
            this.gvFindMaster.GridControl = this.gcFindMaster;
            this.gvFindMaster.Name = "gvFindMaster";
            this.gvFindMaster.OptionsView.ColumnAutoWidth = false;
            this.gvFindMaster.OptionsView.ShowGroupPanel = false;
            // 
            // FormMasterSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 407);
            this.Controls.Add(this.gcFindMaster);
            this.Controls.Add(this.paFilter);
            this.Controls.Add(this.paTitle);
            this.Name = "FormMasterSearch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda";
            ((System.ComponentModel.ISupportInitialize)(this.paTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcFindMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFindMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl paTitle;
        private DevExpress.XtraEditors.PanelControl paFilter;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repButton;
        private DevExpress.XtraGrid.GridControl gcFindMaster;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFindMaster;
    }
}