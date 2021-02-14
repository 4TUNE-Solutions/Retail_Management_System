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
    class BusinessConfigViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public BusinessConfigViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            ArticleConfigNavigateCommand = new MvxAsyncCommand(() => _navigationService.Navigate<ArticleOptionsViewModel>());
        }

        //navigation properties
        public IMvxAsyncCommand ArticleConfigNavigateCommand { get; private set; }
        public IMvxAsyncCommand GoBackCommand => new MvxAsyncCommand(GoBack);

        private async Task GoBack()
        {
            await _navigationService.Close(this);
        }
    }
}
