namespace Szukaj_pacjenta
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboArkusze = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_pesel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbox_wyfiltrowaneDane = new System.Windows.Forms.RichTextBox();
            this.lbl_danePacjenta = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonPESEL = new System.Windows.Forms.RadioButton();
            this.radioButtonBaza = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // cboArkusze
            // 
            this.cboArkusze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArkusze.FormattingEnabled = true;
            this.cboArkusze.Location = new System.Drawing.Point(314, 38);
            this.cboArkusze.Name = "cboArkusze";
            this.cboArkusze.Size = new System.Drawing.Size(121, 21);
            this.cboArkusze.TabIndex = 2;
            this.cboArkusze.SelectedIndexChanged += new System.EventHandler(this.cboArkusze_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Otwórz plik excela z bazą";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_pesel
            // 
            this.textBox_pesel.Location = new System.Drawing.Point(12, 106);
            this.textBox_pesel.Name = "textBox_pesel";
            this.textBox_pesel.Size = new System.Drawing.Size(196, 20);
            this.textBox_pesel.TabIndex = 4;
            this.textBox_pesel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pesel_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Szukaj badania wg nr PESEL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Wybierz rok do wyświetlenia";
            // 
            // rtbox_wyfiltrowaneDane
            // 
            this.rtbox_wyfiltrowaneDane.Location = new System.Drawing.Point(13, 189);
            this.rtbox_wyfiltrowaneDane.Name = "rtbox_wyfiltrowaneDane";
            this.rtbox_wyfiltrowaneDane.Size = new System.Drawing.Size(295, 214);
            this.rtbox_wyfiltrowaneDane.TabIndex = 9;
            this.rtbox_wyfiltrowaneDane.Text = "";
            // 
            // lbl_danePacjenta
            // 
            this.lbl_danePacjenta.AutoSize = true;
            this.lbl_danePacjenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_danePacjenta.Location = new System.Drawing.Point(12, 166);
            this.lbl_danePacjenta.Name = "lbl_danePacjenta";
            this.lbl_danePacjenta.Size = new System.Drawing.Size(120, 18);
            this.lbl_danePacjenta.TabIndex = 10;
            this.lbl_danePacjenta.Text = "Dane pacjenta:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.opisToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // opisToolStripMenuItem
            // 
            this.opisToolStripMenuItem.Name = "opisToolStripMenuItem";
            this.opisToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.opisToolStripMenuItem.Text = "Opis";
            this.opisToolStripMenuItem.Click += new System.EventHandler(this.opisToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // radioButtonPESEL
            // 
            this.radioButtonPESEL.AutoSize = true;
            this.radioButtonPESEL.Checked = true;
            this.radioButtonPESEL.Location = new System.Drawing.Point(15, 132);
            this.radioButtonPESEL.Name = "radioButtonPESEL";
            this.radioButtonPESEL.Size = new System.Drawing.Size(123, 17);
            this.radioButtonPESEL.TabIndex = 12;
            this.radioButtonPESEL.TabStop = true;
            this.radioButtonPESEL.Text = "Szukaj wg nr PESEL";
            this.radioButtonPESEL.UseVisualStyleBackColor = true;
            this.radioButtonPESEL.CheckedChanged += new System.EventHandler(this.radioButtonPESEL_CheckedChanged);
            // 
            // radioButtonBaza
            // 
            this.radioButtonBaza.AutoSize = true;
            this.radioButtonBaza.Location = new System.Drawing.Point(144, 132);
            this.radioButtonBaza.Name = "radioButtonBaza";
            this.radioButtonBaza.Size = new System.Drawing.Size(138, 17);
            this.radioButtonBaza.TabIndex = 13;
            this.radioButtonBaza.Text = "Szukaj wg nr bazowego";
            this.radioButtonBaza.UseVisualStyleBackColor = true;
            this.radioButtonBaza.CheckedChanged += new System.EventHandler(this.radioButtonBaza_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 457);
            this.Controls.Add(this.radioButtonBaza);
            this.Controls.Add(this.radioButtonPESEL);
            this.Controls.Add(this.lbl_danePacjenta);
            this.Controls.Add(this.rtbox_wyfiltrowaneDane);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_pesel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboArkusze);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Szukaj pacjenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboArkusze;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_pesel;
        private System.Windows.Forms.Button btn_szykajWgPESEL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbox_wyfiltrowaneDane;
        private System.Windows.Forms.Label lbl_danePacjenta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButtonPESEL;
        private System.Windows.Forms.RadioButton radioButtonBaza;
    }
}

