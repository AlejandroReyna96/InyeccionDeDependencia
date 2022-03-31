using System;

namespace InyeccionDeDependencia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cerveza cerveza = new Cerveza("Indio", "HEINEKEN MÉXICO");
            BebidaConCerveza bebidaConCerveza = new BebidaConCerveza(10, 2, cerveza);
            bebidaConCerveza.Preparar();
            Console.Read();
            // TU CLASE NO DEBERÍA DEPENDER DE CÓMO CREAR LAS COSAS, SIMPLEMENTE RECIBE LAS COSAS YA HECHAS.
        }
    }
}
