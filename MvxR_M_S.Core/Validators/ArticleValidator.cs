using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MvxR_M_S.Core.Models;

namespace MvxR_M_S.Wpf.Validators
{
    public class ArticleValidator : AbstractValidator<ArticleModel>
    {
        public ArticleValidator()
        {
            RuleFor(a => a.ArticleName)
                .NotEmpty().WithMessage("Article name can not is empty!");

            RuleFor(a => a.TaxId)
                .NotEmpty().WithMessage("Tax Id can not be empty!");
        }
    }
}
