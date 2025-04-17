using Excel = Microsoft.Office.Interop.Excel;
namespace MarketKasaApp
{
    public partial class Form1 : Form
    {
        decimal toplam = 0;
        List<Sepet> sepetim = new List<Sepet>();

        Sepet sepet = new Sepet();
        Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SepetToplami();

        }
        void FisOlustur(string message)
        {
            Excel.Application excel = new Excel.Application();

            object Misssing = Type.Missing;
            Excel.Workbook workbook = excel.Workbooks.Add(Misssing);
            Excel.Worksheet worksheet =(Excel.Worksheet)excel.Sheets[1];

            worksheet.Range["A1"].Value = "#";
            worksheet.Range["B1"].Value = "Ürün Adý";
            worksheet.Range["C1"].Value = "Kilo";
            worksheet.Range["D1"].Value = "Kilo Fiyatý";
            worksheet.Range["E1"].Value = "Toplam Tutar";

            worksheet.Range["A1"].ColumnWidth = 3.4;
            worksheet.Range["B1"].ColumnWidth = 14;
            worksheet.Range["C1"].ColumnWidth = 5;
            worksheet.Range["D1"].ColumnWidth = 11;
            worksheet.Range["E1"].ColumnWidth = 14;

            worksheet.Range["A1:E1"].Font.ColorIndex = 9;

            int rowCount = worksheet.Range["A" + worksheet.Rows.Count].End[Excel.XlDirection.xlUp].Row;
            rowCount++;

            for (int i = 0; i < sepetim.Count; i++)
            {
                worksheet.Range["A" +rowCount].Value = (i + 1);
                worksheet.Range["B" +rowCount].Value = sepetim[i].Urunadi;
                worksheet.Range["C" +rowCount].Value = sepetim[i].Kilo;
                worksheet.Range["D" +rowCount].Value = sepetim[i].KiloFiyati;
                worksheet.Range["E" +rowCount].Value = sepetim[i].Toplam;
                rowCount++;

            }

            worksheet.Range["A1:E" + (rowCount - 1)].Borders.LineStyle = 1;

            worksheet.Range["E" + rowCount].Formula = "=Sum(E2:E" + (rowCount - 1) + ")";

            worksheet.Range["E" + rowCount].Borders.LineStyle = 1;
            rowCount++;

            worksheet.Range["A" + rowCount].Value = message;
            worksheet.Range["A" + rowCount+":E"+rowCount].MergeCells = true;

            worksheet.Range["D2:E" + rowCount].NumberFormat = "#,##0.00";

            //worksheet.PrintOutEx(); //yazýcý


            excel.Visible = true;


        }

        void SepetiGoster()
        {
            dG1.DataSource = "";
            dG1.DataSource = sepetim;
            SepetToplami();


        }
        void SepetToplami()
        {
            toplam = 0;
            foreach (Sepet sepet in sepetim)
            {
                toplam += sepet.Toplam;
            }

            lbToplam.Text = String.Format("{0:C}", toplam);
        }

        void BtnlariKapat()
        {
            bool status = false;
            gBAdet.Visible = true;
            btnAltin.Enabled = status;
            btnAluminyum.Enabled = status;
            btnBakir.Enabled = status;
            btnBor.Enabled = status;
            btnDemir.Enabled = status;
            btnGumus.Enabled = status;
            bntKredi.Enabled = status;
            bntNakit.Enabled = status;

        }
        void Vazgec()
        {
            textKilo.Text = "1";
            bool status = true;
            gBAdet.Visible = false;
            btnAltin.Enabled = status;
            btnAluminyum.Enabled = status;
            btnBakir.Enabled = status;
            btnBor.Enabled = status;
            btnDemir.Enabled = status;
            btnGumus.Enabled = status;
            bntKredi.Enabled = status;
            bntNakit.Enabled = status;
        }

        void Form2Cagir(Sepet sepet)
        {
            form2 = new Form2(sepet);
            form2.Show();
            form2._form1 = this;
        }





        private void btnDemir_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Demir", 1, 12);
            //sepetim.Add(sepet);
            //SepetiGoster();
            //BtnlariKapat();
            Form2Cagir(sepet);
        }



        private void btnBakir_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Bakýr", 1, 34);
            //sepetim.Add(sepet);
            //SepetiGoster();
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnAltin_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Altýn", 1, 1200);
            //sepetim.Add(sepet);
            //SepetiGoster();
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnBor_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Bor", 1, 56);
            // sepetim.Add(sepet);
            // SepetiGoster();
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnAluminyum_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Alüminyum", 1, 34);
            //sepetim.Add(sepet);
            //SepetiGoster();
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnGumus_Click(object sender, EventArgs e)
        {
            sepet = new Sepet("Gümüþ", 1, 34);
            //sepetim.Add(sepet);
            //SepetiGoster();
            //BtnlariKapat();
            Form2Cagir(sepet);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Vazgec();
        }

        private void bntKredi_Click(object sender, EventArgs e)
        {

            MesajGoster("Sepetteki ürünler kredi kartý ile ödendi");
        }

        private void bntNakit_Click(object sender, EventArgs e)
        {
            MesajGoster("Sepetteki ürünler nakit olarak ödendi");
        }



        void MesajGoster(string message)
        {
            if (sepetim.Count > 0)
            {
                FisOlustur(message);
                return;

                sepetim = new List<Sepet>();
                SepetiGoster();
                MessageBox.Show(message, "Ödeme Yapýldý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Sepette ürün yok"," Hata", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }


        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKilo_Click(object sender, EventArgs e)
        {
            //SepeteUrunEkle();

        }
        public void SepeteUrunEkle(Sepet sepet)
        {
            // sepet.Kilo = Convert.ToInt16(textKilo.Text);
            // sepet.Toplam = sepet.Kilo * sepet.KiloFiyati;
            sepetim.Add(sepet);
            SepetiGoster();
            // Vazgec();
        }

        private void dG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >=0)
            {
                string urunadi= dG1.Rows[e.RowIndex].Cells["Urunadi"].Value.ToString();

                if (MessageBox.Show($"{urunadi} adlý ürünü silmek ister misin", "Sil!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sepetim.RemoveAt(e.RowIndex);
                    SepetiGoster();
                }
                else 
                {
                    MessageBox.Show("Ürün kaldý");
                }


                
            }
        }
    }
}
