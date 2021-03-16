﻿using OnSale.Common.Entities;
using OnSale.Prism.Views;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnSale.Prism.ItemViewModels
{
    public class ProductItemViewModel : Product
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
            await _navigationService.NavigateAsync(nameof(ProductDetailPage));
        }
    }

}
