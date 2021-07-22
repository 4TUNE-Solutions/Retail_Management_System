using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvxR_M_S.Core.API;
using MvxR_M_S.Core.Models;

namespace MvxR_M_S.Core.ViewModels
{
    class DeleteArticleViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private BindingList<ArticleModel> _articles;
        private ArticleModel _articleId;

        public DeleteArticleViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand GoBackCommand => new MvxAsyncCommand(GoBack);

        public IMvxAsyncCommand DeleteCommand => new MvxAsyncCommand(DeleteArticle);

        public BindingList<ArticleModel> Articles
        {
            get { return _articles; }
            set
            {
                SetProperty(ref _articles, value);
            }
        }

        public ArticleModel ArticleId
        {
            get { return _articleId; }
            set
            {
                SetProperty(ref _articleId, value);
            }
        }

        //Calling method when View finished loading
        public override async void ViewAppeared()
        {
            base.ViewAppeared();
            await LoadArticles(new ArticleEndpoint(new APIHelper()));
        }

        //Article Retrieval from database
        public async Task LoadArticles(ArticleEndpoint articleEndpoint)
        {
            var articleList = await articleEndpoint.GetAll();
            Articles = new BindingList<ArticleModel>(articleList);
        }

        //Command methods
        public async Task DeleteArticle()
        {
            var ae = new ArticleEndpoint(new APIHelper());

            await ae.Delete(ArticleId.id);
            await LoadArticles(new ArticleEndpoint(new APIHelper()));
        }

        private async Task GoBack()
        {
            await _navigationService.Close(this);
        }
    }
}
