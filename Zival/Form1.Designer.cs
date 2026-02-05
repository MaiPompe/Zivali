namespace Zival
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ustvariZival = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.podatkiZivali = new System.Windows.Forms.DataGridView();
            this.imeZivali = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vrstaZivali = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.izpisZivali = new System.Windows.Forms.Button();
            this.vrstaZivali2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.oglasanjeZivali = new System.Windows.Forms.Button();
            this.glasZivali = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zivali = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioVse = new System.Windows.Forms.RadioButton();
            this.radioČlenonožec = new System.Windows.Forms.RadioButton();
            this.radioSesalec = new System.Windows.Forms.RadioButton();
            this.btnIzvoz = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnPrimerjaj = new System.Windows.Forms.Button();
            this.zival2 = new System.Windows.Forms.ComboBox();
            this.zival1 = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBoxPremakniZival = new System.Windows.Forms.ComboBox();
            this.btnPremakniZival = new System.Windows.Forms.Button();
            this.txtPremakniSe = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podatkiZivali)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.ustvariZival);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.podatkiZivali);
            this.groupBox1.Controls.Add(this.imeZivali);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vrstaZivali);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustvari žival";
            // 
            // ustvariZival
            // 
            this.ustvariZival.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ustvariZival.Enabled = false;
            this.ustvariZival.Location = new System.Drawing.Point(10, 348);
            this.ustvariZival.Name = "ustvariZival";
            this.ustvariZival.Size = new System.Drawing.Size(75, 27);
            this.ustvariZival.TabIndex = 6;
            this.ustvariZival.Text = "&Ustvari žival";
            this.ustvariZival.UseVisualStyleBackColor = false;
            this.ustvariZival.Click += new System.EventHandler(this.ustvariZival_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izberi njene podatke";
            // 
            // podatkiZivali
            // 
            this.podatkiZivali.AllowUserToAddRows = false;
            this.podatkiZivali.AllowUserToDeleteRows = false;
            this.podatkiZivali.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.podatkiZivali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podatkiZivali.Location = new System.Drawing.Point(10, 182);
            this.podatkiZivali.Name = "podatkiZivali";
            this.podatkiZivali.RowHeadersWidth = 51;
            this.podatkiZivali.RowTemplate.Height = 24;
            this.podatkiZivali.Size = new System.Drawing.Size(378, 150);
            this.podatkiZivali.TabIndex = 4;
            // 
            // imeZivali
            // 
            this.imeZivali.Location = new System.Drawing.Point(10, 114);
            this.imeZivali.Name = "imeZivali";
            this.imeZivali.Size = new System.Drawing.Size(174, 22);
            this.imeZivali.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Daj ji ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izberi vrsto živali";
            // 
            // vrstaZivali
            // 
            this.vrstaZivali.FormattingEnabled = true;
            this.vrstaZivali.Items.AddRange(new object[] {
            "Sesalec",
            "Kopenski sesalec",
            "Leteči sesalec",
            "Vodni sesalec",
            "Členonožec",
            "Žuželka",
            "Pajkovec",
            "Rak"});
            this.vrstaZivali.Location = new System.Drawing.Point(9, 48);
            this.vrstaZivali.Name = "vrstaZivali";
            this.vrstaZivali.Size = new System.Drawing.Size(175, 24);
            this.vrstaZivali.TabIndex = 0;
            this.vrstaZivali.SelectedIndexChanged += new System.EventHandler(this.vrstaZivali_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Controls.Add(this.izpisZivali);
            this.groupBox2.Controls.Add(this.vrstaZivali2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(428, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izpis živali";
            // 
            // izpisZivali
            // 
            this.izpisZivali.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.izpisZivali.Enabled = false;
            this.izpisZivali.Location = new System.Drawing.Point(9, 232);
            this.izpisZivali.Name = "izpisZivali";
            this.izpisZivali.Size = new System.Drawing.Size(75, 30);
            this.izpisZivali.TabIndex = 8;
            this.izpisZivali.Text = "&Izpiši";
            this.izpisZivali.UseVisualStyleBackColor = false;
            this.izpisZivali.Click += new System.EventHandler(this.izpisZivali_Click);
            // 
            // vrstaZivali2
            // 
            this.vrstaZivali2.FormattingEnabled = true;
            this.vrstaZivali2.Items.AddRange(new object[] {
            "Sesalec",
            "Kopenski sesalec",
            "Leteči sesalec",
            "Vodni sesalec",
            "Členonožec",
            "Žuželka",
            "Pajkovec",
            "Rak"});
            this.vrstaZivali2.Location = new System.Drawing.Point(6, 48);
            this.vrstaZivali2.Name = "vrstaZivali2";
            this.vrstaZivali2.Size = new System.Drawing.Size(175, 24);
            this.vrstaZivali2.TabIndex = 7;
            this.vrstaZivali2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Izberi vrsto živali za izpis vseh";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 1000;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(348, 148);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Controls.Add(this.oglasanjeZivali);
            this.groupBox3.Controls.Add(this.glasZivali);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.zivali);
            this.groupBox3.Location = new System.Drawing.Point(428, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 132);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Klic živali";
            // 
            // oglasanjeZivali
            // 
            this.oglasanjeZivali.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.oglasanjeZivali.Enabled = false;
            this.oglasanjeZivali.Location = new System.Drawing.Point(249, 45);
            this.oglasanjeZivali.Name = "oglasanjeZivali";
            this.oglasanjeZivali.Size = new System.Drawing.Size(98, 32);
            this.oglasanjeZivali.TabIndex = 3;
            this.oglasanjeZivali.Text = "&Oglasi se";
            this.oglasanjeZivali.UseVisualStyleBackColor = false;
            this.oglasanjeZivali.Click += new System.EventHandler(this.oglasanjeZivali_Click);
            // 
            // glasZivali
            // 
            this.glasZivali.Location = new System.Drawing.Point(6, 89);
            this.glasZivali.Name = "glasZivali";
            this.glasZivali.ReadOnly = true;
            this.glasZivali.Size = new System.Drawing.Size(341, 22);
            this.glasZivali.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Izberi žival, ki želiš, da se oglasi";
            // 
            // zivali
            // 
            this.zivali.FormattingEnabled = true;
            this.zivali.Location = new System.Drawing.Point(6, 50);
            this.zivali.Name = "zivali";
            this.zivali.Size = new System.Drawing.Size(175, 24);
            this.zivali.TabIndex = 0;
            this.zivali.SelectedIndexChanged += new System.EventHandler(this.zivali_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Controls.Add(this.radioVse);
            this.groupBox4.Controls.Add(this.radioČlenonožec);
            this.groupBox4.Controls.Add(this.radioSesalec);
            this.groupBox4.Controls.Add(this.btnIzvoz);
            this.groupBox4.Location = new System.Drawing.Point(794, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 111);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Izvoz živali";
            // 
            // radioVse
            // 
            this.radioVse.AutoSize = true;
            this.radioVse.Checked = true;
            this.radioVse.Location = new System.Drawing.Point(44, 29);
            this.radioVse.Name = "radioVse";
            this.radioVse.Size = new System.Drawing.Size(52, 20);
            this.radioVse.TabIndex = 3;
            this.radioVse.TabStop = true;
            this.radioVse.Text = "Vse";
            this.radioVse.UseVisualStyleBackColor = true;
            // 
            // radioČlenonožec
            // 
            this.radioČlenonožec.AutoSize = true;
            this.radioČlenonožec.Location = new System.Drawing.Point(141, 29);
            this.radioČlenonožec.Name = "radioČlenonožec";
            this.radioČlenonožec.Size = new System.Drawing.Size(99, 20);
            this.radioČlenonožec.TabIndex = 2;
            this.radioČlenonožec.Text = "Členonožec";
            this.radioČlenonožec.UseVisualStyleBackColor = true;
            // 
            // radioSesalec
            // 
            this.radioSesalec.AutoSize = true;
            this.radioSesalec.Location = new System.Drawing.Point(268, 29);
            this.radioSesalec.Name = "radioSesalec";
            this.radioSesalec.Size = new System.Drawing.Size(78, 20);
            this.radioSesalec.TabIndex = 1;
            this.radioSesalec.Text = "Sesalec";
            this.radioSesalec.UseVisualStyleBackColor = true;
            // 
            // btnIzvoz
            // 
            this.btnIzvoz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzvoz.Location = new System.Drawing.Point(85, 64);
            this.btnIzvoz.Name = "btnIzvoz";
            this.btnIzvoz.Size = new System.Drawing.Size(194, 23);
            this.btnIzvoz.TabIndex = 0;
            this.btnIzvoz.Text = "Izvozi";
            this.btnIzvoz.UseVisualStyleBackColor = false;
            this.btnIzvoz.Click += new System.EventHandler(this.btnIzvoz_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox5.Controls.Add(this.btnPrimerjaj);
            this.groupBox5.Controls.Add(this.zival2);
            this.groupBox5.Controls.Add(this.zival1);
            this.groupBox5.Location = new System.Drawing.Point(794, 129);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(378, 132);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Primerjanje teže";
            // 
            // btnPrimerjaj
            // 
            this.btnPrimerjaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrimerjaj.Location = new System.Drawing.Point(228, 65);
            this.btnPrimerjaj.Name = "btnPrimerjaj";
            this.btnPrimerjaj.Size = new System.Drawing.Size(118, 23);
            this.btnPrimerjaj.TabIndex = 5;
            this.btnPrimerjaj.Text = "Primerjaj težo";
            this.btnPrimerjaj.UseVisualStyleBackColor = false;
            this.btnPrimerjaj.Click += new System.EventHandler(this.btnPrimerjaj_Click);
            // 
            // zival2
            // 
            this.zival2.FormattingEnabled = true;
            this.zival2.Location = new System.Drawing.Point(23, 85);
            this.zival2.Name = "zival2";
            this.zival2.Size = new System.Drawing.Size(177, 24);
            this.zival2.TabIndex = 1;
            // 
            // zival1
            // 
            this.zival1.FormattingEnabled = true;
            this.zival1.Location = new System.Drawing.Point(23, 43);
            this.zival1.Name = "zival1";
            this.zival1.Size = new System.Drawing.Size(177, 24);
            this.zival1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox7.Controls.Add(this.txtPremakniSe);
            this.groupBox7.Controls.Add(this.btnPremakniZival);
            this.groupBox7.Controls.Add(this.comboBoxPremakniZival);
            this.groupBox7.Location = new System.Drawing.Point(794, 267);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(378, 131);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Premakni žival";
            // 
            // comboBoxPremakniZival
            // 
            this.comboBoxPremakniZival.FormattingEnabled = true;
            this.comboBoxPremakniZival.Location = new System.Drawing.Point(23, 40);
            this.comboBoxPremakniZival.Name = "comboBoxPremakniZival";
            this.comboBoxPremakniZival.Size = new System.Drawing.Size(175, 24);
            this.comboBoxPremakniZival.TabIndex = 4;
            // 
            // btnPremakniZival
            // 
            this.btnPremakniZival.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPremakniZival.Location = new System.Drawing.Point(228, 40);
            this.btnPremakniZival.Name = "btnPremakniZival";
            this.btnPremakniZival.Size = new System.Drawing.Size(118, 23);
            this.btnPremakniZival.TabIndex = 6;
            this.btnPremakniZival.Text = "Premakni žival";
            this.btnPremakniZival.UseVisualStyleBackColor = false;
            this.btnPremakniZival.Click += new System.EventHandler(this.btnPremakniZival_Click);
            // 
            // txtPremakniSe
            // 
            this.txtPremakniSe.Location = new System.Drawing.Point(23, 84);
            this.txtPremakniSe.Name = "txtPremakniSe";
            this.txtPremakniSe.ReadOnly = true;
            this.txtPremakniSe.Size = new System.Drawing.Size(323, 22);
            this.txtPremakniSe.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 429);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Živali";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podatkiZivali)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox vrstaZivali;
        private System.Windows.Forms.TextBox imeZivali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ustvariZival;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView podatkiZivali;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox vrstaZivali2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox zivali;
        private System.Windows.Forms.Button izpisZivali;
        private System.Windows.Forms.Button oglasanjeZivali;
        private System.Windows.Forms.TextBox glasZivali;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnIzvoz;
        private System.Windows.Forms.RadioButton radioVse;
        private System.Windows.Forms.RadioButton radioČlenonožec;
        private System.Windows.Forms.RadioButton radioSesalec;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnPrimerjaj;
        private System.Windows.Forms.ComboBox zival2;
        private System.Windows.Forms.ComboBox zival1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnPremakniZival;
        private System.Windows.Forms.ComboBox comboBoxPremakniZival;
        private System.Windows.Forms.TextBox txtPremakniSe;
    }
}

