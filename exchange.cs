public class Exchange
{
    public int a,b,c,d,e,f,g,h,i,j;
    public void Divived(double use)
    {
       int result;
       use = use * 100;

        a = (int)use/100000;
        result = (int)use%100000 ;
        b = result/50000;
        result = result%50000;
        c = result/10000;
        result = result%10000;
        d = result/5000;
        result = result%5000;
        e = result/2000;
        result = result%2000;
        f = result/1000;
        result = result%1000;
        g = result/500;
        result = result%500;
        h = result/100;
        result = result%100;
        i = result/50;
        result = result%50;
        j = result/25;
        result = result%25; 
    }
    public void Outputmoney()
    {
    Console.WriteLine();
    Console.WriteLine("1000: {0}",a);
    Console.WriteLine("500: {0}",b);
    Console.WriteLine("100: {0}",c);
    Console.WriteLine("50: {0}",d);
    Console.WriteLine("20: {0}",e);
    Console.WriteLine("10: {0}",f);
    Console.WriteLine("5: {0}",g);
    Console.WriteLine("1: {0}",h);
    Console.WriteLine("0.50: {0}",i);
    Console.WriteLine("0.25: {0}",j);
    Console.WriteLine();
    }
} 