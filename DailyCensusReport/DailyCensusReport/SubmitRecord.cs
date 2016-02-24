﻿using System;
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
        //ICU Insert Method
        public static void InsertICU(int unitID, string[] varICU)
        {
            //Creating the database connection.
            SqlConnection connect = DBConnect.GetConnection();

            SqlCommand cmd = new SqlCommand("spInsertICU", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertICU";

            /*Adding parameters to their respective values/variables. In this case, their values are
            in an array of variables that are equal to the user's input.*/
            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitID;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = varICU[0];
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = varICU[1];
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = varICU[2];
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = varICU[3];
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = varICU[4];
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = varICU[5];

            try
            {
                connect.Open();
                //Executes then check to see if correct.
                cmd.ExecuteNonQuery();                
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
        }
        
        /*
         Everything in the methods below are 
         practically the same as the ICU Insert 
         method
         */

        //T2 Insert Method
        public static void InsertT2(int unitIDT2, string[] varT2)
        {

            SqlConnection connect = DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("spInsertT2", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertT2";

            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitIDT2;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = varT2[0];
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = varT2[1];
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = varT2[2];
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = varT2[3];
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = varT2[4];
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = varT2[5];

            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();

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
        }

//PEDI Insert Method
        public static void InsertPEDI(int unitIDPEDI, string[] varPEDI)
        {

            SqlConnection connect = DBConnect.GetConnection();
            SqlCommand cmd = new SqlCommand("spInsertPEDI", connect);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertPEDI";

            cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitIDPEDI;
            cmd.Parameters.Add("@currentCensus", SqlDbType.VarChar, 50).Value = varPEDI[0];
            cmd.Parameters.Add("@availBeds", SqlDbType.VarChar, 50).Value = varPEDI[1];
            cmd.Parameters.Add("@numberISP", SqlDbType.VarChar, 50).Value = varPEDI[2];
            cmd.Parameters.Add("@DC", SqlDbType.VarChar, 50).Value = varPEDI[3];
            cmd.Parameters.Add("@notes", SqlDbType.VarChar, 50).Value = varPEDI[4];
            cmd.Parameters.Add("@currentCap", SqlDbType.VarChar, 50).Value = varPEDI[5];

            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();

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
        }
    }
}
