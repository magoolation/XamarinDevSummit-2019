using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XamarinDevSummit.ViewModels
{
    public class AccessibleTreViewModel : ViewModelBase
    {
        public AccessibleTreViewModel(INavigationService navigationService): base(navigationService)
        {
            Title = "Accessible Tree";
        }
    }
}
