using OnSale.Common.Helpers;
using OnSale.Common.Models;
using OnSale.Prism.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnSale.Prism.ItemViewModels
{
    public class MenuItemViewModel : Menu
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectMenuCommand;
        private DelegateCommand _selectUserCommand;

        private DelegateCommand _selectHeadMenuCommand;


        public MenuItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectMenuCommand => _selectMenuCommand ??
            (_selectMenuCommand = new DelegateCommand(SelectMenuAsync));

        private async void SelectMenuAsync()
        {
            if (PageName == nameof(LoginPage) && Settings.IsLogin)
            {
                Settings.IsLogin = false;
                Settings.Token = null;
            }

            await _navigationService.NavigateAsync($"/{nameof(OnSaleMasterDetailPage)}/NavigationPage/{PageName}");
        }

        /// <summary>
        /// 
        /// </summary>
        public DelegateCommand SelectHeadMenuCommand => _selectHeadMenuCommand ??
           (_selectHeadMenuCommand = new DelegateCommand(SelectHeadMenuAsync));

        private async void SelectHeadMenuAsync()
        {
            await _navigationService.NavigateAsync($"/{nameof(OnSaleMasterDetailPage)}/NavigationPage/{PageName}");
        }



    }

}
