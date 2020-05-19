using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stringier.Literary {
	/// <summary>
	/// Implements a counter for glyphs of an orthography.
	/// </summary>
	internal sealed class OrthographyCounter : IReadOnlyDictionary<Glyph, Int32> {
		private readonly IDictionary<Glyph, Int32> Glyphs;

		internal OrthographyCounter(Orthography orthography) {
			Glyphs = new Dictionary<Glyph, Int32>(orthography.Count);
			foreach (Glyph glyph in orthography) {
				if (!Glyphs.ContainsKey(glyph.ToUpper())) {
					Glyphs.Add(glyph.ToUpper(), 0);
				}
			}
		}

		/// <inheritdoc/>
		public Int32 this[Glyph key] {
			get {
				if (ContainsKey(key)) {
					return Glyphs[key.ToUpper()];
				} else {
					return 0;
				}
			}
		}

		public Int32 this[Char key] => this[new Glyph(key)];

		/// <inheritdoc/>
		public IEnumerable<Glyph> Keys => Glyphs.Keys;

		/// <inheritdoc/>
		public IEnumerable<Int32> Values => Glyphs.Values;

		/// <inheritdoc/>
		public Int32 Count {
			get {
				Int32 count = 0;
				foreach (Int32 value in Values) {
					count += value;
				}
				return count;
			}
		}

		public void Add(String @string) {
			foreach (Glyph glyph in @string.EnumerateGlyphs()) {
				if (ContainsKey(glyph)) {
					Glyphs[glyph.ToUpper()]++;
				}
			}
		}

		/// <inheritdoc/>
		public Boolean ContainsKey(Glyph key) => Glyphs.ContainsKey(key.ToUpper());

		public Boolean ContainsKey(Char key) => ContainsKey(new Glyph(key));

		/// <inheritdoc/>
		public IEnumerator<KeyValuePair<Glyph, Int32>> GetEnumerator() => Glyphs.GetEnumerator();

		/// <inheritdoc/>
		public Boolean TryGetValue(Glyph key, out Int32 value) => Glyphs.TryGetValue(key.ToUpper(), out value);

		public Boolean TryGetValue(Char key, out Int32 value) => TryGetValue(new Glyph(key), out value);

		/// <inheritdoc/>
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
