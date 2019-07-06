using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamarinDevSummit.ViewModels
{
    public class TabIndexPageViewModel : ViewModelBase
    {
        public TabIndexPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Tab Index";
        }
    }
}
