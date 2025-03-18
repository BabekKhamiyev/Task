using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Ecnapsulation___Inheritance;

internal class Human
{
    public string name;
    public string surname;
    private byte _age;
    public byte Age
    {
        get
        {
            return _age;
        }
        set
        {
            _age = value;
        }
    }
    public Human()
    {
        
    }   
    public Human(string name)
    {
        this.name = name;
    }
    public Human(string name, string surname)
    {
        this.name=name;
        this.surname = surname;
           
    }
    public void ShowFullData()
    {
        Console.WriteLine($"adi:{name}, soyadi:{surname}, yasi:{_age}");
    }

    public string GetFullName()
    {
        return name+" "+surname;
    }

}
