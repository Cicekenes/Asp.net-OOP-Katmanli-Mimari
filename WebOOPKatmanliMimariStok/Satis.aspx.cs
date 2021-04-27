using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;
namespace WebOOPKatmanliMimariStok
{
    public partial class Satis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntitySatis> SatList = BLLSatis.BLLSatisListesi();
            Repeater1.DataSource = SatList;
            Repeater1.DataBind();
        }
    }
}