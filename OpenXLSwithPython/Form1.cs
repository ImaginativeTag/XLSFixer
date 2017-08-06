using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel; 


namespace XLSFixer
{
    public partial class OpenXLS : Form
    {
        public OpenXLS()
        {
            InitializeComponent();
        }

        //private void btnOpen_Click(object sender, EventArgs e)
        //{

        //    string lcFile = this.textBox1.Text;
        //    run_cmd();
        //}
        //private void run_cmd()
        //{
        //    string fileName = @"c:\sample_script.py";
        //    Process p = new Process();
        //    p.StartInfo = new ProcessStartInfo(@"C:\Python27\python.exe", fileName)
        //    {
        //        RedirectStandardOutput = false,
        //        UseShellExecute = true,
        //        CreateNoWindow = true
        //    };
        //    p.Start();

        //    string output = p.StandardOutput.ReadToEnd();
        //    p.WaitForExit();

        //    Console.WriteLine(output);

        //    Console.ReadLine();

        //}

        private void textBox1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;  
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            lblTick.Visible = false;
            //   string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files dropped
           string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string filePath in files) 
            {
                string ext = Path.GetExtension(filePath).ToLower();
           
                if (ext == ".xls")
                {
                    textBox1.Text = filePath + "; " + textBox1.Text;
                    runExcel(filePath);
                }
                else {
                    MessageBox.Show(filePath + " is not an .xls file and cannot be imported.", "Warning", MessageBoxButtons.OK);
                }
            }

         //   MessageBox.Show("All files processed", "Complete", MessageBoxButtons.OK);
            textBox1.Text = "Drag and Drop .xls files here";
            lblTick.Text = "\u221A";
            lblTick.Visible = true;
           
            // below only accepts a single file, I want to cycle through all files if possible
            //if (files != null && files.Any())
            //    textBox1.Text = files.First(); //select the first one  
        }

        private void btnOpenCSharp_Click(object sender, EventArgs e)
        {
            if (File.Exists(this.textBox1.Text))
            {
                string lcFile = this.textBox1.Text;
                runExcel(lcFile);
            }
            else
            {
                MessageBox.Show("File does not exist","File Error",MessageBoxButtons.OK);
            }

            
        }

        private void runExcel(string lcFile)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Workbook xlWorkBook2;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(lcFile , 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            
            if (this.chkFreeze.Checked==true) {
            xlWorkSheet.Activate();
            xlWorkSheet.Application.ActiveWindow.SplitRow = 1;
            xlWorkSheet.Application.ActiveWindow.FreezePanes = true;
            }

            if (this.chkFilter.Checked == true)
            {
                Excel.Range firstRow = (Excel.Range)xlWorkSheet.Rows[1];
                firstRow.AutoFilter(1,
                    Type.Missing,
                    Excel.XlAutoFilterOperator.xlAnd,
                    Type.Missing,
                    true);
            }
            if (this.chkResize.Checked == true) {
                xlWorkSheet.Application.Columns.AutoFit();
            }

        
            try
            {
                xlWorkBook.SaveAs(Filename: lcFile + "x", FileFormat: Excel.XlFileFormat.xlWorkbookDefault);
                deleteOld(lcFile);
            }
            catch(Exception e)
                {
                    MessageBox.Show("An error occurred: '{0}'"+e,"File Error",MessageBoxButtons.OK);
                    
                }

            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            if (this.chkOpen.Checked == true && File.Exists(@lcFile + "x"))
            {
               xlApp.Visible = true;
               xlWorkBook2=xlApp.Workbooks.Open(@lcFile + "x");
               releaseObject(xlWorkBook2);
            }
            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }
       
        private void deleteOld(string lcFile)
        {
            if (File.Exists(@lcFile + "x"))
            {
                if (File.Exists(@lcFile))
                {
                    File.Delete(@lcFile);
                }

            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        } 
    }
}
