using Stringier.Literary;
using Xunit;

namespace Tests {
	public class OrthographyTests {
		[Fact]
		public void Lookup() {
			Assert.Equal(Orthography.English_Latin, Language.English[Script.Latin]);
			Assert.Equal(Orthography.English_Deseret, Language.English[Script.Deseret]);
			Assert.Equal(Orthography.English_Shavian, Language.English[Script.Shavian]);
		}
	}
}
