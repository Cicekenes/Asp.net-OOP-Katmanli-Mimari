using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data;
using System.Data.SqlClient;
namespace WebOOPKatmanliMimariStok
{
    public partial class SatisEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select * from TBLURUN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownListUrun.DataValueField = "URUNID";
                DropDownListUrun.DataTextField = "URUNAD";
                DropDownListUrun.DataSource = dt;
                DropDownListUrun.DataBind();

                SqlCommand komut2 = new SqlCommand("Select PERSONELID,(PERSONELAD+' '+ PERSONELSOYAD) AS 'PERSONELADSOYAD' from TBLPERSONEL", Baglanti.bgl);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DropDownListPersonel.DataValueField = "PERSONELID";
                DropDownListPersonel.DataTextField = "PERSONELADSOYAD";
                DropDownListPersonel.DataSource = dt2;
                DropDownListPersonel.DataBind();

                SqlCommand komut3 = new SqlCommand("Select MUSTERIID,(MUSTERIAD+' '+ MUSTERISOYAD) AS 'MUSTERIADSOYAD' from TBLMUSTERI", Baglanti.bgl);
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                DropDownListMusteri.DataValueField = "MUSTERIID";
                DropDownListMusteri.DataTextField = "MUSTERIADSOYAD";
                DropDownListMusteri.DataSource = dt3;
                DropDownListMusteri.DataBind();
            }
        }
    }
}