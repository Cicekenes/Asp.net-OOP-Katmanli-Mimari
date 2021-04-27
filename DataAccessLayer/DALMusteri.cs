using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
   public  class DALMusteri
    {
        public static List<EntityMusteri> MusteriListesi()
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLMUSTERI",Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.Musteriid =Convert.ToInt32( dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int MusteriEkle(EntityMusteri p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLMUSTERI(MUSTERIAD,MUSTERISOYAD) VALUES (@p1,@p2)",Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",p.Musteriad);
            komut.Parameters.AddWithValue("@p2",p.Musterisoyad);
            return komut.ExecuteNonQuery();
        }

        public static bool MusteriSil(int p)
        {
            SqlCommand komut = new SqlCommand("Delete From TBLMUSTERI where MUSTERIID=@p1",Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",p);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityMusteri> MusteriGetir(int id)
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLMUSTERI where MUSTERIID=@p1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1",id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                //ent.Musteriid = Convert.ToInt32(dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool MusteriGuncelle(EntityMusteri p)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBLMUSTERI SET MUSTERIAD=@p1,MUSTERISOYAD=@p2 where MUSTERIID=@p3",Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",p.Musteriad);
            komut.Parameters.AddWithValue("@p2",p.Musterisoyad);
            komut.Parameters.AddWithValue("@p3",p.Musteriid);

            return komut.ExecuteNonQuery() > 0;
        }
    }
}
