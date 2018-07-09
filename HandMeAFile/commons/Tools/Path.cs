using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.Tools
{
    public class Path : IEquatable<string>, IComparable<Path>, IComparable<string>, IComparable, IReadOnlyList<string>
    {
        public           StringComparison DefaultComparison { get; }
        public           string           Separator         { get; }
        private readonly string           m_org;
        private readonly int              m_hashCode;
        private readonly List<string>     m_parts;

        /// <summary>Ruft die Anzahl der Elemente in der Auflistung ab.</summary>
        /// <returns>Die Anzahl der Elemente in der Auflistung.</returns>
        public int Count => m_parts.Count;

        public string Raw => m_org;

        public Path([NotNull] string org, string separator = "\\", StringComparison defaultComparison = StringComparison.CurrentCulture)
        {
            DefaultComparison = defaultComparison;
            Separator         = separator ?? "\\";
            m_org             = org       ?? throw new ArgumentNullException(nameof(org));

            string normalized                                 = m_org;
            while (normalized.EndsWith(Separator)) normalized = normalized.Substring(0, normalized.Length - Separator.Length);
            m_hashCode = normalized.GetHashCode();

            if (m_org == string.Empty)
                m_parts = new List<string>();
            else
            {
                string escapedSep = Regex.Escape(Separator);
                m_parts = Regex.Split(normalized, $@"(?<!{escapedSep}){escapedSep}(?!{escapedSep})").ToList();
            }
        }

        public Path(IEnumerable<string> enumerable, string separator = "\\", StringComparison defaultComparison = StringComparison.CurrentCulture)
        {
            m_parts           = enumerable.ToList();
            Separator         = separator;
            DefaultComparison = defaultComparison;
            m_org             = string.Join(Separator, m_parts);
            m_hashCode        = m_org.GetHashCode();
        }

        protected bool Equals(Path other)
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
        public bool Equals(Path other, PathComparison comparisonType)
        {
            return CompareTo(other, comparisonType) == 0;
        }

        /// <summary>Bestimmt, ob das angegebene Objekt mit dem aktuellen Objekt identisch ist.</summary>
        /// <returns>true, wenn das angegebene Objekt und das aktuelle Objekt gleich sind, andernfalls false.</returns>
        /// <param name="obj">Das Objekt, das mit dem aktuellen Objekt verglichen werden soll.</param>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType() && obj.GetType() != typeof(string)) return false;
            return Equals((Path) obj);
        }

        /// <summary>Fungiert als Hashfunktion für einen bestimmten Typ.</summary>
        /// <returns>Ein Hashcode für das aktuelle Objekt.</returns>
        public override int GetHashCode()
        {
            return m_hashCode;
        }

        /// <summary>Gibt einen Enumerator zurück, der eine Auflistung durchläuft.</summary>
        /// <returns>Ein <see cref="T:System.Collections.IEnumerator" />-Objekt, das zum Durchlaufen der Auflistung verwendet werden kann.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>Returns a value that indicates whether the values of two <see cref="T:org.ek.HandMeAFile.commons.Tools.Path" /> objects are equal.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
        public static bool operator ==(Path left, Path right)
        {
            return Equals(left, right);
        }

        /// <summary>Returns a value that indicates whether two <see cref="T:org.ek.HandMeAFile.commons.Tools.Path" /> objects have different values.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
        public static bool operator !=(Path left, Path right)
        {
            return !Equals(left, right);
        }

        public static implicit operator string(Path ns) => ns?.m_org;
        public static explicit operator Path(string s) => s == null ? null : new Path(s);
        public static implicit operator NaturalString(Path s) => new NaturalString(s.m_org);
        public static explicit operator Path(NaturalString s) => new Path(s);

        /// <summary>Vergleicht das aktuelle Objekt mit einem anderen Objekt desselben Typs.</summary>
        /// <returns>Ein Wert, der die relative Reihenfolge der verglichenen Objekte angibt. Der Rückgabewert hat folgende Bedeutung: Wert  Bedeutung  Kleiner als 0  Dieses Objekt ist kleiner als der <paramref name="other" />-Parameter. Zero  Dieses Objekt ist gleich <paramref name="other" />.  Größer als 0 (null)  Dieses Objekt ist größer als <paramref name="other" />.</returns>
        /// <param name="other">Ein Objekt, das mit diesem Objekt verglichen werden soll.</param>
        /// <param name="comparisonType">Art des Stringvergleiches</param>
        public int CompareTo(Path other, PathComparison comparisonType)
        {
            StringComparison stringComparison = comparisonType.ConvertToStringComparison().OrDefault(DefaultComparison);
            for (var i = 0; i < m_parts.Count && i < other.m_parts.Count; i++)
            {
                int result = string.Compare(m_parts[i], other.m_parts[i], stringComparison);
                if (result != 0) return result;
            }

            return m_parts.Count.CompareTo(other.m_parts.Count);
        }

        /// <summary>Vergleicht das aktuelle Objekt mit einem anderen Objekt desselben Typs.</summary>
        /// <returns>Ein Wert, der die relative Reihenfolge der verglichenen Objekte angibt. Der Rückgabewert hat folgende Bedeutung: Wert  Bedeutung  Kleiner als 0  Dieses Objekt ist kleiner als der <paramref name="other" />-Parameter. Zero  Dieses Objekt ist gleich <paramref name="other" />.  Größer als 0 (null)  Dieses Objekt ist größer als <paramref name="other" />.</returns>
        /// <param name="other">Ein Objekt, das mit diesem Objekt verglichen werden soll.</param>
        public int CompareTo(Path other)
        {
            return CompareTo(other, PathComparison.Default);
        }

        public static bool Equals(Path first, Path second, PathComparison comparison = PathComparison.Default)
        {
            if (ReferenceEquals(first, null) && ReferenceEquals(second, null)) return true;
            if (ReferenceEquals(first, null) || ReferenceEquals(second, null)) return false;
            return first.Equals(second, comparison);
        }

        public static int CompareTo(Path first, Path second, PathComparison comparison = PathComparison.Default)
        {
            if (ReferenceEquals(first, null) && ReferenceEquals(second, null)) return 0;
            if (ReferenceEquals(first,  null)) return -1;
            if (ReferenceEquals(second, null)) return 1;
            return first.CompareTo(second, comparison);
        }

        /// <summary>Vergleicht das aktuelle Objekt mit einem anderen Objekt desselben Typs.</summary>
        /// <returns>Ein Wert, der die relative Reihenfolge der verglichenen Objekte angibt. Der Rückgabewert hat folgende Bedeutung: Wert  Bedeutung  Kleiner als 0  Dieses Objekt ist kleiner als der <paramref name="other" />-Parameter. Zero  Dieses Objekt ist gleich <paramref name="other" />.  Größer als 0 (null)  Dieses Objekt ist größer als <paramref name="other" />.</returns>
        /// <param name="other">Ein Objekt, das mit diesem Objekt verglichen werden soll.</param>
        /// <param name="comparisonType">Art des Stringvergleiches</param>
        public int CompareTo(string other, PathComparison comparisonType)
        {
            return CompareTo(new Path(other, Separator), comparisonType);
        }

        /// <summary>Vergleicht das aktuelle Objekt mit einem anderen Objekt desselben Typs.</summary>
        /// <returns>Ein Wert, der die relative Reihenfolge der verglichenen Objekte angibt. Der Rückgabewert hat folgende Bedeutung: Wert  Bedeutung  Kleiner als 0  Dieses Objekt ist kleiner als der <paramref name="other" />-Parameter. Zero  Dieses Objekt ist gleich <paramref name="other" />.  Größer als 0 (null)  Dieses Objekt ist größer als <paramref name="other" />.</returns>
        /// <param name="other">Ein Objekt, das mit diesem Objekt verglichen werden soll.</param>
        public int CompareTo(string other)
        {
            return CompareTo(other, PathComparison.Default);
        }

        /// <summary>
        /// Replaces the first occurence of search in this <see cref="Path"/> by replace matching by comparison rules up to the max start index
        /// </summary>
        /// <param name="search">pattern to search for</param>
        /// <param name="replace">string to replace the pattern with</param>
        /// <param name="comparison">type of string comparison</param>
        /// <param name="maxStartIndex">latest index the search can occur in this instance to be replaced</param>
        /// <returns></returns>
        [Pure]
        public Path Replace([NotNull] Path search, [NotNull] Path replace, PathComparison comparison = PathComparison.Default, int maxStartIndex = int.MaxValue)
        {
            if (search  == null) throw new ArgumentNullException(nameof(search));
            if (replace == null) throw new ArgumentNullException(nameof(replace));

            if (Count < search.Count) return this;
            int startIndex = IndexOf(search.m_parts[0], 0, comparison);
            if (startIndex         > maxStartIndex) return this;
            if (startIndex         < 0) return this;
            if (Count + startIndex < search.Count) return this;

            StringComparison stringComparison = comparison.ConvertToStringComparison().OrDefault(DefaultComparison);
            while (startIndex > -1)
            {
                bool equal = true;
                for (var i = 0; i + startIndex < m_parts.Count && i < search.m_parts.Count; i++)
                {
                    if (!string.Equals(m_parts[i + startIndex], search.m_parts[i], stringComparison))
                    {
                        startIndex = IndexOf(search.m_parts[0], i + startIndex + 1);
                        if (startIndex > maxStartIndex) return this;
                        equal = false;
                        break;
                    }
                }

                if (equal) break;
            }

            if (startIndex == -1) return this;
            return new Path(this.Take(startIndex).Concat(replace).Concat(this.Skip(startIndex + search.Count)), Separator, DefaultComparison);
        }
        [Pure]
        public Path ReplaceFromStart(Path search, Path replace, PathComparison comparison = PathComparison.Default)
        {
            return Replace(search, replace, comparison, 0);
        }
        [Pure]
        public Path Replace([NotNull] string search, [NotNull] string replace, PathComparison comparison = PathComparison.Default, int maxStartIndex = int.MaxValue)
        {
            return Replace(new Path(search, Separator), new Path(replace, Separator), comparison, maxStartIndex);
        }
        [Pure]
        public Path ReplaceFromStart(string search, string replace, PathComparison comparison = PathComparison.Default)
        {
            return Replace(search, replace, comparison, 0);
        }
        [Pure]
        public int IndexOf(string item, int index = 0, PathComparison comparison = PathComparison.Default)
        {
            StringComparison stringComparison = comparison.ConvertToStringComparison().OrDefault(DefaultComparison);
            return m_parts.FindIndex(index, part => string.Equals(part, item, stringComparison));
        }
        [Pure]
        public bool StartsWith(Path start, PathComparison comparison = PathComparison.Default)
        {
            if (start.Count > Count) return false;
            StringComparison stringComparison = comparison.ConvertToStringComparison().OrDefault(DefaultComparison);
            for (var i = 0; i < start.Count; i++)
            {
                if (!string.Equals(this[i], start[i], stringComparison))
                    return false;
            }

            return true;
        }
        [Pure]
        public Path RemoveStart(Path remove, PathComparison comparison = PathComparison.Default)
        {
            return ReplaceFromStart(remove, Empty(Separator,DefaultComparison), comparison);
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
            if (!(obj is Path)) throw new ArgumentException($"Object must be of type {nameof(Path)} or {nameof(String)}");
            return CompareTo((Path) obj);
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.Path" /> value is less than another <see cref="T:org.ek.HandMeAFile.commons.Tools.Path" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is less than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator <(Path left, Path right)
        {
            return Comparer<Path>.Default.Compare(left, right) < 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.Path" /> value is greater than another <see cref="T:org.ek.HandMeAFile.commons.Tools.Path" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator >(Path left, Path right)
        {
            return Comparer<Path>.Default.Compare(left, right) > 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.Path" /> value is less than or equal to another <see cref="T:org.ek.HandMeAFile.commons.Tools.Path" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is less than or equal to <paramref name="right" />; otherwise, false.</returns>
        public static bool operator <=(Path left, Path right)
        {
            return Comparer<Path>.Default.Compare(left, right) <= 0;
        }
        /// <summary>Returns a value that indicates whether a <see cref="T:org.ek.HandMeAFile.commons.Tools.Path" /> value is greater than or equal to another <see cref="T:org.ek.HandMeAFile.commons.Tools.Path" /> value.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> is greater than <paramref name="right" />; otherwise, false.</returns>
        public static bool operator >=(Path left, Path right)
        {
            return Comparer<Path>.Default.Compare(left, right) >= 0;
        }
        public static Path operator +(Path first, Path second)
        {
            return first.Append(second);
        }
        public static Path operator +(Path first, string second)
        {
            return first.Append(second);
        }

        /// <summary>Gibt einen Enumerator zurück, der die Auflistung durchläuft.</summary>
        /// <returns>Ein <see cref="T:System.Collections.Generic.IEnumerator`1" />, der zum Durchlaufen der Auflistung verwendet werden kann.</returns>
        public IEnumerator<string> GetEnumerator()
        {
            return m_parts.ToList().GetEnumerator();
        }
        /// <summary>Gibt eine Zeichenfolge zurück, die das aktuelle Objekt darstellt.</summary>
        /// <returns>Eine Zeichenfolge, die das aktuelle Objekt darstellt.</returns>
        public override string ToString()
        {
            return m_org;
        }
        /// <summary>Ruft das Element am angegebenen Index in der schreibgeschützten Liste ab.</summary>
        /// <returns>Das Element am angegebenen Index in der schreibgeschützten Liste.</returns>
        /// <param name="index">Der nullbasierte Index des abzurufenden Elements.</param>
        public string this[int index] => m_parts[index];

        public Path GetParent()
        {
            return new Path(m_parts.Take(m_parts.Count - 1), Separator, DefaultComparison);
        }
        public IEnumerable<Path> GetAncestors()
        {
            Path p = this;
            while (p.Count > 1)
                yield return p = p.GetParent();
        }
        public Path Append(string add)
        {
            return Append(new Path(add, Separator, DefaultComparison));
        }
        public Path Append(Path add)
        {
            return new Path(m_parts.Concat(add.m_parts), Separator, DefaultComparison);
        }
        public Path TakeFirst(int count)
        {
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
            return new Path(this.Take(count),Separator,DefaultComparison);
        }

        public static Path Empty(string separator = "\\", StringComparison def = StringComparison.CurrentCulture) => new Path(String.Empty, separator, def);

        public static Path EmptyRegistry() =>
                new Path(string.Empty, "\\", StringComparison.OrdinalIgnoreCase);
    }
}