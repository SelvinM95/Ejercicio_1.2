using Ejercicio2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  async void button_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(nombre.Text) && !String.IsNullOrWhiteSpace(apellido.Text) && !String.IsNullOrWhiteSpace(edad.Text) && !String.IsNullOrWhiteSpace(correo.Text))
            {
                var datos = new Datos
                {
                    Name = nombre.Text,
                    Apellido = apellido.Text,
                    Edad = Convert.ToInt32(edad.Text),
                    correo = correo.Text

                };

                var page1 = new Page1();
                page1.BindingContext = datos;
                await Navigation.PushAsync(page1);

            }
            else
            {
                DisplayAlert("Advertencia", "Llenar todos los campos", "Cerrar");
            }
        }
    }
}
