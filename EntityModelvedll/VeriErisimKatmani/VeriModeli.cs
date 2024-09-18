using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class VeriModeli
    {
        SqlConnection con;
        SqlCommand cmd;
        public VeriModeli()
        {
            con = new SqlConnection(VeriYollari.veriyolu);
            cmd = con.CreateCommand();
        }

        public void KategoriEkle(Kategori kat)
        {
            cmd.CommandText = "INSERT INTO Categories(CategoryName, Description) VALUES(@categoryName, @description)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@categoryname", kat.Isim);
            cmd.Parameters.AddWithValue("@description", kat.Aciklama);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<Kategori> KategorileriGetir()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            cmd.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories ORDER BY CategoryID";
            cmd.Parameters.Clear();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Kategori kat = new Kategori();
                kat.ID = reader.GetInt32(0);
                kat.Isim = reader.GetString(1);
                kat.Aciklama = reader.GetString(2);
                kategoriler.Add(kat);
            }
            con.Close();
            return kategoriler;
        }
    }
}
