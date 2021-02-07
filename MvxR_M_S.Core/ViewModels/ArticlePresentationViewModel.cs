using System.ComponentModel;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvxR_M_S.Core.API;
using MvxR_M_S.Core.Models;

namespace MvxR_M_S.Core.ViewModels
{
    public class ArticlePresentationViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public ArticlePresentationViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new MvxAsyncCommand(() => _navigationService.Navigate<NewArticleViewModel>());
        }

        public IMvxAsyncCommand NavigateCommand { get; private set; }
        public IMvxAsyncCommand GoBackCommand => new MvxAsyncCommand(GoBack);

        public override async void ViewAppeared()
        {
            base.ViewAppeared();
            await LoadArticles(new ArticleEndpoint(new APIHelper()));
        }

        public async Task LoadArticles(ArticleEndpoint articleEndpoint)
        {
            var articleList = await articleEndpoint.GetAll();
            Articles = new BindingList<ArticleModel>(articleList);
        }

        private BindingList<ArticleModel> _articles;

        public BindingList<ArticleModel> Articles
        {
            get { return _articles; }
            set
            {
                SetProperty(ref _articles, value);
            }
        }
        private async Task GoBack()
        {
            await _navigationService.Close(this);
        }
    }
}
