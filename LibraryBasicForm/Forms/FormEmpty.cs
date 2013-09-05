using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryBasicForm
{
    public partial class FormBaseEmpty : Form
    {
        #region Events

        public FormBaseEmpty()
        {
            InitializeComponent();
        }

        private void FormBaseEmpty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
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
    }
}
