using System.Data.SqlClient;
using System.Globalization;
using System.Numerics;
using RolPrueba1.Models;

namespace RolPrueba1.Repository
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
                ser.Nombre = this.reader["NOMBRE"].ToString();
                ser.Especie = this.reader["ESPECIE"].ToString();
                ser.Planeta = this.reader["PLANETA"].ToString();
                ser.Agresividad = this.reader["AGRESIVIDAD"].ToString();
                ser.Habilidades = this.reader["HABILIDADES"].ToString();
                ser.Debilidad = this.reader["DEBILIDAD"].ToString();
                ser.Bioma = this.reader["BIOMA"].ToString();        
                seres.Add(ser);
            }
            this.reader.Close();
            this.cn.Close();
            return seres;

        }
        public Seres FindSeres(string id)
        {
            string sql = "SELECT * FROM SERES WHERE NOMBRE=@ID";
            SqlParameter pamnom = new SqlParameter("@ID", id);
            this.com.Parameters.Add(pamnom);
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            Seres ser = new Seres();
            this.reader.Read();

            ser.Nombre = this.reader["NOMBRE"].ToString();
            ser.Especie = this.reader["ESPECIE"].ToString();
            ser.Planeta = this.reader["PLANETA"].ToString();
            ser.Agresividad = this.reader["AGRESIVIDAD"].ToString();
            ser.Habilidades = this.reader["HABILIDADES"].ToString();
            ser.Debilidad = this.reader["DEBILIDAD"].ToString();
            ser.Bioma = this.reader["BIOMA"].ToString();

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return ser;
        }
        public void InsertSeres(string id, string especie, string planeta, string agresividad, string habilidades, string debilidad, string bioma)
        {
            string sql = "INSERT INTO SERES VALUES (@ID, @ESPECIE, @PLANETA, @AGRESIVIDAD, @HABILIDADES, @DEBILIDAD, @BIOMA)";
            SqlParameter pamnom = new SqlParameter("@ID", id);
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
        public void UpdateDepartamento(string id, string especie, string planeta, string agresividad, string habilidades, string debilidad, string bioma)
        {
            string sql = "UPDATE SERES SET ESPECIE=@ESPECIE, PLANETA=@PLANETA, AGRESIVIDAD=@AGRESIVIDAD, HABILIDADES=@HABILIDADES, DEBILIDAD=@DEBILIDAD, BIOMA=@BIOMA WHERE NOMBRE=@ID";

            SqlParameter pamnom = new SqlParameter("@ID", id);
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
        public void DeleteSeres(String id)
        {
            string sql = "DELETE FROM SERES WHERE NOMBRE=@ID";
            SqlParameter pamnom = new SqlParameter("@ID", id);
            this.com.Parameters.Add(pamnom); 
            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
