using OnSale.Common.Models;
using OnSale.Prism.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnSale.Prism.ItemViewModels
{
   
        public class HeadMenuItemViewModel : Menu
        {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectMenuCommand;
        private DelegateCommand _selectUserCommand;


        public HeadMenuItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public DelegateCommand SelectMenuCommand => _selectMenuCommand ??
            (_selectMenuCommand = new DelegateCommand(SelectMenuAsync));

        private async void SelectMenuAsync()
        {
            await _navigationService.NavigateAsync($"/{nameof(OnSaleMasterDetailPage)}/NavigationPage/{PageName}");
        }


        }
}
    

