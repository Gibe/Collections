using System;
using System.Collections.Generic;
using System.Linq;

namespace Gibe.Collections
{
	public class CaseInsensitiveDictionary<T> : Dictionary<string, T>
	{
		public CaseInsensitiveDictionary() 
			: base(StringComparer.OrdinalIgnoreCase) { }

		public CaseInsensitiveDictionary(int capacity)
			: base(capacity, StringComparer.OrdinalIgnoreCase) { }

		public CaseInsensitiveDictionary(IDictionary<string, T> dictionary)
			: base(dictionary, StringComparer.OrdinalIgnoreCase) { }

		public CaseInsensitiveDictionary(IEnumerable<T> source, Func<T, string> keySelector)
			: base(source.ToDictionary(keySelector), StringComparer.OrdinalIgnoreCase) { }

		public CaseInsensitiveDictionary(IEnumerable<T> source, Func<T, string> keySelector, Func<T, T> valueSelector)
			: base(source.ToDictionary(keySelector, valueSelector), StringComparer.OrdinalIgnoreCase) { }

		public Dictionary<string, T> ToDictionary() => 
			this.ToDictionary(d => d.Key, d=> d.Value);
	}
}
