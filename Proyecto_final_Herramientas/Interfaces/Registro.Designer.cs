
namespace Proyecto_final_Herramientas.Interfaces
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.BTN_Registrarse = new System.Windows.Forms.Button();
            this.TXT_Clave = new System.Windows.Forms.TextBox();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_VerificarClave = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Registrarse
            // 
            this.BTN_Registrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BTN_Registrarse.FlatAppearance.BorderSize = 0;
            this.BTN_Registrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BTN_Registrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BTN_Registrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Registrarse.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Registrarse.ForeColor = System.Drawing.Color.DimGray;
            this.BTN_Registrarse.Location = new System.Drawing.Point(442, 226);
            this.BTN_Registrarse.Name = "BTN_Registrarse";
            this.BTN_Registrarse.Size = new System.Drawing.Size(176, 35);
            this.BTN_Registrarse.TabIndex = 9;
            this.BTN_Registrarse.Text = "REGISTRARSE";
            this.BTN_Registrarse.UseVisualStyleBackColor = false;
            this.BTN_Registrarse.Click += new System.EventHandler(this.BTN_Registrarse_Click);
            // 
            // TXT_Clave
            // 
            this.TXT_Clave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXT_Clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Clave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Clave.ForeColor = System.Drawing.Color.DimGray;
            this.TXT_Clave.Location = new System.Drawing.Point(329, 112);
            this.TXT_Clave.Name = "TXT_Clave";
            this.TXT_Clave.Size = new System.Drawing.Size(409, 31);
            this.TXT_Clave.TabIndex = 8;
            this.TXT_Clave.Text = "CONTRASEÑA";
            this.TXT_Clave.TextChanged += new System.EventHandler(this.TXT_Clave_TextChanged);
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXT_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Usuario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Usuario.ForeColor = System.Drawing.Color.DimGray;
            this.TXT_Usuario.Location = new System.Drawing.Point(329, 63);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(409, 31);
            this.TXT_Usuario.TabIndex = 6;
            this.TXT_Usuario.Text = "USUARIO";
            this.TXT_Usuario.TextChanged += new System.EventHandler(this.TXT_Usuario_TextChanged);
            // 
            // TXT_VerificarClave
            // 
            this.TXT_VerificarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TXT_VerificarClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_VerificarClave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_VerificarClave.ForeColor = System.Drawing.Color.DimGray;
            this.TXT_VerificarClave.Location = new System.Drawing.Point(329, 167);
            this.TXT_VerificarClave.Name = "TXT_VerificarClave";
            this.TXT_VerificarClave.Size = new System.Drawing.Size(409, 31);
            this.TXT_VerificarClave.TabIndex = 11;
            this.TXT_VerificarClave.Text = "CONFIRMAR CONTRASEÑA";
            this.TXT_VerificarClave.TextChanged += new System.EventHandler(this.TXT_VerificarClave_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 291);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(478, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "REGISTRO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(748, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(764, 291);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TXT_VerificarClave);
            this.Controls.Add(this.BTN_Registrarse);
            this.Controls.Add(this.TXT_Clave);
            this.Controls.Add(this.TXT_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Registrarse;
        private System.Windows.Forms.TextBox TXT_Clave;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_VerificarClave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}