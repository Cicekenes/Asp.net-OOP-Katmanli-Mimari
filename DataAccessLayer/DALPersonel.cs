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
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("DEPARTMANLIST",Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Personelid = Convert.ToInt32(dr["PERSONELID"].ToString());
                ent.Personelad = dr["PERSONELAD"].ToString();
                ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Personelmaas = Convert.ToDecimal(dr["PERSONELMAAS"].ToString());
                //ent.Personeldepartman = Convert.ToByte(dr["PERSONELDEPARTMAN"].ToString());
                ent.Personeldep = dr["DEPARTMANAD"].ToString();
                ent.Personelfotograf = dr["PERSONELFOTOGRAF"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand(@"insert into TBLPERSONEL (PERSONELAD,PERSONELSOYAD,PERSONELDEPARTMAN,PERSONELMAAS) values (@p1,@p2,@p3,@p4)",Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",p.Personelad);
            komut.Parameters.AddWithValue("@p2",p.Personelsoyad);
            komut.Parameters.AddWithValue("@p3",p.Personeldepartman);
            komut.Parameters.AddWithValue("@p4",p.Personelmaas);

            return komut.ExecuteNonQuery();
        }
    }
}
