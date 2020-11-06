using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace G8M_LibreriaControles
{
    public partial class SWTextbox : TextBox
    {
        public SWTextbox()
        {
            InitializeComponent();
            this.TextChanged += new EventHandler(ORTextBox_TextChanged);
            this.LostFocus += new EventHandler(ORTextBox_Focus);
            FTextC = this.Text;
        }

        //ENUM//
        private InputType _InputSelection;
        public InputType InputTextType
        {
            set { _InputSelection = value; }
            get { return _InputSelection; }
        }
        public enum InputType
        {
            [Description("Input String")]
            Text,
            [Description("Input Number")]
            Integer,
            [Description("Input Code")]
            Code,
            [Description("Input Date")]
            Date
        }

        private EmptyTextbox _InputSelection2;
        public EmptyTextbox AllowEmptyText
        {
            set { _InputSelection2 = value; }
            get { return _InputSelection2; }
        }
        public enum EmptyTextbox
        {
            [Description("Allow empty textbox")]
            Empty,
            [Description("Not allow empty textbox")]
            MandatoryText

        }



        bool notext = false;
        private EmptyField _InputSelection3;
        public EmptyField AllowEmptyField
        {
            set { _InputSelection3 = value; }
            get { return _InputSelection3; }
        }
        public enum EmptyField
        {
            [Description("Texto Obligatorio")]
            WithText,
            [Description("Text No Required")]
            NoTextNeeded
        }
        string FTextC;
        private void ORTextBox_TextChanged(object sender, EventArgs e)
        {
            /////VALIDACION INPUT ES EL TIPO CORRECTO////
            if (_InputSelection == InputType.Text)
            {
                //Si es solo texto
            }
            else if (_InputSelection == InputType.Integer) //Si es numero
            {
                string pattern = "^[0-9]*$";
                string input = ((TextBox)sender).Text.Trim();

                Regexp(pattern, input);

            }
            else if (_InputSelection == InputType.Code) //REGEX
            {
                string pattern = "^[A-Z]{4}-\\d{3}/[13579][AEIOU]$";
                string input = ((TextBox)sender).Text.Trim();
                //Match m = Regex.Match(input, pattern);

                Regexp(pattern, input);

            }
            else if (_InputSelection == InputType.Date)
            {
                string pattern = "^([0-2][0-9]|(3)[0-1])(\\/)(((0)[1-9])|((1)[0-2]))(\\/)\\d{4}$";
                string input = ((TextBox)sender).Text.Trim();
                //Match m = Regex.Match(input, pattern);

                Regexp(pattern, input);
            }

            if (_InputSelection3 == EmptyField.WithText)
            {
                notext = false;
            }
            else
            {
                notext = true;
            }

            if (notext == false)
            {
                //QUE EL .TEXT NO ESTÉ VACÍO :):):):):):)

            }
        }


        public void Regexp(string re, string tb)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(tb))
            {
                this.ForeColor = Color.Green;
            }
            else
            {
                this.ForeColor = Color.Red;

            }
        }
        //ENUM//

        //FORECOLOR
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            this.BackColor = Color.White;

        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.Gray;
        }
        //FORECOLOR

        //SI CAMPO PUEDE ESTAR VACÍO O NO//

private void ORTextBox_Focus(object sender, EventArgs e)
        {
            if (_InputSelection2 == EmptyTextbox.Empty)
            {
                //Si puede estar vacía, nada
            }
            else if (_InputSelection2 == EmptyTextbox.MandatoryText) //Si es numero
            {
                if (string.IsNullOrEmpty(this.Text))
                {
                    MessageBox.Show("Enter an Input");
                }

            }
        }

        //SI CAMPO PUEDE ESTAR VACÍO O NO//

        //CAMBIOS + COMBOBOX//



    }
}
