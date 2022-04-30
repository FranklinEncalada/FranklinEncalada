using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FranklinEncalada
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();

        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {

            string usuario = txtUser.Text;
            string clave = txtPass.Text;

            if ((usuario == "franklin2022") && (clave == "uisrael2022"))
            {
                await Navigation.PushAsync(new registro(usuario, clave));
            }
            else
            {
                lblResultado.Text = "El usuario o contraseña son incorrectos";
            }


        }
    }
}