using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace k1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Btncalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(txtprecio.Text);
                int cantidad = Convert.ToInt32(txtcantidad.Text);
                double vslor = precio * cantidad;
                DisplayAlert("resultado", vslor.ToString(), "aceptar");
            }

            catch (Exception ex)
            {

                DisplayAlert("alerta", ex.ToString(), "CERRAR");
            }

        }
    }
}