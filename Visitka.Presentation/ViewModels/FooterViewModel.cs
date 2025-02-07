using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Visitka.Presentation.ViewModels
{
    public class FooterViewModel
    {
        public ICommand NavigateCommand { get; }

        public FooterViewModel()
        {
            NavigateCommand = new Command<string>(async (route) =>
            {
                if (!string.IsNullOrEmpty(route))
                {
                    await Shell.Current.GoToAsync($"//{route}");
                }
            });
        }
    }
}
