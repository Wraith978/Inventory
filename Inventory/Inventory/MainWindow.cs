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
            //gross hack
            this.tabControl1.SelectedTab = lamTab;
            this.tabControl1.SelectedTab = sheetTab;
        }

        private void tabContainerIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listView3.Items.Clear();
            SqlDataReader reader = null;
            if (this.tabControl1.SelectedTab.Name == sheetTab.Name)
            {
                string command = "SELECT * FROM Sheet";
                using (SqlConnection connection = new SqlConnection(SQLDB.GetConnectionString()))
                {
                    reader = SQLDB.doSQLSelect(command, null, null, null, 0, connection);

                    for (int i = 0; reader.Read(); i++)
                    {

                        IDataRecord record = (IDataRecord)reader;

                        int quantity = Int32.Parse(record["quantity"].ToString());
                        bool stockArrived = Boolean.Parse(record["stock_arrived"].ToString());
                        DateTime estimatedArrival = DateTime.Parse(record["estimated_arrival"].ToString());
                        int jobNumber = Int32.Parse(record["job_number"].ToString());
                        string size = record["size"].ToString();
                        string thickness = record["thickness"].ToString();
                        string stockType = record["stock_type"].ToString();

                        ListViewItem item = new ListViewItem(stockType, i);
                        item.SubItems.Add(size);
                        item.SubItems.Add(thickness);
                        item.SubItems.Add(quantity.ToString());
                        item.SubItems.Add(jobNumber.ToString());
                        item.SubItems.Add(estimatedArrival.Month + "/" + estimatedArrival.Day + "/" + estimatedArrival.Year);
                        item.SubItems.Add(stockArrived.ToString());

                        if (i % 2 == 0)
                        {
                            item.BackColor = System.Drawing.Color.LightGray;
                        }

                        this.listView1.Items.Add(item);

                    }
                    reader.Close();
                }
                
            }
            else if (this.tabControl1.SelectedTab.Name == lamTab.Name)
            {
                //Why can't I select a joined row as TableName.columnName pretty much every other language allows that, weird implementation.
                string command = "SELECT quantity, stock_arrived, estimated_arrival, job_number, size, laminate_company, colour, lam_code, LaminateType.lam_type AS stupid_fix  FROM Laminate INNER JOIN LaminateType ON Laminate.lam_type=LaminateType.lam_type_id INNER JOIN LaminateCompanies ON Laminate.lam_company=LaminateCompanies.laminate_company_id";

                using (SqlConnection connection = new SqlConnection(SQLDB.GetConnectionString()))
                {
                    reader = SQLDB.doSQLSelect(command, null, null, null, 0, connection);

                    for (int i = 0; reader.Read(); i++)
                    {

                        IDataRecord record = (IDataRecord)reader;

                        int quantity = Int32.Parse(record["quantity"].ToString());
                        bool stockArrived = Boolean.Parse(record["stock_arrived"].ToString());
                        DateTime estimatedArrival = DateTime.Parse(record["estimated_arrival"].ToString());
                        int jobNumber = Int32.Parse(record["job_number"].ToString());
                        string size = record["size"].ToString();
                        string company = record["laminate_company"].ToString();
                        string colour = record["colour"].ToString();
                        string lamCode = record["lam_code"].ToString();
                        string lamType = record["stupid_fix"].ToString();

                        ListViewItem item = new ListViewItem(lamCode, i);
                        item.SubItems.Add(size);
                        item.SubItems.Add(lamType);
                        item.SubItems.Add(colour);
                        item.SubItems.Add(company);
                        item.SubItems.Add(quantity.ToString());
                        item.SubItems.Add(jobNumber.ToString());
                        item.SubItems.Add(estimatedArrival.Month + "/" + estimatedArrival.Day + "/" + estimatedArrival.Year);
                        item.SubItems.Add(stockArrived.ToString());

                        if (i % 2 == 0)
                        {
                            item.BackColor = System.Drawing.Color.LightGray;
                        }

                        this.listView2.Items.Add(item);

                    }
                    reader.Close();
                }
            }
            else if (this.tabControl1.SelectedTab.Name == edgeTab.Name)
            {
                string command = "SELECT quantity, stock_arrived, estimated_arrival, job_number, edgetape_thickness, EdgetapeCompanies.edgetape_company, colour, edgetape_code FROM Edgetape INNER JOIN EdgetapeThickness ON Edgetape.thickness=EdgetapeThickness.edgetape_thickness_id INNER JOIN EdgetapeCompanies ON Edgetape.edgetape_company=EdgetapeCompanies.edgetape_company_id";
                using (SqlConnection connection = new SqlConnection(SQLDB.GetConnectionString()))
                {
                    reader = SQLDB.doSQLSelect(command, null, null, null, 0, connection);

                    for (int i = 0; reader.Read(); i++)
                    {

                        IDataRecord record = (IDataRecord)reader;

                        int quantity = Int32.Parse(record["quantity"].ToString());
                        bool stockArrived = Boolean.Parse(record["stock_arrived"].ToString());
                        DateTime estimatedArrival = DateTime.Parse(record["estimated_arrival"].ToString());
                        int jobNumber = Int32.Parse(record["job_number"].ToString());
                        string thickness = record["edgetape_thickness"].ToString();
                        string company = record["edgetape_company"].ToString();
                        string colour = record["colour"].ToString();
                        string edgetapeCode = record["edgetape_code"].ToString();

                        ListViewItem item = new ListViewItem(edgetapeCode, i);
                        item.SubItems.Add(thickness);
                        item.SubItems.Add(colour);
                        item.SubItems.Add(company);
                        item.SubItems.Add(quantity.ToString());
                        item.SubItems.Add(jobNumber.ToString());
                        item.SubItems.Add(estimatedArrival.Month + "/" + estimatedArrival.Day + "/" + estimatedArrival.Year);
                        item.SubItems.Add(stockArrived.ToString());

                        if (i % 2 == 0)
                        {
                            item.BackColor = System.Drawing.Color.LightGray;
                        }

                        this.listView3.Items.Add(item);

                    }
                    reader.Close();
                }

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == sheetTab)
            {
                AddSheetForm sheetForm = new AddSheetForm();
                sheetForm.Show();
            }
            else if (tabControl1.SelectedTab == edgeTab)
            {
                AddEdgeForm edgeForm = new AddEdgeForm();
                edgeForm.Show();
            }
            else if (tabControl1.SelectedTab == lamTab)
            {
                AddLamForm lamForm = new AddLamForm();
                lamForm.Show();
            }
        }

        private void sheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSheetForm sheetForm = new AddSheetForm();
            sheetForm.Show();
        }

        private void laminateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLamForm lamForm = new AddLamForm();
            lamForm.Show();
        }

        private void edgetapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEdgeForm edgeForm = new AddEdgeForm();
            edgeForm.Show();
        }

    }
}
