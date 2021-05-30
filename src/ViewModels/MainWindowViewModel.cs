using OpenPDF.Services;

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace OpenPDF.ViewModels
{
    class MainWindowViewModel : PropertyChangeNotifier
    {
        private ObservableCollection<TabViewModel> tabs;
        private string msg;

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel()
        {
            tabs = new ObservableCollection<TabViewModel>();
            tabs.Add(new TabViewModel(0, "Home", "Finally working tab"));
            msg = "Logs:";
        }

        // Getters, setters
        public ObservableCollection<TabViewModel> Tabs
        {
            get => tabs;
            set
            {
                if (tabs != value && value != null)
                {
                    tabs = value;
                    OnPropertyChanged(this);
                }
            }
        }

        public string TabCount { get => "Tabs: " + tabs.Count; }

        public string Msg
        {
            get => msg;
            set
            {
                if (msg != value)
                {
                    msg = value;
                    OnPropertyChanged(this);
                }
            }
        }

        // Other methods
        public void CreateTab()
        {
            tabs.Add(new TabViewModel(tabs.Count, $"test{tabs.Count}", $"New content tab {tabs.Count}"));
            OnPropertyChanged(this, nameof(Tabs));

            msg += $"\nNew tab added ({tabs[tabs.Count - 1].Title})";
            OnPropertyChanged(this, nameof(Msg));
        }

        public void CloseTab(int id)
        {
            msg += $"\nClose tab ({tabs[id].Title})";
            tabs.RemoveAt(id);
            OnPropertyChanged(this, nameof(Msg));
        }
    }
}
