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
            ClrPan1();
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
            if (instrumento.GetType().Equals(typeof(C_CUERDA_INSTRUMENTOS)))
            {
                C_CUERDA_INSTRUMENTOS c = (C_CUERDA_INSTRUMENTOS)instrumento;
                c.Sonar();
            }
            else if (instrumento.GetType().Equals(typeof(C_PERCUSION_INSTRUMENTOS)))
            {
                C_PERCUSION_INSTRUMENTOS p = (C_PERCUSION_INSTRUMENTOS)instrumento;
                p.Sonar();
            }
            else if (instrumento.GetType().Equals(typeof(C_VIENTO_INSTRUMENTOS)))
            {
                C_VIENTO_INSTRUMENTOS v = (C_VIENTO_INSTRUMENTOS)instrumento;
                v.Sonar();
            }
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
            if (MessageBox.Show("A continuación se tocaran todos los instrumentos", "no se que", System.Windows.Forms.MessageBoxButtons.OKCancel)
            != DialogResult.Cancel)
                orq.TocarTodo();
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
