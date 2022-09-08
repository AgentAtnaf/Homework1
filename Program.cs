
public class Program
{
   static void Main(string[] args)
  {
    string name = Inputname();
    string owner = Inputowner();
    string number = Inputnumber();
    string value = Inputvalue();

     Outputinfo(name,owner,number,value); 
    
    
    string money = Firstinput();
    double use = Converter(money);
    Exchange exchange = new Exchange();
    exchange.Divived(use);
    exchange.Outputmoney();
    }
  public static void Outputinfo(string name,string owner,string number,string value)
  {
    Console.WriteLine("*************************************************");
    Console.WriteLine("Name: {0}",name);
    Console.WriteLine("Number: {0}",number);
    Console.WriteLine("Owner name: {0}",owner);
    Console.WriteLine("Registered value: {0}",value);
    Console.WriteLine("*************************************************");
  }

    static string Inputname()
    {
        Console.WriteLine("Input shopname:");
        return Console.ReadLine();
    }
    static string Inputnumber()
    {
        Console.WriteLine("Input number:");
        return Console.ReadLine();
    }
    static string  Inputowner()
    {
        Console.WriteLine("Input owner:");
        return Console.ReadLine();
    }
      static string Inputvalue()
    {
        Console.WriteLine("Input value:");
        return Console.ReadLine();
    }
     static string Firstinput()
    {
        Console.WriteLine("Input money: ");
        return Console.ReadLine();
    }
    public static double Converter(string money)
    {
        if (double.TryParse(money, out double amout))
        {
            return amout;
        }   
        throw new Exception("Plese input number correctly.");

    }
    
}
