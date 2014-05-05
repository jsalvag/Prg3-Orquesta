
namespace Prg3_Orquesta
{
    class C_VIENTO_GRUPO:C_VIENTO
    {
        private string nombre;

        public C_VIENTO_GRUPO(string n)
            : base()
        {
            this.nombre = n;
        }

        public string GetNombreG()
        {
            return this.nombre;
        }
    }
}
