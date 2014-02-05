namespace Inventory
{
    partial class AddSheetForm
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
            this.sheetTypeBox = new System.Windows.Forms.TextBox();
            this.sheetThicknessBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stockSizeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sheetQuantityBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sheetJobNumberBox = new System.Windows.Forms.TextBox();
            this.sheetEstimatedArrivalPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Type";
            // 
            // sheetTypeBox
            // 
            this.sheetTypeBox.Location = new System.Drawing.Point(13, 30);
            this.sheetTypeBox.Name = "sheetTypeBox";
            this.sheetTypeBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sheetTypeBox.Size = new System.Drawing.Size(100, 20);
            this.sheetTypeBox.TabIndex = 1;
            // 
            // sheetThicknessBox
            // 
            this.sheetThicknessBox.Location = new System.Drawing.Point(120, 29);
            this.sheetThicknessBox.Name = "sheetThicknessBox";
            this.sheetThicknessBox.Size = new System.Drawing.Size(100, 20);
            this.sheetThicknessBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock Thickness";
            // 
            // stockSizeBox
            // 
            this.stockSizeBox.Location = new System.Drawing.Point(227, 29);
            this.stockSizeBox.Name = "stockSizeBox";
            this.stockSizeBox.Size = new System.Drawing.Size(100, 20);
            this.stockSizeBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock Size";
            // 
            // sheetQuantityBox
            // 
            this.sheetQuantityBox.Location = new System.Drawing.Point(12, 76);
            this.sheetQuantityBox.Name = "sheetQuantityBox";
            this.sheetQuantityBox.Size = new System.Drawing.Size(100, 20);
            this.sheetQuantityBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Job Number";
            // 
            // sheetJobNumberBox
            // 
            this.sheetJobNumberBox.Location = new System.Drawing.Point(120, 76);
            this.sheetJobNumberBox.Name = "sheetJobNumberBox";
            this.sheetJobNumberBox.Size = new System.Drawing.Size(100, 20);
            this.sheetJobNumberBox.TabIndex = 9;
            // 
            // sheetEstimatedArrivalPicker
            // 
            this.sheetEstimatedArrivalPicker.Location = new System.Drawing.Point(230, 76);
            this.sheetEstimatedArrivalPicker.Name = "sheetEstimatedArrivalPicker";
            this.sheetEstimatedArrivalPicker.Size = new System.Drawing.Size(200, 20);
            this.sheetEstimatedArrivalPicker.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estimated Arrival";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 136);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sheetEstimatedArrivalPicker);
            this.Controls.Add(this.sheetJobNumberBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sheetQuantityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stockSizeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sheetThicknessBox);
            this.Controls.Add(this.sheetTypeBox);
            this.Controls.Add(this.label1);
            this.Name = "AddSheetForm";
            this.Text = "Add Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sheetTypeBox;
        private System.Windows.Forms.TextBox sheetThicknessBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stockSizeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sheetQuantityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sheetJobNumberBox;
        private System.Windows.Forms.DateTimePicker sheetEstimatedArrivalPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}