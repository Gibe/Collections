using System;
using System.Collections.Generic;
using System.Linq;

namespace Gibe.Collections
{
	public class CaseInsensitiveLookup<T>
	{
		private readonly ILookup<string, T> _lookup;

		public CaseInsensitiveLookup(IEnumerable<T> source, Func<T, string> keySelector)
		{
			_lookup = source.ToLookup(keySelector, StringComparer.OrdinalIgnoreCase);
		}

		public CaseInsensitiveLookup(IEnumerable<T> source, Func<T, string> keySelector, Func<T, T> valueSelector)
		{
			_lookup = source.ToLookup(keySelector, valueSelector, StringComparer.OrdinalIgnoreCase);
		}

		public IEnumerable<T> this[string key] => _lookup[key];
	}
}
