
namespace Ahorcado
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_a = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_x = new System.Windows.Forms.Button();
            this.bt_w = new System.Windows.Forms.Button();
            this.bt_v = new System.Windows.Forms.Button();
            this.bt_u = new System.Windows.Forms.Button();
            this.bt_t = new System.Windows.Forms.Button();
            this.bt_z = new System.Windows.Forms.Button();
            this.bt_y = new System.Windows.Forms.Button();
            this.bt_s = new System.Windows.Forms.Button();
            this.bt_r = new System.Windows.Forms.Button();
            this.bt_q = new System.Windows.Forms.Button();
            this.bt_p = new System.Windows.Forms.Button();
            this.bt_o = new System.Windows.Forms.Button();
            this.bt_ñ = new System.Windows.Forms.Button();
            this.bt_n = new System.Windows.Forms.Button();
            this.bt_m = new System.Windows.Forms.Button();
            this.bt_l = new System.Windows.Forms.Button();
            this.bt_k = new System.Windows.Forms.Button();
            this.bt_j = new System.Windows.Forms.Button();
            this.bt_i = new System.Windows.Forms.Button();
            this.bt_h = new System.Windows.Forms.Button();
            this.bt_g = new System.Windows.Forms.Button();
            this.bt_f = new System.Windows.Forms.Button();
            this.bt_e = new System.Windows.Forms.Button();
            this.bt_d = new System.Windows.Forms.Button();
            this.bt_c = new System.Windows.Forms.Button();
            this.bt_b = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button26 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Iniciar Juego";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.IniciarJuego_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Pedir Pista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PedirPista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "El número de pistas restantes es: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "El número de intentos fallidos es: ";
            // 
            // bt_a
            // 
            this.bt_a.Location = new System.Drawing.Point(6, 13);
            this.bt_a.Name = "bt_a";
            this.bt_a.Size = new System.Drawing.Size(43, 26);
            this.bt_a.TabIndex = 5;
            this.bt_a.Text = "A";
            this.bt_a.UseVisualStyleBackColor = true;
            this.bt_a.Click += new System.EventHandler(this.bt_click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_x);
            this.groupBox1.Controls.Add(this.bt_w);
            this.groupBox1.Controls.Add(this.bt_v);
            this.groupBox1.Controls.Add(this.bt_u);
            this.groupBox1.Controls.Add(this.bt_t);
            this.groupBox1.Controls.Add(this.bt_z);
            this.groupBox1.Controls.Add(this.bt_y);
            this.groupBox1.Controls.Add(this.bt_s);
            this.groupBox1.Controls.Add(this.bt_r);
            this.groupBox1.Controls.Add(this.bt_q);
            this.groupBox1.Controls.Add(this.bt_p);
            this.groupBox1.Controls.Add(this.bt_o);
            this.groupBox1.Controls.Add(this.bt_ñ);
            this.groupBox1.Controls.Add(this.bt_n);
            this.groupBox1.Controls.Add(this.bt_m);
            this.groupBox1.Controls.Add(this.bt_l);
            this.groupBox1.Controls.Add(this.bt_k);
            this.groupBox1.Controls.Add(this.bt_j);
            this.groupBox1.Controls.Add(this.bt_i);
            this.groupBox1.Controls.Add(this.bt_h);
            this.groupBox1.Controls.Add(this.bt_g);
            this.groupBox1.Controls.Add(this.bt_f);
            this.groupBox1.Controls.Add(this.bt_e);
            this.groupBox1.Controls.Add(this.bt_d);
            this.groupBox1.Controls.Add(this.bt_c);
            this.groupBox1.Controls.Add(this.bt_b);
            this.groupBox1.Controls.Add(this.bt_a);
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 208);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teclado";
            // 
            // bt_x
            // 
            this.bt_x.Location = new System.Drawing.Point(202, 141);
            this.bt_x.Name = "bt_x";
            this.bt_x.Size = new System.Drawing.Size(43, 26);
            this.bt_x.TabIndex = 37;
            this.bt_x.Text = "X";
            this.bt_x.UseVisualStyleBackColor = true;
            this.bt_x.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_w
            // 
            this.bt_w.Location = new System.Drawing.Point(153, 141);
            this.bt_w.Name = "bt_w";
            this.bt_w.Size = new System.Drawing.Size(43, 26);
            this.bt_w.TabIndex = 36;
            this.bt_w.Text = "W";
            this.bt_w.UseVisualStyleBackColor = true;
            this.bt_w.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_v
            // 
            this.bt_v.Location = new System.Drawing.Point(104, 141);
            this.bt_v.Name = "bt_v";
            this.bt_v.Size = new System.Drawing.Size(43, 26);
            this.bt_v.TabIndex = 35;
            this.bt_v.Text = "V";
            this.bt_v.UseVisualStyleBackColor = true;
            this.bt_v.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_u
            // 
            this.bt_u.Location = new System.Drawing.Point(55, 141);
            this.bt_u.Name = "bt_u";
            this.bt_u.Size = new System.Drawing.Size(43, 26);
            this.bt_u.TabIndex = 34;
            this.bt_u.Text = "U";
            this.bt_u.UseVisualStyleBackColor = true;
            this.bt_u.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_t
            // 
            this.bt_t.Location = new System.Drawing.Point(6, 141);
            this.bt_t.Name = "bt_t";
            this.bt_t.Size = new System.Drawing.Size(43, 26);
            this.bt_t.TabIndex = 33;
            this.bt_t.Text = "T";
            this.bt_t.UseVisualStyleBackColor = true;
            this.bt_t.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_z
            // 
            this.bt_z.Location = new System.Drawing.Point(55, 173);
            this.bt_z.Name = "bt_z";
            this.bt_z.Size = new System.Drawing.Size(43, 26);
            this.bt_z.TabIndex = 32;
            this.bt_z.Text = "Z";
            this.bt_z.UseVisualStyleBackColor = true;
            this.bt_z.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_y
            // 
            this.bt_y.Location = new System.Drawing.Point(6, 173);
            this.bt_y.Name = "bt_y";
            this.bt_y.Size = new System.Drawing.Size(43, 26);
            this.bt_y.TabIndex = 31;
            this.bt_y.Text = "Y";
            this.bt_y.UseVisualStyleBackColor = true;
            this.bt_y.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_s
            // 
            this.bt_s.Location = new System.Drawing.Point(202, 109);
            this.bt_s.Name = "bt_s";
            this.bt_s.Size = new System.Drawing.Size(43, 26);
            this.bt_s.TabIndex = 27;
            this.bt_s.Text = "S";
            this.bt_s.UseVisualStyleBackColor = true;
            this.bt_s.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_r
            // 
            this.bt_r.Location = new System.Drawing.Point(153, 109);
            this.bt_r.Name = "bt_r";
            this.bt_r.Size = new System.Drawing.Size(43, 26);
            this.bt_r.TabIndex = 26;
            this.bt_r.Text = "R";
            this.bt_r.UseVisualStyleBackColor = true;
            this.bt_r.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_q
            // 
            this.bt_q.Location = new System.Drawing.Point(104, 109);
            this.bt_q.Name = "bt_q";
            this.bt_q.Size = new System.Drawing.Size(43, 26);
            this.bt_q.TabIndex = 25;
            this.bt_q.Text = "Q";
            this.bt_q.UseVisualStyleBackColor = true;
            this.bt_q.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_p
            // 
            this.bt_p.Location = new System.Drawing.Point(55, 109);
            this.bt_p.Name = "bt_p";
            this.bt_p.Size = new System.Drawing.Size(43, 26);
            this.bt_p.TabIndex = 24;
            this.bt_p.Text = "P";
            this.bt_p.UseVisualStyleBackColor = true;
            this.bt_p.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_o
            // 
            this.bt_o.Location = new System.Drawing.Point(6, 109);
            this.bt_o.Name = "bt_o";
            this.bt_o.Size = new System.Drawing.Size(43, 26);
            this.bt_o.TabIndex = 23;
            this.bt_o.Text = "O";
            this.bt_o.UseVisualStyleBackColor = true;
            this.bt_o.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_ñ
            // 
            this.bt_ñ.Location = new System.Drawing.Point(202, 77);
            this.bt_ñ.Name = "bt_ñ";
            this.bt_ñ.Size = new System.Drawing.Size(43, 26);
            this.bt_ñ.TabIndex = 21;
            this.bt_ñ.Text = "Ñ";
            this.bt_ñ.UseVisualStyleBackColor = true;
            this.bt_ñ.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_n
            // 
            this.bt_n.Location = new System.Drawing.Point(153, 77);
            this.bt_n.Name = "bt_n";
            this.bt_n.Size = new System.Drawing.Size(43, 26);
            this.bt_n.TabIndex = 20;
            this.bt_n.Text = "N";
            this.bt_n.UseVisualStyleBackColor = true;
            this.bt_n.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_m
            // 
            this.bt_m.Location = new System.Drawing.Point(104, 77);
            this.bt_m.Name = "bt_m";
            this.bt_m.Size = new System.Drawing.Size(43, 26);
            this.bt_m.TabIndex = 19;
            this.bt_m.Text = "M";
            this.bt_m.UseVisualStyleBackColor = true;
            this.bt_m.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_l
            // 
            this.bt_l.Location = new System.Drawing.Point(55, 77);
            this.bt_l.Name = "bt_l";
            this.bt_l.Size = new System.Drawing.Size(43, 26);
            this.bt_l.TabIndex = 18;
            this.bt_l.Text = "L";
            this.bt_l.UseVisualStyleBackColor = true;
            this.bt_l.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_k
            // 
            this.bt_k.Location = new System.Drawing.Point(6, 77);
            this.bt_k.Name = "bt_k";
            this.bt_k.Size = new System.Drawing.Size(43, 26);
            this.bt_k.TabIndex = 17;
            this.bt_k.Text = "K";
            this.bt_k.UseVisualStyleBackColor = true;
            this.bt_k.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_j
            // 
            this.bt_j.Location = new System.Drawing.Point(202, 45);
            this.bt_j.Name = "bt_j";
            this.bt_j.Size = new System.Drawing.Size(43, 26);
            this.bt_j.TabIndex = 15;
            this.bt_j.Text = "J";
            this.bt_j.UseVisualStyleBackColor = true;
            this.bt_j.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_i
            // 
            this.bt_i.Location = new System.Drawing.Point(153, 45);
            this.bt_i.Name = "bt_i";
            this.bt_i.Size = new System.Drawing.Size(43, 26);
            this.bt_i.TabIndex = 14;
            this.bt_i.Text = "I";
            this.bt_i.UseVisualStyleBackColor = true;
            this.bt_i.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_h
            // 
            this.bt_h.Location = new System.Drawing.Point(104, 45);
            this.bt_h.Name = "bt_h";
            this.bt_h.Size = new System.Drawing.Size(43, 26);
            this.bt_h.TabIndex = 13;
            this.bt_h.Text = "H";
            this.bt_h.UseVisualStyleBackColor = true;
            this.bt_h.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_g
            // 
            this.bt_g.Location = new System.Drawing.Point(55, 45);
            this.bt_g.Name = "bt_g";
            this.bt_g.Size = new System.Drawing.Size(43, 26);
            this.bt_g.TabIndex = 12;
            this.bt_g.Text = "G";
            this.bt_g.UseVisualStyleBackColor = true;
            this.bt_g.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_f
            // 
            this.bt_f.Location = new System.Drawing.Point(6, 45);
            this.bt_f.Name = "bt_f";
            this.bt_f.Size = new System.Drawing.Size(43, 26);
            this.bt_f.TabIndex = 11;
            this.bt_f.Text = "F";
            this.bt_f.UseVisualStyleBackColor = true;
            this.bt_f.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_e
            // 
            this.bt_e.Location = new System.Drawing.Point(202, 13);
            this.bt_e.Name = "bt_e";
            this.bt_e.Size = new System.Drawing.Size(43, 26);
            this.bt_e.TabIndex = 9;
            this.bt_e.Text = "E";
            this.bt_e.UseVisualStyleBackColor = true;
            this.bt_e.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_d
            // 
            this.bt_d.Location = new System.Drawing.Point(153, 13);
            this.bt_d.Name = "bt_d";
            this.bt_d.Size = new System.Drawing.Size(43, 26);
            this.bt_d.TabIndex = 8;
            this.bt_d.Text = "D";
            this.bt_d.UseVisualStyleBackColor = true;
            this.bt_d.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_c
            // 
            this.bt_c.Location = new System.Drawing.Point(104, 13);
            this.bt_c.Name = "bt_c";
            this.bt_c.Size = new System.Drawing.Size(43, 26);
            this.bt_c.TabIndex = 7;
            this.bt_c.Text = "C";
            this.bt_c.UseVisualStyleBackColor = true;
            this.bt_c.Click += new System.EventHandler(this.bt_click);
            // 
            // bt_b
            // 
            this.bt_b.Location = new System.Drawing.Point(56, 12);
            this.bt_b.Name = "bt_b";
            this.bt_b.Size = new System.Drawing.Size(43, 26);
            this.bt_b.TabIndex = 6;
            this.bt_b.Text = "B";
            this.bt_b.UseVisualStyleBackColor = true;
            this.bt_b.Click += new System.EventHandler(this.bt_click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button26);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 151);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(6, 87);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(243, 48);
            this.button26.TabIndex = 34;
            this.button26.Text = "Resolver";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.Resolver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(8, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 43);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Palabra Secreta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ahorcado.Properties.Resources.ah_0;
            this.pictureBox1.Location = new System.Drawing.Point(273, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 492);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "El ahorcado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_a;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_s;
        private System.Windows.Forms.Button bt_r;
        private System.Windows.Forms.Button bt_q;
        private System.Windows.Forms.Button bt_p;
        private System.Windows.Forms.Button bt_o;
        private System.Windows.Forms.Button bt_ñ;
        private System.Windows.Forms.Button bt_n;
        private System.Windows.Forms.Button bt_m;
        private System.Windows.Forms.Button bt_l;
        private System.Windows.Forms.Button bt_k;
        private System.Windows.Forms.Button bt_j;
        private System.Windows.Forms.Button bt_i;
        private System.Windows.Forms.Button bt_h;
        private System.Windows.Forms.Button bt_g;
        private System.Windows.Forms.Button bt_f;
        private System.Windows.Forms.Button bt_e;
        private System.Windows.Forms.Button bt_d;
        private System.Windows.Forms.Button bt_c;
        private System.Windows.Forms.Button bt_b;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_x;
        private System.Windows.Forms.Button bt_w;
        private System.Windows.Forms.Button bt_v;
        private System.Windows.Forms.Button bt_u;
        private System.Windows.Forms.Button bt_t;
        private System.Windows.Forms.Button bt_z;
        private System.Windows.Forms.Button bt_y;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

