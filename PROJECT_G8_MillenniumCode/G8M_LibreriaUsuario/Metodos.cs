using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
using System.Diagnostics;
using G8M_AccesoDatos;

namespace G8M_LibreriaUsuario
{
	public class Metodos
	{
		public int USER_ID;
		DataSet dtsTabla;

		public void ConnectData(){
			G8M_AccesoDatos.AccesoDatos ad_lib;
			ad_lib = new AccesoDatos();
			DataSet dtsTabla = ad_lib.PortarTaula("Users");
		}

		public bool ValidacioLogin(String input_username, String input_password)
		{
			bool valid = false;

			foreach (DataRow dr in dtsTabla.Tables[0].Rows) {
				if(dr["Login"].ToString() == input_username
				&& dr["Password"].ToString() == input_password)
				{
					valid = true;
					USER_ID = int.Parse(dr["idUser"].ToString());
				}
			}

			//Devolver UserID del usuario y el password

			return valid;
		}

		#region Función SetTimeOut (Funciona a medias)
		public bool SetTimeout(Action theAction, int millisecond)
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			bool flag = false;
			while (!flag)
			{
				if (sw.ElapsedMilliseconds > millisecond)
				{
					flag = true;
				}
			}
			sw.Stop();
			theAction();
			return true;
		}
		#endregion
	}
}
