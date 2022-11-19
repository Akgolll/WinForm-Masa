namespace Kasa_isleri
{
    partial class frm_masa1
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
            this.lst_Tablo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.cmb_urunler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_toplam = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_ode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_Tablo
            // 
            this.lst_Tablo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lst_Tablo.CheckBoxes = true;
            this.lst_Tablo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lst_Tablo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lst_Tablo.FullRowSelect = true;
            this.lst_Tablo.GridLines = true;
            this.lst_Tablo.HideSelection = false;
            this.lst_Tablo.Location = new System.Drawing.Point(418, 43);
            this.lst_Tablo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lst_Tablo.Name = "lst_Tablo";
            this.lst_Tablo.Size = new System.Drawing.Size(310, 420);
            this.lst_Tablo.TabIndex = 0;
            this.lst_Tablo.UseCompatibleStateImageBehavior = false;
            this.lst_Tablo.View = System.Windows.Forms.View.Details;
            this.lst_Tablo.SelectedIndexChanged += new System.EventHandler(this.lst_Tablo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün";
            this.columnHeader1.Width = 160;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyatı";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.Location = new System.Drawing.Point(417, 467);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(153, 79);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "Ürün ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Location = new System.Drawing.Point(574, 467);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(153, 79);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // cmb_urunler
            // 
            this.cmb_urunler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_urunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_urunler.FormattingEnabled = true;
            this.cmb_urunler.Location = new System.Drawing.Point(184, 53);
            this.cmb_urunler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_urunler.Name = "cmb_urunler";
            this.cmb_urunler.Size = new System.Drawing.Size(146, 21);
            this.cmb_urunler.TabIndex = 3;
            this.cmb_urunler.SelectedIndexChanged += new System.EventHandler(this.cmb_urunler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yiyecekler";
            // 
            // lbl_toplam
            // 
            this.lbl_toplam.AutoSize = true;
            this.lbl_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplam.Location = new System.Drawing.Point(304, 431);
            this.lbl_toplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_toplam.Name = "lbl_toplam";
            this.lbl_toplam.Size = new System.Drawing.Size(0, 31);
            this.lbl_toplam.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_ode
            // 
            this.btn_ode.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.btn_ode.Location = new System.Drawing.Point(19, 466);
            this.btn_ode.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ode.Name = "btn_ode";
            this.btn_ode.Size = new System.Drawing.Size(153, 79);
            this.btn_ode.TabIndex = 7;
            this.btn_ode.Text = "Ödendi";
            this.btn_ode.UseVisualStyleBackColor = true;
            this.btn_ode.Click += new System.EventHandler(this.btn_ode_Click);
            // 
            // frm_masa1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(199)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(735, 556);
            this.Controls.Add(this.btn_ode);
            this.Controls.Add(this.lbl_toplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_urunler);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lst_Tablo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_masa1";
            this.Text = "Masa 1";
            this.Load += new System.EventHandler(this.frm_masa1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lst_Tablo;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.ComboBox cmb_urunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Label lbl_toplam;
        public System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ode;
    }
}