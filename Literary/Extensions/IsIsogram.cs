using System;
using System.Globalization;

namespace Stringier.Literary {
	public static partial class LiteraryExtensions {
		/// <summary>
		/// Is the <paramref name="string"/> an isogram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <returns><see langword="true"/> if isogram; otherwise, <see langword="false"/>.</returns>
		/// <remarks>
		/// <para>Isograms are text in which each glyph that is present, is present the same number of times.</para>
		/// <para>This assumes the current culture.</para>
		/// </remarks>
		public static Boolean IsIsogram(this String @string) => @string.IsIsogram(out _);

		/// <summary>
		/// Is the <paramref name="string"/> an isogram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <param name="order">The order of the isogram.</param>
		/// <returns><see langword="true"/> if isogram; otherwise, <see langword="false"/>.</returns>
		/// <remarks>
		/// <para>Isograms are text in which each glyph that is present, is present the same number of times.</para>
		/// <para>This assumes the current culture.</para>
		/// </remarks>
		public static Boolean IsIsogram(this String @string, out Int32 order) => @string.IsIsogram(CultureInfo.CurrentCulture, out order);

		/// <summary>
		/// Is the <paramref name="string"/> an isogram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <param name="culture">The <see cref="CultureInfo"/> to use for determining orthography.</param>
		/// <returns><see langword="true"/> if isogram; otherwise, <see langword="false"/>.</returns>
		/// <remarks>
		/// <para>Isograms are text in which each glyph that is present, is present the same number of times.</para>
		/// </remarks>
		public static Boolean IsIsogram(this String @string, CultureInfo culture) => @string.IsIsogram(culture, out _);

		/// <summary>
		/// Is the <paramref name="string"/> an isogram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <param name="culture">The <see cref="CultureInfo"/> to use for determining orthography.</param>
		/// <param name="order">The order of the isogram.</param>
		/// <returns><see langword="true"/> if isogram; otherwise, <see langword="false"/>.</returns>
		/// <remarks>
		/// <para>Isograms are text in which each glyph that is present, is present the same number of times.</para>
		/// </remarks>
		public static Boolean IsIsogram(this String @string, CultureInfo culture, out Int32 order) => @string.IsIsogram(culture.GetOrthography(), out order);

		/// <summary>
		/// Is the <paramref name="string"/> an isogram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <param name="orthography">The orthography to use.</param>
		/// <returns><see langword="true"/> if isogram; otherwise, <see langword="false"/>.</returns>
		/// <remarks>
		/// <para>Isograms are text in which each glyph that is present, is present the same number of times.</para>
		/// </remarks>
		public static Boolean IsIsogram(this String @string, Orthography orthography) => @string.IsIsogram(orthography, out _);

		/// <summary>
		/// Is the <paramref name="string"/> an isogram?
		/// </summary>
		/// <param name="string">The <see cref="String"/> to check.</param>
		/// <param name="orthography">The orthography to use.</param>
		/// <param name="order">The order of the isogram.</param>
		/// <returns><see langword="true"/> if isogram; otherwise, <see langword="false"/>.</returns>
		/// <remarks>
		/// <para>Isograms are text in which each glyph that is present, is present the same number of times.</para>
		/// </remarks>
		public static Boolean IsIsogram(this String @string, Orthography orthography, out Int32 order) {
			OrthographyCounter counter = orthography.GetCounter();
			counter.Add(@string);
			order = 0;
			foreach (Int32 count in counter.Values) {
				if (order == 0 && count != 0) {
					order = count;
				}
				if (count != order && count != 0) {
					return false;
				}
			}
			return true;
		}
	}
}
