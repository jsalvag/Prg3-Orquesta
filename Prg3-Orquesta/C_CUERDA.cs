
namespace Prg3_Orquesta
{
    class C_CUERDA
    {
        string nombre;

        public C_CUERDA()
        {
            this.nombre = "Cuerda";
        }

        public string GetNombreF()
        {
            return this.nombre;
        }

        public virtual string Tocar()
        {
            return this.nombre;
        }
    }
}
