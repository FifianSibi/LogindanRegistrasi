using Microsoft.Maui.Controls;

namespace ViewLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            // Implement logic untuk proses login di sini
            // Misalnya, Anda dapat memvalidasi email dan password dengan layanan autentikasi

            // Tampilkan notifikasi "Anda berhasil login"
            DisplayAlert("Notifikasi", "Anda berhasil login", "OK");
        }

        private void OnSignUpTapped(object sender, EventArgs e)
        {
            // Navigasi ke halaman login (MainPage)
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
