using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace ChatApp_PasanaSubaan.Models
{
    public class IsViewerConverter : IValueConverter
    {
        DataClass dataClass = DataClass.GetInstance;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool retVal = false;

            if (value!= null)
            {
                ConversationModel conversation = value as ConversationModel;

                if (conversation.converseeID.Equals(dataClass.loggedInUser.uid))
                    retVal = true;
            }

            return retVal;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
