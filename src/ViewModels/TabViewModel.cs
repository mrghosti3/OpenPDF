using OpenPDF.Services;
using System;

namespace OpenPDF.ViewModels
{
    class TabViewModel : PropertyChangeNotifier
    {
        // Data
        private int id;
        private string title;
        private string content;

        //
        public TabViewModel(int id, string title, string content)
        {
            this.id = id;
            this.title = title;
            this.content = content;
        }

        // Getters, setters
        public int Id
        {
            get => id;
            set
            {
                if (value != id || value == 0)
                {
                    id = value;
                    OnPropertyChanged(this);
                }
            }
        }

        public string Title
        {
            get => title;
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged(this);
                }
            }
        }

        public string Content
        {
            get => content;
            set
            {
                if (content != value)
                {
                    content = value;
                    OnPropertyChanged(this);
                }
            }
        }
    }
}
