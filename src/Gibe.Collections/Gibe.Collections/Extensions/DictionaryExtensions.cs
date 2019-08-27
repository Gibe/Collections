using System.Collections.Generic;

namespace Gibe.Collections.Extensions
{
	public static class DictionaryExtensions
	{
		public static T TryGetOrDefault<T>(this Dictionary<string, T> dictionary, string key)
		{
			T value;
			if (dictionary.TryGetValue(key, out value))
			{
				return value;
			}

			return default(T);
		}

		public static T TryGetOrDefault<T>(this Dictionary<string, T> dictionary, string key, T defaultValue)
		{
			var value = dictionary.TryGetOrDefault(key);

			return value.Equals(default(T)) ? defaultValue : value;
		}
	}
}
