using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using Lab1;
using Guna.UI2.WinForms;

namespace FYPManagement
{
    public partial class viewReport3 : UserControl
    {
        public viewReport3()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(@"SELECT 
    AVG(CAST(ge.ObtainedMarks AS FLOAT)) AS AverageMarks
FROM 
    GroupEvaluation ge
JOIN 
    Evaluation e ON ge.EvaluationId = e.Id;
", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }

        private void viewReport3_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                loadData();
        }

        private void rep3Btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (.pdf)|.pdf";
            saveFileDialog.Title = "Export to PDF";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                document.Open();

                // Add a header table
                PdfPTable headerTable = new PdfPTable(1);
                headerTable.DefaultCell.Border = 0;
                headerTable.WidthPercentage = 100;

                // Header cell styles
                PdfPCell headerCell1 = new PdfPCell(new Phrase("FYP Management"));
                headerCell1.HorizontalAlignment = Element.ALIGN_CENTER;
                headerCell1.PaddingBottom = 10f; // Add padding to the bottom
                headerCell1.BackgroundColor = new BaseColor(200, 200, 200); // Set background color
                headerTable.AddCell(headerCell1);

                PdfPCell headerCell2 = new PdfPCell(new Phrase("Advisors Report"));
                headerCell2.HorizontalAlignment = Element.ALIGN_CENTER;
                headerCell2.PaddingBottom = 10f;
                headerCell2.BackgroundColor = new BaseColor(200, 200, 200);
                headerTable.AddCell(headerCell2);

                PdfPCell headerCell3 = new PdfPCell(new Phrase("Submitted by: Asim Ali 2022-CS-175"));
                headerCell3.HorizontalAlignment = Element.ALIGN_CENTER;
                headerCell3.PaddingBottom = 10f;
                headerCell3.BackgroundColor = new BaseColor(200, 200, 200);
                headerTable.AddCell(headerCell3);

                PdfPCell headerCell4 = new PdfPCell(new Phrase("Submitted To: Mr. Nazeef Ul Haq"));
                headerCell4.HorizontalAlignment = Element.ALIGN_CENTER;
                headerCell4.PaddingBottom = 10f;
                headerCell4.BackgroundColor = new BaseColor(200, 200, 200);
                headerTable.AddCell(headerCell4);

                document.Add(headerTable);

                // Add a spacer line between header and data table
                document.Add(new Paragraph(" "));
                // Add the evaluation data table to the PDF document
                PdfPTable pdfTable = new PdfPTable(guna2DataGridView1.Columns.Count);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                // Add table headers
                foreach (DataColumn column in guna2DataGridView1.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName));
                    headerCell.BackgroundColor = new BaseColor(150, 150, 150);
                    headerCell.Padding = 5f;
                    pdfTable.AddCell(headerCell);
                }

                // Add data rows
                foreach (DataRow row in guna2DataGridView1.Rows)
                {
                    foreach (object cellValue in row.ItemArray)
                    {
                        PdfPCell dataCell = new PdfPCell(new Phrase(cellValue != null ? cellValue.ToString() : ""));
                        dataCell.Padding = 5f;
                        pdfTable.AddCell(dataCell);
                    }
                }

                document.Add(pdfTable);
                document.Close();

                Console.WriteLine("PDF file generated");

            }
        }
    }
}