using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomTefmplates.Models
{
    public class Autorithation : IDataErrorInfo
    {
        public string Login { get; set; }
        public string Pass { get; set; }

        public string this[string columnName]
        {
            get
            {
                string error = String.Empty;
                switch (columnName)
                {
                    case "Login":
                        if (Login.Length < 6)
                        {
                            error = "Login to short!";
                            break;
                        }
                        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                        Match match = regex.Match(Login);
                        if (!match.Success)
                            error = "Email is not correct!";
                        break;
                    case "Pass":
                        
                        break;
                }
                return error;
            }
        }

        public string Error => throw new NotImplementedException();

    }
}
