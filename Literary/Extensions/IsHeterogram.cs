using System;
using System.Globalization;

namespace Stringier.Literary {
	public static partial class LiteraryExtensions {
		/// <summary>
		/// Is the <paramref name="string"/> a heterogram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <returns><see langword="true"/> if heterogram; otherwise, <see langword="false"/>.</returns>
		/// <remarks>
		/// <para>Heterograms are text in which no glyph in the orthography appears more than once.</para>
		/// <para>This assumes the current culture.</para>
		/// </remarks>
		public static Boolean IsHeterogram(this String @string) => @string.IsHeterogram(CultureInfo.CurrentCulture);

		/// <summary>
		/// Is the <paramref name="string"/> a heterogram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <param name="culture">The <see cref="CultureInfo"/> to use for determining orthography.</param>
		/// <returns><see langword="true"/> if heterogram; otherwise, <see langword="false"/>.</returns>
		/// <remarks>
		/// <para>Heterograms are text in which no glyph in the orthography appears more than once.</para>
		/// </remarks>
		public static Boolean IsHeterogram(this String @string, CultureInfo culture) => @string.IsHeterogram(culture.GetOrthography());

		/// <summary>
		/// Is the <paramref name="string"/> a heterogram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <param name="orthography">The orthography to use.</param>
		/// <returns><see langword="true"/> if heterogram; otherwise, <see langword="false"/>.</returns>
		/// <remarks>
		/// <para>Heterograms are text in which no glyph in the orthography appears more than once.</para>
		/// </remarks>
		public static Boolean IsHeterogram(this String @string, Orthography orthography) {
			OrthographyCounter counter = orthography.GetCounter();
			counter.Add(@string);
			foreach (Int32 count in counter.Values) {
				if (count > 1) {
					return false;
				}
			}
			return true;
		}
	}
}
