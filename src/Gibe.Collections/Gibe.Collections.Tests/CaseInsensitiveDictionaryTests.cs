using NUnit.Framework;
using System.Collections.Generic;

namespace Gibe.Collections.Tests
{
	[TestFixture]
	public class CaseInsensitiveDictionaryTests
	{
		[Test]
		public void AccessingCaseInsensitiveDictionaryItem_WithDifferentCasedKey_ReturnsAppropriateValue()
		{
			var dictionary = new CaseInsensitiveDictionary<int>()
			{
				{ "key1", 1 },
				{ "KEY2", 2 },
				{ "Key3", 3 }
			};

			Assert.AreEqual(1, dictionary["KEY1"]);
			Assert.AreEqual(2, dictionary["key2"]);
			Assert.AreEqual(3, dictionary["key3"]);
		}

		[Test]
		public void ConvertToStandardDictionary_WithCaseInsensitiveItems_KeepsDictionaryIntact()
		{
			var caseInsensitiveDictionary = new CaseInsensitiveDictionary<string>()
			{
				{ "Key1", "Value1" },
				{ "Key2", "Value2" }
			};

			var dictionary = caseInsensitiveDictionary.ToDictionary();

			Assert.AreEqual("Value1", caseInsensitiveDictionary["Key1"]);
			Assert.AreEqual("Value2", caseInsensitiveDictionary["Key2"]);
		}

		[Test]
		public void AccessingCaseInsensitiveDictionaryItem_ConstructedFromExistingDictionary_ReturnsAppropriateValue()
		{
			var dictionary = new Dictionary<string, string>()
			{
				{ "KEY1", "Value1" },
			};

			var caseInsensitiveDictionary = new CaseInsensitiveDictionary<string>(dictionary);

			Assert.AreEqual("Value1", caseInsensitiveDictionary["key1"]);
		}
	}
}
