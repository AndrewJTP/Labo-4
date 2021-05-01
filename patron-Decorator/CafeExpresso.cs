using System;

namespace patron_Decorator
{
    public class CafeExpresso : BebidaComponent
    {
        public override double Costo => 12;
        public override string Descripcion => "Café expreso";
    }
}
