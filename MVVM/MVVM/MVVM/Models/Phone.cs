using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MVVM.Models
{
    public class Phone : INotifyPropertyChanged
    {

        private int _id;
        public int ID
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _model;
        public string Model
        {
            get => _model;
            set
            {
                _model = value;
                OnPropertyChanged();
            }
        }

        private string _brand;
        public string Brand
        {
            get => _brand;
            set
            {
                _brand = value;
                OnPropertyChanged();
            }
        }

        private int _tapped;
        public int Tapped
        {
            get => _tapped;
            set
            {
                _tapped = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
