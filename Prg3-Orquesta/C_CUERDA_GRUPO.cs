
namespace Prg3_Orquesta
{
    class C_CUERDA_GRUPO:C_CUERDA
    {
        string nombre;

        public C_CUERDA_GRUPO(string n)
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
