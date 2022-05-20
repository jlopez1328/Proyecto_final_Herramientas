
namespace Proyecto_final_Herramientas.Interfaces
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Entradas = new System.Windows.Forms.PictureBox();
            this.Platos_Fuertes = new System.Windows.Forms.PictureBox();
            this.Comidas_Rapidas = new System.Windows.Forms.PictureBox();
            this.Bebidas = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platos_Fuertes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comidas_Rapidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(315, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 100);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(783, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 15);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(109, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "ENTRADAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(596, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "PLATOS FUERTES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(626, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "BEBIDAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(69, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "COMIDAS RAPIDAS";
            // 
            // Entradas
            // 
            this.Entradas.Image = ((System.Drawing.Image)(resources.GetObject("Entradas.Image")));
            this.Entradas.Location = new System.Drawing.Point(56, 174);
            this.Entradas.Name = "Entradas";
            this.Entradas.Size = new System.Drawing.Size(195, 121);
            this.Entradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Entradas.TabIndex = 6;
            this.Entradas.TabStop = false;
            this.Entradas.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Platos_Fuertes
            // 
            this.Platos_Fuertes.Image = ((System.Drawing.Image)(resources.GetObject("Platos_Fuertes.Image")));
            this.Platos_Fuertes.Location = new System.Drawing.Point(547, 174);
            this.Platos_Fuertes.Name = "Platos_Fuertes";
            this.Platos_Fuertes.Size = new System.Drawing.Size(222, 121);
            this.Platos_Fuertes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platos_Fuertes.TabIndex = 7;
            this.Platos_Fuertes.TabStop = false;
            this.Platos_Fuertes.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Comidas_Rapidas
            // 
            this.Comidas_Rapidas.Image = ((System.Drawing.Image)(resources.GetObject("Comidas_Rapidas.Image")));
            this.Comidas_Rapidas.Location = new System.Drawing.Point(56, 341);
            this.Comidas_Rapidas.Name = "Comidas_Rapidas";
            this.Comidas_Rapidas.Size = new System.Drawing.Size(195, 120);
            this.Comidas_Rapidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Comidas_Rapidas.TabIndex = 8;
            this.Comidas_Rapidas.TabStop = false;
            this.Comidas_Rapidas.Click += new System.EventHandler(this.Comidas_Rapidas_Click);
            // 
            // Bebidas
            // 
            this.Bebidas.Image = ((System.Drawing.Image)(resources.GetObject("Bebidas.Image")));
            this.Bebidas.Location = new System.Drawing.Point(547, 341);
            this.Bebidas.Name = "Bebidas";
            this.Bebidas.Size = new System.Drawing.Size(222, 120);
            this.Bebidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bebidas.TabIndex = 9;
            this.Bebidas.TabStop = false;
            this.Bebidas.Click += new System.EventHandler(this.Bebidas_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(258, 188);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(283, 256);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Bebidas);
            this.Controls.Add(this.Comidas_Rapidas);
            this.Controls.Add(this.Platos_Fuertes);
            this.Controls.Add(this.Entradas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu_Principal";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Entradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platos_Fuertes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comidas_Rapidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Entradas;
        private System.Windows.Forms.PictureBox Platos_Fuertes;
        private System.Windows.Forms.PictureBox Comidas_Rapidas;
        private System.Windows.Forms.PictureBox Bebidas;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}