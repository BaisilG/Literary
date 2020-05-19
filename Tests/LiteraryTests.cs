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
		[InlineData("", true, 0)]
		[InlineData("subdermatoglyphic", true, 1)]
		[InlineData("uncopyrightables", true, 1)]
		[InlineData("hydropneumatics", true, 1)]
		[InlineData("the quick fox", true, 1)]
		[InlineData("deed", true, 2)]
		[InlineData("vivienne", true, 2)]
		[InlineData("intestines", true, 2)]
		[InlineData("deeded", true, 3)]
		[InlineData("sestettes", true, 3)]
		[InlineData("geggee", true, 3)]
		public void IsIsogram_English_Latin(String source, Boolean expected, Int32 order) {
			if (expected) {
				Assert.True(source.IsIsogram(English[Latin], out Int32 ord));
				Assert.Equal(order, ord);
			} else {
				Assert.False(source.IsIsogram(English[Latin]));
			}
		}

		[Theory]
		[InlineData("", true, 0)]
		[InlineData("𐑕𐑳𐑚𐑛𐑧𐑮𐑥𐑩𐑑𐑪𐑜𐑤𐑭𐑐𐑣𐑦𐑗", true, 1)]
		[InlineData("𐑳𐑯𐑗𐑪𐑐𐑭𐑮𐑦𐑜𐑣𐑑𐑩𐑚𐑤𐑧𐑕", true, 1)]
		[InlineData("𐑣𐑭𐑛𐑮𐑪𐑐𐑯𐑧𐑳𐑥𐑩𐑑𐑦𐑗𐑕", true, 1)]
		[InlineData("𐑑𐑣𐑧 𐑶𐑳𐑦𐑗𐑒 𐑓𐑪𐑻", true, 1)]
		[InlineData("𐑛𐑧𐑧𐑛", true, 2)]
		[InlineData("𐑝𐑦𐑝𐑦𐑧𐑯𐑯𐑧", true, 2)]
		[InlineData("𐑦𐑯𐑑𐑧𐑕𐑑𐑦𐑯𐑧𐑕", true, 2)]
		[InlineData("𐑛𐑧𐑧𐑛𐑧𐑛", true, 3)]
		[InlineData("𐑕𐑧𐑕𐑑𐑧𐑑𐑑𐑧𐑕", true, 3)]
		[InlineData("𐑜𐑧𐑜𐑜𐑧𐑧", true, 3)]
		public void IsIsogram_English_Shavian(String source, Boolean expected, Int32 order) {
			if (expected) {
				Assert.True(source.IsIsogram(English[Shavian], out Int32 ord));
				Assert.Equal(order, ord);
			} else {
				Assert.False(source.IsIsogram(English[Shavian]));
			}
		}

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
		[InlineData("Baêab", true)]
		[InlineData("Bâeâb", true)]
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
