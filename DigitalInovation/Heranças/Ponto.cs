using System;

namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;
        private int distancia;

        public Ponto(int x , int y )
        {
            this.x = x;
            this.y = y;
        }

        protected void Calculardistancia()
        {
            //Alguma coisa...
        }

        private void Calculardistancia2()
        {
            //Alguma coisa...
        }
        public virtual void Calculardistancia3()
        {
            //Alguma coisa...
        }
    }
}