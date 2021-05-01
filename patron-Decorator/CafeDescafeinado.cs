using System;

namespace patron_Decorator
{
    public class CafeDescafeinado : BebidaComponent
    {
        public override double Costo => 15;
        public override string Descripcion => "Café descafeinado";
    }
}
