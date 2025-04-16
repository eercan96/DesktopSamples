namespace MarketKasaApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDemir = new Button();
            btnBakir = new Button();
            btnGumus = new Button();
            btnAluminyum = new Button();
            btnBor = new Button();
            btnAltin = new Button();
            bntNakit = new Button();
            bntKredi = new Button();
            dG1 = new DataGridView();
            lbToplam = new Label();
            gBAdet = new GroupBox();
            btnVazgec = new Button();
            btnKilo = new Button();
            textKilo = new TextBox();
            label1 = new Label();
            btnFormKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dG1).BeginInit();
            gBAdet.SuspendLayout();
            SuspendLayout();
            // 
            // btnDemir
            // 
            btnDemir.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDemir.Location = new Point(41, 29);
            btnDemir.Name = "btnDemir";
            btnDemir.Size = new Size(141, 92);
            btnDemir.TabIndex = 0;
            btnDemir.TabStop = false;
            btnDemir.Text = "Demir";
            btnDemir.UseVisualStyleBackColor = true;
            btnDemir.Click += btnDemir_Click;
            // 
            // btnBakir
            // 
            btnBakir.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBakir.Location = new Point(188, 29);
            btnBakir.Name = "btnBakir";
            btnBakir.Size = new Size(141, 92);
            btnBakir.TabIndex = 1;
            btnBakir.TabStop = false;
            btnBakir.Text = "Bakır";
            btnBakir.UseVisualStyleBackColor = true;
            btnBakir.Click += btnBakir_Click;
            // 
            // btnGumus
            // 
            btnGumus.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGumus.Location = new Point(188, 253);
            btnGumus.Name = "btnGumus";
            btnGumus.Size = new Size(141, 92);
            btnGumus.TabIndex = 2;
            btnGumus.TabStop = false;
            btnGumus.Text = "Gümüş";
            btnGumus.UseVisualStyleBackColor = true;
            btnGumus.Click += btnGumus_Click;
            // 
            // btnAluminyum
            // 
            btnAluminyum.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAluminyum.Location = new Point(41, 253);
            btnAluminyum.Name = "btnAluminyum";
            btnAluminyum.Size = new Size(141, 92);
            btnAluminyum.TabIndex = 3;
            btnAluminyum.TabStop = false;
            btnAluminyum.Text = "Alüminyum";
            btnAluminyum.UseVisualStyleBackColor = true;
            btnAluminyum.Click += btnAluminyum_Click;
            // 
            // btnBor
            // 
            btnBor.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBor.Location = new Point(188, 137);
            btnBor.Name = "btnBor";
            btnBor.Size = new Size(141, 92);
            btnBor.TabIndex = 4;
            btnBor.TabStop = false;
            btnBor.Text = "Bor";
            btnBor.UseVisualStyleBackColor = true;
            btnBor.Click += btnBor_Click;
            // 
            // btnAltin
            // 
            btnAltin.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltin.Location = new Point(41, 137);
            btnAltin.Name = "btnAltin";
            btnAltin.Size = new Size(141, 92);
            btnAltin.TabIndex = 5;
            btnAltin.TabStop = false;
            btnAltin.Text = "Altın";
            btnAltin.UseVisualStyleBackColor = true;
            btnAltin.Click += btnAltin_Click;
            // 
            // bntNakit
            // 
            bntNakit.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bntNakit.Location = new Point(475, 397);
            bntNakit.Name = "bntNakit";
            bntNakit.Size = new Size(141, 92);
            bntNakit.TabIndex = 6;
            bntNakit.TabStop = false;
            bntNakit.Text = "Nakit";
            bntNakit.UseVisualStyleBackColor = true;
            bntNakit.Click += bntNakit_Click;
            // 
            // bntKredi
            // 
            bntKredi.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bntKredi.Location = new Point(313, 397);
            bntKredi.Name = "bntKredi";
            bntKredi.Size = new Size(141, 92);
            bntKredi.TabIndex = 7;
            bntKredi.TabStop = false;
            bntKredi.Text = "Kredi Kartı";
            bntKredi.UseVisualStyleBackColor = true;
            bntKredi.Click += bntKredi_Click;
            // 
            // dG1
            // 
            dG1.AllowUserToAddRows = false;
            dG1.AllowUserToDeleteRows = false;
            dG1.AllowUserToResizeRows = false;
            dG1.BackgroundColor = SystemColors.ButtonFace;
            dG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dG1.Location = new Point(636, 2);
            dG1.Name = "dG1";
            dG1.RowHeadersVisible = false;
            dG1.RowTemplate.Height = 25;
            dG1.Size = new Size(453, 402);
            dG1.TabIndex = 8;
            dG1.TabStop = false;
            // 
            // lbToplam
            // 
            lbToplam.BorderStyle = BorderStyle.FixedSingle;
            lbToplam.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbToplam.Location = new Point(684, 416);
            lbToplam.Name = "lbToplam";
            lbToplam.Size = new Size(349, 63);
            lbToplam.TabIndex = 9;
            lbToplam.Text = "0,00";
            lbToplam.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gBAdet
            // 
            gBAdet.Controls.Add(btnVazgec);
            gBAdet.Controls.Add(btnKilo);
            gBAdet.Controls.Add(textKilo);
            gBAdet.Controls.Add(label1);
            gBAdet.Location = new Point(387, 137);
            gBAdet.Name = "gBAdet";
            gBAdet.Size = new Size(200, 173);
            gBAdet.TabIndex = 10;
            gBAdet.TabStop = false;
            gBAdet.Visible = false;
            // 
            // btnVazgec
            // 
            btnVazgec.Location = new Point(29, 135);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(100, 32);
            btnVazgec.TabIndex = 3;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // btnKilo
            // 
            btnKilo.Location = new Point(29, 97);
            btnKilo.Name = "btnKilo";
            btnKilo.Size = new Size(100, 32);
            btnKilo.TabIndex = 2;
            btnKilo.Text = "Kaydet";
            btnKilo.UseVisualStyleBackColor = true;
            btnKilo.Click += btnKilo_Click;
            // 
            // textKilo
            // 
            textKilo.Location = new Point(29, 58);
            textKilo.Name = "textKilo";
            textKilo.Size = new Size(100, 33);
            textKilo.TabIndex = 1;
            textKilo.Text = "1";
            textKilo.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 29);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 0;
            label1.Text = "Kilo";
            // 
            // btnFormKapat
            // 
            btnFormKapat.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFormKapat.Location = new Point(12, 397);
            btnFormKapat.Name = "btnFormKapat";
            btnFormKapat.Size = new Size(141, 92);
            btnFormKapat.TabIndex = 11;
            btnFormKapat.TabStop = false;
            btnFormKapat.Text = "Formu Kapat";
            btnFormKapat.UseVisualStyleBackColor = true;
            btnFormKapat.Click += btnFormKapat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1101, 501);
            Controls.Add(btnFormKapat);
            Controls.Add(gBAdet);
            Controls.Add(lbToplam);
            Controls.Add(dG1);
            Controls.Add(bntKredi);
            Controls.Add(bntNakit);
            Controls.Add(btnAltin);
            Controls.Add(btnBor);
            Controls.Add(btnAluminyum);
            Controls.Add(btnGumus);
            Controls.Add(btnBakir);
            Controls.Add(btnDemir);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cevher Marketi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dG1).EndInit();
            gBAdet.ResumeLayout(false);
            gBAdet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDemir;
        private Button btnBakir;
        private Button btnGumus;
        private Button btnAluminyum;
        private Button btnBor;
        private Button btnAltin;
        private Button bntNakit;
        private Button bntKredi;
        private DataGridView dG1;
        private Label lbToplam;
        private GroupBox gBAdet;
        private Button btnKilo;
        private TextBox textKilo;
        private Label label1;
        private Button btnVazgec;
        private Button btnFormKapat;
    }
}
