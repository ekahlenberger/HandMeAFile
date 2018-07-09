using System;
using System.Globalization;

namespace org.ek.HandMeAFile.commons.UI.WPF.Converter
{
    public class ReadableDecimalConverter : BaseConverter
    {
        public double Digits { get; set; } = 3;
        public string GigaPrefix { get; set; } = "G";
        /// <summary>
        /// Konvertiert einen Wert.
        /// </summary>
        /// <returns>
        /// Ein konvertierter Wert. Wenn die Methode null zurückgibt, wird der gültige NULL-Wert verwendet.
        /// </returns>
        /// <param name="value">Der von der Bindungsquelle erzeugte Wert.</param><param name="targetType">Der Typ der Bindungsziel-Eigenschaft.</param><param name="parameter">Der zu verwendende Konverterparameter.</param><param name="culture">Die im Konverter zu verwendende Kultur.</param>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Decimal d)
            {
                string append = string.Empty;
                if (d > 1000000000)
                    append = GigaPrefix;
                else if (d > 1000000)
                    append = "M";
                else if (d > 1000)
                    append = "k";
                double dbl = (double) d;
                double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(dbl))) + 1 - Digits);
                return Math.Truncate(dbl / scale) + append;
            }
            return string.Empty;
        }
        
        /// <summary>
        /// Konvertiert einen Wert.
        /// </summary>
        /// <returns>
        /// Ein konvertierter Wert. Wenn die Methode null zurückgibt, wird der gültige NULL-Wert verwendet.
        /// </returns>
        /// <param name="value">Der Wert, der vom Bindungsziel erzeugt wird.</param><param name="targetType">Der Typ, in den konvertiert werden soll.</param><param name="parameter">Der zu verwendende Konverterparameter.</param><param name="culture">Die im Konverter zu verwendende Kultur.</param>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}