using System;

namespace Prg3_Orquesta
{
    class C_CUERDA_INSTRUMENTOS:C_CUERDA_GRUPO,IEquatable<C_CUERDA_INSTRUMENTOS>
    {
        private string nombre;
        private string sonido;
        private bool afinado;
        private int
            afinacion,
            estado,
            intento,
            posicion,
            numero;

        public C_CUERDA_INSTRUMENTOS(string nomGrupo, string nomInst, string son, int pos, int num)
            : base(nomGrupo)
        {
            this.nombre = nomInst;
            this.sonido = son;
            this.afinacion = 1;
            this.estado = new Random().Next(10);
            this.afinado = false;
            this.posicion = pos;
            this.numero = num;
            this.intento = 0;
        }

        public string[] Datos()
        {
            string[] d = new string[6];
            d[0] = this.nombre;
            d[1] = this.sonido;
            d[2] = this.afinado ? "Afinado" : "Desafinado";
            d[3] = Convert.ToString(this.estado);
            d[4] = Convert.ToString(this.posicion);
            d[5] = Convert.ToString(this.numero);

            return d;
        }

        public bool Afinar()
        {
            intento++;
            if(intento>5)
                this.estado=afinacion;
            if (afinacion == estado)
            {
                this.afinado = true;
                return true;
            }
            this.estado = new Random().Next(10);
            return false;
        }

        public bool Equals(C_CUERDA_INSTRUMENTOS other)
        {
            if (other.nombre == this.nombre && other.numero == this.numero && other.posicion == this.posicion)
                return true;
            return false;
        }

        public new string Tocar()
        {
            return "Sonido de un(a) " + this.nombre + " #" + this.numero + " Posición: " + this.posicion + System.Environment.NewLine
                + "Familia " + base.Tocar();
        }

        public void Sonar()
        {
            System.Windows.Forms.MessageBox.Show("Sonido de " + this.nombre);
        }
    }
}
