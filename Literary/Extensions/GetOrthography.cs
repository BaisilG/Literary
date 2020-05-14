using System;
using System.Globalization;

namespace Stringier.Literary {
	public static partial class LiteraryExtensions {
		/// <summary>
		/// Get the major orthography used by this <paramref name="culture"/>.
		/// </summary>
		/// <param name="culture">The <see cref="CultureInfo"/> to get the <see cref="Orthography"/> for.</param>
		/// <returns>The major <see cref="Orthography"/> used by this <paramref name="culture"/>; or <see langword="null"/>.</returns>
		internal static Orthography GetOrthography(this CultureInfo culture) {
			//This uses a double select-case setup to simplify things. In many cases, languages share the same orthography all around the world. So instead of an entry for every single one, slice out the language identifier and use that.
			switch (culture.Name) {
			default:
				switch (culture.Name.Substring(0, 2)) {
				case "en":
					return Orthography.English_Latin;
				}
				return null;
			}
		}
	}
}