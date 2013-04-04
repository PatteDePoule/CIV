﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows;
using System.Windows.Markup;
using System.Globalization;

namespace CIV
{
    public class EnumBooleanConverter : ConverterMarkupExtension<EnumBooleanConverter>
    {
        public EnumBooleanConverter()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string parameterString = parameter as string;

            if (parameterString == null)
                return DependencyProperty.UnsetValue;

            if (Enum.IsDefined(value.GetType(), value) == false)
                return DependencyProperty.UnsetValue;

            object parameterValue = Enum.Parse(value.GetType(), parameterString);

            return parameterValue.Equals(value);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string parameterString = parameter as string;

            if (parameterString == null || value.Equals(false))
                return DependencyProperty.UnsetValue;

            return Enum.Parse(targetType, parameterString);
        }

    }
}
