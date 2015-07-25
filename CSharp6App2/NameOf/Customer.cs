using System;
using System.ComponentModel;

namespace CSharp6App2.NameOf
{
    public class Customer : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public Customer(string name)
        {
            _name = name;

            PropertyChanged += Customer_PropertyChanged;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;

                    OnPropertyChanged(nameof(Name), oldValue, _name);
                }
            }
        }
        
        private void OnPropertyChanged(string propertyName, string oldValue, string newValue)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler.Invoke(this, new CustomerPropertyChangeEventArgs(propertyName, oldValue, newValue));
            }
        }

        private void Customer_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var eventArgs = e as CustomerPropertyChangeEventArgs;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("'{0}' propertyChanged, oldValue: '{1}' , newValue: '{2}'", eventArgs.PropertyName,  eventArgs.OldValue, eventArgs.NewValue);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
