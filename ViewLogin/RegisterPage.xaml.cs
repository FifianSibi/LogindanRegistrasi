using Microsoft.Maui.Controls;

namespace ViewLogin
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void OnRegisterClicked(object sender, EventArgs e)
        {
            string fullName = FullNameEntry.Text;
            string phoneNumber = PhoneNumberEntry.Text;
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phoneNumber) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                DisplayAlert("Error", "Please fill in all fields", "OK");
                return;
            }

            // Implement logic untuk proses registrasi di sini
            // Misalnya, Anda dapat memvalidasi data dan menyimpan data ke penyimpanan

            // Tampilkan notifikasi "Anda berhasil melakukan registrasi"
            DisplayAlert("Notifikasi", "Anda berhasil melakukan registrasi", "OK");
        }

        private void OnSignInTapped(object sender, EventArgs e)
        {
            // Navigasi ke halaman login (MainPage)
            Navigation.PopAsync();
        }
    }
}
