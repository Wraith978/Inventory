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
    public partial class AddEdgeForm : Form
    {
        private class EdgeCompanies
        {
            public string Name { get; set; }
            public string ID { get; set; }
        }

        private class EdgeThickness
        {
            public string Name { get; set; }
            public string ID { get; set; }
        }

        public AddEdgeForm()
        {
            InitializeComponent();

            //populate Lam Companies
            string command = "SELECT * FROM EdgetapeCompanies";
            SqlDataReader reader = SQLDB.doSQLSelect(command, null, null, null, 0);
            List<EdgeCompanies> dataSource = new List<EdgeCompanies>();
            while (reader.Read())
            {
                IDataRecord record = (IDataRecord)reader;
                dataSource.Add(new EdgeCompanies() { Name = record["edgetape_company"].ToString(), ID = record["edgetape_company_id"].ToString() });
            }
            edgeCompanyCombo.DataSource = dataSource;
            edgeCompanyCombo.DisplayMember = "Name";
            edgeCompanyCombo.ValueMember = "ID";

            //populate Lam types.
            command = "SELECT * FROM EdgetapeThickness";
            reader = SQLDB.doSQLSelect(command, null, null, null, 0);
            List<EdgeThickness> dataSource2 = new List<EdgeThickness>();
            while (reader.Read())
            {
                IDataRecord record = (IDataRecord)reader;
                dataSource2.Add(new EdgeThickness() { Name = record["edgetape_thickness"].ToString(), ID = record["edgetape_thickness_id"].ToString() });
            }
            edgeThicknessCombo.DataSource = dataSource2;
            edgeThicknessCombo.DisplayMember = "Name";
            edgeThicknessCombo.ValueMember = "ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
