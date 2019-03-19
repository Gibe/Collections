using System;
using System.Collections.Generic;

namespace Gibe.Collections.Extensions
{
	public static class EnumerableExtensions
	{
		public static CaseInsensitiveLookup<T> ToCaseInsensitiveLookup<T>(this IEnumerable<T> source, Func<T, string> keySelector)
		{
			return new CaseInsensitiveLookup<T>(source, keySelector);
		}

		public static CaseInsensitiveLookup<T> ToCaseInsensitiveLookup<T>(this IEnumerable<T> source, Func<T, string> keySelector, Func<T, T> valueSelector)
		{
			return new CaseInsensitiveLookup<T>(source, keySelector, valueSelector);
		}

		public static CaseInsensitiveDictionary<T> ToCaseInsensitiveDictionary<T>(this IEnumerable<T> source, Func<T, string> keySelector)
		{
			return new CaseInsensitiveDictionary<T>(source, keySelector);
		}

		public static CaseInsensitiveDictionary<T> ToCaseInsensitiveDictionary<T>(this IEnumerable<T> source, Func<T, string> keySelector, Func<T, T> valueSelector)
		{
			return new CaseInsensitiveDictionary<T>(source, keySelector, valueSelector);
		}
	}
}
