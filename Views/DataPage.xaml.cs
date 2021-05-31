using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace RoBuilt.Views
{
    public partial class DataPage : ContentPage
    {
        public DataPage()
        {
            InitializeComponent();
        }

        void button_SignIn_Clicked(System.Object sender, System.EventArgs e)
        {
            var username = userName.Text;
            var password = userPassword.Text;
            ToAccountPage(username);
        }

        private async void ToAccountPage(string username)
        {
            await Navigation.PushAsync(new AccountPage(username));
        }
    }
}
