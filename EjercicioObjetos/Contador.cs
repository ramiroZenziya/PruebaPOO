using System;
namespace EjercicioObjetos
{
    public class Contador : IContador
    {
        public int Numero { get; set; }

        public Contador()
        {
            Numero = 0;
        }

        public int MostrarNumero()
        {
            return Numero++;
        }
    }
}
