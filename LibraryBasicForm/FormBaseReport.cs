using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using FastReport;
using FastReport.Utils;
using FastReport.Export;

namespace LibraryBasicForm
{
    public partial class FormBaseReport : LibraryBasicForm.FormBase
    {
        #region atributes

        public Report FReport;
        private DataSet FDataSet;

        #endregion

        #region properties

        public string DirectoryFrx { get; set; }
        public string ReportName { get; set; }        

        #endregion

        #region constructor

        public FormBaseReport()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        private string GetReportsFolder()
        {
            string thisFolder = Config.ApplicationFolder;

            for (int i = 0; i < 6; i++)
            {

                if (System.IO.Directory.Exists(thisFolder + @"Reports"))
                {
                    return Path.GetFullPath(thisFolder + @"Reports\");
                }
                thisFolder += @"..\";
            }

            throw new Exception("Could not locate the Reports folder.");
        }

        public void ShowPreviewReport()
        {
            FReport = new Report();
            string pathReportName = GetReportsFolder() + ReportName;
            FReport.Load(pathReportName);
            RegisterDataReport();
            FReport.Prepare();
            FReport.ShowPrepared();
        }

        public void DesignReport()
        {
            FReport = new Report();

            // register the dataset
            RegisterDataReport();

            // enable the "Employees" datasource programmatically. 
            // You can also do this in the "Report|Choose Report Data..." menu.
            //FReport.GetDataSource("Employees").Enabled = true;

            // design the report
            FReport.Design();

            // free resources used by report
            FReport.Dispose();
        }

        public void ShowReport()
        {
            FReport = new Report();

            // get path of report
            string pathReportName = GetReportsFolder() + ReportName;

            // load the existing report
            FReport.Load(pathReportName);

            RegisterDataReport();

            // run the report
            FReport.Show();

            // free resources used by report
            FReport.Dispose();
        }

        public virtual void RegisterDataReport()
        {
            // register the dataset
            //FReport.RegisterData(FDataSet);
        }

        #endregion

    }
}
