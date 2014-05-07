using System.Collections.Generic;

namespace Prg3_Orquesta
{
    class C_ORQUESTA
    {
        private List<C_CUERDA_INSTRUMENTOS> listCuerda = new List<C_CUERDA_INSTRUMENTOS>();
        private List<C_VIENTO_INSTRUMENTOS> listViento = new List<C_VIENTO_INSTRUMENTOS>();
        private List<C_PERCUSION_INSTRUMENTOS> listPerc = new List<C_PERCUSION_INSTRUMENTOS>();

        public C_ORQUESTA()
        {
            AddInstrumentos();
        }

        public bool AddCuerda(string g,string no,string s, int p, int nu)
        {
            C_CUERDA_INSTRUMENTOS c = new C_CUERDA_INSTRUMENTOS(g, no, s, p, nu);
            if (!listCuerda.Contains(c))
                listCuerda.Add(c);
            else
                return false;
            return true;
        }

        public bool AddViento(string g, string no, string s, int p, int nu)
        {
            C_VIENTO_INSTRUMENTOS v = new C_VIENTO_INSTRUMENTOS(g, no, s, p, nu);
            if (!listViento.Contains(v))
                listViento.Add(v);
            else
                return false;
            return true;
        }

        public bool AddPerc(string g, string no, string s, int p, int nu)
        {
            C_PERCUSION_INSTRUMENTOS pe = new C_PERCUSION_INSTRUMENTOS(g, no, s, p, nu);
            if (!listPerc.Contains(pe))
                listPerc.Add(pe);
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

        public void TocarTodo()
        {
            int i = 0;
            foreach (C_CUERDA_INSTRUMENTOS c in listCuerda)
            {
                i++;
                System.Windows.Forms.MessageBox.Show("Nº: " + i + System.Environment.NewLine + c.Tocar());
            }
            foreach (C_VIENTO_INSTRUMENTOS v in listViento)
            {
                i++;
                System.Windows.Forms.MessageBox.Show("Nº: " + i + System.Environment.NewLine + v.Tocar());
            }
            foreach (C_PERCUSION_INSTRUMENTOS p in listPerc)
            {
                i++;
                System.Windows.Forms.MessageBox.Show("Nº: " + i + System.Environment.NewLine + p.Tocar());
            }
        }

        private void AddInstrumentos()
        {
            ///CUERDA
            ///FORTADA
            ///Violines primeros
            AddCuerda("Frotada", "Violín", "Sonido de Violin", 1, 1);
            AddCuerda("Frotada", "Violín", "Sonido de Violin", 1, 2);
            AddCuerda("Frotada", "Violín", "Sonido de Violin", 1, 3);
            AddCuerda("Frotada", "Violín", "Sonido de Violin", 1, 4);
            AddCuerda("Frotada", "Violín", "Sonido de Violin", 1, 5);
            AddCuerda("Frotada", "Violín", "Sonido de Violin", 1, 6);
            ///Violines segundos
            AddCuerda("Frotada", "Violín", "Sonido de Violin", 2, 1);
            AddCuerda("Frotada", "Violín", "Sonido de Violin", 2, 2);
            AddCuerda("Frotada", "Violín", "Sonido de Violin", 2, 3);
            AddCuerda("Frotada", "Violín", "Sonido de Violin", 2, 4);
            ///Violas
            AddCuerda("Frotada", "Viola", "Sonido de Viola", 3, 1);
            AddCuerda("Frotada", "Viola", "Sonido de Viola", 3, 2);
            AddCuerda("Frotada", "Viola", "Sonido de Viola", 3, 3);
            ///Violonchelos
            AddCuerda("Frotada", "Violonchelo", "Sonido de Violonchelo", 4, 1);
            AddCuerda("Frotada", "Violonchelo", "Sonido de Violonchelo", 4, 2);
            ///Contrabajos
            AddCuerda("Frotada", "Contrabajo", "Sonido de Contrabajo", 5, 1);
            ///PULSADA
            ///Guitarra
            AddCuerda("Pulsada", "Guitarra", "Sonido de Guitarra", 0, 1);
            ///Arpa
            AddCuerda("Pulsada", "Arpa", "Sonido de Arpa", 14, 1);
            ///PERCUTIDA
            ///Piano
            AddCuerda("Percutida", "Piano", "Sonido de Piano", 0, 2);

            ///VIENTO
            ///MADERA
            ///Flauta travesera
            AddViento("Madera", "Flauta travesera", "Sonido de Flauta travesera", 6, 1);
            AddViento("Madera", "Flauta travesera", "Sonido de Flauta travesera", 6, 2);
            ///Clarinetes
            AddViento("Madera", "Clarinete", "Sonido de clarinete", 7, 1);
            AddViento("Madera", "Clarinete", "Sonido de clarinete", 7, 2);
            ///Oboe
            AddViento("Madera", "Oboe", "Sonido de Oboe", 8, 1);
            AddViento("Madera", "Oboe", "Sonido de Oboe", 8, 2);
            ///Fagot
            AddViento("Madera", "Fagot", "Sonido de Fagot", 9, 1);
            AddViento("Madera", "Fagot", "Sonido de Fagot", 9, 2);
            ///Saxofón
            AddViento("Madera", "Saxofón", "Sonido de Saxofón", 0, 3);
            ///Corno inglés
            AddViento("Madera", "Corno inglés", "Sonido de Corno inglés", 0, 4);
            ///METAL
            ///Trompeta
            AddViento("Metal", "Trompeta", "Sonido de Trompeta", 10, 1);
            AddViento("Metal", "Trompeta", "Sonido de Trompeta", 10, 2);
            ///Trombón de varas
            AddViento("Metal", "Trombón de varas", "Sonido de Trombón de varas", 11, 1);
            AddViento("Metal", "Trombón de varas", "Sonido de Trombón de varas", 11, 2);
            ///Tuba
            AddViento("Metal", "Tuba", "Sonido de Tuba", 11, 3);
            AddViento("Metal", "Tuba", "Sonido de Tuba", 11, 4);
            ///Trompa
            AddViento("Metal", "Trompa", "Sonido de Trompa", 12, 1);
            AddViento("Metal", "Trompa", "Sonido de Trompa", 12, 2);

            ///PERCUCION
            ///PERCUCION AFINADA
            ///Timbales
            AddPerc("Afinada", "Timbales", "Sonido de Timbales", 13, 1);
            ///Xilófono
            AddPerc("Afinada", "Xilófono", "Sonido de Xilófono", 13, 2);
            ///Metalófono
            AddPerc("Afinada", "Metalófono", "Sonido de Metalófono", 13, 3);
            ///Marimba
            AddPerc("Afinada", "Marimba", "Sonido de Marimba", 13, 4);
            ///PERCUCION NO AFINADA
            ///Maracas
            AddPerc("No Afinada", "Maracas", "Sonido de Maracas", 13, 5);
            ///Claves
            AddPerc("No Afinada", "Claves", "Sonido de Claves", 13, 6);
            ///Caja china
            AddPerc("No Afinada", "Caja china", "Sonido de Caja china", 13, 7);
            ///Castañuelas
            AddPerc("No Afinada", "Castañuelas", "Sonido de Castañuelas", 13, 8);
            ///Pandereta
            AddPerc("No Afinada", "Pandereta", "Sonido de Pandereta", 13, 9);
            ///Bombo
            AddPerc("No Afinada", "Bombo", "Sonido de Bombo", 13, 10);
            ///Caja
            AddPerc("No Afinada", "Caja", "Sonido de Caja", 13, 11);
        }
    }
}
