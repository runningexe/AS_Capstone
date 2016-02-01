using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DailyCensusReport
{
    public class SubmitRecord
    {

        //public SubmitRecord() { }

        //public SubmitRecord (int unitID, string currentCensus, string availBeds, string numOfIsoPatients, string potentialDCs, string notes, string currentCapStat)
        //{
        //    this.UnitID = unitID;
        //    this.CurrentCensus = currentCensus;
        //    this.AvailBeds = availBeds;
        //    this.IsolationPatients = numOfIsoPatients;
        //    this.PotentialDCs = potentialDCs;
        //    this.Notes = notes;D
        //    this.CurrentCapStat = currentCapStat;
        //}

        //#region Properties
        //public int UnitID { get; set; }
        //public string CurrentCensus { get; set; }
        //public string AvailBeds { get; set; }
        //public string IsolationPatients { get; set; }
        //public string PotentialDCs { get; set; }
        //public string Notes { get; set; }
        //public string CurrentCapStat { get; set; }
        //#endregion

        public static bool AddRecord(int unitID, string currentCensus, string availBeds, string numOfIsoPatients, string potentialDCs, string notes, string currentCapStat)

        {

            //this add to database based what is giving.
            SqlConnection connect = DBConnect.GetConnection();

            SqlCommand sqlCmd = new SqlCommand("spInsertICU", connect);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "spInsertICU";
            //sqlCmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitID;
            sqlCmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = currentCensus;
            sqlCmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = availBeds;
            sqlCmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = numOfIsoPatients;
            sqlCmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = potentialDCs;
            sqlCmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = notes;
            sqlCmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = currentCapStat;

            try
            {
                connect.Open();
                //executes then check to see if correct.
                int count = sqlCmd.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connect.Close();
            }
        }

        private static int GetUserID(DateTime date)
        {
            SqlConnection conn = DBConnect.GetConnection();
            SqlCommand sqlCommand = new SqlCommand("spCensus", conn);

            DataTable dt = new DataTable();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

            try
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                da.Fill(dt);
            }
            catch (Exception exc)
            {
                exc.ToString();
            }
            finally
            {
                conn.Close();
            }

            return unitId;
        }
    }
}
