using System;
 class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Dien can nang vao dum(kg):");
        Double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Dien chieu cao vao dum(m):");
        Double b = Double.Parse(Console.ReadLine());
        Double c = a/Math.Pow(b,2);
        
        Console.WriteLine("BMI:" + c);
        if(c < 18.5)
        {
             Console.WriteLine("Suy dinh duong roi nhe"); 

        }
        else if (c <= 25.0)
        {
            Console.WriteLine("Dang dep day");

        }
        else if( c <= 30)
        {
            Console.WriteLine("Beo roi an it thoi");
        }
        else
        {
            Console.WriteLine("Thich lam pig hay gi?");
        }


        }
}