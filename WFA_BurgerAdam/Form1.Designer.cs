namespace WFA_BurgerAdam
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbKing = new System.Windows.Forms.RadioButton();
            this.chkDomates = new System.Windows.Forms.CheckBox();
            this.chkTursu = new System.Windows.Forms.CheckBox();
            this.chkPeynir = new System.Windows.Forms.CheckBox();
            this.chkAciSos = new System.Windows.Forms.CheckBox();
            this.chkHardal = new System.Windows.Forms.CheckBox();
            this.chkBarbeku = new System.Windows.Forms.CheckBox();
            this.gbEkstra = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.gbEkstra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 203);
            this.label1.TabIndex = 0;
            this.label1.Text = "Burger Adam";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Menu:";
            // 
            // cmbMenu
            // 
            this.cmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(81, 227);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(243, 21);
            this.cmbMenu.TabIndex = 2;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbOrta.Location = new System.Drawing.Point(81, 255);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(58, 24);
            this.rbOrta.TabIndex = 3;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBuyuk.Location = new System.Drawing.Point(167, 255);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(71, 24);
            this.rbBuyuk.TabIndex = 3;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Buyuk";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbKing
            // 
            this.rbKing.AutoSize = true;
            this.rbKing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKing.Location = new System.Drawing.Point(263, 255);
            this.rbKing.Name = "rbKing";
            this.rbKing.Size = new System.Drawing.Size(58, 24);
            this.rbKing.TabIndex = 3;
            this.rbKing.TabStop = true;
            this.rbKing.Text = "King";
            this.rbKing.UseVisualStyleBackColor = true;
            // 
            // chkDomates
            // 
            this.chkDomates.AutoSize = true;
            this.chkDomates.Location = new System.Drawing.Point(20, 54);
            this.chkDomates.Name = "chkDomates";
            this.chkDomates.Size = new System.Drawing.Size(68, 17);
            this.chkDomates.TabIndex = 4;
            this.chkDomates.Text = "Domates";
            this.chkDomates.UseVisualStyleBackColor = true;
            // 
            // chkTursu
            // 
            this.chkTursu.AutoSize = true;
            this.chkTursu.Location = new System.Drawing.Point(106, 54);
            this.chkTursu.Name = "chkTursu";
            this.chkTursu.Size = new System.Drawing.Size(53, 17);
            this.chkTursu.TabIndex = 4;
            this.chkTursu.Text = "Turşu";
            this.chkTursu.UseVisualStyleBackColor = true;
            // 
            // chkPeynir
            // 
            this.chkPeynir.AutoSize = true;
            this.chkPeynir.Location = new System.Drawing.Point(190, 54);
            this.chkPeynir.Name = "chkPeynir";
            this.chkPeynir.Size = new System.Drawing.Size(55, 17);
            this.chkPeynir.TabIndex = 4;
            this.chkPeynir.Text = "Peynir";
            this.chkPeynir.UseVisualStyleBackColor = true;
            // 
            // chkAciSos
            // 
            this.chkAciSos.AutoSize = true;
            this.chkAciSos.Location = new System.Drawing.Point(20, 88);
            this.chkAciSos.Name = "chkAciSos";
            this.chkAciSos.Size = new System.Drawing.Size(62, 17);
            this.chkAciSos.TabIndex = 4;
            this.chkAciSos.Text = "Acı Sos";
            this.chkAciSos.UseVisualStyleBackColor = true;
            // 
            // chkHardal
            // 
            this.chkHardal.AutoSize = true;
            this.chkHardal.Location = new System.Drawing.Point(106, 88);
            this.chkHardal.Name = "chkHardal";
            this.chkHardal.Size = new System.Drawing.Size(57, 17);
            this.chkHardal.TabIndex = 4;
            this.chkHardal.Text = "Hardal";
            this.chkHardal.UseVisualStyleBackColor = true;
            // 
            // chkBarbeku
            // 
            this.chkBarbeku.AutoSize = true;
            this.chkBarbeku.Location = new System.Drawing.Point(190, 88);
            this.chkBarbeku.Name = "chkBarbeku";
            this.chkBarbeku.Size = new System.Drawing.Size(66, 17);
            this.chkBarbeku.TabIndex = 4;
            this.chkBarbeku.Text = "Barbekü";
            this.chkBarbeku.UseVisualStyleBackColor = true;
            // 
            // gbEkstra
            // 
            this.gbEkstra.Controls.Add(this.chkDomates);
            this.gbEkstra.Controls.Add(this.chkBarbeku);
            this.gbEkstra.Controls.Add(this.chkAciSos);
            this.gbEkstra.Controls.Add(this.chkPeynir);
            this.gbEkstra.Controls.Add(this.chkTursu);
            this.gbEkstra.Controls.Add(this.chkHardal);
            this.gbEkstra.Location = new System.Drawing.Point(81, 298);
            this.gbEkstra.Name = "gbEkstra";
            this.gbEkstra.Size = new System.Drawing.Size(262, 138);
            this.gbEkstra.TabIndex = 5;
            this.gbEkstra.TabStop = false;
            this.gbEkstra.Text = "Ekstralar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(21, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet:";
            // 
            // nudAdet
            // 
            this.nudAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudAdet.Location = new System.Drawing.Point(81, 451);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(111, 35);
            this.nudAdet.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(331, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(714, 420);
            this.listBox1.TabIndex = 8;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(331, 451);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(212, 50);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // btnSiparis
            // 
            this.btnSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparis.Location = new System.Drawing.Point(833, 444);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(212, 50);
            this.btnSiparis.TabIndex = 9;
            this.btnSiparis.Text = "SİPARİŞ VER";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.BtnSiparis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 646);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbEkstra);
            this.Controls.Add(this.rbKing);
            this.Controls.Add(this.rbBuyuk);
            this.Controls.Add(this.rbOrta);
            this.Controls.Add(this.cmbMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEkstra.ResumeLayout(false);
            this.gbEkstra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbKing;
        private System.Windows.Forms.CheckBox chkDomates;
        private System.Windows.Forms.CheckBox chkTursu;
        private System.Windows.Forms.CheckBox chkPeynir;
        private System.Windows.Forms.CheckBox chkAciSos;
        private System.Windows.Forms.CheckBox chkHardal;
        private System.Windows.Forms.CheckBox chkBarbeku;
        private System.Windows.Forms.GroupBox gbEkstra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSiparis;
    }
}

