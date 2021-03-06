﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stringier.Literary {
	/// <summary>
	/// The type classification of a <see cref="Language"/>.
	/// </summary>
	public enum LanguageType {
		/// <summary>
		/// The language is living, that is, actively spoken and developed.
		/// </summary>
		Living,

		/// <summary>
		/// The language is ancient, that is, it was once spoken but no longer.
		/// </summary>
		Ancient,

		/// <summary>
		/// The language is constructed, that is, actively spoken but deliberately developed rather than naturally.
		/// </summary>
		Constructed,
	}
}
