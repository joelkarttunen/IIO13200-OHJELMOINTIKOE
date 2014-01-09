using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

public partial class f6761_T2 : System.Web.UI.Page
{
    DataTable dt;
    DataSet ds;
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
         IniMyStuff();
       
    }
    protected void IniMyStuff()
    {
        try
        {
            List<String> otsikkorivi = new List<String>();


            ds = new DataSet();
            ds.ReadXml(ConfigurationManager.AppSettings["countries"]);

            dt = ds.Tables[0];

            GridView1.AllowPaging = false;

            GridView1.PagerSettings.Visible = false;
            GridView1.DataSource = dt;
            GridView1.DataBind();

            txtMaat.Text = dt.Rows.Count.ToString();
            int asukasluku = 0;

            foreach (DataRow row in dt.Rows)
            {
                asukasluku += Int32.Parse(row["Population"].ToString());
            }

            txtAsukasluku.Text = asukasluku.ToString();

            Session["table"] = dt;
        }
        catch (Exception es)
        {

            txtError.Text = es.Message;
        }
        
    }
    protected void btnKaikki_Click(object sender, EventArgs e)
    {
        try
        {
            IniMyStuff();
        }
        catch (Exception es)
        {

            txtError.Text = es.Message;
        }
        
    }
    protected void btnSuurimmat_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dts = (DataTable)Session["table"];
            dts.DefaultView.Sort = "Population DESC";
            DataView dv = new DataView(dts);
            GridView1.AllowPaging = true;
            GridView1.PageSize = 10;
            GridView1.PagerSettings.Visible = false;
            GridView1.DataSource = dv.Table;
            GridView1.DataBind();

        }
        catch (Exception es)
        {

            txtError.Text = es.Message;
        }
        
       
        
    }
    protected void btnElinAika_Click(object sender, EventArgs e)
    {
        try
        {
            DataTable dts = (DataTable)Session["table"];
            dts.DefaultView.Sort = "LifeExpectancy ASC";
            DataView dv = new DataView(dts);
            GridView1.AllowPaging = true;
            GridView1.PageSize = 5;
            GridView1.PagerSettings.Visible = false;
            GridView1.DataSource = dv.Table;
            GridView1.DataBind();

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
            DataTable dts = (DataTable)Session["table"];
            dts.DefaultView.RowFilter = "Name like '%" + haku + "%'";

            GridView1.DataSource = dts;
            GridView1.DataBind();
        }
        catch (Exception es)
        {

            txtError.Text = es.Message;
        }
        

    }
    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        
    }
}