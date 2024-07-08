using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCTuyenDung
{
    public class DoanhNghiepBUS
    {
        private DoanhNghiepDAO dnDAO = new DoanhNghiepDAO();

        public List<DoanhNghiepDTO> xemDSDN_BUS()
        {
            return dnDAO.xemDSDN_DAO();
        }

        public List<DoanhNghiepDTO> xemDSDNHetHan_BUS()
        {
            return dnDAO.xemDSDNHetHan_DAO();
        }

        public static void xuatFileDSDNHetHan_BUS(DataGridView tbDS, string fileName)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (FileStream fstream = new FileStream(fileName, FileMode.Create))
            {
                Document doc = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                PdfWriter writer = PdfWriter.GetInstance(doc, fstream);

                doc.Open();

                PdfPTable pTable = new PdfPTable(tbDS.Columns.Count);
                pTable.DefaultCell.Padding = 2;
                pTable.WidthPercentage = 100;
                pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                List<string> header = new List<string>(new string[] { "MA DN", "TEN DOANH NGHIEP", "NGUOI DAI DIEN", "EMAIL", "NGAY HET HAN" });

                foreach (string text in header)
                {
                    PdfPCell pCell = new PdfPCell(new Phrase(text));
                    pTable.AddCell(pCell);
                }

                foreach (DataGridViewRow row in tbDS.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        pTable.AddCell(cell.Value.ToString());
                    }
                }

                doc.Add(pTable);
                doc.Close();
                fstream.Close();
            }
        }
    }
}
