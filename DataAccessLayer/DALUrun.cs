using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;
namespace DataAccessLayer
{
   public  class DALUrun
    {
        public static List<EntityUrun> UrunListesi()
        {
            List<EntityUrun> degerler = new List<EntityUrun>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLURUN", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityUrun ent = new EntityUrun();
                ent.Urunid = byte.Parse(dr["URUNID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Urunfiyat = decimal.Parse(dr["URUNFIYAT"].ToString());
                ent.Urunadet = int.Parse(dr["URUNADET"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int UrunEkle(EntityUrun p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLURUN(URUNAD,URUNFIYAT,URUNADET) VALUES (@p1,@p2,@p3)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", p.Urunad);
            komut.Parameters.AddWithValue("@p2", p.Urunfiyat);
            komut.Parameters.AddWithValue("@p3",p.Urunadet);
            return komut.ExecuteNonQuery();
        }
    }
}
