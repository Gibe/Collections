using Gibe.Collections.Tests.DummyObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Gibe.Collections.Tests
{
	[TestFixture]
	public class CaseInsensitiveLookupTest
	{
		[Test]
		public void AccessingCaseInsensitiveLookupItem_WithDifferentCasedKey_ReturnsAppropriateValue()
		{
			var people = new List<Person>
			{
				new Person
				{
					FirstName = "Jack",
					LastName = "Durcan",
					DateOfBirth = new DateTime(1992, 7, 13) // Now that you've seen this, you have no excuse to not buy me a birthday present.
				}
			};

			var lookup = new CaseInsensitiveLookup<Person>(people, p => p.FirstName);

			var peopleNamedJack = lookup["jack"];

			Assert.AreEqual("Durcan", peopleNamedJack.First().LastName);
		}
	}
}
