using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

using MVVM.Models;

namespace MVVM.Services
{
    public class PhoneService
    {

        public ObservableCollection<Phone> GetPhones()
        {
            var list = new ObservableCollection<Phone>
            {
                new Phone
                {
                    Model = "iPhone X",
                    Brand = "Apple"
                },
                new Phone
                {
                    Model = "Galaxy S7",
                    Brand = "Samsung"
                }
            };

            return list;
        }

    }
}
