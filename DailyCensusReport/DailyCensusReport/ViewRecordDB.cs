/*Commented this all out so nothing gets screwy for whatever reason when you go in and start
programming. I'm also testing something out with the ASP.NET C# code. Wanted to see if it would make
any difference between the way we did it in C# and the way we did it in ASP.*/

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;


//namespace DailyCensusReport
//{
//    class ViewRecordDB
//    {
//        #region Constructors
//        public ViewRecordDB()
//        {
//        }

//        public ViewRecordDB(int id)
//        {
//            DataTable dt = new DataTable();
//            dt = GetRecord(id);
//            if (dt.Rows.Count > 0)
//            {
//                this.UnitID = Convert.ToInt32(dt.Rows[0]["UnitID"].ToString());
//            }
//        }
//        #endregion

//        #region Properties
//        public int UnitID { get; set; }
//        #endregion

//        private static DataTable GetRecord(int id)
//        {
//            var connect = DBConnect.GetConnection();
//            SqlCommand sqlCommand = new SqlCommand("spCensus", connect);

//            DataTable dt = new DataTable();
//            sqlCommand.CommandType = CommandType.StoredProcedure;
//            sqlCommand.Parameters.Add("@unitID", SqlDbType.Int).Value = id;

//            try
//            {
//                connect.Open();
//                sqlCommand.ExecuteNonQuery();
//            }
//            catch (Exception exc)
//            {
//                exc.ToString();
//            }
//            finally
//            {
//                connect.Close();
//            }

//            return dt;
//        }
//    }
//}
