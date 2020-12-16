using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDP_App
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            profileImage.Source = ImageSource.FromFile("wf.jpg"); //
            aboutList.ItemsSource = GetMenuList();
            var homePage = typeof(Views.AboutPage);
            Detail = new NavigationPage((Page)Activator.CreateInstance(homePage));
            IsPresented = false;
        }

        public List<MasterMenuItems> GetMenuList()
        {
            var list = new List<MasterMenuItems>();
            list.Add(new MasterMenuItems()
            {
                Text = "АЕвгений Базив",
                Detail = "Черди",
                ImagePath = "cherdy.jpg",
                TargetPage = typeof(Views.AboutPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Лёня Поздняков ", //
                Detail = "-К4питанПаника-",
                ImagePath = "panic.jpg",
                TargetPage = typeof(Views.ExperiencePage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Али Тагиев",
                Detail = "Трейз",
                ImagePath = "treiz.jpg",
                TargetPage = typeof(Views.SkillsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Вадим Зубрицкий",
                Detail = "Джетфайер",
                ImagePath = "dzet.png",
                TargetPage = typeof(Views.AchievemnetsPage)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Егор Широков",
                Detail = "КвикСк0уп",
                ImagePath = "kviki.png",
                TargetPage = typeof(Views.Kvik)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Кирилл Нехожин",
                Detail = "-Кл4уд.",
                ImagePath = "cloud.jpg",
                TargetPage = typeof(Views.Cloud)
            });
            list.Add(new MasterMenuItems()
            {
                Text = "Илья Филатов",
                Detail = "Силвеон",
                ImagePath = ".jpg",
                TargetPage = typeof(Views.Silveon)
            });
            return list;
        }

        private void aboutList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMenuItem = (MasterMenuItems)e.SelectedItem;
            Type selectedPage = selectedMenuItem.TargetPage;
            Detail = new NavigationPage((Page)Activator.CreateInstance(selectedPage));
            IsPresented = false;
        }

       
    }
}
