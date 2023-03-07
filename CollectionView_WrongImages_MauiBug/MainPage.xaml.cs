using CollectionView_WrongImages_MauiBug.ViewModels;

namespace CollectionView_WrongImages_MauiBug;

public partial class MainPage : ContentPage
{
    public GamesViewModel GamesViewModel { get; set; }

    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = GamesViewModel = new GamesViewModel();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        GamesViewModel.Games.Clear();

        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "aerosmith.png",
            Name = "Aerosmith",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "aiq.png",
            Name = "Avengers: Infinity Quest",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "Batman.png",
            Name = "Batman '66",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "beatles.png",
            Name = "Beatles",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "blackknight.png",
            Name = "Black Knight: Sword of Rage",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "bond.png",
            Name = "James Bond 007",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "deadpool.png",
            Name = "Deadpool",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "foofighters.png",
            Name = "Foo Fighters",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "godzilla.png",
            Name = "Godzilla",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "guardians.png",
            Name = "Guardians of the Galaxy",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "ironmaiden.png",
            Name = "Iron Maiden",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "led.png",
            Name = "Led Zeppelin",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "aerosmith.png",
            Name = "Aerosmith",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "mando.png",
            Name = "The Mandolorian",
            IsNew = false
        });
        GamesViewModel.Games.Add(new Game
        {
            ImageUrl = "munsters.png",
            Name = "The Munsters",
            IsNew = false
        });
    }
}

