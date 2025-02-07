using Visitka.Presentation.ViewModels;

namespace Visitka.Presentation.Components;

public partial class FooterView : ContentView
{
	public FooterView()
	{
		InitializeComponent();
        BindingContext = new FooterViewModel();
    }
}