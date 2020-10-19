using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G8M_LibreriaUsuario
{
	public class Metodos
	{
		public bool ValidacioLogin(String input_username, String input_password)
		{
			String usuari = "PROVA";
			String pass = "12345";

			bool valid = (input_username == usuari && input_password == pass);
			return valid;
		}

	}
}
