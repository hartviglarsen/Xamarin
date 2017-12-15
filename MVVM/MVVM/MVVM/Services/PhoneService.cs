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
                    ID = 1,
                    Model = "iPhone X",
                    Brand = "Apple"
                },
                new Phone
                {
                    ID = 2,
                    Model = "Galaxy S7",
                    Brand = "Samsung"
                }
            };

            return list;
        }

    }
}
