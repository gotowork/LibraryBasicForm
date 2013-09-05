using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class ctrlCliente : LibraryBasicForm.TheButtonEdit
    {
        public ctrlCliente()
        {
            InitializeComponent();
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        
        public override void ShowButtonAbout()
        {
            fmDetail ofmDetail = new fmDetail();
            ofmDetail.Show();
        }

        public override void ShowButtonFinder()
        {
            fmFinder ofmFinder = new fmFinder();
            ofmFinder.Show();
        }
    }
}
