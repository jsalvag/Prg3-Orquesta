
namespace Prg3_Orquesta
{
    class C_VIENTO
    {
        private string nombre;

        public C_VIENTO()
        {
            this.nombre = "Viento";
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
