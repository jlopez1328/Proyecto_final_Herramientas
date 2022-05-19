
namespace Proyecto_final_Herramientas.Interfaces
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Clave = new System.Windows.Forms.TextBox();
            this.BTN_Login = new System.Windows.Forms.Button();
            this.BTN_Registrarse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(16, 30);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(100, 20);
            this.TXT_Usuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // TXT_Clave
            // 
            this.TXT_Clave.Location = new System.Drawing.Point(16, 74);
            this.TXT_Clave.Name = "TXT_Clave";
            this.TXT_Clave.Size = new System.Drawing.Size(100, 20);
            this.TXT_Clave.TabIndex = 3;
            this.TXT_Clave.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.TXT_Clave_PreviewKeyDown);
            // 
            // BTN_Login
            // 
            this.BTN_Login.Location = new System.Drawing.Point(16, 119);
            this.BTN_Login.Name = "BTN_Login";
            this.BTN_Login.Size = new System.Drawing.Size(100, 23);
            this.BTN_Login.TabIndex = 4;
            this.BTN_Login.Text = "Iniciar Sesión";
            this.BTN_Login.UseVisualStyleBackColor = true;
            this.BTN_Login.Click += new System.EventHandler(this.BTN_Login_Click);
            // 
            // BTN_Registrarse
            // 
            this.BTN_Registrarse.Location = new System.Drawing.Point(16, 157);
            this.BTN_Registrarse.Name = "BTN_Registrarse";
            this.BTN_Registrarse.Size = new System.Drawing.Size(100, 23);
            this.BTN_Registrarse.TabIndex = 5;
            this.BTN_Registrarse.Text = "Registrarse";
            this.BTN_Registrarse.UseVisualStyleBackColor = true;
            this.BTN_Registrarse.Click += new System.EventHandler(this.BTN_Registrarse_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_Registrarse);
            this.Controls.Add(this.BTN_Login);
            this.Controls.Add(this.TXT_Clave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_Usuario);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXT_Clave;
        private System.Windows.Forms.Button BTN_Login;
        private System.Windows.Forms.Button BTN_Registrarse;
    }
}