namespace org.ek.HandMeAFile.commons.ApiWrapper.System
{
    public interface IMath
    {
        double Pi { get; }

        /// <summary>
        /// Gibt den Sinus des angegebenen Winkels zurück
        /// </summary>
        /// <param name="angle">Winkel im Bogenmaß</param>
        /// <returns>Sinus des Winkels</returns>
        double Sin(double angle);

        /// <summary>
        /// Gibt den Kosinus des angegebenen Winkels zurück
        /// </summary>
        /// <param name="angle">Winkel im Bogenmaß</param>
        /// <returns>Kosinus des Winkels</returns>
        double Cos(double angle);

        /// <summary>
        /// Gibt einen Winkel zurück, dessen Tangens der Quotient zweier angegebener Zahlen ist
        /// </summary>
        /// <param name="y">Zähler des Quotienten</param>
        /// <param name="x">Nenner des Quotienten</param>
        /// <returns>Winkel im Bogenmaß</returns>
        double ATan2(double y, double x);

        /// <summary>
        /// Rundet einen Gleitkommawert mit einfacher Genauigkeit auf eine angegebene Anzahl von Stellen
        /// </summary>
        /// <param name="value">Zahl</param>
        /// <param name="digits">Nachkommagenauigkeit</param>
        /// <returns>Gerundeter Wert</returns>
        double Round(double value, int digits);

        /// <summary>
        /// Gibt den Absolutbetrag einer Gleitkommazahl mit einfacher Genauigkeit zurück.
        /// </summary>
        /// <param name="value">Zahl zwischen Min und Max value</param>
        /// <returns>Betrag der Zahl</returns>
        float Abs(float value);

        /// <summary>
        /// Rundet einen Gleitkommawert mit einfacher Genauigkeit auf eine angegebene Anzahl von Stellen
        /// </summary>
        /// <param name="value">Zahl</param>
        /// <param name="digits">Nachkommagenauigkeit</param>
        /// <returns>Gerundeter Wert</returns>
        float Round(float value, int digits);

        /// <summary>
        /// Potenziert eine angegebene  Zahl mit den angegebenen Exponenten
        /// </summary>
        /// <param name="x">Basis</param>
        /// <param name="y">Exponent</param>
        /// <returns></returns>
        double Pow(double x, double y);

        /// <summary>
        /// Gibt die Quadratwurzel einer Zahl zurück
        /// </summary>
        /// <param name="value">Wert</param>
        /// <returns>Quadratwurzel des Werts</returns>
        double Sqrt(double value);

        /// <summary>
        /// Gibt die kleinere von zwei Gleitkommazahlen mit doppelter Genauigkeit zurück.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        double Min(double val1, double val2);

        /// <summary>
        /// Gibt die kleinere von zwei 32-Bit-Ganzzahlen mit Vorzeichen zurück.
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <returns></returns>
        int Min(int val1, int val2);

        /// <summary>
        /// Gibt den Absolutbetrag einer Gleitkommazahl mit doppelter Genauigkeit zurück.
        /// </summary>
        /// <param name="value">Zahl zwischen Min und Max value</param>
        /// <returns>Betrag der Zahl</returns>
        double Abs(double value);
    }
}