using System;

namespace patron_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            BebidaComponent cafe = new CafeDescafeinado();
            cafe = new Crema(cafe);
            cafe = new Edulcorante(cafe);
            cafe = new Canela(cafe);
           

            Console.WriteLine($"Producto:  {cafe.Descripcion} tiene un costo de : {cafe.Costo} Bs");

            Console.ReadKey();
        }
    }
}
