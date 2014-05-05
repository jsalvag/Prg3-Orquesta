using System.Collections.Generic;

namespace Prg3_Orquesta
{
    class C_ORQUESTA
    {
        private List<C_CUERDA_INSTRUMENTOS> listCuerda = new List<C_CUERDA_INSTRUMENTOS>();
        private List<C_VIENTO_INSTRUMENTOS> listViento = new List<C_VIENTO_INSTRUMENTOS>();
        private List<C_PERCUSION_INSTRUMENTOS> listPerc = new List<C_PERCUSION_INSTRUMENTOS>();

        public bool AddCuerda(C_CUERDA_INSTRUMENTOS inst)
        {
            if (!listCuerda.Contains(inst))
                listCuerda.Add(inst);
            else
                return false;
            return true;
        }

        public bool AddViento(C_VIENTO_INSTRUMENTOS inst)
        {
            if (!listViento.Contains(inst))
                listViento.Add(inst);
            else
                return false;
            return true;
        }

        public bool AddPerc(C_PERCUSION_INSTRUMENTOS inst)
        {
            if (!listPerc.Contains(inst))
                listPerc.Add(inst);
            else
                return false;
            return true;
        }

        public List<C_CUERDA_INSTRUMENTOS> GetListCuerda()
        {
            return this.listCuerda;
        }

        public List<C_VIENTO_INSTRUMENTOS> GetListViento()
        {
            return this.listViento;
        }

        public List<C_PERCUSION_INSTRUMENTOS> GetListPerc()
        {
            return this.listPerc;
        }
    }
}
