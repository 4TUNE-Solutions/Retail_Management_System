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
    class ArticleOptionsViewModel : MvxViewModel
    {
        //navigation backing field
        private readonly IMvxNavigationService _navigationService;

        public ArticleOptionsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            ShowArticlesNavigationCommand =
                new MvxAsyncCommand(() => _navigationService.Navigate<ArticlePresentationViewModel>());
            InputArticlesNavigationCommand =
                new MvxAsyncCommand(() => _navigationService.Navigate<NewArticleViewModel>());
            DeleteArticlesNavigationCommand =
                new MvxAsyncCommand(() => _navigationService.Navigate<DeleteArticleViewModel>());
        }

        //command properties
        public IMvxAsyncCommand GoBackCommand => new MvxAsyncCommand(GoBack);
        
        public IMvxAsyncCommand ShowArticlesNavigationCommand { get; private set; }

        public IMvxAsyncCommand InputArticlesNavigationCommand { get; private set; }

        public IMvxAsyncCommand DeleteArticlesNavigationCommand { get; private set; }

        private async Task GoBack()
        {
            await _navigationService.Close(this);
        }
    }
}
