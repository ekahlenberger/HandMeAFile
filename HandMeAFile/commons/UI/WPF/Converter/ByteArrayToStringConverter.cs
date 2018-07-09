using System;
using System.Globalization;
using System.Linq;

namespace org.ek.HandMeAFile.commons.UI.WPF.Converter
{
    public class ByteArrayToStringConverter : BaseConverter
    {
        /// <summary>Konvertiert einen Wert.</summary>
        /// <param name="value">
        ///   Der von der Bindungsquelle erzeugte Wert.
        /// </param>
        /// <param name="targetType">
        ///   Der Typ der Bindungsziel-Eigenschaft.
        /// </param>
        /// <param name="parameter">
        ///   Der zu verwendende Konverterparameter.
        /// </param>
        /// <param name="culture">
        ///   Die im Konverter zu verwendende Kultur.
        /// </param>
        /// <returns>
        ///   Ein konvertierter Wert.
        ///    Wenn die Methode <see langword="null" /> zurückgibt, wird der gültige NULL-Wert verwendet.
        /// </returns>
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is byte[] bytes)) return string.Empty;
            return string.Join(" ", bytes.Select(b => b.ToString("X2")).ToArray());
        }

        /// <summary>Konvertiert einen Wert.</summary>
        /// <param name="value">
        ///   Der Wert, der vom Bindungsziel erzeugt wird.
        /// </param>
        /// <param name="targetType">
        ///   Der Typ, in den konvertiert werden soll.
        /// </param>
        /// <param name="parameter">
        ///   Der zu verwendende Konverterparameter.
        /// </param>
        /// <param name="culture">
        ///   Die im Konverter zu verwendende Kultur.
        /// </param>
        /// <returns>
        ///   Ein konvertierter Wert.
        ///    Wenn die Methode <see langword="null" /> zurückgibt, wird der gültige NULL-Wert verwendet.
        /// </returns>
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}