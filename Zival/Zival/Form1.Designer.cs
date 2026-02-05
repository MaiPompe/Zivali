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
            this.comboBoxZival1 = new System.Windows.Forms.ComboBox();
            this.comboBoxZival2 = new System.Windows.Forms.ComboBox();
            this.buttonTeza = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.podatkiZivali)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(296, 331);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustvari žival";
            // 
            // ustvariZival
            // 
            this.ustvariZival.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ustvariZival.Enabled = false;
            this.ustvariZival.Location = new System.Drawing.Point(8, 283);
            this.ustvariZival.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ustvariZival.Name = "ustvariZival";
            this.ustvariZival.Size = new System.Drawing.Size(56, 22);
            this.ustvariZival.TabIndex = 6;
            this.ustvariZival.Text = "&Ustvari žival";
            this.ustvariZival.UseVisualStyleBackColor = false;
            this.ustvariZival.Click += new System.EventHandler(this.ustvariZival_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izberi njene podatke";
            // 
            // podatkiZivali
            // 
            this.podatkiZivali.AllowUserToAddRows = false;
            this.podatkiZivali.AllowUserToDeleteRows = false;
            this.podatkiZivali.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.podatkiZivali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.podatkiZivali.Location = new System.Drawing.Point(8, 148);
            this.podatkiZivali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.podatkiZivali.Name = "podatkiZivali";
            this.podatkiZivali.RowHeadersWidth = 51;
            this.podatkiZivali.RowTemplate.Height = 24;
            this.podatkiZivali.Size = new System.Drawing.Size(284, 122);
            this.podatkiZivali.TabIndex = 4;
            // 
            // imeZivali
            // 
            this.imeZivali.Location = new System.Drawing.Point(8, 93);
            this.imeZivali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imeZivali.Name = "imeZivali";
            this.imeZivali.Size = new System.Drawing.Size(132, 20);
            this.imeZivali.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Daj ji ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
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
            this.vrstaZivali.Location = new System.Drawing.Point(7, 39);
            this.vrstaZivali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vrstaZivali.Name = "vrstaZivali";
            this.vrstaZivali.Size = new System.Drawing.Size(132, 21);
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
            this.groupBox2.Location = new System.Drawing.Point(321, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(270, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izpis živali";
            // 
            // izpisZivali
            // 
            this.izpisZivali.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.izpisZivali.Enabled = false;
            this.izpisZivali.Location = new System.Drawing.Point(7, 188);
            this.izpisZivali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.izpisZivali.Name = "izpisZivali";
            this.izpisZivali.Size = new System.Drawing.Size(56, 24);
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
            this.vrstaZivali2.Location = new System.Drawing.Point(4, 39);
            this.vrstaZivali2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vrstaZivali2.Name = "vrstaZivali2";
            this.vrstaZivali2.Size = new System.Drawing.Size(132, 21);
            this.vrstaZivali2.TabIndex = 7;
            this.vrstaZivali2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Izberi vrsto živali za izpis vseh";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 1000;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(4, 63);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(262, 121);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Controls.Add(this.oglasanjeZivali);
            this.groupBox3.Controls.Add(this.glasZivali);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.zivali);
            this.groupBox3.Location = new System.Drawing.Point(321, 233);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(270, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Klic živali";
            // 
            // oglasanjeZivali
            // 
            this.oglasanjeZivali.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.oglasanjeZivali.Enabled = false;
            this.oglasanjeZivali.Location = new System.Drawing.Point(187, 37);
            this.oglasanjeZivali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.oglasanjeZivali.Name = "oglasanjeZivali";
            this.oglasanjeZivali.Size = new System.Drawing.Size(74, 26);
            this.oglasanjeZivali.TabIndex = 3;
            this.oglasanjeZivali.Text = "&Oglasi se";
            this.oglasanjeZivali.UseVisualStyleBackColor = false;
            this.oglasanjeZivali.Click += new System.EventHandler(this.oglasanjeZivali_Click);
            // 
            // glasZivali
            // 
            this.glasZivali.Location = new System.Drawing.Point(4, 72);
            this.glasZivali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.glasZivali.Name = "glasZivali";
            this.glasZivali.ReadOnly = true;
            this.glasZivali.Size = new System.Drawing.Size(257, 20);
            this.glasZivali.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Izberi žival, ki želiš, da se oglasi";
            // 
            // zivali
            // 
            this.zivali.FormattingEnabled = true;
            this.zivali.Location = new System.Drawing.Point(4, 41);
            this.zivali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zivali.Name = "zivali";
            this.zivali.Size = new System.Drawing.Size(132, 21);
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
            this.groupBox4.Location = new System.Drawing.Point(596, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(284, 90);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Izvoz živali";
            // 
            // radioVse
            // 
            this.radioVse.AutoSize = true;
            this.radioVse.Checked = true;
            this.radioVse.Location = new System.Drawing.Point(33, 24);
            this.radioVse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioVse.Name = "radioVse";
            this.radioVse.Size = new System.Drawing.Size(43, 17);
            this.radioVse.TabIndex = 3;
            this.radioVse.TabStop = true;
            this.radioVse.Text = "Vse";
            this.radioVse.UseVisualStyleBackColor = true;
            // 
            // radioČlenonožec
            // 
            this.radioČlenonožec.AutoSize = true;
            this.radioČlenonožec.Location = new System.Drawing.Point(106, 24);
            this.radioČlenonožec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioČlenonožec.Name = "radioČlenonožec";
            this.radioČlenonožec.Size = new System.Drawing.Size(81, 17);
            this.radioČlenonožec.TabIndex = 2;
            this.radioČlenonožec.Text = "Členonožec";
            this.radioČlenonožec.UseVisualStyleBackColor = true;
            // 
            // radioSesalec
            // 
            this.radioSesalec.AutoSize = true;
            this.radioSesalec.Location = new System.Drawing.Point(201, 24);
            this.radioSesalec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioSesalec.Name = "radioSesalec";
            this.radioSesalec.Size = new System.Drawing.Size(63, 17);
            this.radioSesalec.TabIndex = 1;
            this.radioSesalec.Text = "Sesalec";
            this.radioSesalec.UseVisualStyleBackColor = true;
            // 
            // btnIzvoz
            // 
            this.btnIzvoz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIzvoz.Location = new System.Drawing.Point(64, 52);
            this.btnIzvoz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzvoz.Name = "btnIzvoz";
            this.btnIzvoz.Size = new System.Drawing.Size(146, 19);
            this.btnIzvoz.TabIndex = 0;
            this.btnIzvoz.Text = "Izvozi";
            this.btnIzvoz.UseVisualStyleBackColor = false;
            this.btnIzvoz.Click += new System.EventHandler(this.btnIzvoz_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox5.Controls.Add(this.buttonTeza);
            this.groupBox5.Controls.Add(this.comboBoxZival2);
            this.groupBox5.Controls.Add(this.comboBoxZival1);
            this.groupBox5.Location = new System.Drawing.Point(596, 113);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(284, 90);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Primerjanje teže";
            // 
            // comboBoxZival1
            // 
            this.comboBoxZival1.FormattingEnabled = true;
            this.comboBoxZival1.Location = new System.Drawing.Point(16, 17);
            this.comboBoxZival1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxZival1.Name = "comboBoxZival1";
            this.comboBoxZival1.Size = new System.Drawing.Size(132, 21);
            this.comboBoxZival1.TabIndex = 8;
            // 
            // comboBoxZival2
            // 
            this.comboBoxZival2.FormattingEnabled = true;
            this.comboBoxZival2.Location = new System.Drawing.Point(16, 45);
            this.comboBoxZival2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxZival2.Name = "comboBoxZival2";
            this.comboBoxZival2.Size = new System.Drawing.Size(132, 21);
            this.comboBoxZival2.TabIndex = 9;
            // 
            // buttonTeza
            // 
            this.buttonTeza.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTeza.Location = new System.Drawing.Point(161, 27);
            this.buttonTeza.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTeza.Name = "buttonTeza";
            this.buttonTeza.Size = new System.Drawing.Size(103, 22);
            this.buttonTeza.TabIndex = 7;
            this.buttonTeza.Text = "&Primerjaj težo";
            this.buttonTeza.UseVisualStyleBackColor = false;
            this.buttonTeza.Click += new System.EventHandler(this.buttonTeza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 349);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button buttonTeza;
        private System.Windows.Forms.ComboBox comboBoxZival2;
        private System.Windows.Forms.ComboBox comboBoxZival1;
    }
}

