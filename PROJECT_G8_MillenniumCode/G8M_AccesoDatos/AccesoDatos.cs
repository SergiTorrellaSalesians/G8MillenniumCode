﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;

namespace G8M_AccesoDatos
{
    public class AccesoDatos
    {
        public SqlConnection conn;
        public DataSet dts;

        public void EncriptarConnectionString()
        {
            #if DEBUG
                string applicationName = Environment.GetCommandLineArgs()[0];
            #else
                string applicationName = Environment.GetCommandLineArgs()[0]+ ".exe";
            #endif

            string exePath = System.IO.Path.Combine(Environment.CurrentDirectory, applicationName);
            Configuration conf = ConfigurationManager.OpenExeConfiguration(exePath);

            ConnectionStringsSection section = conf.GetSection("connectionStrings")
            as ConnectionStringsSection;

        }
        public string connectionString()
        {
            string connectString = ConfigurationManager.ConnectionStrings["G8_MillenniumCode.Properties.Settings.SecureCoreConnectionString"].ToString();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectString);

            connectString = "Data Source = " + Environment.MachineName.ToString() + connectString.Substring(connectString.IndexOf('\\')); //Manually set computer name

            return connectString;
        }

        public void Connectar()
        {
            //Crear conexión
            //SqlConnection conn;
            string cnx;
            cnx = connectionString();
            conn = new SqlConnection(cnx);
        }

        public DataSet PortarTaula(string table_name)
        {
            dts = new DataSet();

            Connectar();

            SqlDataAdapter adapter;
            
            string query = "select * from " + table_name;
            adapter = new SqlDataAdapter(query, conn);

            conn.Open();

            adapter.Fill(dts, table_name);

            conn.Close();

            return dts;
        }

        public DataSet PortarPerConsulta(string consulta)
        {
            Connectar();

            SqlDataAdapter adapter;

            string query = consulta;
            adapter = new SqlDataAdapter(query, conn);
            DataSet dataset_portarperconsulta = new DataSet();

            conn.Open();

            adapter.Fill(dataset_portarperconsulta);

            conn.Close();

            return dataset_portarperconsulta;
        }

        public DataSet PortarPerConsulta(string consulta, string dataset_name)
        {
            Connectar();

            SqlDataAdapter adapter;

            string query = consulta;
            adapter = new SqlDataAdapter(query, conn);
            DataSet dataset_portarperconsulta = new DataSet();

            conn.Open();

            adapter.Fill(dataset_portarperconsulta, dataset_name);

            conn.Close();

            return dataset_portarperconsulta;
        }

        public bool Actualitzar(DataSet dts, string bbdd_tablename)
        {
            bool correct = false;

            Connectar();
            conn.Open();

            string query = "select * from " + bbdd_tablename;
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);


            if (dts.HasChanges())
            {
                int result = adapter.Update(dts.Tables[0]);
                correct = true;
            }

            conn.Close();

            return correct;
        }

        public void Executa(string consulta)
        {
            string query = consulta;

            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            int registresAfectats = cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }

        public void GeneraConsultaCerca(string tablename, Dictionary<string, string> nomvalorcamps)
        {
            string query = "select count(*) from" + tablename;
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int numAlumnes = (int)cmd.ExecuteScalar();
            cmd.Dispose();
        }
        public string GetTableData(string nomCamp, string query)
        {
            Connectar();

            SqlDataAdapter adapterLocal = new SqlDataAdapter(query, conn);

            DataSet dts = new DataSet();

            conn.Open();
            adapterLocal.Fill(dts);
            conn.Close();

            return dts.Tables[0].Rows[0][nomCamp].ToString();
        }
    }
}
