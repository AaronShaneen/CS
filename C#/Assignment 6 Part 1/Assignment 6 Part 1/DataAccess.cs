using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_Part_1
{
    /// <summary>
    /// Accesses the database
    /// </summary>
    public class DataAccess
    {
        /// <summary>
        /// Holds connection string to the database
        /// </summary>
        private string connectionString;

        /// <summary>
        /// Sets the connection string to the database
        /// </summary>
        public DataAccess()
        {
            connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory() + "\\ReservationSystem.mdb";
        }

        /// <summary>
        /// Executes a SQL statment and returns a DataSet. The number of rows returned from the query will be put into
        /// the reference parameter numRows.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement to be executed.</param>
        /// <param name="numRows">Reference parameter that returns the number of selected rows.</param>
        /// <returns>A DataSet that contains the data from the SQL statement.</returns>
		public DataSet ExecuteSQLStatement(string sqlStatement, ref int numRows)
        {
            try
            {
                DataSet dataSet = new DataSet();

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter())
                    {
                        connection.Open();

                        adapter.SelectCommand = new OleDbCommand(sqlStatement, connection);
                        adapter.SelectCommand.CommandTimeout = 0;

                        adapter.Fill(dataSet);
                    }
                }
                numRows = dataSet.Tables[0].Rows.Count;

                return dataSet;
            }
            catch (Exception ex)
            {
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." + MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }
    }
}
