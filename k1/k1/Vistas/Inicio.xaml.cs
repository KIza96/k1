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
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Clicked(object sender, EventArgs e)
        {
            //redireccionar a otra pantalla
           // Navigation.PushAsync(new Registro());

            //login
            string usuario = "karol";
            string contraseña = "12345";
            string estado = "1";
            if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
            {
                Navigation.PushAsync(new Registro());
            }
            else
            {
                DisplayAlert("Alerta", "Error al ingresa", "Cerrar");
            }
        }
    }
}