using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinDevSummit.CustomControls
{
    public class AccessibleBar : BoxView
    {
        public AccessibleBar()
        {
            SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
        }

        public string Label
        {
            get => (string)GetValue(AutomationProperties.NameProperty);
            set => SetValue(AutomationProperties.NameProperty, value);
        }
    }
}
