﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
namespace WebOOPKatmanliMimariStok
{
    public partial class UrunEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityUrun ent = new EntityUrun();
            ent.Urunad = TextBox1.Text;
            ent.Urunfiyat = decimal.Parse(TextBox2.Text);
            ent.Urunadet = int.Parse(TextBox3.Text);
            BLLUrun.BLLUrunEkle(ent);
            ScriptManager.RegisterClientScriptBlock(this,this.GetType(),"alertmessage","alert('Ürün Ekleme İşlemi Yapıldı!')",true);
            Response.Redirect("URUNLER.ASPX");
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}