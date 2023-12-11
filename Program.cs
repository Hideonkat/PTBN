using System;

namespace ptbn;

 class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Phuong trinh bac nhat");
        Console.WriteLine("ax+b=0, hay nhap a,b");
        Console.Write("a:");
        Double a = Double.Parse(Console.ReadLine());
        Console.Write("b:");
        Double b = Double.Parse(Console.ReadLine());
        
        if (a != 0)
        {
            Console.WriteLine("Phuong trinh co nghiem:" + -b/a);

        }
        else 
        {
            if(b==0)
            {
                Console.WriteLine("Vo so nghiem");

            }
            else
            {
                Console.WriteLine("Vo nghiem");
            }

            
        }




        }
}