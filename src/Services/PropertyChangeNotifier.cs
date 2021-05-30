using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OpenPDF.Services
{
    class PropertyChangeNotifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(object sender, [CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs(propertyName));
        }
    }
}
