namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            btn.Text = vez;

            if (VerificarVitoria(vez))
            {
                DisplayAlert("Vitória", $"{vez} venceu!", "Ok");
                Zerar();
            }
            else if (VerificarVelha())
            {
                DisplayAlert("Empate", "Deu velha!", "Ok");
                Zerar();
            }
            else
            {
                vez = vez == "X" ? "O" : "X";
            }
        }

        bool VerificarVitoria(string jogador)
        {
            return (btn10.Text == jogador && btn11.Text == jogador && btn12.Text == jogador) ||
                   (btn20.Text == jogador && btn21.Text == jogador && btn22.Text == jogador) ||
                   (btn30.Text == jogador && btn31.Text == jogador && btn32.Text == jogador) ||
                   (btn10.Text == jogador && btn20.Text == jogador && btn30.Text == jogador) ||
                   (btn11.Text == jogador && btn21.Text == jogador && btn31.Text == jogador) ||
                   (btn12.Text == jogador && btn22.Text == jogador && btn32.Text == jogador) ||
                   (btn10.Text == jogador && btn21.Text == jogador && btn32.Text == jogador) ||
                   (btn12.Text == jogador && btn21.Text == jogador && btn30.Text == jogador);
        }

        bool VerificarVelha()
        {
            return !btn10.IsEnabled && !btn11.IsEnabled && !btn12.IsEnabled &&
                   !btn20.IsEnabled && !btn21.IsEnabled && !btn22.IsEnabled &&
                   !btn30.IsEnabled && !btn31.IsEnabled && !btn32.IsEnabled;
        }

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            vez = "X";
        }
    }
}
