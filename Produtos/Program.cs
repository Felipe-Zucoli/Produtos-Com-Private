using System;
using Produtos;
using System.Globalization;

namespace Course { 
class Program
{
    
    static void Main(string[] args)
    {
        Estoque estoque = new Estoque ("Tv", 500.00, 10);
            estoque.SetName("Fe");
            Console.WriteLine(estoque.GetName());
            Console.WriteLine(estoque.GetPrecoProd()); 
            Console.WriteLine (estoque.GetQuantProd());
            
    }
}
}