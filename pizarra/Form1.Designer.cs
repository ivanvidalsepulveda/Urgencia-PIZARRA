﻿namespace pizarra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totaln = new System.Windows.Forms.Label();
            this.totala = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.hora = new System.Windows.Forms.Label();
            this.cargar = new System.Windows.Forms.Button();
            this.scn = new System.Windows.Forms.Label();
            this.sca = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.c5n = new System.Windows.Forms.Label();
            this.c4n = new System.Windows.Forms.Label();
            this.c3n = new System.Windows.Forms.Label();
            this.c2n = new System.Windows.Forms.Label();
            this.c5a = new System.Windows.Forms.Label();
            this.c4a = new System.Windows.Forms.Label();
            this.c3a = new System.Windows.Forms.Label();
            this.c2a = new System.Windows.Forms.Label();
            this.enTotal = new System.Windows.Forms.Label();
            this.enAtencion = new System.Windows.Forms.Label();
            this.enEspera = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(219)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "PACIENTES EN SERVICIO URGENCIA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(219)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(758, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 83);
            this.label2.TabIndex = 1;
            this.label2.Text = "EN ESPERA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.totaln);
            this.panel1.Controls.Add(this.totala);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.scn);
            this.panel1.Controls.Add(this.sca);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.c5n);
            this.panel1.Controls.Add(this.c4n);
            this.panel1.Controls.Add(this.c3n);
            this.panel1.Controls.Add(this.c2n);
            this.panel1.Controls.Add(this.c5a);
            this.panel1.Controls.Add(this.c4a);
            this.panel1.Controls.Add(this.c3a);
            this.panel1.Controls.Add(this.c2a);
            this.panel1.Controls.Add(this.enTotal);
            this.panel1.Controls.Add(this.enAtencion);
            this.panel1.Controls.Add(this.enEspera);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1598, 876);
            this.panel1.TabIndex = 2;
            // 
            // totaln
            // 
            this.totaln.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.totaln.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totaln.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaln.Location = new System.Drawing.Point(1454, 713);
            this.totaln.Name = "totaln";
            this.totaln.Size = new System.Drawing.Size(135, 83);
            this.totaln.TabIndex = 36;
            this.totaln.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totala
            // 
            this.totala.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.totala.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totala.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totala.Location = new System.Drawing.Point(1454, 650);
            this.totala.Name = "totala";
            this.totala.Size = new System.Drawing.Size(135, 83);
            this.totala.TabIndex = 35;
            this.totala.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label18.BackColor = System.Drawing.Color.SlateGray;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1441, 501);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 83);
            this.label18.TabIndex = 34;
            this.label18.Text = "TOTAL";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1158, 836);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(439, 36);
            this.label9.TabIndex = 33;
            this.label9.Text = "* Pacientes aún sin Categoria.";
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = "";
            this.panel2.AccessibleName = "";
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(8)))), ((int)(((byte)(17)))));
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.fecha);
            this.panel2.Controls.Add(this.hora);
            this.panel2.Controls.Add(this.cargar);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(14, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1581, 64);
            this.panel2.TabIndex = 18;
            this.panel2.Tag = "";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(640, 64);
            this.label16.TabIndex = 0;
            this.label16.Text = "INFORMACIÓN AL PACIENTE";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fecha
            // 
            this.fecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fecha.BackColor = System.Drawing.Color.Transparent;
            this.fecha.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(730, -3);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(845, 64);
            this.fecha.TabIndex = 33;
            this.fecha.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // hora
            // 
            this.hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hora.BackColor = System.Drawing.Color.Transparent;
            this.hora.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.Color.White;
            this.hora.Location = new System.Drawing.Point(587, 0);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(159, 64);
            this.hora.TabIndex = 34;
            this.hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cargar
            // 
            this.cargar.BackColor = System.Drawing.Color.Transparent;
            this.cargar.ForeColor = System.Drawing.Color.Transparent;
            this.cargar.Location = new System.Drawing.Point(14, 21);
            this.cargar.Name = "cargar";
            this.cargar.Size = new System.Drawing.Size(75, 23);
            this.cargar.TabIndex = 1;
            this.cargar.UseVisualStyleBackColor = false;
            this.cargar.Click += new System.EventHandler(this.cargar_Click);
            // 
            // scn
            // 
            this.scn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.scn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.scn.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scn.Location = new System.Drawing.Point(1405, 713);
            this.scn.Name = "scn";
            this.scn.Size = new System.Drawing.Size(135, 83);
            this.scn.TabIndex = 32;
            this.scn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sca
            // 
            this.sca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sca.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sca.Location = new System.Drawing.Point(1405, 650);
            this.sca.Name = "sca";
            this.sca.Size = new System.Drawing.Size(135, 83);
            this.sca.TabIndex = 31;
            this.sca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.BackColor = System.Drawing.Color.SlateGray;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(1401, 501);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 83);
            this.label17.TabIndex = 30;
            this.label17.Text = "*S/C";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c5n
            // 
            this.c5n.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.c5n.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c5n.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c5n.Location = new System.Drawing.Point(1239, 713);
            this.c5n.Name = "c5n";
            this.c5n.Size = new System.Drawing.Size(135, 83);
            this.c5n.TabIndex = 29;
            this.c5n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c4n
            // 
            this.c4n.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.c4n.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c4n.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4n.Location = new System.Drawing.Point(1073, 713);
            this.c4n.Name = "c4n";
            this.c4n.Size = new System.Drawing.Size(135, 83);
            this.c4n.TabIndex = 28;
            this.c4n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c3n
            // 
            this.c3n.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.c3n.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c3n.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3n.Location = new System.Drawing.Point(914, 713);
            this.c3n.Name = "c3n";
            this.c3n.Size = new System.Drawing.Size(135, 83);
            this.c3n.TabIndex = 27;
            this.c3n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2n
            // 
            this.c2n.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.c2n.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c2n.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2n.Location = new System.Drawing.Point(755, 713);
            this.c2n.Name = "c2n";
            this.c2n.Size = new System.Drawing.Size(135, 83);
            this.c2n.TabIndex = 26;
            this.c2n.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c5a
            // 
            this.c5a.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c5a.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c5a.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c5a.Location = new System.Drawing.Point(1239, 650);
            this.c5a.Name = "c5a";
            this.c5a.Size = new System.Drawing.Size(135, 83);
            this.c5a.TabIndex = 25;
            this.c5a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c4a
            // 
            this.c4a.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c4a.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c4a.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c4a.Location = new System.Drawing.Point(1073, 650);
            this.c4a.Name = "c4a";
            this.c4a.Size = new System.Drawing.Size(135, 83);
            this.c4a.TabIndex = 24;
            this.c4a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c3a
            // 
            this.c3a.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c3a.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c3a.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3a.Location = new System.Drawing.Point(914, 650);
            this.c3a.Name = "c3a";
            this.c3a.Size = new System.Drawing.Size(135, 83);
            this.c3a.TabIndex = 23;
            this.c3a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c2a
            // 
            this.c2a.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.c2a.BackColor = System.Drawing.Color.WhiteSmoke;
            this.c2a.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2a.Location = new System.Drawing.Point(755, 659);
            this.c2a.Name = "c2a";
            this.c2a.Size = new System.Drawing.Size(135, 83);
            this.c2a.TabIndex = 22;
            this.c2a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enTotal
            // 
            this.enTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enTotal.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enTotal.Location = new System.Drawing.Point(1164, 384);
            this.enTotal.Name = "enTotal";
            this.enTotal.Size = new System.Drawing.Size(212, 83);
            this.enTotal.TabIndex = 21;
            this.enTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enAtencion
            // 
            this.enAtencion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enAtencion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enAtencion.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enAtencion.Location = new System.Drawing.Point(1054, 384);
            this.enAtencion.Name = "enAtencion";
            this.enAtencion.Size = new System.Drawing.Size(212, 83);
            this.enAtencion.TabIndex = 20;
            this.enAtencion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enEspera
            // 
            this.enEspera.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enEspera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.enEspera.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enEspera.Location = new System.Drawing.Point(758, 384);
            this.enEspera.Name = "enEspera";
            this.enEspera.Size = new System.Drawing.Size(212, 83);
            this.enEspera.TabIndex = 19;
            this.enEspera.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.BackColor = System.Drawing.Color.DarkOrange;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(755, 501);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 83);
            this.label13.TabIndex = 18;
            this.label13.Text = "C2";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(872, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(586, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.BackColor = System.Drawing.Color.Blue;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1239, 501);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 83);
            this.label12.TabIndex = 15;
            this.label12.Text = "C5";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoEllipsis = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(219)))));
            this.label15.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(189, 789);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(593, 83);
            this.label15.TabIndex = 14;
            this.label15.Text = "PEDIATRÍA";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoEllipsis = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(219)))));
            this.label14.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(189, 650);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(593, 83);
            this.label14.TabIndex = 13;
            this.label14.Text = "MEDICINA ADULTO";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.Green;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1073, 501);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 83);
            this.label11.TabIndex = 10;
            this.label11.Text = "C4";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.BackColor = System.Drawing.Color.Yellow;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(914, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 83);
            this.label10.TabIndex = 9;
            this.label10.Text = "C3";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoEllipsis = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(219)))));
            this.label8.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(189, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(593, 83);
            this.label8.TabIndex = 7;
            this.label8.Text = "PACIENTES POR CATEGORIZACIÓN EN ESPERA ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(740, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(607, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(475, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(219)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1164, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 83);
            this.label4.TabIndex = 3;
            this.label4.Text = "TOTAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(155)))), ((int)(((byte)(219)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1054, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 83);
            this.label3.TabIndex = 2;
            this.label3.Text = "EN BOX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label c4a;
        private System.Windows.Forms.Label c3a;
        private System.Windows.Forms.Label c2a;
        private System.Windows.Forms.Label enTotal;
        private System.Windows.Forms.Label enAtencion;
        private System.Windows.Forms.Label enEspera;
        private System.Windows.Forms.Label c4n;
        private System.Windows.Forms.Label c3n;
        private System.Windows.Forms.Label c2n;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label c5n;
        private System.Windows.Forms.Label c5a;
        private System.Windows.Forms.Label scn;
        private System.Windows.Forms.Label sca;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Button cargar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label totaln;
        private System.Windows.Forms.Label totala;
    }
}

