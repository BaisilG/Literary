using System;
using System.Collections.Generic;
using System.Linq;

namespace Stringier.Literary {
	/// <summary>
	/// Represents an <see cref="Orthography"/> with casing
	/// </summary>
	internal sealed class CasedOrthography : Orthography {
		private IReadOnlyCollection<Glyph> UppercaseGlyphs;

		private IReadOnlyCollection<Glyph> LowercaseGlyphs;

		internal CasedOrthography(String[] uppercaseGlyphs, String[] lowercaseGlyphs) {
			UppercaseGlyphs = uppercaseGlyphs.ToGlyphs();
			LowercaseGlyphs = lowercaseGlyphs.ToGlyphs();
		}

		/// <inheritdoc/>
		public override Int32 Count => UppercaseGlyphs.Count + LowercaseGlyphs.Count;

		/// <inheritdoc/>
		public override IEnumerator<Glyph> GetEnumerator() => UppercaseGlyphs.Concat(LowercaseGlyphs).GetEnumerator();
	}
}
