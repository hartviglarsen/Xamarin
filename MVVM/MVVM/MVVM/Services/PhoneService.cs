using System;
using System.Collections.Generic;
using System.Text;

using MVVM.Models;

namespace MVVM.Services
{
    public class PhoneService
    {

        public List<Phone> GetPhones()
        {
            var list = new List<Phone>
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
