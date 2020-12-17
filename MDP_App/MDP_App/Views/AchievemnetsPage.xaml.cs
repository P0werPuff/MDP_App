using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MDP_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AchievemnetsPage : ContentPage
    {
        public AchievemnetsPage()
        {
            InitializeComponent();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            dzet.GestureRecognizers.Add(tap);

        }

        private async void Tap_Tapped(object sender, EventArgs e)
        {
            var wiki = await DisplayAlert("Глянь игрока!", "Посмотри данные о игроке, продолжить?", "Да", "Нет");
            if (wiki == true)
            {
                await Browser.OpenAsync("https://pvp.gg/player/f5e68cace4c2324356babb8024af5851/", BrowserLaunchMode.SystemPreferred);
            }
        }

    }
}