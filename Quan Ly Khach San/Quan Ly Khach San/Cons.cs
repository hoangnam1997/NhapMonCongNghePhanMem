using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;

namespace Quan_Ly_Khach_San
{
    public class Cons
    {
        public static int sizeLeave = 15;
        public static Color mauPhongTrong = Color.FromArgb(245, 240, 240);
        public static Color mauPhongCoNguoi = Color.FromArgb(14, 14, 232);
        /// <summary>
        /// chuyển sang hệ mã asskII mật khẩu
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static string hasPass(string Password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(Password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            hasPass.Reverse();
            return hasPass;
        }
        /// <summary>
        /// Xóa khoản trắng thừa
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string xoakhoangtrang(string a)
        {
            string s = a.Trim();
            while (s.IndexOf("  ") >= 0)
                s = s.Replace("  ", " ");
            return s;
        }
        /// <summary>
        /// Random ký tự Mã
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string Random(int length)
        {
            string result = "";
            char c;
            Random ran = new Random();
            for (int i = 0; i < length; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(ran.Next(65, 87)));
                result += c;
            }
            return result;
        }
        static public bool exportDataToExcel(string tieude, DataTable dt)
        {
            bool result = false;
            //khoi tao cac doi tuong Com Excel de lam viec
            Excel.Application xlApp;
            Excel.Worksheet xlSheet;
            Excel.Workbook xlBook;
            //doi tuong Trống để thêm  vào xlApp sau đó lưu lại sau
            object missValue = System.Reflection.Missing.Value;
            //khoi tao doi tuong Com Excel moi
            xlApp = new Excel.Application();
            xlBook = xlApp.Workbooks.Add(missValue);
            //su dung Sheet dau tien de thao tac
            xlSheet = (Excel.Worksheet)xlBook.Worksheets.get_Item(1);
            //không cho hiện ứng dụng Excel lên để tránh gây đơ máy
            xlApp.Visible = false;
            int socot = dt.Columns.Count;
            int sohang = dt.Rows.Count;
            int i, j;

            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xls)|*.xls";
            if (f.ShowDialog() == DialogResult.OK)
            {


                //set thuoc tinh cho tieu de
                xlSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1").Merge(false);
                Excel.Range caption = xlSheet.get_Range("A1", Convert.ToChar(socot + 65) + "1");
                caption.Select();
                caption.FormulaR1C1 = tieude;
                //căn lề cho tiêu đề
                caption.HorizontalAlignment = Excel.Constants.xlCenter;
                caption.Font.Bold = true;
                caption.VerticalAlignment = Excel.Constants.xlCenter;
                caption.Font.Size = 18;
                //màu nền cho tiêu đề
                caption.Interior.ColorIndex = 20;
                caption.RowHeight = 30;
                //thuoc tinh cho cac header
                Excel.Range header = xlSheet.get_Range("A2", Convert.ToChar(socot + 65) + "2");
                header.Select();

                header.HorizontalAlignment = Excel.Constants.xlCenter;
                header.Font.Bold = true;
                header.Font.Size = 10;
                //điền tiêu đề cho các cột trong file excel
                for (i = 0; i < socot; i++)
                    xlSheet.Cells[2, i + 2] = dt.Columns[i].ColumnName;
                //dien cot stt
                xlSheet.Cells[2, 1] = "STT";
                for (i = 0; i < sohang; i++)
                    xlSheet.Cells[i + 3, 1] = i + 1;
                //dien du lieu vao sheet


                for (i = 0; i < sohang; i++)
                    for (j = 0; j < socot; j++)
                    {
                        xlSheet.Cells[i + 3, j + 2] = dt.Rows[i][j];

                    }
                //autofit độ rộng cho các cột
                for (i = 0; i < sohang; i++)
                {
                    ((Microsoft.Office.Interop.Excel.Range)xlSheet.Cells[1, i + 1]).EntireColumn.AutoFit();
                }

                //save file
                xlBook.SaveAs(f.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, missValue, missValue, missValue, missValue, Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue, missValue);
                xlBook.Close(true, missValue, missValue);
                xlApp.Quit();

                // release cac doi tuong COM
                releaseObject(xlSheet);
                releaseObject(xlBook);
                releaseObject(xlApp);
                result = true;
            }
            return result;
        }
        static public void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                throw new Exception("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        static public bool exportReport(int type, ReportDocument repd)
        {
            SaveFileDialog f = new SaveFileDialog();
            bool result = false;
            switch (type)
            {
                case 1:

                    f.Filter = "Word file(*.doc)|*.doc";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        repd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.WordForWindows, f.FileName);
                        result = true;
                    }
                    break;
                case 2:

                    f.Filter = "Pdf file(*.pdf)|*.pdf";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        repd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, f.FileName);
                        result = true;
                    }
                    break;
                case 3:

                    f.Filter = "Excel file(*.xls)|*.xls";
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        repd.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, f.FileName);
                        result = true;
                    }
                    break;
                default:
                    MessageBox.Show("Khong chon dung loai ");
                    break;


            }
            return result;
        }
    }
}
