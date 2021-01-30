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
    public class NewArticleViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public IMvxAsyncCommand GoBackCommand => new MvxAsyncCommand(GoBack);

        public NewArticleViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private async Task GoBack()
        {
            await _navigationService.Close(this);
        }
    }
}
