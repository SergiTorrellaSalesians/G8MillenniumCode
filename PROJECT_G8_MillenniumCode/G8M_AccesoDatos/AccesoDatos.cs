using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;

namespace G8M_AccesoDatos
{
    public class AccesoDatos
    {
        //ESTAS VARIABLES NO ME LAS LEEN EL RESTO DE CLASES ASÍ QUE A VER QUÉ PODEMOS HACER
        public SqlConnection conn;
        string connection_string;
        public string query;
        //DataSet dts;
        public AccesoDatos()
        {
            //query = "hpñs";

        }

        public string connectionString()
        {
            //LAPTOP-45H9O8I4
            String hostname = System.Environment.MachineName;

            String connStr = "Data Source="+hostname+"\\SQLEXPRESS;Initial Catalog=SecureCore;Integrated Security=True"; //conseguir el hostname??? o lo que sea
            String cadenacnnStr = connStr + "";

            return cadenacnnStr;
        }

        public void Connectar()
        {
            //Crear conexión
            SqlConnection conn;
            string cnx;
            cnx = connectionString();
            conn = new SqlConnection(cnx);
        }

        public DataSet PortarTaula(string table_name)
        {
            Connectar();

            SqlDataAdapter adapter;
            DataSet dts = new DataSet();
            string stringconnection = connectionString();
            SqlConnection conn = new SqlConnection(stringconnection);
            
            string query = "select * from " + table_name;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, table_name);
            //dtgAgencies.DataSource = dts.Tables[table_name];

            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string consulta)
        {
            DataSet dtsRegistres = new DataSet();
            string dataset_name = "";

            

            return PortarPerConsulta(consulta, dataset_name);
        }

        public DataSet PortarPerConsulta(string consulta, string dataset_name)
        {
            DataSet dtsRegistres = new DataSet();

            return dtsRegistres;
        }

        public void Actualitzar(string table_name)
        {

            //esborrar
            //modificar
            //insertar

            string stringconnection = connectionString();
            //SqlConnection conn = new SqlConnection(stringconnection);
            //string query = "select * from " + table_name;
            DataSet dts = new DataSet();

            conn.Open();


            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                int result = adapter.Update(dts.Tables[0]);
            }

            conn.Close();
        }

        //Hi haurà una funció Executa que rebrà una consulta de modificació, 
        //inserció o esborrat
        //i l’executarà directament sobre BBDD.

        public static void Executa(string consulta)
        {

        }

        /*
         * 
         * Una funció GeneraConsultaCerca que rebrà el nom de la taula i 
         * un Dictionary amb
nom de camp i valor del camp per tal de generar la consulta en runtime.
        Aquesta
consulta s’ha de generar parametritzada per tal d’evitar atacs de SQL Injection.
         * */
        public static void GeneraConsultaCerca(string tablename, Dictionary<string, string> nomvalorcamps)
        {

        }

        /*
         * vPreveure que potser caldrà inserir imatges i/o documents en format PDF a la
BBDD. En la classe heretada caldrà implementar una funció que, en cas d’inserció o
modificació, permeti sobreescriure la funció Actualitza per tal de fer una crida a la
funció del base i a continuació modificar el registre acabat de modificar per tal de
modificar la fotografia o el document adjunt.
         * */

        public static void Actualitza()
        {

        }
    }
}
