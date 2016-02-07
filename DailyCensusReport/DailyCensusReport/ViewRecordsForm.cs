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
    public partial class ViewRecordsForm : Form
    {
        public ViewRecordsForm()
        {
            InitializeComponent();
        }

        private void ViewRecordsForm_Load(object sender, EventArgs e)
        {

        }

        //DateTime Picker
        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();

        //    SqlConnection cn = DBConnect.GetConnection();

        //    SqlCommand cmd = new SqlCommand("spCensus", cn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@date", SqlDbType.VarChar).Value = DPRecordDate.Value;


        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    try
        //    {
        //        cn.Open();
        //        da.Fill(dt);
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //    RecordView.Rows.Add(dt.Rows[0]);
        //}
    }
}
