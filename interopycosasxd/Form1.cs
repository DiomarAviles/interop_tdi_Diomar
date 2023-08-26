using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
namespace interopycosasxd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog dailo = new SaveFileDialog(); 
            if(dailo.ShowDialog()!= DialogResult.OK)
            {
                return;
            }
            string ruta = dailo.FileName;
            var wordApp = new Word.Application();
            wordApp.Visible = true;
            wordApp.Documents.Add();
            string dato = txtdato.Text;
            wordApp.Selection.TypeText(dato);
            wordApp.ActiveDocument.SaveAs2(ruta);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dailo = new SaveFileDialog();
            if (dailo.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string ruta = dailo.FileName;
            var excelApp = new Excel.Application();
            // Add a new Excel workbook.
            excelApp.Workbooks.Add();
            excelApp.Visible = true;
            string dato = txtdato.Text;
            excelApp.Range["A1"].Value = dato;
            excelApp.ActiveWorkbook.SaveAs(ruta);
            excelApp.Columns[1].AutoFit();c
        }
    }
}
