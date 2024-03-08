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
    public partial class viewReport2 : UserControl
    {
        public viewReport2()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT    P.Id AS ProjectId,    P.Title AS ProjectTitle,    AB.AdvisorId AS AdvisorId,    CONCAT(PeAdvisor.FirstName, ' ', PeAdvisor.LastName) AS AdvisorName,    GS.StudentId AS StudentId,    CONCAT(PeStudent.FirstName, ' ', PeStudent.LastName) AS StudentName FROM    Project P LEFT JOIN    ProjectAdvisor AB ON P.Id = AB.ProjectId LEFT JOIN    Person PeAdvisor ON AB.AdvisorId = PeAdvisor.Id LEFT JOIN    GroupProject GP ON P.Id = GP.ProjectId LEFT JOIN    GroupStudent GS ON GP.GroupId = GS.GroupId LEFT JOIN    Person PeStudent ON GS.StudentId = PeStudent.Id ORDER BY    P.Id, AB.AdvisorId, GS.StudentId;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
        }
        private void evaluationReport_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void rep1Btn_Click(object sender, EventArgs e)
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

                // Add the data table
                PdfPTable pdfTable = new PdfPTable(guna2DataGridView1.ColumnCount);
                pdfTable.DefaultCell.Padding = 3;
                pdfTable.WidthPercentage = 100;
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                // Data cell styles
                foreach (DataGridViewColumn column in guna2DataGridView1.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new BaseColor(150, 150, 150); // Set background color
                    cell.Padding = 5f; // Add padding
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Check for null before accessing the Value property
                        object cellValue = cell.Value;
                        string cellText = cellValue != null ? cellValue.ToString() : "";

                        PdfPCell dataCell = new PdfPCell(new Phrase(cellText));
                        dataCell.Padding = 5f;
                        pdfTable.AddCell(dataCell);
                    }
                }

                document.Add(pdfTable);
                document.Close();

                MessageBox.Show("PDF file has been created!");
            }
        }

        private void viewRep1_Click(object sender, EventArgs e)
        {

        }

        private void viewReport1_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
                loadData();
        }
    }
}