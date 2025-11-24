
using System;
using System.Windows.Forms;

namespace ControleClientes
{
    internal static class Program
    {
        /// <summary>
        /// O ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 1. Inicializa a configuração da aplicação (necessário no .NET 5+)
            ApplicationConfiguration.Initialize();

            // 2. Cria uma instância da tela de Login
            LoginForm loginForm = new LoginForm();

            // 3. Exibe o LoginForm como uma caixa de diálogo modal
            // O programa pausa aqui e espera o resultado do login.
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // 4. Se o LoginForm retornar DialogResult.OK (login bem-sucedido):
                //    Inicia o loop principal da aplicação com a tela inicial.
                Application.Run(new MenuForm());
            }
            else
            {
                // 5. Se o LoginForm for fechado, ou retornar outro DialogResult (Cancel, etc.):
                //    O aplicativo simplesmente encerra aqui.
            }
        }
    }
}