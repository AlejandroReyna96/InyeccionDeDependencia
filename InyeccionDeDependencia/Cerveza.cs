namespace InyeccionDeDependencia
{
    public  class Cerveza
    {
        private string cnombre;
        private string cmarca;

        public string Nombre {
            get { return cnombre; }
        }

        public Cerveza(string _cnombre, string _cmarca)
        {
            cnombre = _cnombre;
            cmarca = _cmarca;
        }
    }
}
