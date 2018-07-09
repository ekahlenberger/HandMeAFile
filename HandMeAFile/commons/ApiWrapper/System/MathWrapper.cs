using System;

namespace org.ek.HandMeAFile.commons.ApiWrapper.System
{
    public class MathWrapper : IMath
    {
        public double Pi => Math.PI;
        /// <summary>
        /// Gibt den Sinus des angegebenen Winkels zurück
        /// </summary>
        /// <param name="angle">Winkel im Bogenmaß</param>
        /// <returns>Sinus des Winkels</returns>
        public double Sin(double angle)
        {
            return Math.Sin(angle);
        }
        /// <summary>
        /// Gibt den Kosinus des angegebenen Winkels zurück
        /// </summary>
        /// <param name="angle">Winkel im Bogenmaß</param>
        /// <returns>Kosinus des Winkels</returns>
        public double Cos(double angle)
        {
            return Math.Cos(angle);
        }

        /// <summary>
        /// Gibt einen Winkel zurück, dessen Tangens der Quotient zweier angegebener Zahlen ist
        /// </summary>
        /// <param name="y">Zähler des Quotienten</param>
        /// <param name="x">Nenner des Quotienten</param>
        /// <returns>Winkel im Bogenmaß</returns>
        public double ATan2(double y, double x)
        {
            return Math.Atan2(y, x);
        }

        /// <summary>
        /// Rundet einen Gleitkommawert mit einfacher Genauigkeit auf eine angegebene Anzahl von Stellen
        /// </summary>
        /// <param name="value">Zahl</param>
        /// <param name="digits">Nachkommagenauigkeit</param>
        /// <returns>Gerundeter Wert</returns>
        public double Round(double value, int digits)
        {
            return Math.Round(value, digits);
        }

        /// <summary>
        /// Gibt den Absolutbetrag einer Gleitkommazahl mit einfacher Genauigkeit zurück.
        /// </summary>
        /// <param name="value">Zahl zwischen Min und Max value</param>
        /// <returns>Betrag der Zahl</returns>
        public float Abs(float value)
        {
            return Math.Abs(value);
        }
        /// <summary>
        /// Gibt den Absolutbetrag einer Gleitkommazahl mit doppelter Genauigkeit zurück.
        /// </summary>
        /// <param name="value">Zahl zwischen Min und Max value</param>
        /// <returns>Betrag der Zahl</returns>
        public double Abs(double value)
        {
            return Math.Abs(value);
        }
        /// <summary>
        /// Rundet einen Gleitkommawert mit einfacher Genauigkeit auf eine angegebene Anzahl von Stellen
        /// </summary>
        /// <param name="value">Zahl</param>
        /// <param name="digits">Nachkommagenauigkeit</param>
        /// <returns>Gerundeter Wert</returns>
        public float Round(float value, int digits)
        {
            return (float) Math.Round(value, digits);
        }
        /// <summary>
        /// Potenziert eine angegebene  Zahl mit den angegebenen Exponenten
        /// </summary>
        /// <param name="x">Basis</param>
        /// <param name="y">Exponent</param>
        /// <returns></returns>
        public double Pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
        /// <summary>
        /// Gibt die Quadratwurzel einer Zahl zurück
        /// </summary>
        /// <param name="value">Wert</param>
        /// <returns>Quadratwurzel des Werts</returns>
        public double Sqrt(double value)
        {
            return Math.Sqrt(value);
        }
        /// <summary>
        /// Gibt die kleinere von zwei Gleitkommazahlen mit doppelter Genauigkeit zurück.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public double Min(double val1, double val2)
        {
            return Math.Min(val1, val2);
        }
        /// <summary>
        /// Gibt die kleinere von zwei 32-Bit-Ganzzahlen mit Vorzeichen zurück.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        public int Min(int val1, int val2)
        {
            return Math.Min(val1, val2);
        }
    }
}