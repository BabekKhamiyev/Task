namespace Task_Ecnapsulation___Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        


        Console.WriteLine("adinizi daxil edin");
        string name=Console.ReadLine();
        Console.WriteLine("soyadinizi daxil edin");
        string surname = Console.ReadLine();
        Console.WriteLine("username daxil edin");
        string username = Console.ReadLine();
        Console.WriteLine("parolunuzu daxil edin");
        string password=Console.ReadLine();



        User user1 = new User(name,surname,username,password);
        
        
    }
}
