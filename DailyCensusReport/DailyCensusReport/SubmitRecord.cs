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
        public static bool AddRecord(List<TextBox[]> boxes)

        {
            //Establishing the database connection.
            SqlConnection connect = DBConnect.GetConnection();

            string[] storeProcedures = { "spInsertICU", "spInsertT2", "spInsertPEDI", "spInsertT4", "spInsert6ACU", "spInsertTBC", "spInsertBHU" };

            //SQL Command that takes in the command string and the connection.
            for (int i = 0; i < boxes.Count; i++)
            {
                for (int j = 0; j < boxes[i].Length; j++)
                {
                    SqlCommand cmd = new SqlCommand(storeProcedures[i], connect);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = storeProcedures[i];
                    cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = boxes[i][j].Text;
                    cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = boxes[i][j].Text;
                    cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = boxes[i][j].Text;
                    cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = boxes[i][j].Text;
                    cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = boxes[i][j].Text;
                    cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = boxes[i][j].Text;
                    cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = boxes[i][j].Text;

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

            }

            //Adding parameters that equal the value to whatever data is put into the textboxes.

            return true;
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
