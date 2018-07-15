using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using JetBrains.Annotations;
using org.ek.HandMeAFile.commons.Extensions;
using org.ek.HandMeAFile.commons.Tools;

namespace org.ek.HandMeAFile.Model
{
    public class FilePack : IEnumerable<Path>
    {
        private readonly ReadOnlyCollection<Path> m_paths;
        public           Path   CommonAncestor { get; }
        public           int    ClipboardCount { get; private set; }

        public FilePack([CanBeNull] IEnumerable<Path> paths)
        {
            m_paths        = new ReadOnlyCollection<Path>(paths?.ToArray() ?? new Path[0]);
            CommonAncestor = m_paths.FindLargestCommon();
        }

        [Pure]
        public FilePack SetCount(int newCount)
        {
            FilePack clone = (FilePack) MemberwiseClone();
            clone.ClipboardCount = newCount;
            return clone;
        }
        [Pure]
        /// <summary>
        ///   Gibt einen Enumerator zurück, der die Auflistung durchläuft.
        /// </summary>
        /// <returns>
        ///   Ein Enumerator, der zum Durchlaufen der Auflistung verwendet werden kann.
        /// </returns>
        public IEnumerator<Path> GetEnumerator()
        {
            return (IEnumerator<Path>) m_paths.GetEnumerator();
        }
        [Pure]
        /// <summary>
        ///   Gibt einen Enumerator zurück, der eine Auflistung durchläuft.
        /// </summary>
        /// <returns>
        ///   Ein <see cref="T:System.Collections.IEnumerator" />-Objekt, das zum Durchlaufen der Auflistung verwendet werden kann.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        [Pure]
        protected bool Equals(FilePack other)
        {
            return m_paths.ElementsEqual(other.m_paths);
        }
        [Pure]
        /// <summary>
        ///   Bestimmt, ob das angegebene Objekt mit dem aktuellen Objekt identisch ist.
        /// </summary>
        /// <param name="obj">
        ///   Das Objekt, das mit dem aktuellen Objekt verglichen werden soll.
        /// </param>
        /// <returns>
        ///   <see langword="true" />, wenn das angegebene Objekt und das aktuelle Objekt gleich sind, andernfalls <see langword="false" />.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((FilePack) obj);
        }
        [Pure]
        /// <summary>Fungiert als die Standardhashfunktion.</summary>
        /// <returns>Ein Hashcode für das aktuelle Objekt.</returns>
        public override int GetHashCode()
        {
            return m_paths != null ? m_paths.GetElementsHashCode() : 0;
        }
        [Pure]
        /// <summary>Returns a value that indicates whether the values of two <see cref="T:org.ek.HandMeAFile.Model.FilePack" /> objects are equal.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
        public static bool operator ==(FilePack left, FilePack right)
        {
            return Equals(left, right);
        }
        [Pure]
        /// <summary>Returns a value that indicates whether two <see cref="T:org.ek.HandMeAFile.Model.FilePack" /> objects have different values.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
        public static bool operator !=(FilePack left, FilePack right)
        {
            return !Equals(left, right);
        }
    }
}