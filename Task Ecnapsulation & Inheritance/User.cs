using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Ecnapsulation___Inheritance;

internal class User:Human
{
    public string username;
    public string password;

    public User(string name, string surname, string username , string password) : base(name, surname)
    {
        if (username.Length > 5 && username.Length < 26)
        {
            this.username = username;
        }
        else
        {
            Console.WriteLine("username minimun 6 maskimun 25 simvoldan ibaret ola biler!");
        }

        if (password.Length > 7 && password.Length < 26)
        {
            this.password = password;   
        }
        else
        {
            Console.WriteLine("parolunuz minimun 8 maskimun 25 simvoldan ibaret ola biler!");
        }


    }
}
