namespace Prg3_Orquesta
{
    partial class ppl
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ppl));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.archivo_m = new System.Windows.Forms.ToolStripMenuItem();
            this.salir_sm = new System.Windows.Forms.ToolStripMenuItem();
            this.instru_m = new System.Windows.Forms.ToolStripMenuItem();
            this.buscar_sm = new System.Windows.Forms.ToolStripMenuItem();
            this.tocarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan1 = new System.Windows.Forms.Panel();
            this.num_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pos_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.estado_lb = new System.Windows.Forms.Label();
            this.afinar_btn = new System.Windows.Forms.Button();
            this.sonido_btn = new System.Windows.Forms.Button();
            this.grupo_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.familia_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.instru_cbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grupo_cbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.familia_cbox = new System.Windows.Forms.ComboBox();
            this.pan2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.pan1.SuspendLayout();
            this.pan2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo_m,
            this.instru_m});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menu.Size = new System.Drawing.Size(668, 25);
            this.menu.TabIndex = 0;
            // 
            // archivo_m
            // 
            this.archivo_m.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salir_sm});
            this.archivo_m.Name = "archivo_m";
            this.archivo_m.Size = new System.Drawing.Size(60, 19);
            this.archivo_m.Text = "Archivo";
            // 
            // salir_sm
            // 
            this.salir_sm.Name = "salir_sm";
            this.salir_sm.Size = new System.Drawing.Size(96, 22);
            this.salir_sm.Text = "Salir";
            this.salir_sm.Click += new System.EventHandler(this.salir_sm_Click);
            // 
            // instru_m
            // 
            this.instru_m.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscar_sm,
            this.tocarTodosToolStripMenuItem});
            this.instru_m.Name = "instru_m";
            this.instru_m.Size = new System.Drawing.Size(89, 19);
            this.instru_m.Text = "Instrumentos";
            // 
            // buscar_sm
            // 
            this.buscar_sm.Name = "buscar_sm";
            this.buscar_sm.Size = new System.Drawing.Size(140, 22);
            this.buscar_sm.Text = "Ver";
            this.buscar_sm.Click += new System.EventHandler(this.buscar_sm_Click);
            // 
            // tocarTodosToolStripMenuItem
            // 
            this.tocarTodosToolStripMenuItem.Name = "tocarTodosToolStripMenuItem";
            this.tocarTodosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.tocarTodosToolStripMenuItem.Text = "Tocar Todos";
            this.tocarTodosToolStripMenuItem.Click += new System.EventHandler(this.tocarTodosToolStripMenuItem_Click);
            // 
            // pan1
            // 
            this.pan1.BackColor = System.Drawing.Color.Transparent;
            this.pan1.Controls.Add(this.num_box);
            this.pan1.Controls.Add(this.label7);
            this.pan1.Controls.Add(this.pos_box);
            this.pan1.Controls.Add(this.label8);
            this.pan1.Controls.Add(this.estado_lb);
            this.pan1.Controls.Add(this.afinar_btn);
            this.pan1.Controls.Add(this.sonido_btn);
            this.pan1.Controls.Add(this.grupo_box);
            this.pan1.Controls.Add(this.label6);
            this.pan1.Controls.Add(this.familia_box);
            this.pan1.Controls.Add(this.label5);
            this.pan1.Controls.Add(this.nombre_box);
            this.pan1.Controls.Add(this.label4);
            this.pan1.Controls.Add(this.label3);
            this.pan1.Controls.Add(this.instru_cbox);
            this.pan1.Controls.Add(this.label2);
            this.pan1.Controls.Add(this.grupo_cbox);
            this.pan1.Controls.Add(this.label1);
            this.pan1.Controls.Add(this.familia_cbox);
            this.pan1.Location = new System.Drawing.Point(0, 30);
            this.pan1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pan1.Name = "pan1";
            this.pan1.Size = new System.Drawing.Size(668, 295);
            this.pan1.TabIndex = 1;
            this.pan1.Visible = false;
            // 
            // num_box
            // 
            this.num_box.Enabled = false;
            this.num_box.Location = new System.Drawing.Point(88, 256);
            this.num_box.Name = "num_box";
            this.num_box.Size = new System.Drawing.Size(191, 26);
            this.num_box.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Número:";
            // 
            // pos_box
            // 
            this.pos_box.Enabled = false;
            this.pos_box.Location = new System.Drawing.Point(88, 224);
            this.pos_box.Name = "pos_box";
            this.pos_box.Size = new System.Drawing.Size(191, 26);
            this.pos_box.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Posición:";
            // 
            // estado_lb
            // 
            this.estado_lb.AutoSize = true;
            this.estado_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_lb.ForeColor = System.Drawing.SystemColors.Info;
            this.estado_lb.Location = new System.Drawing.Point(285, 195);
            this.estado_lb.Name = "estado_lb";
            this.estado_lb.Size = new System.Drawing.Size(64, 20);
            this.estado_lb.TabIndex = 14;
            this.estado_lb.Text = "estado";
            // 
            // afinar_btn
            // 
            this.afinar_btn.Enabled = false;
            this.afinar_btn.Location = new System.Drawing.Point(286, 159);
            this.afinar_btn.Name = "afinar_btn";
            this.afinar_btn.Size = new System.Drawing.Size(75, 27);
            this.afinar_btn.TabIndex = 13;
            this.afinar_btn.Text = "Afinar";
            this.afinar_btn.UseVisualStyleBackColor = true;
            this.afinar_btn.Click += new System.EventHandler(this.afinar_btn_Click);
            // 
            // sonido_btn
            // 
            this.sonido_btn.Enabled = false;
            this.sonido_btn.Location = new System.Drawing.Point(286, 127);
            this.sonido_btn.Name = "sonido_btn";
            this.sonido_btn.Size = new System.Drawing.Size(75, 27);
            this.sonido_btn.TabIndex = 12;
            this.sonido_btn.Text = "Sonido";
            this.sonido_btn.UseVisualStyleBackColor = true;
            this.sonido_btn.Click += new System.EventHandler(this.sonido_btn_Click);
            // 
            // grupo_box
            // 
            this.grupo_box.Enabled = false;
            this.grupo_box.Location = new System.Drawing.Point(88, 160);
            this.grupo_box.Name = "grupo_box";
            this.grupo_box.Size = new System.Drawing.Size(191, 26);
            this.grupo_box.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(19, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Grupo:";
            // 
            // familia_box
            // 
            this.familia_box.Enabled = false;
            this.familia_box.Location = new System.Drawing.Point(88, 128);
            this.familia_box.Name = "familia_box";
            this.familia_box.Size = new System.Drawing.Size(191, 26);
            this.familia_box.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(14, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Familia:";
            // 
            // nombre_box
            // 
            this.nombre_box.Enabled = false;
            this.nombre_box.Location = new System.Drawing.Point(88, 192);
            this.nombre_box.Name = "nombre_box";
            this.nombre_box.Size = new System.Drawing.Size(191, 26);
            this.nombre_box.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(8, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(95, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seleccione el Instrumento:";
            // 
            // instru_cbox
            // 
            this.instru_cbox.FormattingEnabled = true;
            this.instru_cbox.Location = new System.Drawing.Point(326, 81);
            this.instru_cbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.instru_cbox.Name = "instru_cbox";
            this.instru_cbox.Size = new System.Drawing.Size(333, 28);
            this.instru_cbox.TabIndex = 4;
            this.instru_cbox.SelectedIndexChanged += new System.EventHandler(this.instru_cbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seleccione el Grupo del Instrumento:";
            // 
            // grupo_cbox
            // 
            this.grupo_cbox.FormattingEnabled = true;
            this.grupo_cbox.Items.AddRange(new object[] {
            "Todos"});
            this.grupo_cbox.Location = new System.Drawing.Point(326, 43);
            this.grupo_cbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grupo_cbox.Name = "grupo_cbox";
            this.grupo_cbox.Size = new System.Drawing.Size(333, 28);
            this.grupo_cbox.TabIndex = 2;
            this.grupo_cbox.SelectedIndexChanged += new System.EventHandler(this.grupo_cbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione la Familia del Instrumento:";
            // 
            // familia_cbox
            // 
            this.familia_cbox.FormattingEnabled = true;
            this.familia_cbox.Items.AddRange(new object[] {
            "Cuerda",
            "Viento",
            "Percución"});
            this.familia_cbox.Location = new System.Drawing.Point(326, 5);
            this.familia_cbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.familia_cbox.Name = "familia_cbox";
            this.familia_cbox.Size = new System.Drawing.Size(333, 28);
            this.familia_cbox.TabIndex = 0;
            this.familia_cbox.SelectedIndexChanged += new System.EventHandler(this.familia_cbox_SelectedIndexChanged);
            // 
            // pan2
            // 
            this.pan2.BackColor = System.Drawing.Color.Transparent;
            this.pan2.Controls.Add(this.label13);
            this.pan2.Controls.Add(this.label12);
            this.pan2.Controls.Add(this.label11);
            this.pan2.Controls.Add(this.label10);
            this.pan2.Controls.Add(this.label9);
            this.pan2.Location = new System.Drawing.Point(0, 333);
            this.pan2.Name = "pan2";
            this.pan2.Size = new System.Drawing.Size(668, 385);
            this.pan2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(200, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(268, 29);
            this.label13.TabIndex = 4;
            this.label13.Text = "Prueba de Instrumentos";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(197, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(275, 73);
            this.label12.TabIndex = 3;
            this.label12.Text = "Musipán";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(277, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 73);
            this.label11.TabIndex = 2;
            this.label11.Text = "De";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(135, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(399, 73);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fialarmónica";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(186, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 73);
            this.label9.TabIndex = 0;
            this.label9.Text = "Orquesta";
            // 
            // ppl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(668, 410);
            this.Controls.Add(this.pan2);
            this.Controls.Add(this.pan1);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ppl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orquesta";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            this.pan2.ResumeLayout(false);
            this.pan2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem archivo_m;
        private System.Windows.Forms.ToolStripMenuItem salir_sm;
        private System.Windows.Forms.ToolStripMenuItem instru_m;
        private System.Windows.Forms.ToolStripMenuItem buscar_sm;
        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox familia_cbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox grupo_cbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox instru_cbox;
        private System.Windows.Forms.TextBox nombre_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox grupo_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox familia_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sonido_btn;
        private System.Windows.Forms.TextBox pos_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label estado_lb;
        private System.Windows.Forms.Button afinar_btn;
        private System.Windows.Forms.TextBox num_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pan2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem tocarTodosToolStripMenuItem;
    }
}

