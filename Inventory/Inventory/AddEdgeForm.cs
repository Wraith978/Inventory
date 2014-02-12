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
        private Edgetape haveEdit;
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

        public AddEdgeForm(Edgetape existing)
        {
            
            InitializeComponent();

            haveEdit = existing;
            //populate Lam Companies
            string command = "SELECT * FROM EdgetapeCompanies";
            using (SqlConnection connection = new SqlConnection(SQLDB.GetConnectionString()))
            {
                SqlDataReader reader = SQLDB.doSQLSelect(command, null, null, null, 0, connection);
                List<EdgeCompanies> dataSource = new List<EdgeCompanies>();
                while (reader.Read())
                {
                    IDataRecord record = (IDataRecord)reader;
                    dataSource.Add(new EdgeCompanies() { Name = record["edgetape_company"].ToString(), ID = record["edgetape_company_id"].ToString() });
                }
                edgeCompanyCombo.DataSource = dataSource;
                edgeCompanyCombo.DisplayMember = "Name";
                edgeCompanyCombo.ValueMember = "ID";
            }
            using (SqlConnection connection = new SqlConnection(SQLDB.GetConnectionString()))
            {
                //populate Lam types.
                command = "SELECT * FROM EdgetapeThickness";
                SqlDataReader reader = SQLDB.doSQLSelect(command, null, null, null, 0, connection);
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

            if (existing != null)
            {
                edgeCodeBox.Text = existing.EdgetapeCode;
                edgeColourBox.Text = existing.Colour;
                edgeCompanyCombo.SelectedValue = existing.CompanyID;
                edgeEstimatedArrivalPicker.Value = existing.EstimatedArrival;
                edgeJobNumberBox.Text = existing.JobNumber.ToString();
                edgeQuantityBox.Text = existing.Quantity.ToString();
                edgeThicknessCombo.SelectedValue = existing.ThicknessID;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
