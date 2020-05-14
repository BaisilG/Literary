using System;
using System.Globalization;

namespace Stringier.Literary {
	public static partial class LiteraryExtensions {
		/// <summary>
		/// Is the <paramref name="string"/> a pangram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <returns>
		/// <para>Pangrams are text in which each glyph in the orthography is present.</para>
		/// <para>This assumes the current culture.</para>
		/// </returns>
		public static Boolean IsPangram(this String @string) => @string.IsPangram(CultureInfo.CurrentCulture);

		/// <summary>
		/// Is the <paramref name="string"/> a pangram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <param name="culture">The <see cref="CultureInfo"/> to use for determining orthography.</param>
		/// <returns>
		/// <para>Pangrams are text in which each glyph in the orthography is present.</para>
		/// </returns>
		public static Boolean IsPangram(this String @string, CultureInfo culture) => @string.IsPangram(culture.GetOrthography());

		/// <summary>
		/// Is the <paramref name="string"/> a pangram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <param name="orthography">The orthography to use.</param>
		/// <returns>
		/// <para>Pangrams are text in which each glyph in the orthography is present.</para>
		/// </returns>
		public static Boolean IsPangram(this String @string, Orthography orthography) {
			OrthographyCounter counter = orthography.GetCounter();
			counter.Add(@string);
			foreach (Int32 count in counter.Values) {
				if (count == 0) {
					return false;
				}
			}
			return true;
		}
	}
}
