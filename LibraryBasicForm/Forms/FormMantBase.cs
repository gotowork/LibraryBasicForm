using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;

namespace LibraryBasicForm
{
    

    public partial class FormMantBase : FormBase
    {

        #region Properties

        public DataTable TableMaster { get; set; }
        public DataView ViewMaster { get; set; }
        public int Id { get; set; }

        #endregion

        #region Constructor

        public FormMantBase()
        {
            InitializeComponent();
        }

        #endregion

        #region Virtual Methods

        protected virtual void Asignar_Codigo_Seleccionado()
        { 
        }

        protected virtual void Accion_Despues_Grabar()
        {            
        }

        protected virtual void Load_Finder()
        { 
        }

        protected virtual bool Existe_Clave()
        {
            return false;
        }

        protected virtual void Limpiar_Campos()
        {
            // --- Limpia los campos            
        }

        protected void Inicializar_Controles()  // --- Inicializa botones, paneles
        {
            // --- Limpia los campos            
        }

        protected virtual bool Claves_Correctas()
        {
            return false;
        }

        protected virtual void Recuperar_Registro()
        {
            
        }

        protected virtual bool Grabar_Registro()
        {
            return false;
        }

        protected virtual void Grabar_Imprimir()
        {

        }

        protected virtual void Eliminar_Registro()
        {
        }

        protected virtual bool Son_Datos_Correctos()
        {
            return true;
        }

        protected virtual bool Grabar()
        {

            if (Son_Datos_Correctos() &&
               (MessageBox.Show("Desea grabar el documento actual?", "Grabar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {

                if (Grabar_Registro())
                {
                    Limpiar_Campos();
                    Accion_Despues_Grabar();
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        #endregion Metodos

        #region Events

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Grabar();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            Limpiar_Campos();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Eliminar_Registro();
        }        

        private void btSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            thePanelTab1.SelectedIndex = 1;

            // --- Hide buttons
            paTopBasicButtons.Enabled = false;
        }

        #endregion

        #region Master of Search

        #region Eventos

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string tipoVariable = TableMaster.Columns[cbCampo.Text].DataType.Name;

            switch (tipoVariable)
            {
                case "String":
                    {
                        //
                        ViewMaster.RowFilter = cbCampo.Text + " like '%" + txtBuscar.Text + "%'";
                        break;
                    }
                case "Int32":
                    {
                        ////                      
                        bool flag = false;
                        try
                        {                            
                            flag = isInt(txtBuscar.Text);
                            if ((txtBuscar.Text.Trim() != "") && (flag))
                                ViewMaster.RowFilter = cbCampo.Text + "=" + Int32.Parse(txtBuscar.Text);
                        }
                        catch
                        {
                            if (txtBuscar.Text == "")
                                ViewMaster.RowFilter = "";
                            else
                                ViewMaster.RowFilter = cbCampo.Text + "=" + 564645656;
                        }
                        break;

                    }
                case "Decimal":
                    {
                        bool flag = false;
                        try
                        {
                            //flag = decimal.Parse(txtBuscar.Text) is decimal;
                            flag = isDecimal(txtBuscar.Text);
                            if ((txtBuscar.Text.Trim() != "") && (flag))
                            {
                                ViewMaster.RowFilter = cbCampo.Text + "=" + Decimal.Parse(txtBuscar.Text);
                            }
                        }
                        catch
                        {
                            if (txtBuscar.Text == "")
                                ViewMaster.RowFilter = "";
                            else
                                ViewMaster.RowFilter = cbCampo.Text + "=" + 5646456563;
                        }
                        break;
                    }
            }
        }

        public bool isInt(object value)
        {
            try
            {
                int d = int.Parse(value.ToString());
                return true;
            }
            catch (System.FormatException)
            {
                return false;
            }
        }

        public bool isDecimal(object value)
        {
            try
            {
                decimal d = decimal.Parse(value.ToString());
                return true;
            }
            catch (System.FormatException)
            {
                return false;
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                try
                {
                    dgvMasterSearch.Rows[dgvMasterSearch.CurrentCell.RowIndex - 1].Selected = true;
                    dgvMasterSearch.CurrentCell = dgvMasterSearch.Rows[dgvMasterSearch.CurrentCell.RowIndex - 1].Cells[0];
                }
                catch { }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                try
                {
                    dgvMasterSearch.Rows[dgvMasterSearch.CurrentCell.RowIndex + 1].Selected = true;
                    dgvMasterSearch.CurrentCell = dgvMasterSearch.Rows[dgvMasterSearch.CurrentCell.RowIndex + 1].Cells[0];
                }
                catch { }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                // --- Resultado OK
                this.DialogResult = DialogResult.OK;

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void cbCampo_DropDownClosed(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            thePanelTab1.SelectedIndex = 0;
        }

        private void btBuscar_Click_1(object sender, EventArgs e)
        {
            thePanelTab1.SelectedIndex = 1;
            Load_Finder();
        }

        #endregion

        #region Methods        

        void Extract_Fields()
        {
            foreach (DataColumn col in TableMaster.Columns)
            { 
                cbCampo.Items.Add(col.ColumnName);
            }
        }

        public void LoadDataMasterSearh(DataTable _tableMaster)
        {
            TableMaster = _tableMaster;
            ViewMaster = new DataView(TableMaster);
            dgvMasterSearch.DataSource = ViewMaster;
            Extract_Fields();
        }

        #endregion

        private void dgvMasterSearch_DoubleClick(object sender, EventArgs e)
        {
            Asignar_Codigo_Seleccionado();
            Recuperar_Registro();
        }

        

        #endregion

        private void btOk_Click(object sender, EventArgs e)
        {
            Asignar_Codigo_Seleccionado();
            Recuperar_Registro();
            btEditar.PerformClick();
        }

        
    }
}
