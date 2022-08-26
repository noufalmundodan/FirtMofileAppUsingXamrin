using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstMobApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            
            InitializeComponent();
            this.EntryErrorMessage.IsVisible = false;
        }
        async void onButtonClicked(Object sender, EventArgs args)
        {
            this.EntryErrorMessage.IsVisible = false;
            var userName = this.EntryUserName.Text;
            var password = this.EntryPassword.Text;
            if(String.IsNullOrEmpty(userName) || String.IsNullOrEmpty(password))
            {
                this.EntryErrorMessage.IsVisible = true;
                this.EntryErrorMessage.Text = "Invalid username/password";               
            }
            else if(userName.ToLower()=="admin" && password == "password")
            {
               await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await Navigation.PushAsync(new ErrorPage());
            }          
        }

    }
}