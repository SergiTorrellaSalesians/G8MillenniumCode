using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G8M_Clases
{
    public class ValidacioLogin (String input_nomusuari, String input_password)
    {
        String usuari = "PROVA";
        String pass = "12345";

        bool valid = (input_nomusuari.Text == usuari && input_password.Text == pass);
    }
}
