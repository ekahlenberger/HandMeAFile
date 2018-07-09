using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.Extensions;
using org.ek.HandMeAFile.commons.Extensions.Convert;

namespace org.ek.HandMeAFile.commons.Tools
{
    public class NaturalString : IEquatable<string>, IComparable<NaturalString>,IComparable<string> , IComparable
    { 
        private readonly string m_org;
        private object[] m_parts = new object[0];
        public int Segments => m_parts.Length;
        public string Raw => m_org;
        public NaturalString() : this(string.Empty)
        {
            
        }
        public NaturalString([NotNull] string org)
        {
            m_org = org ?? throw new ArgumentNullException(nameof(org));
            InitDetails();
        }

        private void InitDetails()
        {
            if (m_org == null) return;
            if (m_org.IsNullOrWhitespace())
            {
                m_parts = new object[]{m_org};
                return;
            }


            MatchCollection matches = Regex.Matches(m_org, "(\\d+)", RegexOptions.Multiline);
            int nextSearchIndex = 0;
            List<object> parts = new List<object>();
            foreach (Group group in matches.OfType<Match>().SelectMany(m => m.Groups.OfType<Group>().Skip(1)))
            {
                // ReSharper disable once StringIndexOfIsCultureSpecific.2
                int index = m_org.IndexOf(group.Value, nextSearchIndex);
                if (index > nextSearchIndex)
                {
                    string part = m_org.Substring(nextSearchIndex, index-nextSearchIndex);
                    Convertable<long> convertable = part.ConvertToLong();
                    if (convertable.Works())
                        parts.Add((long)convertable);
                    else
                        parts.Add(part);
                    nextSearchIndex += part.Length;
                }
                if (index == nextSearchIndex)
                {
                    string part = m_org.Substring(index,group.Value.Length);
                    if (part.ConvertToLong().Works())
                        parts.Add((long) part.ConvertToLong());
                    else
                        parts.Add(part);
                    nextSearchIndex = index + group.Value.Length;
                }               
            }

            if (nextSearchIndex < m_org.Length)
            {
                string            lastPart    = m_org.Substring(nextSearchIndex, m_org.Length - nextSearchIndex);
                Convertable<long> convertable = lastPart.ConvertToLong();
                if (convertable.Works())
                    parts.Add((long) convertable);
                else
                    parts.Add(lastPart);
            }
            m_parts = parts.ToArray();
        }

        protected bool Equals(NaturalString other)
        {
            return CompareTo(other) == 0;
        }
        /// <summary>Gibt an, ob das aktuelle Objekt gleich einem anderen Objekt des gleichen Typs ist.</summary>
        /// <returns>true, wenn das aktuelle Objekt gleich dem <paramref name="other" />-Parameter ist, andernfalls false.</returns>
        /// <param name="other">Ein Objekt, das mit diesem Objekt verglichen werden soll.</param>
        public bool Equals(string other)
        {
            return CompareTo(other) == 0;
        }
        /// <summary>Gibt an, ob das aktuelle Objekt gleich einem anderen Objekt des gleichen Typs ist.</summary>
        /// <returns>true, wenn das aktuelle Objekt gleich dem <paramref name="other" />-Parameter ist, andernfalls false.</returns>
        /// <param name="other">Ein Objekt, das mit diesem Objekt verglichen werden soll.</param>
        /// <param name="comparisonType">Art des Stringvergleiches</param>
        public bool Equals(NaturalString other, StringComparison comparisonType)
        {
            return CompareTo(other,comparisonType) == 0;
        }

        /// <summary>Bestimmt, ob das angegebene Objekt mit dem aktuellen Objekt identisch ist.</summary>
        /// <returns>true, wenn das angegebene Objekt und das aktuelle Objekt gleich sind, andernfalls false.</returns>
        /// <param name="obj">Das Objekt, das mit dem aktuellen Objekt verglichen werden soll.</param>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType() && obj.GetType() != typeof(string)) return false;
            return Equals((NaturalString)obj);
        }
        /// <summary>Fungiert als Hashfunktion für einen bestimmten Typ.</summary>
        /// <returns>Ein Hashcode für das aktuelle Objekt.</returns>
        public override int GetHashCode()
        {
            // ReSharper disable once NonReadonlyMemberInGetHashCode
            return m_org != null ? m_parts.Aggregate(0, (hash, part) => (hash * 397) ^ part.GetHashCode()) : 0;
        }
        /// <summary>Returns a value that indicates whether the values of two <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> objects are equal.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
        public static bool operator ==(NaturalString left, NaturalString right)
        {
            return Equals(left, right);
        }
        /// <summary>Returns a value that indicates whether two <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> objects have different values.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
        public static bool operator !=(NaturalString left, NaturalString right)
        {
            return !Equals(left, right);
        }

        public static implicit operator string(NaturalString ns) => ns?.m_org;
        public static implicit operator NaturalString(string s) => s == null ? null : new NaturalString(s);

        /// <summary>Vergleicht das aktuelle Objekt mit einem anderen Objekt desselben Typs.</summary>
        /// <returns>Ein Wert, der die relative Reihenfolge der verglichenen Objekte angibt. Der Rückgabewert hat folgende Bedeutung: Wert  Bedeutung  Kleiner als 0  Dieses Objekt ist kleiner als der <paramref name="other" />-Parameter. Zero  Dieses Objekt ist gleich <paramref name="other" />.  Größer als 0 (null)  Dieses Objekt ist größer als <paramref name="other" />.</returns>
        /// <param name="other">Ein Objekt, das mit diesem Objekt verglichen werden soll.</param>
        /// <param name="comparisonType">Art des Stringvergleiches</param>
        public int CompareTo(NaturalString other, StringComparison comparisonType)
        {
            for (var i = 0; i < m_parts.Length && i < other.m_parts.Length; i++)
            {
                int result  = Compare(m_parts[i], other.m_parts[i],comparisonType);
                if (result != 0) return result;
            }

            return m_parts.Length.CompareTo(other.m_parts.Length);
        }
        private static int Compare(object a, object b, StringComparison comparisonType = StringComparison.CurrentCulture)
        {
            if (a is string strA && b is string strB) return string.Compare(strA, strB, comparisonType);
            if (a is long longA  && b is long longB) return longA.CompareTo(longB);
            return string.Compare(a.ToString(), b.ToString(), comparisonType);
        }
        /// <summary>Vergleicht das aktuelle Objekt mit einem anderen Objekt desselben Typs.</summary>
        /// <returns>Ein Wert, der die relative Reihenfolge der verglichenen Objekte angibt. Der Rückgabewert hat folgende Bedeutung: Wert  Bedeutung  Kleiner als 0  Dieses Objekt ist kleiner als der <paramref name="other" />-Parameter. Zero  Dieses Objekt ist gleich <paramref name="other" />.  Größer als 0 (null)  Dieses Objekt ist größer als <paramref name="other" />.</returns>
        /// <param name="other">Ein Objekt, das mit diesem Objekt verglichen werden soll.</param>
        public int CompareTo(NaturalString other)
        {
            return CompareTo(other, StringComparison.CurrentCulture);
        }

        public static bool Equals(NaturalString first, NaturalString second, StringComparison comparison = StringComparison.CurrentCulture)
        {
            if (ReferenceEquals(first, null) && ReferenceEquals(second, null)) return true;
            if (ReferenceEquals(first, null) || ReferenceEquals(second, null)) return false;
            return first.Equals(second,comparison);
        }
        public static int CompareTo(NaturalString first, NaturalString second, StringComparison comparison = StringComparison.CurrentCulture)
        {
            if (ReferenceEquals(first, null) && ReferenceEquals(second, null)) return 0;
            if (ReferenceEquals(first, null)) return -1;
            if (ReferenceEquals(second, null)) return 1;
            return first.CompareTo(second, comparison);
        }
        /// <summary>Vergleicht das aktuelle Objekt mit einem anderen Objekt desselben Typs.</summary>
        /// <returns>Ein Wert, der die relative Reihenfolge der verglichenen Objekte angibt. Der Rückgabewert hat folgende Bedeutung: Wert  Bedeutung  Kleiner als 0  Dieses Objekt ist kleiner als der <paramref name="other" />-Parameter. Zero  Dieses Objekt ist gleich <paramref name="other" />.  Größer als 0 (null)  Dieses Objekt ist größer als <paramref name="other" />.</returns>
        /// <param name="other">Ein Objekt, das mit diesem Objekt verglichen werden soll.</param>
        /// <param name="comparisonType">Art des Stringvergleiches</param>
        public int CompareTo(string other, StringComparison comparisonType)
        {
            return CompareTo((NaturalString) other, comparisonType);
        }
        /// <summary>Vergleicht das aktuelle Objekt mit einem anderen Objekt desselben Typs.</summary>
        /// <returns>Ein Wert, der die relative Reihenfolge der verglichenen Objekte angibt. Der Rückgabewert hat folgende Bedeutung: Wert  Bedeutung  Kleiner als 0  Dieses Objekt ist kleiner als der <paramref name="other" />-Parameter. Zero  Dieses Objekt ist gleich <paramref name="other" />.  Größer als 0 (null)  Dieses Objekt ist größer als <paramref name="other" />.</returns>
        /// <param name="other">Ein Objekt, das mit diesem Objekt verglichen werden soll.</param>
        public int CompareTo(string other)
        {
            return CompareTo(other,StringComparison.CurrentCulture);
        }
        
        /// <summary>Vergleicht die aktuelle Instanz mit einem anderen Objekt vom selben Typ und gibt eine ganze Zahl zurück, die angibt, ob die aktuelle Instanz in der Sortierreihenfolge vor oder nach dem anderen Objekt oder an derselben Position auftritt.</summary>
        /// <returns>Ein Wert, der die relative Reihenfolge der verglichenen Objekte angibt. Der Rückgabewert hat folgende Bedeutung: Wert  Bedeutung  Kleiner als 0  Diese Instanz befindet sich in der Sortierreihenfolge vor <paramref name="obj" />.  Zero  Diese Instanz tritt in der Sortierreihenfolge an der gleichen Position wie <paramref name="obj" /> auf.  Größer als 0 (null)  Diese Instanz folgt in der Sortierreihenfolge auf <paramref name="obj" />.</returns>
        /// <param name="obj">Ein Objekt, das mit dieser Instanz verglichen werden soll.</param>
        /// <exception cref="T:System.ArgumentException">
        /// <paramref name="obj" /> hat nicht denselben Typ wie diese Instanz.</exception>
        public int CompareTo(object obj)
        {
            if (ReferenceEquals(null, obj)) return 1;
            if (ReferenceEquals(this, obj)) return 0;
            if (obj is string otherStr) return CompareTo(otherStr);
            if (!(obj is NaturalString)) throw new ArgumentException($"Object must be of type {nameof(NaturalString)} or {nameof(String)}");
            return CompareTo((NaturalString) obj);
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is less than another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is less than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator <(NaturalString left, NaturalString right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) < 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is less than another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is less than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator <(NaturalString left, string right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) < 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is less than another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is less than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator <(string left, NaturalString right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) < 0;
        }

        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is greater than another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator >(NaturalString left, NaturalString right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) > 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is greater than another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator >(NaturalString left, string right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) > 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is greater than another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator >(string left, NaturalString right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) > 0;
        }

        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is less than or equal to another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, false.</returns>
        public static bool operator <=(NaturalString left, NaturalString right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) <= 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is less than or equal to another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, false.</returns>
        public static bool operator <=(NaturalString left, string right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) <= 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is less than or equal to another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, false.</returns>
        public static bool operator <=(string left, NaturalString right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) <= 0;
        }

        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is greater than or equal to another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator >=(NaturalString left, NaturalString right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) >= 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is greater than or equal to another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator >=(NaturalString left, string right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) >= 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value is greater than or equal to another <see cref="T:org.ek.HandMeAFile.commons.Tools.NaturalString" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator >=(string left, NaturalString right)
        {
            return Comparer<NaturalString>.Default.Compare(left, right) >= 0;
        }
        /// <summary>Gibt eine Zeichenfolge zurück, die das aktuelle Objekt darstellt.</summary>
        /// <returns>Eine Zeichenfolge, die das aktuelle Objekt darstellt.</returns>
        public override string ToString()
        {
            return m_org;
        }
    }
}
