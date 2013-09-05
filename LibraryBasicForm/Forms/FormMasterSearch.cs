using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using LibraryBasicForm.Util;


namespace LibraryBasicForm
{    
    public partial class FormMasterSearch : Form
    {        
        string id = "";
        Dictionary<string, string> keys = new Dictionary<string, string>();        
        bool flagItemSelected = false;

        public FormMasterSearch()
        {
            InitializeComponent();            
        }

        public FormMasterSearch(string pId)
        {
            InitializeComponent();
            id = pId;
        }

        public void AddFilter(UserControl filter, System.Drawing.Size filterSize)
        {
            if (filter != null)
            {
                filter.Dock = DockStyle.Fill;
                paFilter.Controls.Add(filter);
                paFilter.Visible = true;
                paFilter.Size = filterSize;                
            }
        }

        public void BindGrid(UserControl filter, System.Drawing.Size size, CParameterSearch parameter)
        {
            AddFilter(filter, size);
            BindGrid(parameter);
        }

        public void BindGrid(CParameterSearch parameter)
        {           
            foreach (string key in parameter.Keys)
                if (!keys.ContainsKey(key))
                    keys.Add(key, "");

            if (parameter is CParameterDatatable)
                gcFindMaster.DataSource = (parameter as CParameterDatatable).ResultSearch;
            else
                gcFindMaster.DataSource = (parameter as CParameterIList).ResultSearch;

            SetAppareance(parameter);
        }

        bool ExistColumnSelect()
        {
            for (int i = 0; i < gvFindMaster.Columns.Count; i++)
                if (gvFindMaster.Columns[i].FieldName == "Select")
                    return true;
            return false;
        }

        public void SetAppareance(CParameterSearch parameter)
        {
            
            //Establecer columnas visibles y no visibles
            for (int j = 0; j < gvFindMaster.Columns.Count; j++)
            {                
                gvFindMaster.Columns[j].OptionsColumn.AllowEdit = false;

                if (parameter.Fields.ContainsKey(gvFindMaster.Columns[j].FieldName))
                {
                    if (parameter.Fields[gvFindMaster.Columns[j].FieldName] == "")
                        gvFindMaster.Columns[j].Visible = false;
                    else
                        gvFindMaster.Columns[j].Caption = parameter.Fields[gvFindMaster.Columns[j].FieldName];
                }
            }

            //Establecer apariencia de la columna select
            if (ExistColumnSelect())
            {
                gvFindMaster.Columns["Select"].Caption = "#";
                gvFindMaster.Columns["Select"].ColumnEdit = repButton;
                gvFindMaster.Columns["Select"].Width = 100;
                gvFindMaster.Columns["Select"].OptionsColumn.AllowSize = false;
                gvFindMaster.Columns["Select"].OptionsFilter.AllowFilter = false;
                gvFindMaster.Columns["Select"].OptionsColumn.AllowEdit = true;
            }

            gvFindMaster.BestFitColumns();
        }

        public Dictionary<string, string> getKeyValues()
        {
            if (flagItemSelected)
            {
                if (gvFindMaster.RowCount > 0)
                {
                    foreach (KeyValuePair<string, string> kvp in keys)
                    {
                        keys[kvp.Key] = gvFindMaster.GetRowCellValue(gvFindMaster.FocusedRowHandle, kvp.Key).ToString();
                        return keys;
                    }
                }
            }
            return null;
        }

        private void repButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ///Alerta al módulo que hizo la llamada, indicando que ha sido seleccionado una fila
            ///
            flagItemSelected = true;
            this.Close();            
        }
    }        
}
