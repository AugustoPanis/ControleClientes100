using Google.Apis.Auth.OAuth2;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ControleClientes
{
    public partial class LoginForm : Form
    {
        // ⚠️ Substitua pelos seus Client ID e Client Secret reais de 'Desktop App'
        private const string CLIENT_ID = "751021547250-cgpdvckinrj8mqs267mfoec7d1t4o81k.apps.googleusercontent.com";
        private const string CLIENT_SECRET = "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";

        // Escopos mínimos
        private static readonly string[] Scopes = { "email", "profile" };

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Desabilita o botão enquanto o processo está rodando
            ((Button)sender).Enabled = false;

            try
            {
                // Inicia o fluxo de autorização. O Google abrirá uma janela do navegador.
                var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    new ClientSecrets
                    {
                        ClientId = CLIENT_ID,
                        ClientSecret = CLIENT_SECRET
                    },
                    Scopes,
                    "user", // Um ID qualquer, pois não usaremos armazenamento persistente aqui
                    CancellationToken.None
                // A sobrecarga simples sem FileDataStore não persistirá o token.
                );

                // Se o token foi obtido, o login funcionou
                if (credential != null && credential.Token.AccessToken != null)
                {
                    MessageBox.Show("Login com Google BEM-SUCEDIDO!\nToken de Acesso Recebido.", "Sucesso Simples", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Define o resultado e fecha o formulário
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Caso o usuário feche a janela ou cancele
                    MessageBox.Show("O login com o Google foi CANCELADO ou o token não foi obtido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Exibe qualquer erro de rede ou autorização
                MessageBox.Show("Erro no login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Reabilita o botão
                ((Button)sender).Enabled = true;
            }
        }
    }
}