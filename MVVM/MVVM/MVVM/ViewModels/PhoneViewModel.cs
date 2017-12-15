using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

using Xamarin.Forms;

using MVVM.Models;
using MVVM.Services;

namespace MVVM.ViewModels
{
    public class PhoneViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Phone> _phonesList;
        public ObservableCollection<Phone> PhonesList
        {
            get => _phonesList;
            set
            {
                _phonesList = value;
                OnPropertyChanged();
            }
        }

        public ICommand PhonesListTappedCommand
        {
            get
            {
                return new Command((item) =>
                {
                    var phone = item as Phone;
                    phone.Tapped++;
                });
            }
        }

        public PhoneViewModel()
        {
            var phoneService = new PhoneService();
            PhonesList = phoneService.GetPhones();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
