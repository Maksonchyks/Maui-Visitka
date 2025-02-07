using Visitka.Presentation.ViewModels;

namespace Visitka.Presentation.Pages
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage(LoginViewModel viewModel)
		{
			InitializeComponent();
			BindingContext = viewModel;
		}
	}
}