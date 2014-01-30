namespace Inventory
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laminateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgetapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sheetTab = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.sheetType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sheetThickness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sheetSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sheetQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sheetJobNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sheetEstimatedArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sheetStockArrived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lamTab = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.lamCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lamSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lamType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lamColour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lamCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lamJobNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lamEstimatedArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lamStockArrived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lamQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edgeTab = new System.Windows.Forms.TabPage();
            this.listView3 = new System.Windows.Forms.ListView();
            this.edgeCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edgeThickness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edgeCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edgeColour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edgeQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edgeJobNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edgeEstimatedArrival = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.edgeStockArrived = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.sheetTab.SuspendLayout();
            this.lamTab.SuspendLayout();
            this.edgeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sheetToolStripMenuItem,
            this.laminateToolStripMenuItem,
            this.edgetapeToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // sheetToolStripMenuItem
            // 
            this.sheetToolStripMenuItem.Name = "sheetToolStripMenuItem";
            this.sheetToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.sheetToolStripMenuItem.Text = "Sheet";
            // 
            // laminateToolStripMenuItem
            // 
            this.laminateToolStripMenuItem.Name = "laminateToolStripMenuItem";
            this.laminateToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.laminateToolStripMenuItem.Text = "Laminate";
            // 
            // edgetapeToolStripMenuItem
            // 
            this.edgetapeToolStripMenuItem.Name = "edgetapeToolStripMenuItem";
            this.edgetapeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.edgetapeToolStripMenuItem.Text = "Edgetape";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.sheetTab);
            this.tabControl1.Controls.Add(this.lamTab);
            this.tabControl1.Controls.Add(this.edgeTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 343);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabContainerIndexChanged);
            // 
            // sheetTab
            // 
            this.sheetTab.Controls.Add(this.listView1);
            this.sheetTab.Location = new System.Drawing.Point(4, 22);
            this.sheetTab.Name = "sheetTab";
            this.sheetTab.Padding = new System.Windows.Forms.Padding(3);
            this.sheetTab.Size = new System.Drawing.Size(673, 317);
            this.sheetTab.TabIndex = 0;
            this.sheetTab.Text = "Sheets";
            this.sheetTab.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sheetType,
            this.sheetThickness,
            this.sheetSize,
            this.sheetQuantity,
            this.sheetJobNumber,
            this.sheetEstimatedArrival,
            this.sheetStockArrived});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(-1, -1);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(675, 320);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // sheetType
            // 
            this.sheetType.Text = "Type";
            this.sheetType.Width = 78;
            // 
            // sheetThickness
            // 
            this.sheetThickness.DisplayIndex = 2;
            this.sheetThickness.Text = "Thickness";
            this.sheetThickness.Width = 63;
            // 
            // sheetSize
            // 
            this.sheetSize.DisplayIndex = 1;
            this.sheetSize.Text = "Size";
            this.sheetSize.Width = 44;
            // 
            // sheetQuantity
            // 
            this.sheetQuantity.Text = "Quantity";
            // 
            // sheetJobNumber
            // 
            this.sheetJobNumber.Text = "Job Number";
            this.sheetJobNumber.Width = 69;
            // 
            // sheetEstimatedArrival
            // 
            this.sheetEstimatedArrival.Text = "Estimated Arrival";
            this.sheetEstimatedArrival.Width = 93;
            // 
            // sheetStockArrived
            // 
            this.sheetStockArrived.Text = "Stock Arrived";
            this.sheetStockArrived.Width = 76;
            // 
            // lamTab
            // 
            this.lamTab.Controls.Add(this.listView2);
            this.lamTab.Location = new System.Drawing.Point(4, 22);
            this.lamTab.Name = "lamTab";
            this.lamTab.Padding = new System.Windows.Forms.Padding(3);
            this.lamTab.Size = new System.Drawing.Size(673, 317);
            this.lamTab.TabIndex = 1;
            this.lamTab.Text = "Laminate";
            this.lamTab.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lamCode,
            this.lamSize,
            this.lamType,
            this.lamColour,
            this.lamCompany,
            this.lamJobNumber,
            this.lamEstimatedArrival,
            this.lamStockArrived,
            this.lamQuantity});
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(-1, -1);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(675, 320);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // lamCode
            // 
            this.lamCode.Text = "Code";
            // 
            // lamSize
            // 
            this.lamSize.Text = "Size";
            // 
            // lamType
            // 
            this.lamType.Text = "Type";
            // 
            // lamColour
            // 
            this.lamColour.Text = "Colour";
            // 
            // lamCompany
            // 
            this.lamCompany.Text = "Company";
            // 
            // lamJobNumber
            // 
            this.lamJobNumber.DisplayIndex = 6;
            this.lamJobNumber.Text = "Job Number";
            this.lamJobNumber.Width = 74;
            // 
            // lamEstimatedArrival
            // 
            this.lamEstimatedArrival.DisplayIndex = 7;
            this.lamEstimatedArrival.Text = "Estimated Arrival";
            this.lamEstimatedArrival.Width = 94;
            // 
            // lamStockArrived
            // 
            this.lamStockArrived.DisplayIndex = 8;
            this.lamStockArrived.Text = "Stock Arrived";
            this.lamStockArrived.Width = 79;
            // 
            // lamQuantity
            // 
            this.lamQuantity.DisplayIndex = 5;
            this.lamQuantity.Text = "Quantity";
            // 
            // edgeTab
            // 
            this.edgeTab.Controls.Add(this.listView3);
            this.edgeTab.Location = new System.Drawing.Point(4, 22);
            this.edgeTab.Name = "edgeTab";
            this.edgeTab.Size = new System.Drawing.Size(673, 317);
            this.edgeTab.TabIndex = 2;
            this.edgeTab.Text = "Edgetape";
            this.edgeTab.UseVisualStyleBackColor = true;
            // 
            // listView3
            // 
            this.listView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.edgeCode,
            this.edgeThickness,
            this.edgeCompany,
            this.edgeColour,
            this.edgeQuantity,
            this.edgeJobNumber,
            this.edgeEstimatedArrival,
            this.edgeStockArrived});
            this.listView3.FullRowSelect = true;
            this.listView3.Location = new System.Drawing.Point(-1, -1);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(675, 320);
            this.listView3.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // edgeCode
            // 
            this.edgeCode.Text = "Code";
            this.edgeCode.Width = 58;
            // 
            // edgeThickness
            // 
            this.edgeThickness.Text = "Thickness";
            this.edgeThickness.Width = 65;
            // 
            // edgeCompany
            // 
            this.edgeCompany.Text = "Company";
            // 
            // edgeColour
            // 
            this.edgeColour.Text = "Colour";
            // 
            // edgeQuantity
            // 
            this.edgeQuantity.Text = "Quantity";
            // 
            // edgeJobNumber
            // 
            this.edgeJobNumber.Text = "Job Number";
            this.edgeJobNumber.Width = 75;
            // 
            // edgeEstimatedArrival
            // 
            this.edgeEstimatedArrival.Text = "Estimated Arrival";
            this.edgeEstimatedArrival.Width = 94;
            // 
            // edgeStockArrived
            // 
            this.edgeStockArrived.Text = "Stock Arrived";
            this.edgeStockArrived.Width = 83;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(699, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(699, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(704, 75);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Job Number";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(792, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Other";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(699, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(699, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(699, 347);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 382);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainWindow";
            this.Text = "West Isle Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.sheetTab.ResumeLayout(false);
            this.lamTab.ResumeLayout(false);
            this.edgeTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sheetTab;
        private System.Windows.Forms.TabPage lamTab;
        private System.Windows.Forms.TabPage edgeTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laminateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgetapeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader sheetType;
        private System.Windows.Forms.ColumnHeader sheetJobNumber;
        private System.Windows.Forms.ColumnHeader sheetThickness;
        private System.Windows.Forms.ColumnHeader sheetQuantity;
        private System.Windows.Forms.ColumnHeader sheetEstimatedArrival;
        private System.Windows.Forms.ColumnHeader sheetSize;
        private System.Windows.Forms.ColumnHeader lamCode;
        private System.Windows.Forms.ColumnHeader lamSize;
        private System.Windows.Forms.ColumnHeader lamType;
        private System.Windows.Forms.ColumnHeader lamCompany;
        private System.Windows.Forms.ColumnHeader lamJobNumber;
        private System.Windows.Forms.ColumnHeader sheetStockArrived;
        private System.Windows.Forms.ColumnHeader lamColour;
        private System.Windows.Forms.ColumnHeader lamEstimatedArrival;
        private System.Windows.Forms.ColumnHeader lamStockArrived;
        private System.Windows.Forms.ColumnHeader edgeCode;
        private System.Windows.Forms.ColumnHeader edgeThickness;
        private System.Windows.Forms.ColumnHeader edgeColour;
        private System.Windows.Forms.ColumnHeader lamQuantity;
        private System.Windows.Forms.ColumnHeader edgeJobNumber;
        private System.Windows.Forms.ColumnHeader edgeQuantity;
        private System.Windows.Forms.ColumnHeader edgeEstimatedArrival;
        private System.Windows.Forms.ColumnHeader edgeStockArrived;
        private System.Windows.Forms.ColumnHeader edgeCompany;
    }
}

