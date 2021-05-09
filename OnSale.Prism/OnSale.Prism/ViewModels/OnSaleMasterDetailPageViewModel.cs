using Newtonsoft.Json;
using OnSale.Common.Helpers;
using OnSale.Common.Models;
using OnSale.Common.Responses;
using OnSale.Prism.Helpers;
using OnSale.Prism.ItemViewModels;
using OnSale.Prism.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;

namespace OnSale.Prism.ViewModels
{
    public class OnSaleMasterDetailPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private UserResponse _user;

        public OnSaleMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            LoadMenus();
            LoadUser();
        }

       



        public ObservableCollection <MenuItemViewModel> Menus { get; set; }
         public UserResponse User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        private void LoadUser()
        {
            if (Settings.IsLogin)
            {
                TokenResponse token = JsonConvert.DeserializeObject<TokenResponse>(Settings.Token);
                User = token.User;
            }
        }


        private void LoadMenus()
        {
            

            List<Menu> menus = new List<Menu>
            {

               
             new Menu
             {
                Icon = "person",
                PageName = $"{nameof(ModifyUserPage)}",
                Title = Languages.ModifyUser,
                IsLoginRequired = true
             },
              new Menu
              {
                Icon = "",
                PageName = $"{nameof(BusinessPage)}",
                Title = Languages.YourBusiness,
                IsLoginRequired = true
              },
              new Menu
              {
                Icon = "ic_gift",
                PageName = $"{nameof(ProductsPage)}",
                Title = Languages.Products
              },
              new Menu
              {
                Icon = "ic_action_shopping_cart",
                PageName = $"{nameof(ShowCarPage)}",
                Title = Languages.ShowShoppingCar,
                IsLoginRequired = true
              },
              new Menu
              {
                Icon = "ic_history",
                PageName = $"{nameof(ShowHistoryPage)}",
                Title = Languages.ShowPurchaseHistory,
                IsLoginRequired = true
              },
          
              new Menu
              {
                Icon = "Salir",
                PageName = $"{nameof(LoginPage)}",
                Title = Settings.IsLogin ? Languages.Logout : Languages.Login
              }
            };

            Menus = new ObservableCollection<MenuItemViewModel>(
                menus.Select(m => new MenuItemViewModel(_navigationService)
                {
                    
                    Icon = m.Icon,
                    PageName = m.PageName,
                    Title = m.Title,
                    IsLoginRequired = m.IsLoginRequired
                }).ToList());
        }
    }


}
