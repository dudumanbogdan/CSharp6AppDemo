using System.ComponentModel;

namespace WpfApp1.Model
{
    #region 1
    public class PersonViewModel
    {
        public string Name { get; set; }
        public string TextBoxName { get; set; }

        public PersonViewModel()
        {
            Name = "Default Name";
        }
    }
    #endregion

    #region 2
    public class PersonViewModel2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region Fields
        private string _name;
        #endregion

        #region Properties
        public string Naaaaaame
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;

                    // 1.
                    OnPropertyChanged(nameof(Naaaaaame));

                    #region 2
                    // !
                    #endregion
                }
            }
        }

        public string TextBoxName { get; set; }

        #endregion

        public PersonViewModel2()
        {
            Naaaaaame = "Default Name";
        }

        private void OnPropertyChanged(string propertyName)
        {
            // 1.
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

            #region 2
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            #endregion
        }

    }
    #endregion
}
