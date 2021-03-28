using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Example.Model;
using Xamarin.Forms;

namespace Example.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {

        private string userName;
        public string Username
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                OnPropertyChanged("Username");
                OnPropertyChanged("Greeting");
            }
        }
        private string greeting;
        public string Greeting
        {
            get
            {
                return $"Hello {userName}";
            }
        }

        public ICommand ClearCommand { get; set; }

        public ObservableCollection<Contact> Contacts { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainVM()
        {
            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact
            {
                Name = "Christian Vigil",
                Email = "example@gmail.com"
            });
                
            Contacts.Add(new Contact
            {
                Name = "Test",
                Email = "test@gmail.com"
            });

            ClearCommand = new Command(ClearUsername, ClearCanExecute);
        }

        private bool ClearCanExecute(object arg)
        {
            return !string.IsNullOrEmpty(Username);
        }

        private void ClearUsername(object parameter)
        {
            Username = string.Empty;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
