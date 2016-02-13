using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DailyCensusReport
{
    public class SubmitRecord
    {

        /****************************************************************************************************************/
        //ICU

        public static bool InsertICU(int icuID,string currentCensus, string availBeds, string numOfIsoPatients, string potentialDCs, string notes, string currentCapStat)
        {

            //this add to database based what is giving.
            SqlConnection connect = DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("spInsertICU", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertICU";
            
            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = icuID;
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
                //throw ex;
                MessageBox.Show(ex.Message);

            }

            finally
            {
                connect.Close();
            }
            return true;
        }

/************************************************************************************************************/
       //T2
        //public static bool InsertT2(int t2ID, int unitIDT2, string currentCensusT2, string availBedsT2, string numOfIsoPatientsT2, string potentialDCsT2, string notesT2, string currentCapStatT2)
        //{

        //    //this add to database based what is giving.
        //    SqlConnection connect = DBConnect.GetConnection();
        //    SqlCommand cmd = new SqlCommand("spInsertT2", connect);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "spInsertT2";
        //    cmd.Parameters.Add("@t2ID", SqlDbType.Int).Value = t2ID;
        //    cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitIDT2;
        //    cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = currentCensusT2;
        //    cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = availBedsT2;
        //    cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = numOfIsoPatientsT2;
        //    cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = potentialDCsT2;
        //    cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = notesT2;
        //    cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = currentCapStatT2;

        //    try
        //    {
        //        connect.Open();
        //        //executes then check to see if correct.
        //        int count = cmd.ExecuteNonQuery();
        //        if (count > 0)
        //            return true;
        //        else
        //            return false;
        //    }
        //    catch (SqlException ex)
        //    {
        //        //throw ex;
        //        MessageBox.Show(ex.Message);
        //    }

        //    finally
        //    {
        //        connect.Close();
        //    }
        //    return true;
        //}
    }
}
