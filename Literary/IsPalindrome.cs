using System;

namespace Stringier.Literary {
	public static partial class LiteraryExtensions {
		/// <summary>
		/// Checks if the <paramref name="string"/> is a palindrome, character-wise.
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <returns><see langword="true"/> if <paramref name="string"/> is a palindrome; otherwise, <see langword="false"/>.</returns>
		public static Boolean IsPalindrome(this String @string) => !(@string is null) && @string.AsSpan().IsPalindrome();

		/// <summary>
		/// Checks if the <paramref name="span"/> is a palindrome, character-wise.
		/// </summary>
		/// <param name="span">The <see cref="ReadOnlySpan{T}"/> of <see cref="Char"/> to check.</param>
		/// <returns><see langword="true"/> if <paramref name="span"/> is a palindrome; otherwise, <see langword="false"/>.</returns>
		public static Boolean IsPalindrome(this Span<Char> span) {
			ReadOnlySpan<Char> prepped = PalindromeStrip(span);
			Span<Char> reversed = new Char[prepped.Length];
			prepped.CopyTo(reversed);
			reversed.Reverse();
			// Now actually check it's a palindrome
			for (Int32 i = 0; i < prepped.Length; i++) {
				if (Char.ToUpper(prepped[i]) != Char.ToUpper(reversed[i])) {
					return false;
				}
			}
			return true;
		}

		/// <summary>
		/// Checks if the <paramref name="span"/> is a palindrome, character-wise.
		/// </summary>
		/// <param name="span">The <see cref="ReadOnlySpan{T}"/> of <see cref="Char"/> to check.</param>
		/// <returns><see langword="true"/> if <paramref name="span"/> is a palindrome; otherwise, <see langword="false"/>.</returns>
		public static Boolean IsPalindrome(this ReadOnlySpan<Char> span) {
			ReadOnlySpan<Char> prepped = PalindromeStrip(span);
			Span<Char> reversed = new Char[prepped.Length];
			prepped.CopyTo(reversed);
			reversed.Reverse();
			// Now actually check it's a palindrome
			for (Int32 i = 0; i < prepped.Length; i++) {
				if (Char.ToUpper(prepped[i]) != Char.ToUpper(reversed[i])) {
					return false;
				}
			}
			return true;
		}

		private static ReadOnlySpan<Char> PalindromeStrip(ReadOnlySpan<Char> span) {
			// First we need to build the string without any punctuation or whitespace or any other unrelated-to-reading characters
			Char[] builder = new Char[span.Length];
			Int32 b = 0;
			foreach (Char s in span) {
				if (!(Char.IsControl(s) || Char.IsPunctuation(s) || Char.IsSeparator(s) || Char.IsSymbol(s) || Char.IsWhiteSpace(s))) {
					builder[b++] = s;
				}
			}
			return builder.AsSpan().Slice(0, b);
		}
	}
}
