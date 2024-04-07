using SampleApplication.Views;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication.ViewModels
{
    internal class MainViewModel : BaseViewModel
    {
        public RelayCommand GalleryViewCommand { get; set; }
        public RelayCommand CreatorViewCommand { get; set; }
        
        public GalleryViewModel GalleryViewModel { get; set; }
        public CreatorViewModel CreatorViewModel { get; set; }
        
        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged(); 
            }
        }
        
        private object _currentView;

        public MainViewModel()
        {
            setViewModels();
            setRelayCommands();

            _currentView = GalleryViewModel;
        }

        private void setViewModels()
        {
            GalleryViewModel = new GalleryViewModel();
            CreatorViewModel = new CreatorViewModel();
        }

        private void setRelayCommands() 
        {
            GalleryViewCommand = new RelayCommand(o =>
            {
                CurrentView = GalleryViewModel;
            });

            CreatorViewCommand = new RelayCommand(o =>
            {
                CurrentView = CreatorViewModel;
            });
        }
    }
}
