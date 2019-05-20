using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Laboratorio12
{
    class NumericValidationTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry entry)
        {
            double result;
            bool isValid = Double.TryParse(entry.Text, out result);
            entry.TextColor = isValid ? Color.Default : Color.Red;
        }
    }
    
}
