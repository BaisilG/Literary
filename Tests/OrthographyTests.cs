using Stringier.Linguistics;
using Xunit;

namespace Tests {
	public class OrthographyTests {
		[Fact]
		public void Lookup() {
			Assert.Equal(Orthography.English, Language.English[Script.Latin]);
		}
	}
}
