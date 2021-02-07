using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MvxR_M_S.Core.ViewModels
{
    class MainPageViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainPageViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            ConfigsNavigationCommand =
                new MvxAsyncCommand(() => _navigationService.Navigate<BusinessConfigViewModel>());
        }

        public IMvxAsyncCommand ConfigsNavigationCommand { get; private set; }
    }
}
