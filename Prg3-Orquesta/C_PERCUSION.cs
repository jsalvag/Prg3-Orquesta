
namespace Prg3_Orquesta
{
    class C_PERCUSION
    {
        private string nombre;

        public C_PERCUSION()
        {
            this.nombre = "Percusión";
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
