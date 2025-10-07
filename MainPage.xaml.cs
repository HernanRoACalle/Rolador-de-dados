using RoladorDeDados.Models;
using System;

namespace RoladorDeDados
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void rolagem_Clicked(object sender, EventArgs e)
        {
            /*int n = Convert.ToInt32(picker.SelectedItem);
            int valor;
            Random rnd = new();
            valor = rnd.Next(1, n + 1);
            */
            dado dado = new dado(2);
            Numrandom.Text = Convert.ToString(dado.Ladossortedos);
            dado.Rolar();
        
        }

    }
}
