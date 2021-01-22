using System;
using System.Data;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using Run = DocumentFormat.OpenXml.Drawing.Run;
using RunProperties = DocumentFormat.OpenXml.Drawing.RunProperties;
using Text = DocumentFormat.OpenXml.Drawing.Text;
using Color = DocumentFormat.OpenXml.Wordprocessing.Color;
using System.IO;
using System.Threading;
using System.Data.SQLite;

namespace SqlQuery
{
    public partial class SqlSorgu : Form
    {
        public SqlSorgu()
        {
            InitializeComponent();
        }


        SQLiteConnection connection = new SQLiteConnection(@"Data Source=|DataDirectory|\productdb.db; Version=3;");
        SQLiteDataAdapter da;
        DataSet ds;






        private void ListeAl2()
        {
            try
            {


                TakingDocuments sonuc = new TakingDocuments();
                sonuc.CreateWordprocessingDocument(@"SqlResults\Rapor.doc", "Sorgu Sonucu");
                string folderPath = @"SqlResults\Rapor.doc";


                string[,] deger = new string[dgwResults.RowCount + 1, dgwResults.ColumnCount];
                for (int i = 0; i < dgwResults.ColumnCount; i++)
                {
                    deger[0, i] = dgwResults.Columns[i].HeaderText.ToString();
                }


                for (int i = 0; i <= dgwResults.RowCount - 1; i++)
                {
                    for (int j = 0; j < dgwResults.Rows[i].Cells.Count; j++)
                    {
                        deger[i + 1, j] = dgwResults.Rows[i].Cells[j].Value.ToString();

                    }

                }

                sonuc.AddTable(folderPath, deger);
                Run HighLightRun = new Run();
                RunProperties runPro = new RunProperties();
                RunFonts runFont = new RunFonts() { Ascii = "Times New Roman", HighAnsi = "Times New Roman" };
                Bold bold = new Bold();
                Color color = new Color() { Val = "FF0000" };
                FontSize fontSize = new FontSize() { Val = "12" };
                FontSizeComplexScript fontSizeComplex = new FontSizeComplexScript() { Val = "12" };
                Text runText = new Text() { Text = deger[0, 0] };

                runPro.Append(runFont);
                runPro.Append(bold);
                runPro.Append(color);
                runPro.Append(fontSize);
                runPro.Append(fontSizeComplex);

                HighLightRun.Append(runPro);
                HighLightRun.Append(runText);

            }
            catch
            {

            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {


                string query = txbQuery.Text;

                da = new SQLiteDataAdapter(query, connection);
                ds = new DataSet();




                da.Fill(ds);

                connection.Close();

                if (ds.Tables[0].Rows.Count != 0)
                {
                    dgwResults.DataSource = ds.Tables[0];

                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnTakeList_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("SqlResults");
            Thread th1 = new Thread(ListeAl2);
            th1.Start();
        }
    }
}
