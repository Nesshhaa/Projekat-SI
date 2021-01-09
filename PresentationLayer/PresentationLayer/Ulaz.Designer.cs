namespace PresentationLayer
{
    partial class Ulaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ulaz));
            this.labelUlazbroj = new System.Windows.Forms.Label();
            this.textBoxUlazBroj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxVrstaRobe = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxProizvodjac = new System.Windows.Forms.ComboBox();
            this.comboBoxOvlascenoLice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonUlazPotvrdi = new System.Windows.Forms.Button();
            this.buttonUlazNazad = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUlazbroj
            // 
            this.labelUlazbroj.AutoSize = true;
            this.labelUlazbroj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUlazbroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUlazbroj.Location = new System.Drawing.Point(90, 15);
            this.labelUlazbroj.Name = "labelUlazbroj";
            this.labelUlazbroj.Size = new System.Drawing.Size(67, 15);
            this.labelUlazbroj.TabIndex = 0;
            this.labelUlazbroj.Text = "Ulaz broj: ";
            // 
            // textBoxUlazBroj
            // 
            this.textBoxUlazBroj.Location = new System.Drawing.Point(163, 12);
            this.textBoxUlazBroj.Name = "textBoxUlazBroj";
            this.textBoxUlazBroj.Size = new System.Drawing.Size(100, 20);
            this.textBoxUlazBroj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vrsta robe:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(331, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(406, 156);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 141);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVrstaRobe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 109);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxVrstaRobe
            // 
            this.comboBoxVrstaRobe.FormattingEnabled = true;
            this.comboBoxVrstaRobe.Items.AddRange(new object[] {
            "Miker",
            "Vilamet"});
            this.comboBoxVrstaRobe.Location = new System.Drawing.Point(115, 28);
            this.comboBoxVrstaRobe.Name = "comboBoxVrstaRobe";
            this.comboBoxVrstaRobe.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVrstaRobe.TabIndex = 10;
            this.comboBoxVrstaRobe.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kolicina:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxProizvodjac);
            this.groupBox2.Controls.Add(this.comboBoxOvlascenoLice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxProizvodjac
            // 
            this.comboBoxProizvodjac.FormattingEnabled = true;
            this.comboBoxProizvodjac.Items.AddRange(new object[] {
            "Miker",
            "Vilamet"});
            this.comboBoxProizvodjac.Location = new System.Drawing.Point(115, 15);
            this.comboBoxProizvodjac.Name = "comboBoxProizvodjac";
            this.comboBoxProizvodjac.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProizvodjac.TabIndex = 12;
            // 
            // comboBoxOvlascenoLice
            // 
            this.comboBoxOvlascenoLice.FormattingEnabled = true;
            this.comboBoxOvlascenoLice.Items.AddRange(new object[] {
            "Miker",
            "Vilamet"});
            this.comboBoxOvlascenoLice.Location = new System.Drawing.Point(115, 51);
            this.comboBoxOvlascenoLice.Name = "comboBoxOvlascenoLice";
            this.comboBoxOvlascenoLice.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOvlascenoLice.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ovlasceno lice:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Proizvodjac:";
            // 
            // buttonUlazPotvrdi
            // 
            this.buttonUlazPotvrdi.BackColor = System.Drawing.Color.Transparent;
            this.buttonUlazPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUlazPotvrdi.Image = ((System.Drawing.Image)(resources.GetObject("buttonUlazPotvrdi.Image")));
            this.buttonUlazPotvrdi.Location = new System.Drawing.Point(378, 303);
            this.buttonUlazPotvrdi.Name = "buttonUlazPotvrdi";
            this.buttonUlazPotvrdi.Size = new System.Drawing.Size(55, 43);
            this.buttonUlazPotvrdi.TabIndex = 11;
            this.buttonUlazPotvrdi.UseVisualStyleBackColor = false;
            // 
            // buttonUlazNazad
            // 
            this.buttonUlazNazad.Location = new System.Drawing.Point(25, 313);
            this.buttonUlazNazad.MaximumSize = new System.Drawing.Size(75, 23);
            this.buttonUlazNazad.MinimumSize = new System.Drawing.Size(75, 23);
            this.buttonUlazNazad.Name = "buttonUlazNazad";
            this.buttonUlazNazad.Size = new System.Drawing.Size(75, 23);
            this.buttonUlazNazad.TabIndex = 12;
            this.buttonUlazNazad.Text = "Nazad";
            this.buttonUlazNazad.UseVisualStyleBackColor = true;
            this.buttonUlazNazad.Click += new System.EventHandler(this.buttonUlazNazad_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // Ulaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 349);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonUlazNazad);
            this.Controls.Add(this.buttonUlazPotvrdi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxUlazBroj);
            this.Controls.Add(this.labelUlazbroj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Ulaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ulaz";
            this.Load += new System.EventHandler(this.Ulaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUlazbroj;
        private System.Windows.Forms.TextBox textBoxUlazBroj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxVrstaRobe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxProizvodjac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOvlascenoLice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUlazPotvrdi;
        private System.Windows.Forms.Button buttonUlazNazad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}