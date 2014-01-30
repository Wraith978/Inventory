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
            }
            else if (this.tabControl1.SelectedTab.Name == lamTab.Name)
            {
                string command = "SELECT * FROM Laminate";
            }
            else if (this.tabControl1.SelectedTab.Name == edgeTab.Name)
            {
                string command = "SELECT * FROM Edgetape";

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
