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
        //public int unitID { get; set; }
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

            SqlCommand cmd = new SqlCommand("spInsertICU", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertICU";
            //cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitID;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = currentCensus;
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = availBeds;
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = numOfIsoPatients;
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = potentialDCs;
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = notes;
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = currentCapStat;

            try
            {
                connect.Open();
                //executes then check to see if correct.
                int count = cmd.ExecuteNonQuery();
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

        //private static int GetUserID(DateTime date)
        //{
        //    SqlConnection connect = DBConnect.GetConnection();
        //    SqlCommand cmd = new SqlCommand("spCensus", connect);

        //    DataTable dt = new DataTable();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

        //    try
        //    {
        //        connect.Open();

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(dt);
        //    }
        //    catch (Exception exc)
        //    {
        //        exc.ToString();
        //    }
        //    finally
        //    {
        //        connect.Close();
        //    }

        //    return unitID;
        //}
    }
}
