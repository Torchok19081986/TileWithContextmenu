using System.ComponentModel;

namespace TileWithContextmenu
{
    public class ViewModel : INotifyPropertyChanged
    {
        // Let's have a static Instance which we can access from anywhere
        static ViewModel _Instance;
        public static ViewModel Instance
        {
            get
            {
                return _Instance ??= new ViewModel();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string Name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }

        private int _CurrentIndex = 0;
        public int CurrentIndex
        {
            get { return _CurrentIndex; }
            set { _CurrentIndex = value; OnPropertyChanged(nameof(CurrentIndex)); }
        }

    }
}
