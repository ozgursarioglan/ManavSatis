namespace WindowsForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.domatesKilo = new System.Windows.Forms.NumericUpDown();
            this.domatesBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.armutBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.armutKilo = new System.Windows.Forms.NumericUpDown();
            this.salatalıkBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.salatalikKilo = new System.Windows.Forms.NumericUpDown();
            this.biberBirimFiyat = new System.Windows.Forms.NumericUpDown();
            this.biberKilo = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tutarNm = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.tutarBox = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.domatesKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domatesBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armutBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armutKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salatalıkBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salatalikKilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biberBirimFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biberKilo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutarNm)).BeginInit();
            this.SuspendLayout();
            // 
            // domatesKilo
            // 
            this.domatesKilo.Location = new System.Drawing.Point(7, 41);
            this.domatesKilo.Name = "domatesKilo";
            this.domatesKilo.Size = new System.Drawing.Size(68, 20);
            this.domatesKilo.TabIndex = 1;
            // 
            // domatesBirimFiyat
            // 
            this.domatesBirimFiyat.Location = new System.Drawing.Point(82, 42);
            this.domatesBirimFiyat.Name = "domatesBirimFiyat";
            this.domatesBirimFiyat.ReadOnly = true;
            this.domatesBirimFiyat.Size = new System.Drawing.Size(68, 20);
            this.domatesBirimFiyat.TabIndex = 2;
            this.domatesBirimFiyat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kilo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kilo Fiyatı";
            // 
            // armutBirimFiyat
            // 
            this.armutBirimFiyat.Location = new System.Drawing.Point(82, 68);
            this.armutBirimFiyat.Name = "armutBirimFiyat";
            this.armutBirimFiyat.ReadOnly = true;
            this.armutBirimFiyat.Size = new System.Drawing.Size(68, 20);
            this.armutBirimFiyat.TabIndex = 6;
            this.armutBirimFiyat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // armutKilo
            // 
            this.armutKilo.Location = new System.Drawing.Point(7, 67);
            this.armutKilo.Name = "armutKilo";
            this.armutKilo.Size = new System.Drawing.Size(68, 20);
            this.armutKilo.TabIndex = 5;
            // 
            // salatalıkBirimFiyat
            // 
            this.salatalıkBirimFiyat.Location = new System.Drawing.Point(82, 94);
            this.salatalıkBirimFiyat.Name = "salatalıkBirimFiyat";
            this.salatalıkBirimFiyat.ReadOnly = true;
            this.salatalıkBirimFiyat.Size = new System.Drawing.Size(68, 20);
            this.salatalıkBirimFiyat.TabIndex = 8;
            this.salatalıkBirimFiyat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // salatalikKilo
            // 
            this.salatalikKilo.Location = new System.Drawing.Point(7, 93);
            this.salatalikKilo.Name = "salatalikKilo";
            this.salatalikKilo.Size = new System.Drawing.Size(68, 20);
            this.salatalikKilo.TabIndex = 7;
            // 
            // biberBirimFiyat
            // 
            this.biberBirimFiyat.Location = new System.Drawing.Point(82, 120);
            this.biberBirimFiyat.Name = "biberBirimFiyat";
            this.biberBirimFiyat.ReadOnly = true;
            this.biberBirimFiyat.Size = new System.Drawing.Size(68, 20);
            this.biberBirimFiyat.TabIndex = 10;
            this.biberBirimFiyat.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // biberKilo
            // 
            this.biberKilo.Location = new System.Drawing.Point(7, 119);
            this.biberKilo.Name = "biberKilo";
            this.biberKilo.Size = new System.Drawing.Size(68, 20);
            this.biberKilo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.domatesKilo);
            this.groupBox1.Controls.Add(this.domatesBirimFiyat);
            this.groupBox1.Controls.Add(this.biberBirimFiyat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.biberKilo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.salatalıkBirimFiyat);
            this.groupBox1.Controls.Add(this.armutKilo);
            this.groupBox1.Controls.Add(this.salatalikKilo);
            this.groupBox1.Controls.Add(this.armutBirimFiyat);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 149);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fiyatlar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tutarNm);
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.tutarBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 79);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tutar";
            // 
            // tutarNm
            // 
            this.tutarNm.Location = new System.Drawing.Point(80, 47);
            this.tutarNm.Name = "tutarNm";
            this.tutarNm.ReadOnly = true;
            this.tutarNm.Size = new System.Drawing.Size(68, 20);
            this.tutarNm.TabIndex = 15;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(6, 19);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(142, 21);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // tutarBox
            // 
            this.tutarBox.Location = new System.Drawing.Point(6, 46);
            this.tutarBox.Name = "tutarBox";
            this.tutarBox.ReadOnly = true;
            this.tutarBox.Size = new System.Drawing.Size(68, 20);
            this.tutarBox.TabIndex = 14;
            this.tutarBox.Text = "Tutar";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 253);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 313);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Windows Form Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.domatesKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domatesBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armutBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armutKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salatalıkBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salatalikKilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biberBirimFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biberKilo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tutarNm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown domatesKilo;
        private System.Windows.Forms.NumericUpDown domatesBirimFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown armutBirimFiyat;
        private System.Windows.Forms.NumericUpDown armutKilo;
        private System.Windows.Forms.NumericUpDown salatalıkBirimFiyat;
        private System.Windows.Forms.NumericUpDown salatalikKilo;
        private System.Windows.Forms.NumericUpDown biberBirimFiyat;
        private System.Windows.Forms.NumericUpDown biberKilo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox tutarBox;
        private System.Windows.Forms.NumericUpDown tutarNm;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

