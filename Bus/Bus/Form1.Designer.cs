namespace Bus
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seferlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adanaKayseriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bayanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 36);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 851);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seferlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seferlerToolStripMenuItem
            // 
            this.seferlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adanaKayseriToolStripMenuItem});
            this.seferlerToolStripMenuItem.Name = "seferlerToolStripMenuItem";
            this.seferlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.seferlerToolStripMenuItem.Text = "Seferler";
            // 
            // adanaKayseriToolStripMenuItem
            // 
            this.adanaKayseriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.adanaKayseriToolStripMenuItem.Name = "adanaKayseriToolStripMenuItem";
            this.adanaKayseriToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adanaKayseriToolStripMenuItem.Text = "Adana-Kayseri";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.AccessibleName = "";
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "09.00",
            "10.00",
            "13.00",
            "20.00"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.Sorted = true;
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 26);
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bayToolStripMenuItem,
            this.bayanToolStripMenuItem});
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon";
            // 
            // bayToolStripMenuItem
            // 
            this.bayToolStripMenuItem.Name = "bayToolStripMenuItem";
            this.bayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bayToolStripMenuItem.Text = "Bay";
            this.bayToolStripMenuItem.Click += new System.EventHandler(this.bayToolStripMenuItem_Click);
            // 
            // bayanToolStripMenuItem
            // 
            this.bayanToolStripMenuItem.Name = "bayanToolStripMenuItem";
            this.bayanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bayanToolStripMenuItem.Text = "Bayan";
            this.bayanToolStripMenuItem.Click += new System.EventHandler(this.bayanToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(230, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(774, 490);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Koltuk No";
            this.columnHeader1.Width = 222;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adi";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyadi";
            this.columnHeader3.Width = 157;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Musteri Listesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 711);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seferlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adanaKayseriToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bayanToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
    }
}

