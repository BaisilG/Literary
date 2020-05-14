using System;
using System.Collections.Generic;
using System.Text;

namespace Stringier.Literary {
	public sealed class Script {
		public static readonly Script Deseret = new Script(ISO15924.Dsrt, ScriptType.Alphabet, Direction.LeftToRight);

		public static readonly Script Latin = new Script(ISO15924.Latn, ScriptType.Alphabet, Direction.LeftToRight);

		public static readonly Script Shavian = new Script(ISO15924.Shaw, ScriptType.Alphabet, Direction.LeftToRight);

		private Script(ISO15924 iso15924, ScriptType type, Direction direction) {
			Direction = direction;
			ISO15924 = iso15924;
			Type = type;
		}

		public Direction Direction { get; }

		public ISO15924 ISO15924 { get; }

		public ScriptType Type { get; }
	}
}
