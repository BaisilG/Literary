using System;
using Stringier.Literary;
using Xunit;

namespace Tests {
	public class LiteraryTests {
		[Theory]
		[InlineData("", true)]
		[InlineData("subdermatoglyphic", true)]
		[InlineData("uncopyrightables", true)]
		[InlineData("hydropneumatics", true)]
		[InlineData("the quick fox", true)]
		[InlineData("boot", false)]
		public void IsHeterogram(String source, Boolean expected) => Assert.Equal(expected, source.IsHeterogram());

		[Theory]
		[InlineData("")]
		[InlineData("a")]
		[InlineData("detartrated")]
		[InlineData("tattarrattat")]
		[InlineData("Malayalam")]
		[InlineData("Was it a car or a cat I saw?")]
		[InlineData("No 'X' in Nixon")]
		[InlineData("Able was I ere I saw Elba")]
		[InlineData("A man, a plan, a canal, Panama!")]
		[InlineData("Do, O God, no evil deed! Live on! Do good!")]
		public void IsPalindrome(String source) => Assert.True(source.IsPalindrome());
    }
}
