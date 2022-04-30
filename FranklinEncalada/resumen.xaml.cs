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
    public partial class resumen : ContentPage
    {
        public resumen(String usuario, string nombre, double primerAbono, double pagomensual)
        {
            InitializeComponent();
            double total;
            lblUser.Text = usuario;
            lblNombre.Text = "Nombre Estudiante: " + nombre;
            lblAbono.Text = "Primer Abono: " + primerAbono;
            lblMensual.Text = "Pago Mensual: " + pagomensual;
            total = primerAbono + (pagomensual * 5);
            lblFinal.Text = "Pago Total: " + total;

        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
         
        }
    }
}