namespace Notatnik
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźIZapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjdźBezZapisywaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ustawieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trybNocnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyłączTrybNocnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licznikSłówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pokażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukryjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1243, 620);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.ustawieniaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszToolStripMenuItem,
            this.wczytajToolStripMenuItem,
            this.wyjdźToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // wyjdźToolStripMenuItem
            // 
            this.wyjdźToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyjdźIZapiszToolStripMenuItem,
            this.wyjdźBezZapisywaniaToolStripMenuItem});
            this.wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            this.wyjdźToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.wyjdźToolStripMenuItem.Text = "Wyjdź";
            // 
            // wyjdźIZapiszToolStripMenuItem
            // 
            this.wyjdźIZapiszToolStripMenuItem.Name = "wyjdźIZapiszToolStripMenuItem";
            this.wyjdźIZapiszToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.wyjdźIZapiszToolStripMenuItem.Text = "Wyjdź i zapisz";
            this.wyjdźIZapiszToolStripMenuItem.Click += new System.EventHandler(this.wyjdźIZapiszToolStripMenuItem_Click);
            // 
            // wyjdźBezZapisywaniaToolStripMenuItem
            // 
            this.wyjdźBezZapisywaniaToolStripMenuItem.Name = "wyjdźBezZapisywaniaToolStripMenuItem";
            this.wyjdźBezZapisywaniaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.wyjdźBezZapisywaniaToolStripMenuItem.Text = "Wyjdź bez zapisywania";
            this.wyjdźBezZapisywaniaToolStripMenuItem.Click += new System.EventHandler(this.wyjdźBezZapisywaniaToolStripMenuItem_Click);
            // 
            // ustawieniaToolStripMenuItem
            // 
            this.ustawieniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trybNocnyToolStripMenuItem,
            this.wyłączTrybNocnyToolStripMenuItem,
            this.licznikSłówToolStripMenuItem});
            this.ustawieniaToolStripMenuItem.Name = "ustawieniaToolStripMenuItem";
            this.ustawieniaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.ustawieniaToolStripMenuItem.Text = "Ustawienia";
            // 
            // trybNocnyToolStripMenuItem
            // 
            this.trybNocnyToolStripMenuItem.Name = "trybNocnyToolStripMenuItem";
            this.trybNocnyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trybNocnyToolStripMenuItem.Text = "Tryb Nocny";
            this.trybNocnyToolStripMenuItem.Click += new System.EventHandler(this.trybNocnyToolStripMenuItem_Click);
            // 
            // wyłączTrybNocnyToolStripMenuItem
            // 
            this.wyłączTrybNocnyToolStripMenuItem.Name = "wyłączTrybNocnyToolStripMenuItem";
            this.wyłączTrybNocnyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wyłączTrybNocnyToolStripMenuItem.Text = "Wyłącz Tryb Nocny";
            this.wyłączTrybNocnyToolStripMenuItem.Click += new System.EventHandler(this.wyłączTrybNocnyToolStripMenuItem_Click);
            // 
            // licznikSłówToolStripMenuItem
            // 
            this.licznikSłówToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokażToolStripMenuItem,
            this.ukryjToolStripMenuItem});
            this.licznikSłówToolStripMenuItem.Name = "licznikSłówToolStripMenuItem";
            this.licznikSłówToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.licznikSłówToolStripMenuItem.Text = "Licznik Słów";
            // 
            // pokażToolStripMenuItem
            // 
            this.pokażToolStripMenuItem.Name = "pokażToolStripMenuItem";
            this.pokażToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pokażToolStripMenuItem.Text = "Pokaż";
            this.pokażToolStripMenuItem.Click += new System.EventHandler(this.pokażToolStripMenuItem_Click);
            // 
            // ukryjToolStripMenuItem
            // 
            this.ukryjToolStripMenuItem.Name = "ukryjToolStripMenuItem";
            this.ukryjToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ukryjToolStripMenuItem.Text = "Ukryj";
            this.ukryjToolStripMenuItem.Click += new System.EventHandler(this.ukryjToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 649);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ilość słów: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 670);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notatnik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem wczytajToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem ustawieniaToolStripMenuItem;
        private ToolStripMenuItem trybNocnyToolStripMenuItem;
        private ToolStripMenuItem wyłączTrybNocnyToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem wyjdźToolStripMenuItem;
        private ToolStripMenuItem wyjdźIZapiszToolStripMenuItem;
        private ToolStripMenuItem wyjdźBezZapisywaniaToolStripMenuItem;
        private ToolStripMenuItem licznikSłówToolStripMenuItem;
        private ToolStripMenuItem pokażToolStripMenuItem;
        private ToolStripMenuItem ukryjToolStripMenuItem;
        private ToolStripMenuItem pomocToolStripMenuItem;
    }
}