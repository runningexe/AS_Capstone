using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SiteProduct
/// </summary>
public class ViewRecord
{

    #region constructors
    //default constructor
    public ViewRecord() { }

    //Creates a DataTable for Product
    public ViewRecord(DateTime date)
    {
        DataTable dt = new DataTable();
        dt = ViewRecordID(unitID);
        if (dt.Rows.Count > 0)
        {
            this.unitID = Convert.ToInt32(dt.Rows[0]["unitID"].ToString());

            this.RecordDate = Convert.ToDateTime(dt.Rows[0]["date"].ToString());
            
        }
    }

    #endregion

    #region properties

    public int unitID { get; set; }
    public DateTime RecordDate { get; set; }

    #endregion

    #region methods/functions

    public static DataTable ViewRecordID(int unitID)
    {
        string connectionString =
               "Data Source=sql.neit.edu;Initial Catalog=SE265_AJF1130;User ID=001246352  ;Password= 02272014";
        SqlConnection connect = new SqlConnection(connectionString);

            //ConfigurationManager.ConnectionStrings
            //["Data Source=sql.neit.edu;Initial Catalog=SE265_AJF1130;User ID=001246352;Password= 02272014"].ConnectionString);

        SqlCommand cmd = new SqlCommand("spCensus", connect);
        
        DataTable dt = new DataTable();
        cmd.CommandType = CommandType.StoredProcedure;
        // Add Parameters to Stored Procedure
        cmd.Parameters.Add("@unitID", SqlDbType.Int).Value = unitID;
        try
        {
            //opens connection to database, most failures happen here
            //check connection string for proper settings
            connect.Open();
            //data adapter object is trasport link between data source and 
            //data destination
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //fill method, for multiple tables use dataset
            da.Fill(dt);
        }
        catch (Exception exc)
        {
            //just put here to make debugging easier, can look at error directly
            exc.ToString();
        }
        finally
        {
            //must always close connections
            connect.Close();
        }

        // Return the datatable
        return dt;
    }



    #endregion
}