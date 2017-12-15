using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

using MVVM.Models;
using MVVM.Services;

namespace MVVM.ViewModels
{
    public class PhoneViewModel : INotifyPropertyChanged
    {
        private List<Phone> _phonesList;

        public List<Phone> PhonesList
        {
            get => _phonesList;
            set
            {
                _phonesList = value;
                OnPropertyChanged();
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
