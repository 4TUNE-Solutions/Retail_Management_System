using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvxR_M_S.Core.API;
using MvxR_M_S.Core.Models;

namespace MvxR_M_S.Core.ViewModels
{
    public class NewArticleViewModel : MvxViewModel
    {
        //navigation backing field
        private readonly IMvxNavigationService _navigationService;

        //Article backing fields
        private string _barcode;
        private string _barcode2;
        private string _barcode3;
        private string _barcode4;
        private string _articleName;
        private int _taxId;
        private string _description;
        private string _articleNote;
        private DateTime _expDate;
        private int _supplierId;
        private bool _isService;
        private int _discount;

        //command properites
        public IMvxAsyncCommand GoBackCommand => new MvxAsyncCommand(GoBack);
        public IMvxAsyncCommand SubmitArticleCommand => new MvxAsyncCommand(SendData);

        public NewArticleViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
        
        //Command properties
        public IMvxCommand AddArticleCommand { get; private set; }

        //Article properties
        public string Barcode
        {
            get => _barcode;
            set => SetProperty(ref _barcode, value);
        }

        public string Barcode2
        {
            get => _barcode2;
            set => SetProperty(ref _barcode2, value);
        }

        public string Barcode3
        {
            get => _barcode3;
            set => SetProperty(ref _barcode3, value);
        }

        public string Barcode4
        {
            get => _barcode4;
            set => SetProperty(ref _barcode4, value);
        }

        public string ArticleName
        {
            get => _articleName;
            set => SetProperty(ref _articleName, value);
        }

        public int TaxId
        {
            get => _taxId;
            set => SetProperty(ref _taxId, value);
        }

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        public string ArticleNote
        {
            get => _articleNote;
            set => SetProperty(ref _articleNote, value);
        }

        public DateTime ExpDate
        {
            get => _expDate;
            set => SetProperty(ref _expDate, value);
        }

        public int SupplierId
        {
            get => _supplierId;
            set => SetProperty(ref _supplierId, value);
        }

        public bool IsService
        {
            get => _isService;
            set => SetProperty(ref _isService, value);
        }

        public int Discount
        {
            get => _discount;
            set => SetProperty(ref _discount, value);
        }

        private async Task SendData()
        {
            var ae = new ArticleEndpoint(new APIHelper());
            await ae.Send<ArticleModel>(new ArticleModel
            {
                Barcode = Barcode,
                Barcode2 = Barcode2,
                Barcode3 = Barcode3,
                Barcode4 = Barcode4,
                ArticleName = ArticleName,
                TaxId = TaxId,
                Description = Description,
                ArticleNote = ArticleNote,
                ExpDate = ExpDate,
                SupplierId = SupplierId,
                IsService = IsService,
                Discount = Discount
            });
        }

        private async Task GoBack()
        {
            await _navigationService.Close(this);
        }
    }
}
