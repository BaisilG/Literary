using System;
using System.Collections.Generic;

namespace Stringier.Literary {
	public static partial class LiteraryExtensions {
		/// <summary>
		/// Convert the <paramref name="strings"/> from <see cref="String"/> to <see cref="Glyph"/>.
		/// </summary>
		/// <param name="strings">The <see cref="IReadOnlyCollection{T}"/> of <see cref="String"/>.</param>
		/// <returns>An <see cref="IReadOnlyCollection{T}"/> of <see cref="Glyph"/>.</returns>
		internal static IReadOnlyCollection<Glyph> ToGlyphs(this IReadOnlyCollection<String> strings) {
			Glyph[] glyphs = new Glyph[strings.Count];
			Int32 g = 0;
			foreach (String @string in strings) {
				glyphs[g++] = new Glyph(@string);
			}
			return glyphs;
		}
	}
}
