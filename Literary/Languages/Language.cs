using System;
using System.Collections.Generic;
using Stringier.Literary;

namespace Stringier.Literary {
	/// <summary>
	/// Represents a spoken or written language.
	/// </summary>
	public sealed class Language {
		/// <summary>
		/// The English language.
		/// </summary>
		public static readonly Language English = new Language((Script.Latin, Orthography.English_Latin), (Script.Shavian, Orthography.English_Shavian), (Script.Deseret, Orthography.English_Deseret));

		/// <summary>
		/// Initialize a new <see cref="Language"/> object.
		/// </summary>
		/// <param name="writingSystems">The mapping of writing systems used for this language.</param>
		private Language(params (Script script, Orthography orthography)[] writingSystems) {
			Script[] scripts = new Script[writingSystems.Length];
			Dictionary<Script, Orthography> orthographies = new Dictionary<Script, Orthography>(writingSystems.Length);
			for (Int32 i = 0; i < writingSystems.Length; i++) {
				scripts[i] = writingSystems[i].script;
				orthographies.Add(writingSystems[i].script, writingSystems[i].orthography);
			}
			Scripts = scripts;
			Orthographies = orthographies;
		}

		/// <summary>
		/// Looks up the <see cref="Orthography"/> used for this <see cref="Language"/> when using the <paramref name="script"/>.
		/// </summary>
		/// <param name="script">The <see cref="Script"/> to get the <see cref="Orthography"/> for.</param>
		/// <returns>The <see cref="Orthography"/> if found, otherwise <see langword="null"/>.</returns>
		public Orthography? this[Script script] => Orthographies[script];

		/// <summary>
		/// The collection of <see cref="Script"/>s used to write in this language.
		/// </summary>
		public IReadOnlyCollection<Script> Scripts { get; }

		/// <summary>
		/// The mapping of <see cref="Script"/> to <see cref="Orthography"/> for this <see cref="Language"/>.
		/// </summary>
		public IReadOnlyDictionary<Script, Orthography> Orthographies { get; }
	}
}
