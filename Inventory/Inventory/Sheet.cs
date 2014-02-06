using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inventory
{
    public class Sheet: Item
    {
        private string size;
        private string thickness;
        private string stockType;
        private int sheetID;

        public string Size { get { return size; } set { size = value; } }
        public string Thickness { get { return thickness; } set { thickness = value; } }
        public string StockType { get { return stockType; } set { stockType = value; } }
        public int SheetID { get { return sheetID; } set { sheetID = value; } }

        public Sheet() //empty constructor
        {
            quantity = 0;
            stockArrived = false;
            estimatedArrival = DateTime.MinValue;
            jobNumber = 0;
            size = "";
            thickness = "";
            stockType = "";

        }

        public Sheet(int quantity, DateTime estimatedArrival, int jobNumber, string size, string thickness, string stockType, bool stockArrived)
        {
            this.quantity = quantity;
            this.stockArrived = stockArrived;
            this.estimatedArrival = estimatedArrival;
            this.jobNumber = jobNumber;
            this.size = size;
            this.thickness = thickness;
            this.stockType = stockType;
        }

        public Sheet(int sheetID)
        {
            string command = "SELECT * FROM Sheet WHERE sheet_id=@sheet_id";
            string[] paramName = { "sheet_id" };
            SqlDbType[] paramTypes = { SqlDbType.Int };
            object[] param = { sheetID };

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
                thickness = record["thickness"].ToString();
                stockType = record["stock_type"].ToString();


                reader.Close();
            }
        }

        public int InsertSheet()
        {
            string command = "INSERT INTO Sheet (quantity, estimated_arrival, job_number, size, colour, stock_type, stock_arrived)  VALUES (@quantity, @estimated_arrival, @job_number, @size, @colour, @stock_type, @stock_arrived)";

            string[] paramNames = { "quantity", "estimated_arrival", "job_number", "size", "colour", "stock_type", "stockArrived" };
            SqlDbType[] paramTypes = {SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Bit };
            object[] param = { this.quantity, this.estimatedArrival, this.jobNumber, this.size, this.stockType, this.stockArrived };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 7);

            command = "SELECT sheet_id FROM Sheet WHERE job_number=@job_number AND stock_type=@stock_type";
            string[] paramNames2 = { "job_number", "stock_type" };
            SqlDbType[] paramTypes2 = { SqlDbType.Int, SqlDbType.VarChar };
            object[] param2 = { jobNumber, stockType };

            using (SqlConnection connection = new SqlConnection(SQLDB.GetConnectionString()))
            {
                SqlDataReader reader = SQLDB.doSQLSelect(command, paramNames2, paramTypes2, param2, 2, connection);
                reader.Read(); //have to read to get to first (and only) entry
                IDataRecord record = (IDataRecord)reader;

                this.sheetID = Int32.Parse(record["sheet_id"].ToString());

                reader.Close();
            }

            return sheetID;
        }

        public void UpdateLaminate()
        {
            string command = "UPDATE Sheet SET quantity=@quantity, estimated_arrival=@estimated_arrival, job_number=@job_number, size=@size, colour=@colour, stock_type=@stock_type, stock_arrived=@stock_arrived WHERE sheet_id=@sheet_id";

            string[] paramNames = { "quantity", "estimated_arrival", "job_number", "size", "colour", "stock_type", "sheet_id", "stock_arrived" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Int, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.VarChar, SqlDbType.Int, SqlDbType.Bit };
            object[] param = { this.quantity, this.estimatedArrival, this.jobNumber, this.size, this.stockType, this.sheetID, this.stockArrived };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 8);
        }

        public void DeleteLaminate()
        {
            string command = "DELETE FROM Sheet WHERE sheet_id=@sheet_id";
            string[] paramNames = { "sheet_id" };
            SqlDbType[] paramTypes = { SqlDbType.Int };
            object[] param = { sheetID };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 1);
        }

        public void TransferToInventory()
        {
            string command = "UPDATE Sheet SET job_number=@job_number WHERE sheet_id=@sheet_id";
            string[] paramNames = { "job_number", "sheet_id" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int };
            object[] param = { 0, sheetID };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 2);
        }

        public void TransferToJob(int jobNumberToAdd)
        {
            string command = "UPDATE Sheet SET job_number=@job_number WHERE sheet_id=@sheet_id";
            string[] paramNames = { "job_number", "sheet_id" };
            SqlDbType[] paramTypes = { SqlDbType.Int, SqlDbType.Int };
            object[] param = { jobNumberToAdd, sheetID };

            SQLDB.doSQL(command, paramNames, paramTypes, param, 2);
        }
    }
}
