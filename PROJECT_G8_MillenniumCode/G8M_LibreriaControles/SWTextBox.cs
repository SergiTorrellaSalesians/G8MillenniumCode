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
    public partial class SWTextBox : TextBox
    {
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
        string FTextC;
        public SWTextBox()
        {
            InitializeComponent();
            this.TextChanged += new EventHandler(ORTextBox_TextChanged);
            FTextC = this.Text;
        }
        private void ORTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_InputSelection == InputType.Text)
            {
                //Si es solo texto
            }
            else if (_InputSelection == InputType.Integer) //Si es numero
            {
                    Int64 num = 0;
                    bool success = Int64.TryParse(((TextBox)sender).Text, out num);
                    if (success & num >= 0)
                    {
                        ((TextBox)sender).Text.Trim();
                        FTextC = ((TextBox)sender).Text;
                    } else
                    {
                        ((TextBox)sender).Text = FTextC;
                        ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
                    }
                
            } else if (_InputSelection == InputType.Code) //REGEX
            {
                //^[A-Z]{4}-\d{3}\/[13579][AEIOU]$
                string pattern = "^[A-Z]{4}-\\d{3}\\/[13579][AEIOU]$";
                string input = ((TextBox)sender).Text.Trim();
                Match m = Regex.Match(input, pattern);
                
                    if (m.Success)
                    {
                        ((TextBox)sender).Text.Trim();
                        FTextC = ((TextBox)sender).Text;
                    }
                
            }
            else if (_InputSelection == InputType.Date)
            {
                string pattern = "^([0-2][0-9]|(3)[0-1])(\\/)(((0)[1-9])|((1)[0-2]))(\\/)\\d{4}$";
                string input = ((TextBox)sender).Text.Trim();
                Match m = Regex.Match(input, pattern);

                    if (m.Success)
                    {
                        ((TextBox)sender).Text.Trim();
                        FTextC = ((TextBox)sender).Text;
                    }
                }
            }
        }
    }
