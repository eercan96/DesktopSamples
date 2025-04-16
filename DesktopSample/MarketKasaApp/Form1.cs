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

        }

        private void bntNakit_Click(object sender, EventArgs e)
        {

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

    }
}
