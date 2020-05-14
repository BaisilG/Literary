using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stringier.Literary {
	public abstract class Orthography : IReadOnlyCollection<Glyph> {
		/// <summary>
		/// Deseret alphabet (English)
		/// </summary>
		public static readonly Orthography English_Deseret = new CasedOrthography(
			new[] { "𐐀", "𐐁", "𐐂", "𐐃", "𐐄", "𐐅", "𐐆", "𐐇", "𐐈", "𐐉", "𐐊", "𐐋", "𐐌", "𐐍", "𐐎", "𐐏", "𐐐", "𐐑", "𐐒", "𐐓", "𐐔", "𐐕", "𐐖", "𐐗", "𐐘", "𐐙", "𐐚", "𐐛", "𐐜", "𐐝", "𐐞", "𐐟", "𐐠", "𐐡", "𐐢", "𐐣", "𐐤", "𐐥", "𐐦", "𐐧" },
			new[] { "𐐨", "𐐩", "𐐪", "𐐫", "𐐬", "𐐭", "𐐮", "𐐯", "𐐰", "𐐱", "𐐲", "𐐳", "𐐴", "𐐵", "𐐶", "𐐷", "𐐸", "𐐹", "𐐺", "𐐻", "𐐼", "𐐽", "𐐾", "𐐿", "𐑀", "𐑁", "𐑂", "𐑃", "𐑄", "𐑅", "𐑆", "𐑇", "𐑈", "𐑉", "𐑊", "𐑋", "𐑌", "𐑍", "𐑎", "𐑏" });

		/// <summary>
		/// English alphabet
		/// </summary>
		public static readonly Orthography English_Latin = new CasedOrthography(
			new[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" },
			new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "k", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });

		/// <summary>
		/// Shavian alphabet (English)
		/// </summary>
		public static readonly Orthography English_Shavian = new UncasedOrthography("𐑐", "𐑚", "𐑑", "𐑛", "𐑒", "𐑜", "𐑓", "𐑝", "𐑔", "𐑞", "𐑕", "𐑟", "𐑖", "𐑠", "𐑗", "𐑡", "𐑘", "𐑢", "𐑙", "𐑣", "𐑤", "𐑮", "𐑥", "𐑯", "𐑦", "𐑰", "𐑧", "𐑱", "𐑨", "𐑲", "𐑩", "𐑳", "𐑪", "𐑴", "𐑫", "𐑵", "𐑬", "𐑶", "𐑭", "𐑷");

		/// <summary>
		/// The amount of glyphs in this orthography.
		/// </summary>
		public abstract Int32 Count { get; }

		/// <inheritdoc/>
		public abstract IEnumerator<Glyph> GetEnumerator();

		/// <inheritdoc/>
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
