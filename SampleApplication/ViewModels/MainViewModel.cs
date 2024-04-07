using SampleApplication.Views;
using System;
using System.Collections.Generic;
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
        
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged(); 
            }
        }

        public MainViewModel()
        {
            GalleryViewModel = new GalleryViewModel();
            CreatorViewModel = new CreatorViewModel();
            
            _currentView = GalleryViewModel;

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
