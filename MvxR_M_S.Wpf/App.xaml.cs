using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace MvxR_M_S.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : MvxApplication
    {
        protected override void RegisterSetup()
        {
            this.RegisterSetupType<MvxWpfSetup<Core.App>>();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzk2NjU3QDMxMzgyZTM0MmUzMFlSQUhnNjJJNi9rSlo2RmFVSlFRekZzeUpRNGFLTXBkZ2hjUGZZamlLK0E9");
        }
    }
}
