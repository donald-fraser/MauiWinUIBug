using Maui_NoteApp.ViewModels;

namespace Maui_NoteApp.Views;

public partial class AppShell : Shell
{
    public AppShell(
        AppShellViewModel appShellViewModel)
	{
		InitializeComponent();
		BindingContext = appShellViewModel;
	}
}
