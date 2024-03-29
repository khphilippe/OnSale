﻿using Newtonsoft.Json;
using OnSale.Common.Entities;
using OnSale.Common.Helpers;
using OnSale.Common.Responses;
using OnSale.Prism.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnSale.Prism.ItemViewModels
{
    public class ProductItemViewModel : ProductResponse
    {
        private readonly INavigationService _navigationService;
        private DelegateCommand _selectProductCommand;

        public ProductItemViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            
        }

        public DelegateCommand SelectProductCommand =>
            _selectProductCommand ?? (_selectProductCommand = new DelegateCommand(SelectProductAsync));

        private async void SelectProductAsync()
        {
           
            NavigationParameters parameters = new NavigationParameters
            {
            { "product", this }
            };
            Settings.Product = JsonConvert.SerializeObject(this);
           

            await _navigationService.NavigateAsync(nameof(ProductTabbedPage), parameters);
        }
    }

}
