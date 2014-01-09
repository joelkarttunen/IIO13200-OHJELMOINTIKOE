using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class f6761_T3 : System.Web.UI.Page
{
    List<String> maat;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        IniMyStuff();
    }
    protected void IniMyStuff()
    {
        
        maat = new List<String>();
        try
        {
            int ostoksetLkm = 0;
            int ostosValue = 0;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Demox"].ToString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM asiakas";
            cmd.Connection = conn;
            conn.Open();
            reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;

                if (!maat.Contains(reader[3].ToString()))
                {
                    maat.Add(reader[3].ToString());
                }
               
                if (reader[6].ToString() != "")
                {
                    ostoksetLkm++;
                    ostosValue += int.Parse(reader[6].ToString());
                }
            }
            DropDownList1.DataSource = maat;
            DropDownList1.DataBind();
            txtLkm.Text = count.ToString();
            conn.Close();

            txtOstosLkm.Text = ostoksetLkm.ToString();
            txtOstosArvo.Text = ostosValue.ToString();
        }
        catch (Exception es)
        {

            txtLkm.Text = "Ei yhteyttä tietokantaan";
            txtError.Text = es.Message;
        }

        
    }
    protected void btnGetAll_Click(object sender, EventArgs e)
    {
        try
        {
            GridView1.DataSourceID = "SqlDataSource1";
        }
        catch (Exception es)
        {

            txtError.Text = es.Message;
        }
        
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable dt = new DataTable();

            DataSourceSelectArguments args = new DataSourceSelectArguments();
            DataView view = (DataView)SqlDataSource2.Select(args);
            dt = view.ToTable();

            dt.DefaultView.RowFilter = "maa = '" + DropDownList1.SelectedItem.ToString() + "'";
            GridView1.DataSource = dt;
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }
        catch (Exception es)
        {

            txtError.Text = es.Message;
        }
        
        
    }
    protected void btnOstos_Click(object sender, EventArgs e)
    {
        try
        {
            GridView1.DataSourceID = "SqlDataSource3";
        }
        catch (Exception es)
        {

            txtError.Text = es.Message;
        }
        
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            String haku = txtSearch.Text;

            DataTable dt = new DataTable();

            DataSourceSelectArguments args = new DataSourceSelectArguments();
            DataView view = (DataView)SqlDataSource1.Select(args);
            dt = view.ToTable();

            dt.DefaultView.RowFilter = "asnimi like '%" + haku + "%' OR yhteyshlo like '%" + haku + "%'";
            GridView1.DataSource = dt;
            GridView1.DataSourceID = null;
            GridView1.DataBind();
        }
        catch (Exception es)
        {

            txtError.Text = es.Message;
        }
        
    }
}