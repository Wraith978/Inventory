using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class Edgetape:Item
    {
        private string thickness;
        private string company;
        private string colour;
        private string edgetapeCode;
        private int edgetapeID;
        private int companyID;
        private int thicknessID;

        public string Thickness { get { return thickness; } set { thickness = value; } }
        public string Company { get { return company; } set { company = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
        public string EdgetapeCode { get { return edgetapeCode; } set { edgetapeCode = value; } }
        public int EdgetapeID { get { return edgetapeID; } set { edgetapeID = value; } }
        public int CompanyID { get { return companyID; } set { companyID = value; } }
        public int ThicknessID { get { return thicknessID; } set { thicknessID = value; } }

        SQLDB db = new SQLDB();

        public Edgetape() //empty constructor
        {
            quantity = 0;
            stockArrived = false;
            estimatedArrival = DateTime.MinValue;
            jobNumber = 0;
            thickness = "";
            company = "";
            colour = "";
            edgetapeCode = "";
            companyID = 1;
            thicknessID = 1;
        }

        public Edgetape(int quantity, DateTime estimatedArrival, int jobNumber, int thicknessID, int companyID, string colour, string edgetapeCode, bool stockArrived)
        {
            this.quantity = quantity;
            this.stockArrived = stockArrived;
            this.estimatedArrival = estimatedArrival;
            this.jobNumber = jobNumber;
            this.thicknessID = thicknessID;
            this.companyID = companyID;
            this.colour = colour;
            this.edgetapeCode = edgetapeCode;
        }

        public Edgetape(int edgetapeID)
        {
            string command = "SELECT * FROM Edgetape INNER JOIN EdgetapeThickness ON Edgetape.thickness=EdgetapeThickness.edgetape_thickness_id INNER JOIN EdgetapeCompanies ON Edgetape.edgetape_company=EdgetapeCompanies.edgetape_company_id WHERE edgetape_id = @edgetape_id";
            string[] paramName = {"edgetape_id"};
            SqlDbType[] paramTypes = {SqlDbType.Int};
            object[] param = { edgetapeID };

            using (SqlConnection connection = new SqlConnection(SQLDB.GetConnectionString()))
            {
                SqlDataReader reader = SQLDB.doSQLSelect(command, paramName, paramTypes, param, 1, connection);
                reader.Read();
                IDataRecord record = (IDataRecord)reader;

                quantity = Int32.Parse(record["quantity"].ToString());
                stockArrived = Boolean.Parse(record["stock_arrived"].ToString());
                estimatedArrival = DateTime.Parse(record["estimated_arrival"].ToString());
                jobNumber = Int32.Parse(record["job_number"].ToString());
                thickness = record["thickness"].ToString();
                company = record["edgetape_company"].ToString();
                companyID = Int32.Parse(record["edgetape_company_id"].ToString());
                colour = record["colour"].ToString();
                edgetapeCode = record["edgetape_code"].ToString();
                thicknessID = Int32.Parse(record["thickness_id"].ToString());

                reader.Close();
            }
        }

        public int InsertEdgetape()
        {
            string command = "INSERT INTO Edgetape (edgetape_company, quantity, estimated_arrival, job_number, colour, edgetape_code, thickness, stock_arrived)  VALUES (@edgetape_company, @quantity, @estimated_arrival, @job_number, @colour, @edgetape_code, @edgetape_type, @stock_arrived)";

            string[] paramNames = { "edgetape_company", "quantity", "estimated_arrival", "job_number", "colour", "edgetape_code", "thickness", "stock_arrived" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.Int, SqlDbType.Bit };
            object[] param = { this.company, this.quantity, this.estimatedArrival, this.jobNumber, this.colour, this.edgetapeCode, this.thicknessID, this.stockArrived };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 8);

            command = "SELECT edgetape_id FROM Edgetape WHERE job_number=@job_number AND edgetape_code=@edgetape_code";
            string[] paramNames2 = { "job_number", "edgetape_code" };
            SqlDbType[] paramTypes2 = { SqlDbType.Int, SqlDbType.VarChar };
            object[] param2 = { jobNumber, edgetapeCode };

            using (SqlConnection connection = new SqlConnection(SQLDB.GetConnectionString()))
            {
                SqlDataReader reader = SQLDB.doSQLSelect(command, paramNames2, paramTypes2, param2, 2, connection);
                reader.Read();
                IDataRecord record = (IDataRecord)reader;

                this.edgetapeID = Int32.Parse(record["edgetape_id"].ToString());

                reader.Close();
            }
            return edgetapeID;
        }

        public void UpdateEdgetape()
        {
            string command = "UPDATE Edgetape SET edgetape_company=@edgetape_company, quantity=@quantity, estimated_arrival=@estimated_arrival, job_number=@job_number, colour=@colour, edgetape_code=@edgetape_code, thickness=@thickness, stock_arrived=@stock_arrived WHERE edgetape_id=@edgetape_id";

            string[] paramNames = { "edgetape_company", "quantity", "estimated_arrival", "job_number", "colour", "edgetape_code", "thickness", "edgetape_id", "stock_arrived" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.Int, SqlDbType.Bit };
            object[] param = { this.company, this.quantity, this.estimatedArrival, this.jobNumber, this.edgetapeCode, this.thickness, this.edgetapeID, this.stockArrived };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 9);
        }

        public void DeleteEdgetape()
        {
            string command = "DELETE FROM Edgetape WHERE edgetape_id=@edgetape_id";
            string[] paramNames = { "edgetape_id" };
            SqlDbType[] paramTypes = { SqlDbType.Int };
            object[] param = { edgetapeID };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 1);
        }

        public void TransferToInventory()
        {
            string command = "UPDATE Edgetape SET job_number=@job_number WHERE edgetape_id=@edgetape_id";
            string[] paramNames = { "job_number", "edgetape_id" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int };
            object[] param = { 0, edgetapeID };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 2);
        }

        public void TransferToJob(int jobNumberToAdd)
        {
            string command = "UPDATE Edgetape SET job_number=@job_number WHERE edgetape_id=@edgetape_id";
            string[] paramNames = { "job_number", "edgetape_id" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int };
            object[] param = { jobNumberToAdd, edgetapeID };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 2);
        }

    }
}
