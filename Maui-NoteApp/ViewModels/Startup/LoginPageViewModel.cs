using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Maui_NoteApp.ViewModels.Startup
{
    public partial class LoginPageViewModel : ObservableObject
    {
        public LoginPageViewModel() 
        {           
            // For some bizare reason if the string is a valid email style address, windows locks up when resizing
            _email = "testy.mctest@test.face";

            //AppShell.Current.Dispatcher.Dispatch(() =>
            //{
            //    Email = "testy.mctest@test.face";
            //});
        }

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [ObservableProperty]
        private string _errorMessage;

        [ObservableProperty]
        private bool _errorVisiable;

        [ObservableProperty]
        private bool _sendingVisiable;

        [RelayCommand]
        private void Login()
        {
            SetErrorInformation(null);

            if (!string.IsNullOrWhiteSpace(Email) && 
                !string.IsNullOrWhiteSpace(Password))
            {                

                Password = null;
            }
            else
            {
                SetErrorInformation("Credentials must be provided");
            }
        }

        private void SetErrorInformation(string message) 
        {
            ErrorMessage = message;
            ErrorVisiable = message != null;
        }
    }
}
