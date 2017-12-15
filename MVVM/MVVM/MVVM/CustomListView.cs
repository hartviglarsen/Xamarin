using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM
{
    public class CustomListView : ListView
    {

        public static BindableProperty ItemClickCommandProperty = 
            BindableProperty.Create(
                nameof(ItemClickCommand), 
                typeof(ICommand), 
                typeof(CustomListView), 
                null
         );

        public ICommand ItemClickCommand
        {
            get
            {
                return (ICommand)this.GetValue(ItemClickCommandProperty);
            }
            set
            {
                this.SetValue(ItemClickCommandProperty, value);
            }
        }

        public CustomListView()
        {
            this.ItemTapped += OnItenTapped;
        }

        private void OnItenTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                ItemClickCommand?.Execute(e.Item);
                SelectedItem = null;
            }
        }
    }
}
