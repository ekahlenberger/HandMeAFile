﻿using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace org.ek.HandMeAFile.commons.Extensions
{
    // ReSharper disable once InconsistentNaming
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Clone<T>(this IEnumerable<T> l)
        {
            if (l.IsNull()) return null;

            var cloned = new List<T>();
            foreach (var element in l)
            {
                var cloneable = element as ICloneable;
                if (cloneable.IsNotNull())
                    cloned.Add((T)cloneable.Clone());
                else if (element is int)
                    cloned.Add(element);
                else if (element is double)
                    cloned.Add(element);
                else if (element is bool)
                    cloned.Add(element);
                else
                    throw new ArgumentException("Supplied list elements are not ICloneable");
            }
            return cloned;
        }
        [ContractAnnotation("null=>true")]
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> l)
        {
            return l.IsNull() || !l.Any();
        }
        [ContractAnnotation("null => halt")]
        public static bool IsEmpty<T>(this IEnumerable<T> l)
        {
            if (l.IsNull()) throw new NullReferenceException();
            return !l.Any();
        }
        public static bool ElementsEqual<T>(this IEnumerable<T> l, IEnumerable<T> compareList)
        {
            var set1 = new HashSet<T>(l);
            var set2 = new HashSet<T>(compareList);
            return set1.SetEquals(set2);
        }

        public static int GetElementsHashCode<T>([CanBeNull]this IEnumerable<T> l)
        {
            return l?.Where(i => i != null).Aggregate(0,(hash, next) => hash ^ next.GetHashCode()) ?? 0;
        }

        public static IEnumerable<T> Do<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T element in enumerable)
            {
                action(element);
                yield return element;
            }
        }

        public static void Run<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (T element in enumerable)
            {
                action(element);
            }
        }

        public static IEnumerable<TSource> RecursiveSelect<TSource>(this IEnumerable<TSource> source, Func<TSource, IEnumerable<TSource>> childSelector)
        {
            Stack<IEnumerator<TSource>> stack = new Stack<IEnumerator<TSource>>();
            IEnumerator<TSource> enumerator = source.GetEnumerator();

            try
            {
                while (true)
                {
                    if (enumerator.MoveNext())
                    {
                        TSource element = enumerator.Current;
                        yield return element;

                        stack.Push(enumerator);
                        enumerator = childSelector(element).GetEnumerator();
                    }
                    else if (stack.Count > 0)
                    {
                        enumerator.Dispose();
                        enumerator = stack.Pop();
                    }
                    else
                    {
                        yield break;
                    }
                }
            }
            finally
            {
                enumerator.Dispose();

                while (stack.Count > 0) // Clean up in case of an exception.
                {
                    enumerator = stack.Pop();
                    enumerator.Dispose();
                }
            }
        }

        public static IEnumerable<TSource> Add<TSource>(this IEnumerable<TSource> source, TSource addValue)
        {
            foreach (TSource existingValue in source)
                yield return existingValue;
            yield return addValue;
        }
    }
}