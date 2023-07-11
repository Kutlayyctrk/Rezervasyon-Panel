namespace Rezervasyon_Panel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            button2 = new Button();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            maskedTextBox3 = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            button1 = new Button();
            Liste = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox4);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(373, 330);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // button2
            // 
            button2.Location = new Point(282, 80);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(136, 154);
            maskedTextBox4.Mask = "00/00/0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(131, 22);
            maskedTextBox4.TabIndex = 8;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(136, 198);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(131, 22);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 204);
            label4.Name = "label4";
            label4.Size = new Size(40, 16);
            label4.TabIndex = 6;
            label4.Text = "Saat:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 157);
            label3.Name = "label3";
            label3.Size = new Size(43, 16);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "İstanbul", "Bursa", "İzmir", "Elazığ", "Trabzon", "Artvin", "Muğla", "Aydın" });
            comboBox2.Location = new Point(136, 102);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(131, 24);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "İstanbul", "Bursa", "İzmir", "Elazığ", "Trabzon", "Artvin", "Muğla", "Aydın" });
            comboBox1.Location = new Point(136, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 24);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 110);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 59);
            label1.Name = "label1";
            label1.Size = new Size(65, 16);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(523, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(332, 330);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(148, 151);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(131, 22);
            maskedTextBox3.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 154);
            label8.Name = "label8";
            label8.Size = new Size(79, 16);
            label8.TabIndex = 12;
            label8.Text = "Telefon No:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 110);
            label7.Name = "label7";
            label7.Size = new Size(90, 16);
            label7.TabIndex = 11;
            label7.Text = "Tc Kimlik No:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(148, 104);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(131, 22);
            maskedTextBox2.TabIndex = 10;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 22);
            textBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 59);
            label6.Name = "label6";
            label6.Size = new Size(72, 16);
            label6.TabIndex = 8;
            label6.Text = "Ad Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 37);
            label5.Name = "label5";
            label5.Size = new Size(0, 16);
            label5.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(414, 428);
            button1.Name = "button1";
            button1.Size = new Size(82, 32);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Liste
            // 
            Liste.BackColor = SystemColors.ActiveCaption;
            Liste.FormattingEnabled = true;
            Liste.HorizontalScrollbar = true;
            Liste.ItemHeight = 16;
            Liste.Location = new Point(872, 130);
            Liste.Name = "Liste";
            Liste.Size = new Size(516, 340);
            Liste.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1417, 100);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(860, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(556, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Script", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(329, 31);
            label9.Name = "label9";
            label9.Size = new Size(155, 27);
            label9.TabIndex = 0;
            label9.Text = "Jupiter AirLines";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(434, 513);
            label10.Name = "label10";
            label10.Size = new Size(40, 16);
            label10.TabIndex = 10;
            label10.Text = "Saat:";
            label10.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1441, 782);
            Controls.Add(label10);
            Controls.Add(panel1);
            Controls.Add(Liste);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Uçuş Rezervasyon Sistemi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox3;
        private Label label8;
        private Label label7;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Button button1;
        private ListBox Liste;
        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button button2;
        private Label label10;
    }
}