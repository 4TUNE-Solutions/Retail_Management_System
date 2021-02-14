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
    class ChangeArticleViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private BindingList<ArticleModel> _articles;
        private ArticleModel _selectedArticle;
        private BindingList<string> _statusMessages = new BindingList<string>();

        public ChangeArticleViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public IMvxAsyncCommand GoBackCommand => new MvxAsyncCommand(GoBack);
        public IMvxAsyncCommand SubmitNewArticle => new MvxAsyncCommand(ChangeArticle);

        public ArticleModel SelectedArticle
        {
            get { return _selectedArticle; }
            set
            {
                SetProperty(ref _selectedArticle, value);
            }
        }

        public BindingList<ArticleModel> Articles
        {
            get
            {
                return _articles;
            }
            set
            {
                SetProperty(ref _articles, value);
            }
        }

        public BindingList<string> StatusMessages => _statusMessages;
        

        public async Task ChangeArticle()
        {

            var ae = new ArticleEndpoint(new APIHelper());
            await ae.Change<ArticleModel>(SelectedArticle.Id, SelectedArticle);

            _statusMessages.Clear();
            StatusMessages.Add("Success!");

            //clear fields
            SelectedArticle.Barcode = "";
            SelectedArticle.Barcode2 = "";
            SelectedArticle.Barcode3 = "";
            SelectedArticle.Barcode4 = "";
            SelectedArticle.ArticleName = "";
            SelectedArticle.ArticleNote = "";
            SelectedArticle.Description = "";
            SelectedArticle.TaxId = 0;
            SelectedArticle.Discount = 0;
            SelectedArticle.ExpDate = DateTime.Now;
            SelectedArticle.SupplierId = 0;

            await LoadArticles(new ArticleEndpoint(new APIHelper()));

        }

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

        public async Task GoBack()
        {
            await _navigationService.Close(this);
        }
    }
}
