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

        public string FullName
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;

                    OnPropertyChanged("FullName", oldValue, _name);

                    #region 2
                    //OnPropertyChanged(nameof(FullName), oldValue, _name);
                    #endregion
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

        #region Null-Cond Operator - Invoke - ex2
        private void OnPropertyChanged2(string propertyName, string oldValue, string newValue)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            handler?.Invoke(this, new CustomerPropertyChangeEventArgs(propertyName, oldValue, newValue));
        }
        #endregion

        public static void Customer_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            var eventArgs = e as CustomerPropertyChangeEventArgs;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("'{0}' propertyChanged, oldValue: '{1}' , newValue: '{2}'", eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
