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
	}
}
