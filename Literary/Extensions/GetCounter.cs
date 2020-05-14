using System;

namespace Stringier.Literary {
	public static partial class LiteraryExtensions {
		/// <summary>
		/// Gets an orthographic counter for this <see cref="Orthography"/>.
		/// </summary>
		/// <returns>A <see cref="OrthographyCounter"/> instance.</returns>
		internal static OrthographyCounter GetCounter(this Orthography orthography) => new OrthographyCounter(orthography);
	}
}
