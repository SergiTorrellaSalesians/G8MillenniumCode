using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using G8M_AccesoDatos;

namespace G8M_LibreriaUsuario
{
	public class Metodos
	{
		public int USER_ID;
		G8M_AccesoDatos.AccesoDatos ad_lib;

		public bool ValidacioLogin(String input_username, String input_password)
		{
			String usuari = "PROVA";
			String pass = "12345";
			//Implementar si coinciden las credenciales con la BBDD
			
			bool valid = (input_username == usuari && input_password == pass);

			if(valid)
				ad_lib = new AccesoDatos();

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
