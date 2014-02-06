using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class Laminate: Item
    {

        private int lamID;
        private string size;
        private string company;
        private string colour;
        private string lamCode;
        private string lamType;
        private int companyID;
        private int lamTypeID;

        public int LamID { get { return lamID; } set { lamID = value; } }
        public string Size { get { return size; } set { size = value; } }
        public string Company { get { return company; } set { company = value; } }
        public string Colour { get { return colour; } set { colour = value; } }
        public string LamCode { get { return lamCode; } set { lamCode = value; } }
        public string LamType { get { return lamType; } set { lamType = value; } }
        public int CompanyID { get { return companyID; } set { companyID = value; } }
        public int LamTypeID { get { return lamTypeID; } set { lamTypeID = value; } }

        SQLDB db = new SQLDB();

        public Laminate() //empty constructor
        {
            lamID = 0;
            quantity = 0;
            stockArrived = false;
            estimatedArrival = DateTime.MinValue;
            jobNumber = 0;
            size = "";
            company = "";
            colour = "";
            lamCode = "";
            lamType = "";
            stockArrived = false;

        }

        public Laminate(int quantity, DateTime estimatedArrival, int jobNumber, string size, string company, string colour, string lamCode, string lamType, bool stockArrived)
        {
            this.quantity = quantity;
            this.stockArrived = false;
            this.estimatedArrival = estimatedArrival;
            this.jobNumber = jobNumber;
            this.size = size;
            this.company = company;
            this.colour = colour;
            this.lamCode = lamCode;
            this.lamType = lamType;
            this.stockArrived = stockArrived;
            //immediate insert?
        }

        public Laminate(int lamID)
        {
            string command = "SELECT * FROM Laminate INNER JOIN LaminateType ON Laminate.lam_type=LaminateType.lam_type_id INNER JOIN LaminateCompanies ON Laminate.lam_company=LaminateCompanies.laminate_company_id WHERE lam_id = @lam_id";
            string[] paramName = {"lam_id"};
            SqlDbType[] paramTypes = {SqlDbType.Int};
            object[] param = {lamID};


            using (SqlConnection connection = new SqlConnection(SQLDB.GetConnectionString()))
            {
                SqlDataReader reader = SQLDB.doSQLSelect(command, paramName, paramTypes, param, 1, connection);
                reader.Read();
                IDataRecord record = (IDataRecord)reader;

                quantity = Int32.Parse(record["quantity"].ToString());
                stockArrived = Boolean.Parse(record["stock_arrived"].ToString());
                estimatedArrival = DateTime.Parse(record["estimated_arrival"].ToString());
                jobNumber = Int32.Parse(record["job_number"].ToString());
                size = record["size"].ToString();
                company = record["lam_company"].ToString();
                colour = record["colour"].ToString();
                lamCode = record["lam_code"].ToString();
                lamType = record["lam_type"].ToString();
                lamTypeID = Int32.Parse(record["lam_type_id"].ToString());
                companyID = Int32.Parse(record["company_id"].ToString());

                reader.Close();
            }
        }

        public int InsertLaminate()
        {
            string command = "INSERT INTO Laminate (lam_company, quantity, estimated_arrival, job_number, size, colour, lam_code, lam_type, stock_arrived)  VALUES (@lam_company, @quantity, @estimated_arrival, @job_number, @size, @colour, @lam_code, @lam_type, @stock_arrived)";

            string[] paramNames = { "lam_company", "quantity", "estimated_arrival", "job_number", "size", "colour", "lam_code", "lam_type", "stockArrived" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.Bit };
            object[] param = { this.companyID, this.quantity, this.estimatedArrival, this.jobNumber, this.size, this.lamCode, this.lamTypeID, this.stockArrived };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 8);

            command = "SELECT lam_id FROM Laminate WHERE job_number=@job_number AND lam_code=@lam_code";
            string[] paramNames2 = { "job_number", "lam_code" };
            SqlDbType[] paramTypes2 = { SqlDbType.Int, SqlDbType.VarChar };
            object[] param2 = { jobNumber, lamCode };

            using (SqlConnection connection = new SqlConnection(SQLDB.GetConnectionString()))
            {
                SqlDataReader reader = SQLDB.doSQLSelect(command, paramNames2, paramTypes2, param2, 2, connection);
                reader.Read(); //have to read to get to first (and only) entry
                IDataRecord record = (IDataRecord)reader;

                this.lamID = Int32.Parse(record["lam_id"].ToString());

                reader.Close();
            }
            return lamID;
        }

        public void UpdateLaminate()
        {
            string command = "UPDATE Laminate SET lam_company=@lam_company, quantity=@quantity, estimated_arrival=@estimated_arrival, job_number=@job_number, size=@size, colour=@colour, lam_code=@lam_code, lam_type=@lam_type, stock_arrived=@stock_arrived WHERE lam_id=@lam_id";

            string[] paramNames = { "lam_company", "quantity", "estimated_arrival", "job_number", "size", "colour", "lam_code", "lam_type", "lam_id", "stock_arrived" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.Int, SqlDbType.Bit };
            object[] param = { this.companyID, this.quantity, this.estimatedArrival, this.jobNumber, this.size, this.lamCode, this.lamTypeID, this.lamID, this.stockArrived };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 9);
        }

        public void DeleteLaminate()
        {
            string command = "DELETE FROM Laminate WHERE lam_id=@lam_id";
            string[] paramNames = { "lam_id" };
            SqlDbType[] paramTypes = { SqlDbType.Int };
            object[] param = { lamID };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 1);
        }

        public void TransferToInventory()
        {
            string command = "UPDATE Laminate SET job_number=@job_number WHERE lam_id=@lam_id";
            string[] paramNames = { "job_number", "lam_id" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int };
            object[] param = { 0, lamID };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 2);
        }

        public void TransferToJob(int jobNumberToAdd)
        {
            string command = "UPDATE Laminate SET job_number=@job_number WHERE lam_id=@lam_id";
            string[] paramNames = { "job_number", "lam_id" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int };
            object[] param = { jobNumberToAdd, lamID };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 2);
        }
    }
}
