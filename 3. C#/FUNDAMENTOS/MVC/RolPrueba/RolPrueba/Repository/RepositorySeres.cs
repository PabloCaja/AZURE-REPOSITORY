using System.Data.SqlClient;
using System.Globalization;
using System.Numerics;
using RolPrueba.Models;

namespace RolPrueba.Repository
{
    public class RepositorySeres
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;


        public RepositorySeres(string connectionString)
        {
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
        }


        public List<Seres> GetSeres()
        {
            string sql = "SELECT * FROM SERES";
            List<Seres> seres = new List<Seres>();
            this.com.CommandText= sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                Seres ser = new Seres();
                ser.Nombre = this.reader["NOM"].ToString();
                ser.Especie = this.reader["ESP"].ToString();
                ser.Planeta = this.reader["PLA"].ToString();
                ser.Agresividad = this.reader["AGR"].ToString();
                ser.Habilidades = this.reader["HAB"].ToString();
                ser.Debilidad = this.reader["DEB"].ToString();
                ser.Bioma = this.reader["BIO"].ToString();        
                seres.Add(ser);
            }
            this.reader.Close();
            this.cn.Close();
            return seres;

        }
        public Seres FindSeres(string nombre)
        {
            string sql = "SELECT * FROM DEPT WHERE NOMBRE=@NOMBRE";
            SqlParameter pamid = new SqlParameter("@NOMBRE", nombre);
            this.com.Parameters.Add(pamid);
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            Seres ser = new Seres();
            this.reader.Read();

            ser.Nombre = this.reader["NOM"].ToString();
            ser.Especie = this.reader["ESP"].ToString();
            ser.Planeta = this.reader["PLA"].ToString();
            ser.Agresividad = this.reader["AGR"].ToString();
            ser.Habilidades = this.reader["HAB"].ToString();
            ser.Debilidad = this.reader["DEB"].ToString();
            ser.Bioma = this.reader["BIO"].ToString();

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return ser;
        }
        public void InsertSeres(string nombre, string especie, string planeta, string agresividad, string habilidades, string debilidad, string bioma)
        {
            string sql = "INSERT INTO DEPT VALUES (@NOMBRE, @ESPECIE, @PLANETA, @AGRESIVIDAD, @HABILIDADES, @DEBILIDAD, @BIOMA)";
            SqlParameter pamnom = new SqlParameter("@NOMBRE", nombre);
            SqlParameter pamesp = new SqlParameter("@ESPECIE", especie);
            SqlParameter pampla = new SqlParameter("@PLANETA", planeta);
            SqlParameter pamagr = new SqlParameter("@AGRESIVIDAD", agresividad);
            SqlParameter pamhab = new SqlParameter("@HABILIDADES", habilidades);
            SqlParameter pamdeb = new SqlParameter("@DEBILIDAD", debilidad);
            SqlParameter pambio = new SqlParameter("@BIOMA", bioma);


            this.com.Parameters.Add(pamnom);
            this.com.Parameters.Add(pamesp);
            this.com.Parameters.Add(pampla);
            this.com.Parameters.Add(pamagr);
            this.com.Parameters.Add(pamhab);
            this.com.Parameters.Add(pamdeb);
            this.com.Parameters.Add(pambio);

            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
        public void UpdateDepartamento(string nombre, string especie, string planeta, string agresividad, string habilidades, string debilidad, string bioma)
        {
            string sql = "UPDATE DEPT SET NOM=@NOMBRE, ESP=@ESPECIE, PLA=@PLANETA, AGR=@AGRESIVIDAD, HAB=@HABILIDADES, DEB=@DEBILIDAD, BIO=@BIOMA WHERE NOM=@NOMBRE";

            SqlParameter pamnom = new SqlParameter("@NOMBRE", nombre);
            SqlParameter pamesp = new SqlParameter("@ESPECIE", especie);
            SqlParameter pampla = new SqlParameter("@PLANETA", planeta);
            SqlParameter pamagr = new SqlParameter("@AGRESIVIDAD", agresividad);
            SqlParameter pamhab = new SqlParameter("@HABILIDADES", habilidades);
            SqlParameter pamdeb = new SqlParameter("@DEBILIDAD", debilidad);
            SqlParameter pambio = new SqlParameter("@BIOMA", bioma);

            this.com.Parameters.Add(pamnom);
            this.com.Parameters.Add(pamesp);
            this.com.Parameters.Add(pampla);
            this.com.Parameters.Add(pamagr);
            this.com.Parameters.Add(pamhab);
            this.com.Parameters.Add(pamdeb);
            this.com.Parameters.Add(pambio);

            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
        public void DeleteSeres(String nombre)
        {
            string sql = "DELETE FROM DEPT WHERE NOM=@NOMBRE";
            SqlParameter pamnom = new SqlParameter("@NOMBRE", nombre);
            this.com.Parameters.Add(pamnom); 
            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
