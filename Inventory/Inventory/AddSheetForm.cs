using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class AddSheetForm : Form
    {
        private Sheet haveSheet;

        public AddSheetForm(Sheet existing)
        {
            InitializeComponent();

            haveSheet = existing;

            if(existing != null)
            {
                sheetEstimatedArrivalPicker.Value = existing.EstimatedArrival;
                sheetJobNumberBox.Text = existing.JobNumber.ToString();
                sheetQuantityBox.Text = existing.Quantity.ToString();
                sheetSizeBox.Text = existing.Size;
                sheetThicknessBox.Text = existing.Thickness;
                sheetTypeBox.Text = existing.StockType;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.sheetTypeBox.Text == "" || this.sheetThicknessBox.Text == "" || this.sheetQuantityBox.Text == "" || this.sheetJobNumberBox.Text == "" || this.sheetSizeBox.Text == "")
            {
                MessageBox.Show("Please enter a value for all fields.");
            }
            else
            {
                if (haveSheet != null)
                {

                }
                else
                {
                    Sheet newSheet = new Sheet(Int32.Parse(this.sheetQuantityBox.Text), this.sheetEstimatedArrivalPicker.Value, Int32.Parse(this.sheetQuantityBox.Text), this.sheetSizeBox.Text, this.sheetThicknessBox.Text, this.sheetTypeBox.Text, false);
                    newSheet.InsertSheet();
                }
                this.Close();
            }
        }
    }
}
