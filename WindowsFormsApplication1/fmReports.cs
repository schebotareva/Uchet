using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport.Export.Pdf;

using FastReport;

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {

        private DataSet FDataSet;

        public Form8()
        {
            InitializeComponent();

            CreateDataSet();

        }

        private void CreateDataSet()
        {
            // create simple dataset with one table
            FDataSet = new DataSet();

            DataTable table = new DataTable();
            table.TableName = "Employees";
            FDataSet.Tables.Add(table);

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));

            table.Rows.Add(1, "Andrew Fuller");
            table.Rows.Add(2, "Nancy Davolio");
            table.Rows.Add(3, "Margaret Peacock");
        }

        private void btnExportWithDialog_Click(object sender, EventArgs e)
        {
            // create report instance
            Report report = new Report();

            // load the existing report
            report.Load(@"..\..\..\report.frx");

            // register the dataset
            report.RegisterData(FDataSet);

            // run the report
            report.Prepare();

            // create export instance
            PDFExport export = new PDFExport();
            export.Export(report);

            // free resources used by report
            report.Dispose();
        }


    }
}
