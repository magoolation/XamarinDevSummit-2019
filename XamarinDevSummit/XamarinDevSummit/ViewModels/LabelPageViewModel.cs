using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XamarinDevSummit.ViewModels
{
    public class LabelPageViewModel : ViewModelBase
    {
        public LabelPageViewModel(INavigationService navigationService): base(navigationService)
        {
            Title = "AutomationId x Label";
        }
    }
}
