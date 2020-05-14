using System;

namespace Stringier.Literary {
	/// <summary>
	/// The direction a <see cref="Script"/> is written.
	/// </summary>
	[Flags]
	public enum Direction {
		/// <summary>
		/// Left-to-Right
		/// </summary>
		LeftToRight = 1,

		/// <summary>
		/// Right-to-Left
		/// </summary>
		RightToLeft = 2,

		/// <summary>
		/// Top-to-Bottom
		/// </summary>
		TopToBottom = 4,
	}
}
