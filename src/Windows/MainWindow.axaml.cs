using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using OpenPDF.ViewModels;

namespace OpenPDF.Windows
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();

#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void CloseTab(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            (DataContext as MainWindowViewModel).CloseTab(int.Parse(btn.Name));
        }
    }
}
