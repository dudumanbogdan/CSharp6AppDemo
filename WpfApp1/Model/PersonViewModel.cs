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
    //public class PersonViewModel : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler PropertyChanged;

    //    #region Fields
    //    private string _name;
    //    #endregion

    //    #region Properties
    //    public string Name
    //    {
    //        get { return _name; }
    //        set
    //        {
    //            if (_name != value)
    //            {
    //                _name = value;

    //                // 1.
    //                OnPropertyChanged("Name");

    //                #region 2
    //                // 2.
    //                //OnPropertyChanged(nameof(Name)); 
    //                #endregion
    //            }
    //        }
    //    }

    //    public string TextBoxName { get; set; }

    //    #endregion

    //    public PersonViewModel()
    //    {
    //        Name = "Default Name";
    //    }

    //    private void OnPropertyChanged(string propertyName)
    //    {
    //        // 1.
    //        if (PropertyChanged != null)
    //        {
    //            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    //        }

    //        #region 2
    //        //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    //        #endregion
    //    }

    //}
    #endregion
}
