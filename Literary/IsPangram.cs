using System;
using System.Globalization;
using Stringier.Linguistics;

namespace Stringier.Literary {
	public static partial class LiteraryExtensions {
		/// <summary>
		/// IS the <paramref name="string"/> a pangram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <returns>
		/// <para>Pangrams are text in which each glyph in the orthography is present.</para>
		/// <para>This assumes the current culture.</para>
		/// </returns>
		public static Boolean IsPangram(this String @string) {
			OrthographyCounter counter = CultureInfo.CurrentCulture.GetOrthography().GetCounter();
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
