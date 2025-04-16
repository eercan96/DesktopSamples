namespace MarketKasaApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gBAdet = new GroupBox();
            btnVazgec = new Button();
            btnKilo = new Button();
            textKilo = new TextBox();
            label1 = new Label();
            gBAdet.SuspendLayout();
            SuspendLayout();
            // 
            // gBAdet
            // 
            gBAdet.Controls.Add(btnVazgec);
            gBAdet.Controls.Add(btnKilo);
            gBAdet.Controls.Add(textKilo);
            gBAdet.Controls.Add(label1);
            gBAdet.Location = new Point(48, 29);
            gBAdet.Name = "gBAdet";
            gBAdet.Size = new Size(200, 173);
            gBAdet.TabIndex = 11;
            gBAdet.TabStop = false;
            // 
            // btnVazgec
            // 
            btnVazgec.Location = new Point(29, 135);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(124, 32);
            btnVazgec.TabIndex = 3;
            btnVazgec.Text = "Vazgeç";
            btnVazgec.UseVisualStyleBackColor = true;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // btnKilo
            // 
            btnKilo.Location = new Point(29, 97);
            btnKilo.Name = "btnKilo";
            btnKilo.Size = new Size(124, 32);
            btnKilo.TabIndex = 2;
            btnKilo.Text = "Kaydet";
            btnKilo.UseVisualStyleBackColor = true;
            btnKilo.Click += btnKilo_Click;
            // 
            // textKilo
            // 
            textKilo.Location = new Point(29, 58);
            textKilo.Name = "textKilo";
            textKilo.Size = new Size(124, 23);
            textKilo.TabIndex = 1;
            textKilo.Text = "1";
            textKilo.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 28);
            label1.Name = "label1";
            label1.Size = new Size(38, 21);
            label1.TabIndex = 0;
            label1.Text = "Kilo";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 232);
            Controls.Add(gBAdet);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kilo Miktarı";
            Load += Form2_Load;
            gBAdet.ResumeLayout(false);
            gBAdet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBAdet;
        private Button btnVazgec;
        private Button btnKilo;
        private TextBox textKilo;
        private Label label1;
    }
}