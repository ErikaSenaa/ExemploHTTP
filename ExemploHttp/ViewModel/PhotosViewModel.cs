using CommunityToolkit.Mvvm.ComponentModel;
using ExemploHttp.Models;
using ExemploHttp.Photos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploHttp.Services;
using System.Windows.Input;

namespace ExemploHttp.ViewModel
{
    public partial class PhotosViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Photo> photos;

        public ICommand getPhotosCommand { get; }

        public PhotosViewModel()
        {
            getPhotosCommand = new Command(getPhotos);
        }

        public async void getPhotos()
        {
            RestService photosService = new RestService();
            photos = await photosService.getPhotosAsync();
        }
    }
}
