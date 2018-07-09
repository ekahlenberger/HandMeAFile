using System;
using System.Globalization;
using System.Linq;
using System.Windows;

namespace org.ek.HandMeAFile.commons.UI.WPF.Converter
{
    public class AnyBoolToVisibilityConverter : MultiBaseConverter
    {
        public bool Collapse { get; set; }
        /// <summary>Konvertiert Quellwerte in einen Wert für das Bindungsziel. Das Datenbindungsmodul ruft diese Methode auf, wenn es Werte aus den Quellbindungen an das Bindungsziel weitergibt.</summary>
        /// <returns>Ein konvertierter Wert. Wenn die Methode null zurückgibt, wird der gültige null-Wert verwendet. Der Rückgabewert <see cref="T:System.Windows.DependencyProperty" />.<see cref="F:System.Windows.DependencyProperty.UnsetValue" /> gibt an, dass der Konverter keinen Wert erstellt und dass die Bindung den <see cref="P:System.Windows.Data.BindingBase.FallbackValue" /> verwendet, falls vorhanden, oder andernfalls den Standardwert. Der Rückgabewert <see cref="T:System.Windows.Data.Binding" />.<see cref="F:System.Windows.Data.Binding.DoNothing" /> gibt an, dass die Bindung den Wert nicht überträgt oder den <see cref="P:System.Windows.Data.BindingBase.FallbackValue" /> oder den Standardwert verwendet.</returns>
        /// <param name="values">Der Wertearray, den die Quellbindungen in dem <see cref="T:System.Windows.Data.MultiBinding" /> erzeugen. Der Wert <see cref="F:System.Windows.DependencyProperty.UnsetValue" /> gibt an, dass die Quellbindung keinen Wert für die Konvertierung bereitstellen kann.</param>
        /// <param name="targetType">Der Typ der Bindungsziel-Eigenschaft.</param>
        /// <param name="parameter">Der zu verwendende Konverterparameter.</param>
        /// <param name="culture">Die im Konverter zu verwendende Kultur.</param>
        public override object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.OfType<bool>().Any(b => b)) return Visibility.Visible;
            return Collapse ? Visibility.Collapsed : Visibility.Hidden;
            
        }

        /// <summary>Konvertiert einen Bindungsziel-Wert in Werte für die Quellbindung.</summary>
        /// <returns>Ein Array von Werten, die aus dem Zielwert in die Quellwerte zurückkonvertiert wurden.</returns>
        /// <param name="value">Der Wert, den das Bindungsziel erzeugt.</param>
        /// <param name="targetTypes">Das Array der Typen, in die konvertiert werden soll. Die Arraylänge gibt die Anzahl und die Typen der Werte an, die der Methode für die Rückgabe vorgeschlagen werden.</param>
        /// <param name="parameter">Der zu verwendende Konverterparameter.</param>
        /// <param name="culture">Die im Konverter zu verwendende Kultur.</param>
        public override object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}