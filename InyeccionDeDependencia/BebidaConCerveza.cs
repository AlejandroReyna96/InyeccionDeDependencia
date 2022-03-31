using System;

namespace InyeccionDeDependencia
{
    public class BebidaConCerveza
    {
        // qué es internal class?

        // Esto es lo que está mal, esta clase no debe tener la responsabilidad de crear el objeto, ni saber como se crea, solo debe recibir el objeto como tal.
        //private Cerveza Cerveza = new Cerveza("Pikantus", "Erdiger");

        private Cerveza cerveza;
        private decimal dAgua;
        private decimal dAzucar;

        public BebidaConCerveza(decimal _dAgua, decimal _dAzucar, Cerveza _cerveza) // Se inyecta, solo se recibe.
        {
            dAgua = _dAgua;
            dAzucar = _dAzucar;
            cerveza = _cerveza;
        }

        public void Preparar()
        {
            Console.WriteLine($"Preparamos bebida que tiene agua {dAgua} , azúcar {dAzucar} y Cerveza {cerveza.Nombre}");
        }
    }
}
