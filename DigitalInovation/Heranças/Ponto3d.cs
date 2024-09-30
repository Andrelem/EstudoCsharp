using System;

namespace Classes.Herança{
    
    public class Ponto3D : Ponto
    {
        public int z;

        public Ponto3D(int x, int y , int z) : base (x,y)
        {
            this.z = z ;
            Calculardistancia();
        }

        public static void Calcular()
        {
            //faz alguma coisa...
        }

        public override void Calculardistancia3()
        {
            base.Calculardistancia3();
        }
    }
}