using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionView_WrongImages_MauiBug.ViewModels
{  
    public class GamesViewModel
    {
        public ObservableCollection<Game> Games { get; set; } = new ObservableCollection<Game>();
    }

    public class Game
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public bool IsNew { get; set; }
    }
}
