using System;

namespace Stringier.Literary {
	public static partial class LiteraryExtensions {
		/// <summary>
		/// Checks if the <paramref name="string"/> is a palindrome, glyph-wise.
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <returns><see langword="true"/> if <paramref name="string"/> is a palindrome; otherwise, <see langword="false"/>.</returns>
		public static Boolean IsPalindrome(this String @string) => !(@string is null) && @string.AsSpan().IsPalindrome();

		/// <summary>
		/// Checks if the <paramref name="span"/> is a palindrome, glyph-wise.
		/// </summary>
		/// <param name="span">The <see cref="ReadOnlySpan{T}"/> of <see cref="Char"/> to check.</param>
		/// <returns><see langword="true"/> if <paramref name="span"/> is a palindrome; otherwise, <see langword="false"/>.</returns>
		public static Boolean IsPalindrome(this Span<Char> span) => IsPalindrome((ReadOnlySpan<Char>)span);

		/// <summary>
		/// Checks if the <paramref name="span"/> is a palindrome, glyph-wise.
		/// </summary>
		/// <param name="span">The <see cref="ReadOnlySpan{T}"/> of <see cref="Char"/> to check.</param>
		/// <returns><see langword="true"/> if <paramref name="span"/> is a palindrome; otherwise, <see langword="false"/>.</returns>
		public static Boolean IsPalindrome(this ReadOnlySpan<Char> span) {
			ReadOnlySpan<Char> prepped = PalindromeStrip(span);
			ReadOnlySpan<Char> reversed = Glyph.Reverse(prepped);
			SpanGlyphEnumerator prep = prepped.EnumerateGlyphs();
			SpanGlyphEnumerator revr = reversed.EnumerateGlyphs();
			// Now actually check it's a palindrome
			while (prep.MoveNext() && revr.MoveNext()) {
				if (prep.Current.ToUpper() != revr.Current.ToUpper()) {
					return false;
				}
			}
			return true;
		}

		private static ReadOnlySpan<Char> PalindromeStrip(ReadOnlySpan<Char> span) {
			// First we need to build the string without any punctuation or whitespace or any other unrelated-to-reading characters
			Char[] builder = new Char[span.Length];
			Int32 b = 0;
			Span<Char> glyphChars = new Char[2];
			foreach (Glyph s in span.EnumerateGlyphs()) {
				if (Glyph.IsLetterOrDigit(s)) {
					switch (s.EncodeToUtf16(glyphChars)) {
					case 1:
						builder[b++] = glyphChars[0];
						break;
					case 2:
						builder[b++] = glyphChars[0];
						builder[b++] = glyphChars[1];
						break;
					}
				}
			}
			return builder.AsSpan().Slice(0, b);
		}
	}
}
