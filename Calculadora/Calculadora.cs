namespace esCalculadora {
    class Calculadora
    {
        private double dato;
        public Calculadora(double dato=0)
        {
            this.dato = dato;
        }

        public double Resultado { get => dato;}

        public void Sumar(double termino)
        {
            dato += termino; 
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }
        public void Multiplicar(double termino)
        {
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
            }else
            {
                Console.WriteLine("No se puede hacer la operacion en 0");
            };
        }
        public void Limpiar(double termino)
        {
            dato = 0;
        }

    }
}