using System.ComponentModel;

namespace CSharp6App2.NameOf
{
    public class CustomerPropertyChangeEventArgs: PropertyChangedEventArgs
    {
        public CustomerPropertyChangeEventArgs(string propertyName, string oldValue, string newValue) : base(propertyName)
        {
            NewValue = newValue;
            OldValue = oldValue;
        }

        public string NewValue { get; private set; }
        public string OldValue { get; private set; }
    }
}
