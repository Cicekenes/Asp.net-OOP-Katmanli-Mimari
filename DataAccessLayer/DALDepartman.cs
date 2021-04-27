using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
namespace DataAccessLayer
{
    public class DALDepartman
    {
        public static List<EntityDepartman> DepartmanListesi()
        {
            List<EntityDepartman> degerler = new List<EntityDepartman>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLDEPARTMAN",Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDepartman ent = new EntityDepartman();
                ent.Departmanid = byte.Parse(dr["DEPARTMANID"].ToString());
                ent.Departmanad = dr["DEPARTMANAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int DepartmanEkle(EntityDepartman p)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLDEPARTMAN(DEPARTMANAD) VALUES (@p1)",Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",p.Departmanad);
            return komut.ExecuteNonQuery();
        }
    }
}
