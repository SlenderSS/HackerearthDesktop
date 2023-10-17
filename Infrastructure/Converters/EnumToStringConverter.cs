using HackerearthDesktop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerearthDesktop.Infrastructure.Common;

namespace HackerearthDesktop.Infrastructure.Converters
{
    class EnumToStringConverter : Converter
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is RequestStatus status)) return null;

            return status.DisplayName();
        }
    }
}
