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
        private int unitID;
        private string currentCensus;
        private string availBeds;
        private string numOfIsoPatiens;
        private string potentialDCs;
        private string notes;

        public SubmitRecord() { }

        public SubmitRecord (int unitID, string currentCensus, string availBeds, string numOfIsoPatients, string potentialDCs, string notes, string currentCapStat)
        {
            this.UnitID = unitID;
            this.CurrentCensus = currentCensus;
            this.AvailBeds = availBeds;
            this.IsolationPatients = numOfIsoPatiens;
            this.PotentialDCs = potentialDCs;
            this.Notes = notes;
            this.CurrentCapStat = currentCapStat;
        }

        #region Properties
        public int UnitID { get; set; }
        public string CurrentCensus { get; set; }
        public string AvailBeds { get; set; }
        public string IsolationPatients { get; set; }
        public string PotentialDCs { get; set; }
        public string Notes { get; set; }
        public string CurrentCapStat { get; set; }
        #endregion

        public static bool AddRecord(int unitID, string currentCensus, string availBeds, string numOfIsoPatients, string potentialDCs, string notes, string currentCapStat)

        {

            //this add to database based what is giving.
            SqlConnection connect = DBConnect.GetConnection();

            SqlCommand sqlCmd = new SqlCommand("spInsertICU", connect);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "spInsertICU";
            sqlCmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitID;
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
    }
}
