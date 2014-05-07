
namespace Prg3_Orquesta
{
    class C_PERCUSION_GRUPO:C_PERCUSION
    {
        private string nombre;

        public C_PERCUSION_GRUPO(string n)
            : base()
        {
            this.nombre = n;
        }

        public string GetNombreG()
        {
            return this.nombre;
        }

        public override string Tocar()
        {
            return base.Tocar() + System.Environment.NewLine
                + "Grupo " + this.nombre;
        }
    }
}
