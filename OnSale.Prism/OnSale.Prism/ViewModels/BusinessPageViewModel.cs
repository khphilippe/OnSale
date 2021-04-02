using OnSale.Prism.Helpers;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnSale.Prism.ViewModels
{
    public class BusinessPageViewModel : ViewModelBase
    {
        public BusinessPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = Languages.YourBusiness;
        }
     }
}
