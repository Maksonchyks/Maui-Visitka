using Visitka.Presentation.ViewModels;

namespace Visitka.Presentation.Pages
{
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage(RegisterViewModel viewModel)
		{
			InitializeComponent();
			BindingContext = viewModel;
		}
	}
}