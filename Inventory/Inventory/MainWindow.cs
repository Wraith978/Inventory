using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Inventory
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            /*
            string command = "INSERT INTO TestTable VALUES (@words, @number, @date)";
            string [] paramNames = {"words", "number", "date"};
            SqlDbType[] paramTypes = {SqlDbType.VarChar, SqlDbType.Int, SqlDbType.DateTime};
            object [] param = { "I am amazing", 26, DateTime.Now};
            SQLDB db = new SQLDB();
            db.doSQL(command, paramNames, paramTypes, param, 3);*/
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabContainerIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedTab.Name == sheetTab.Name)
            {
                string command = "SELECT * FROM Sheet";
                SqlDataReader reader = SQLDB.doSQLSelect(command, null, null, null, 0);

                for(int i = 0;reader.Read();i++)
                {

                    IDataRecord record = (IDataRecord)reader;

                    int quantity = Int32.Parse(record["quantity"].ToString());
                    bool stockArrived = Boolean.Parse(record["stock_arrived"].ToString());
                    DateTime estimatedArrival = DateTime.Parse(record["estimated_arrival"].ToString());
                    int jobNumber = Int32.Parse(record["job_number"].ToString());
                    string size = record["size"].ToString();
                    string thickness = record["thickness"].ToString();
                    string stockType = record["stock_type"].ToString();

                    ListViewItem item = new ListViewItem("item", i);
                    item.SubItems.Add(stockType);
                    item.SubItems.Add(size);
                    item.SubItems.Add(thickness);
                    item.SubItems.Add(quantity.ToString());
                    item.SubItems.Add(jobNumber.ToString());
                    item.SubItems.Add(estimatedArrival.ToString());
                    item.SubItems.Add(stockArrived.ToString());

                }
                reader.Close();

                
            }
            else if (this.tabControl1.SelectedTab.Name == lamTab.Name)
            {
                //string command = "SELECT * FROM Laminate";
                //SqlDataReader reader = SQLDB.doSQLSelect(command, null, null, null, 0);
                //reader.Read();
            }
            else if (this.tabControl1.SelectedTab.Name == edgeTab.Name)
            {
                //string command = "SELECT * FROM Edgetape";
                //SqlDataReader reader = SQLDB.doSQLSelect(command, null, null, null, 0);
                //reader.Read();

            }
            else
            {
                MessageBox.Show("Something messed up, call Chris");//should never be hit
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

    }
}
