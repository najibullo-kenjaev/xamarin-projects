using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace UIDesing
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Places> Places;

        public ObservableCollection<Places> places
        {
            get { return Places; }
            set
            {
                Places = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("places"));
            }
        }

        public MainViewModel()
        {
            places = new ObservableCollection<Places>();
            addDate();
        }

        private void addDate()
        {
            places.Add(new Places
            {
                Id = 0,
                Title = "The beautiful sunset",
                Country = "Franche",
                ImgSource = "https://bestwallpapers.in/wp-content/uploads/2018/04/palm-trees-sunset-orange-sun-green-water-4k-wallpaper-1440x2560.jpg"
            });
            places.Add(new Places
            {
                Id = 1,
                Title = "The best places",
                Country = "Tajikistan",
                ImgSource = "https://www.3wallpapers.fr/wp-content/uploads/2017/09/iphone_wallpaper_sunset_sky.jpg"
            });
            places.Add(new Places
            {
                Id = 2,
                Title = "The Beautiful",
                Country = "Russia",
                ImgSource = "https://ihdwall.com/storage/202101/sunset-road-landscape-scenery-hd-phone-wallpaper-1125x2436.jpg"
            });
            places.Add(new Places
            {
                Id = 3,
                Title = "So match ",
                Country = "USA",
                ImgSource = "https://i.pinimg.com/originals/66/55/03/6655039bd090abed0037746c6edf662b.jpg"
            });

        }
    }
}
