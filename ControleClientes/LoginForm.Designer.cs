using System.Drawing;
using System.Windows.Forms;

namespace ControleClientes
{
    partial class LoginForm
    {
        /// <summary>
        /// Componentes necessários.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Botão para iniciar o Login com Google
        /// </summary>
        private System.Windows.Forms.Button btnLoginGoogle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnLoginGoogle = new Button();
            SuspendLayout();
            // 
            // btnLoginGoogle
            // 
            btnLoginGoogle.Location = new Point(47, 106);
            btnLoginGoogle.Name = "btnLoginGoogle";
            btnLoginGoogle.Size = new Size(200, 40);
            btnLoginGoogle.TabIndex = 0;
            btnLoginGoogle.Text = "Entrar com Google";
            btnLoginGoogle.UseVisualStyleBackColor = true;
            btnLoginGoogle.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 264);
            Controls.Add(btnLoginGoogle);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);

        }

        #endregion
    }
}