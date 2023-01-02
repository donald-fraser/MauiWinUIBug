using Maui_NoteApp.ViewModels.Startup;

namespace Maui_NoteApp.Views.Startup;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}