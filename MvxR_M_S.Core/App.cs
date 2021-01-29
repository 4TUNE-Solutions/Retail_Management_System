using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.ViewModels;
using MvxR_M_S.Core.API;
using MvxR_M_S.Core.ViewModels;

namespace MvxR_M_S.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<ArticlePresentationViewModel>();
        }
    }
}
