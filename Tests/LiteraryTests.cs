using System;
using Stringier.Literary;
using Xunit;
using static Stringier.Literary.Language;
using static Stringier.Literary.Script;

namespace Tests {
	public class LiteraryTests {
		[Theory]
		[InlineData("",  true)]
		[InlineData("subdermatoglyphic", true)]
		[InlineData("uncopyrightables", true)]
		[InlineData("hydropneumatics", true)]
		[InlineData("the quick fox", true)]
		[InlineData("boot", false)]
		public void IsHeterogram_English_Latin(String source, Boolean expected) => Assert.Equal(expected, source.IsHeterogram(English[Latin]));

		[Theory]
		[InlineData("", true)]
		[InlineData("𐑕𐑳𐑚𐑛𐑧𐑮𐑥𐑩𐑑𐑪𐑜𐑤𐑭𐑐𐑣𐑦𐑗", true)]
		[InlineData("𐑳𐑯𐑗𐑪𐑐𐑭𐑮𐑦𐑜𐑣𐑑𐑩𐑚𐑤𐑧𐑕", true)]
		[InlineData("𐑣𐑭𐑛𐑮𐑪𐑐𐑯𐑧𐑳𐑥𐑩𐑑𐑦𐑗𐑕", true)]
		[InlineData("𐑑𐑣𐑧 𐑶𐑳𐑦𐑗𐑒 𐑓𐑪𐑻", true)]
		[InlineData("𐑚𐑪𐑪𐑑", false)]
		public void IsHeterogram_English_Shavian(String source, Boolean expected) => Assert.Equal(expected, source.IsHeterogram(English[Shavian]));

		[Theory]
		[InlineData("", true)]
		[InlineData("a", true)]
		[InlineData("detartrated", true)]
		[InlineData("tattarrattat", true)]
		[InlineData("Malayalam", true)]
		[InlineData("Was it a car or a cat I saw?", true)]
		[InlineData("No 'X' in Nixon", true)]
		[InlineData("Able was I ere I saw Elba", true)]
		[InlineData("A man, a plan, a canal, Panama!", true)]
		[InlineData("Do, O God, no evil deed! Live on! Do good!", true)]
		[InlineData("boot", false)]
		public void IsPalindrome(String source, Boolean expected) => Assert.Equal(expected, source.IsPalindrome());

		[Theory]
		[InlineData("", false)]
		[InlineData("The quick brown fox jumps over a lazy dog", true)]
		[InlineData("Jived fox nymph grabs quick waltz", true)]
		[InlineData("Glib jocks quiz nymph to vex dwarf", true)]
		[InlineData("boot", false)]
		public void IsPangram_English_Latin(String source, Boolean expected) => Assert.Equal(expected, source.IsPangram(English[Latin]));

		[Theory]
		[InlineData("", false)]
		[InlineData("𐑐𐑑𐑒𐑓𐑔𐑕𐑖𐑗𐑘𐑙𐑚𐑛𐑜𐑝𐑞𐑟𐑠𐑡𐑢𐑣𐑤𐑥𐑦𐑧𐑨𐑩𐑪𐑫𐑬𐑭𐑮𐑯𐑰𐑱𐑲𐑳𐑴𐑵𐑶𐑷𐑸𐑹𐑺𐑻𐑼𐑽𐑾𐑿", true)]
		public void IsPangram_English_Shavian(String source, Boolean expected) => Assert.Equal(expected, source.IsPangram(English[Shavian]));
    }
}
