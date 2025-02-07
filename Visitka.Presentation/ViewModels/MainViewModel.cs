using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitka.Application;
using Visitka.Domain.Models;

namespace Visitka.Presentation.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IUserService _userService;

        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users 
        { 
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            } 
        }
        public MainViewModel(IUserService userService) 
        { 
            _userService = userService;
            Users = new ObservableCollection<User>();
            LoadUsersAsync();
        
        }

        private async void LoadUsersAsync() 
        {
            var users = await _userService.GetAllUsersAsync();
            Users = new ObservableCollection<User>(users);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
