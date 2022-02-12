using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM02EJ12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Enviar(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name.Text) && !string.IsNullOrEmpty(lname.Text) && !string.IsNullOrEmpty(age.Text) && !string.IsNullOrEmpty(email.Text))
            {
                var Persona = new Models.Persona
                {
                    name = "Nombre: " + this.name.Text,
                    lname = "Apellido: " + this.lname.Text,
                    age = "Edad: " + this.age.Text,
                    email = "Correo: " + this.email.Text
                };

                PersonData pdata = new PersonData();
                pdata.BindingContext = Persona;
                await Navigation.PushAsync(pdata);
            }
            else
                DisplayAlert("Error", "Debe llenar todos los campos", "OK");
        }
    }
}
