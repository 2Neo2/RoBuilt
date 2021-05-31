using System;
using System.Data.SqlClient;


using Xamarin.Forms;

namespace RoBuilt.Views
{
    public partial class OwnAcountPage : ContentPage
    {
        private SqlConnectionStringBuilder _connectionStringBuilder;
        public OwnAcountPage()
        {
            InitializeComponent();
            _connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "doroninia.database.windows.net",
                UserID = "Neo",
                Password = "Doronin455171",
                InitialCatalog = "doroninia/Users"
            };
        }

        void button_SignUp_Clicked(System.Object sender, System.EventArgs e)
        {
            ToRegistrationPage();
        }

        void button_SignIn_Clicked(System.Object sender, System.EventArgs e)
        {
            var username = userName.Text;
            var password = userPassword.Text;

            /*if (!IsExist(username))
            {
                label_exception.Text = "This login does not exist in system, go to registration!";
                return;
            }
            else if (!IsCorrect(password))
            {

            }*/

            ToAccountPage(username);
        }

        private bool IsExist(string username)
        {
            using (var connection = new SqlConnection(_connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                var query = "";

                
            }

            return false;
        }

        private bool IsCorrect(string password)
        {
            using (var connection = new SqlConnection(_connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                var query = "";

            }

            return false;
        }

        private async void ToAccountPage(string username)
        {

            await Navigation.PushModalAsync(new AccountPage(username), false);
        }

        private async void ToRegistrationPage()
        {
            await Navigation.PushAsync(new DataPage(), false);
        }
    }
}
