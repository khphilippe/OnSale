using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnSale.Prism.ViewModels
{
    public class ProductDetailPageViewModel : ViewModelBase
    {
        public ProductDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Product";
        }
    }

}
