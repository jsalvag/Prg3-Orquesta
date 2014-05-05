using System;
using System.Windows.Forms;

namespace Prg3_Orquesta
{
    public partial class ppl : Form
    {
        C_ORQUESTA orq = new C_ORQUESTA();
        object instrumento;

        string[] datos = new string[8];

        public ppl()
        {
            InitializeComponent();
            pan1.Dock = System.Windows.Forms.DockStyle.Fill;
            pan2.Dock = System.Windows.Forms.DockStyle.Fill;
            AddInstrumentos();
            ClrPan1();
        }

        private void AddInstrumentos()
        {
            ///CUERDA
            ///FORTADA
            ///Violines primeros
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violín", "Sonido de Violin", 1, 1));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violín", "Sonido de Violin", 1, 2));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violín", "Sonido de Violin", 1, 3));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violín", "Sonido de Violin", 1, 4));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violín", "Sonido de Violin", 1, 5));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violín", "Sonido de Violin", 1, 6));
            ///Violines segundos
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violín", "Sonido de Violin", 2, 1));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violín", "Sonido de Violin", 2, 2));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violín", "Sonido de Violin", 2, 3));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violín", "Sonido de Violin", 2, 4));
            ///Violas
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Viola", "Sonido de Viola", 3, 1));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Viola", "Sonido de Viola", 3, 2));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Viola", "Sonido de Viola", 3, 3));
            ///Violonchelos
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violonchelo", "Sonido de Violonchelo", 4, 1));
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Violonchelo", "Sonido de Violonchelo", 4, 2));
            ///Contrabajos
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Frotada", "Contrabajo", "Sonido de Contrabajo", 5, 1));
            ///PULSADA
            ///Guitarra
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Pulsada", "Guitarra", "Sonido de Guitarra", 0, 1));
            ///Arpa
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Pulsada", "Arpa", "Sonido de Arpa", 14, 1));
            ///PERCUTIDA
            ///Piano
            orq.AddCuerda(new C_CUERDA_INSTRUMENTOS("Percutida", "Piano", "Sonido de Piano", 0, 2));

            ///VIENTO
            ///MADERA
            ///Flauta travesera
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Madera", "Flauta travesera", "Sonido de Flauta travesera", 6, 1));
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Madera", "Flauta travesera", "Sonido de Flauta travesera", 6, 2));
            ///Clarinetes
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Madera", "Clarinete", "Sonido de clarinete", 7, 1));
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Madera", "Clarinete", "Sonido de clarinete", 7, 2));
            ///Oboe
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Madera", "Oboe", "Sonido de Oboe", 8, 1));
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Madera", "Oboe", "Sonido de Oboe", 8, 2));
            ///Fagot
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Madera", "Fagot", "Sonido de Fagot", 9, 1));
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Madera", "Fagot", "Sonido de Fagot", 9, 2));
            ///Saxofón
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Madera", "Saxofón", "Sonido de Saxofón", 0, 3));
            ///Corno inglés
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Madera", "Corno inglés", "Sonido de Corno inglés", 0, 4));
            ///METAL
            ///Trompeta
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Metal", "Trompeta", "Sonido de Trompeta", 10, 1));
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Metal", "Trompeta", "Sonido de Trompeta", 10, 2));
            ///Trombón de varas
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Metal", "Trombón de varas", "Sonido de Trombón de varas", 11, 1));
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Metal", "Trombón de varas", "Sonido de Trombón de varas", 11, 2));
            ///Tuba
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Metal", "Tuba", "Sonido de Tuba", 11, 3));
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Metal", "Tuba", "Sonido de Tuba", 11, 4));
            ///Trompa
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Metal", "Trompa", "Sonido de Trompa", 12, 1));
            orq.AddViento(new C_VIENTO_INSTRUMENTOS("Metal", "Trompa", "Sonido de Trompa", 12, 2));
            
            ///PERCUCION
            ///PERCUCION AFINADA
            ///Timbales
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("Afinada", "Timbales", "Sonido de Timbales", 13, 1));
            ///Xilófono
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("Afinada", "Xilófono", "Sonido de Xilófono", 13, 2));
            ///Metalófono
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("Afinada", "Metalófono", "Sonido de Metalófono", 13, 3));
            ///Marimba
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("Afinada", "Marimba", "Sonido de Marimba", 13, 4));
            ///PERCUCION NO AFINADA
            ///Maracas
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("No Afinada", "Maracas", "Sonido de Maracas", 13, 5));
            ///Claves
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("No Afinada", "Claves", "Sonido de Claves", 13, 6));
            ///Caja china
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("No Afinada", "Caja china", "Sonido de Caja china", 13, 7));
            ///Castañuelas
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("No Afinada", "Castañuelas", "Sonido de Castañuelas", 13, 8));
            ///Pandereta
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("No Afinada", "Pandereta", "Sonido de Pandereta", 13, 9));
            ///Bombo
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("No Afinada", "Bombo", "Sonido de Bombo", 13, 10));
            ///Caja
            orq.AddPerc(new C_PERCUSION_INSTRUMENTOS("No Afinada", "Caja", "Sonido de Caja", 13, 11));
        }

        private void ClrPan1()
        {
            familia_cbox.Text = "";
            grupo_cbox.Items.Clear();
            instru_cbox.Items.Clear();
            grupo_cbox.Text = "";
            instru_cbox.Text = "";
            estado_lb.Text = "";
            sonido_btn.Enabled = false;
            afinar_btn.Enabled = false;

            familia_box.Clear();
            grupo_box.Clear();
            nombre_box.Clear();
            pos_box.Clear();
            num_box.Clear();
        }

        private void instru_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            verInstrumento();
        }

        private void verInstrumento()
        {
            instrumento = Instrumento();
            
            familia_box.Text = datos[6];
            grupo_box.Text = datos[7];
            nombre_box.Text = datos[0];
            pos_box.Text = datos[4];
            num_box.Text = datos[5];
            estado_lb.Text = datos[2];

            sonido_btn.Enabled = true;
            afinar_btn.Enabled = true;

            if (instrumento.GetType().Equals(typeof(C_PERCUSION_INSTRUMENTOS)))
            {
                C_PERCUSION_INSTRUMENTOS p = (C_PERCUSION_INSTRUMENTOS)instrumento;
                if (p.GetNombreG() == "No Afinada")
                {
                    estado_lb.Text = "No requiere afinación";
                    afinar_btn.Enabled = false;
                }

            }
        }

        private void familia_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            grupo_cbox.Items.Clear();
            instru_cbox.Items.Clear();
            grupo_cbox.Text = "";
            instru_cbox.Text = "";
            switch (familia_cbox.SelectedIndex)
            {
                case 0:
                    grupo_cbox.Items.Add("Frotada");
                    grupo_cbox.Items.Add("Pulsada");
                    grupo_cbox.Items.Add("Percutida");
                    break;
                case 1:
                    grupo_cbox.Items.Add("Madera");
                    grupo_cbox.Items.Add("Metal");
                    break;
                case 2:
                    grupo_cbox.Items.Add("Afinada");
                    grupo_cbox.Items.Add("No Afinada");
                    break;
            }
        }

        private void listarInstrumentos(string[] d, string op, string c)
        {
            if (c == op)
            {
                instru_cbox.Items.Add(d[0] + " - Posición: " + d[4] + " - Número: " + d[5]);
            }
        }

        private void grupo_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            instru_cbox.Items.Clear();
            instru_cbox.Text = "";
            string op = grupo_cbox.Text;
            switch (op)
            {
                case "Frotada":
                case "Pulsada":
                case "Percutida":
                    foreach (C_CUERDA_INSTRUMENTOS c in orq.GetListCuerda())
                        listarInstrumentos(c.Datos(), op, c.GetNombreG());
                    break;
                case "Madera":
                case "Metal":
                    foreach (C_VIENTO_INSTRUMENTOS c in orq.GetListViento())
                        listarInstrumentos(c.Datos(), op, c.GetNombreG());
                    break;
                case "Afinada":
                case "No Afinada":
                    foreach (C_PERCUSION_INSTRUMENTOS c in orq.GetListPerc())
                        listarInstrumentos(c.Datos(), op, c.GetNombreG());
                    break;
            }
        }

        private object Instrumento()
        {
            object inst = new object();

            string cad = instru_cbox.Text;
            string[] s = cad.Split('-');
            s[0] = s[0].Trim();
            s[1] = s[1].Trim().Split(':')[1].Trim();
            s[2] = s[2].Trim().Split(':')[1].Trim();

            inst = orq.GetListCuerda().Find(x => x.Datos()[0] == s[0] && x.Datos()[4] == s[1] && x.Datos()[5] == s[2]);

            if (inst == null)
            {
                inst = orq.GetListViento().Find(x => x.Datos()[0] == s[0] && x.Datos()[4] == s[1] && x.Datos()[5] == s[2]);
                if (inst != null)
                {
                    C_VIENTO_INSTRUMENTOS v = (C_VIENTO_INSTRUMENTOS)inst;
                    Datos(v.Datos(), v.GetNombreF(), v.GetNombreG());
                }
            }

            if (inst == null)
            {
                inst = orq.GetListPerc().Find(x => x.Datos()[0] == s[0] && x.Datos()[4] == s[1] && x.Datos()[5] == s[2]);
                if (inst != null)
                {
                    C_PERCUSION_INSTRUMENTOS p = (C_PERCUSION_INSTRUMENTOS)inst;

                    Datos(p.Datos(), p.GetNombreF(), p.GetNombreG());
                }
            }

            if (inst.GetType().Equals(typeof(C_CUERDA_INSTRUMENTOS)))
            {
                C_CUERDA_INSTRUMENTOS c = (C_CUERDA_INSTRUMENTOS)inst;
                Datos(c.Datos(), c.GetNombreF(), c.GetNombreG());
            }

                return inst;
        }

        private void sonido_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(datos[1]);
        }

        private void afinar_btn_Click(object sender, EventArgs e)
        {
            if (instrumento.GetType().Equals(typeof(C_CUERDA_INSTRUMENTOS)))
            {
                C_CUERDA_INSTRUMENTOS c = (C_CUERDA_INSTRUMENTOS)instrumento;
                if (c.Afinar())
                    estado_lb.Text = "Afinado";
                else
                    estado_lb.Text = "Desafinado";
                
            }
            else if (instrumento.GetType().Equals(typeof(C_PERCUSION_INSTRUMENTOS)))
            {
                C_PERCUSION_INSTRUMENTOS p = (C_PERCUSION_INSTRUMENTOS)instrumento;
                if (p.Afinar())
                    estado_lb.Text = "Afinado";
                else
                    estado_lb.Text = "Desafinado";

            }
            else if (instrumento.GetType().Equals(typeof(C_VIENTO_INSTRUMENTOS)))
            {
                C_VIENTO_INSTRUMENTOS v = (C_VIENTO_INSTRUMENTOS)instrumento;
                if (v.Afinar())
                    estado_lb.Text = "Afinado";
                else
                    estado_lb.Text = "Desafinado";
            }
        }

        private void tocarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (C_CUERDA_INSTRUMENTOS c in orq.GetListCuerda())
            {
                i++;
                Datos(c.Datos(), c.GetNombreF(), c.GetNombreG());
                MensajeInstrumento(datos, i);
            }
            foreach (C_PERCUSION_INSTRUMENTOS p in orq.GetListPerc())
            {
                i++;
                Datos(p.Datos(), p.GetNombreF(), p.GetNombreG());
                MensajeInstrumento(datos, i);
            }
            foreach (C_VIENTO_INSTRUMENTOS v in orq.GetListViento())
            {
                i++;
                Datos(v.Datos(), v.GetNombreF(), v.GetNombreG());
                MensajeInstrumento(datos, i);
            }
        }

        private void MensajeInstrumento(string[] d,int i)
        {
            MessageBox.Show("Instrumento #"+i+System.Environment.NewLine+
                "Soy el(la) " + d[0] + " Numero #" + d[5] + " de la Posicion " + d[4]+System.Environment.NewLine+
                "Pertenezco al grupo "+d[6]+" "+d[7]+" de la familia "+d[6]);
        }

        private void Datos(string[] d, string f, string g)
        {
            datos[0] = d[0];
            datos[1] = d[1];
            datos[2] = d[2];
            datos[3] = d[3];
            datos[4] = d[4];
            datos[5] = d[5];
            datos[6] = f;
            datos[7] = g;
        }

        private void buscar_sm_Click(object sender, EventArgs e)
        {
            pan1.Show();
            pan2.Hide();
            ClrPan1();
        }

        private void salir_sm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
