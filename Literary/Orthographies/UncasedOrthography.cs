using System;
using System.Collections.Generic;

namespace Stringier.Literary {
	/// <summary>
	/// Represents an <see cref="Orthography"/> without casing.
	/// </summary>
	internal sealed class UncasedOrthography : Orthography {
		private readonly IReadOnlyCollection<Glyph> Glyphs;

		internal UncasedOrthography(params String[] glyphs) => Glyphs = glyphs.ToGlyphs();

		/// <inheritdoc/>
		public override Int32 Count => Glyphs.Count;

		/// <inheritdoc/>
		public override IEnumerator<Glyph> GetEnumerator() => Glyphs.GetEnumerator();
	}
}
