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

namespace Inventory
{
    public partial class AddLamForm : Form
    {
        private class LaminateCompanies
        {
            public string Name { get; set; }
            public string ID { get; set; }
        }

        private class LaminateTypes
        {
            public string Name { get; set; }
            public string ID { get; set; }
        }

        public AddLamForm()
        {
            InitializeComponent();

            //populate Lam Companies
            string command = "SELECT * FROM LaminateCompanies";
            SqlDataReader reader = SQLDB.doSQLSelect(command, null, null, null, 0);
            List<LaminateCompanies> dataSource = new List<LaminateCompanies>();
            while (reader.Read())
            {
                IDataRecord record = (IDataRecord)reader;
                dataSource.Add(new LaminateCompanies() { Name = record["laminate_company"].ToString(), ID = record["laminate_company_id"].ToString() });
            }
            lamCompanyCombo.DataSource = dataSource;
            lamCompanyCombo.DisplayMember = "Name";
            lamCompanyCombo.ValueMember = "ID";

            //populate Lam types.
            command = "SELECT * FROM LaminateType";
            reader = SQLDB.doSQLSelect(command, null, null, null, 0);
            List<LaminateTypes> dataSource2 = new List<LaminateTypes>();
            while (reader.Read())
            {
                IDataRecord record = (IDataRecord)reader;
                dataSource2.Add(new LaminateTypes() { Name = record["lam_type"].ToString(), ID = record["lam_type_id"].ToString() });
            }
            lamTypeCombo.DataSource = dataSource2;
            lamTypeCombo.DisplayMember = "Name";
            lamTypeCombo.ValueMember = "ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
