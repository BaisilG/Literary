''' <summary>
''' Represents an orthography; the system of writing of a language in a given script.
''' </summary>
Public MustInherit Class Orthography
	Implements IReadOnlyCollection(Of String)

	''' <summary>
	''' English alphabet
	''' </summary>
	Public Shared ReadOnly English As Orthography = New CasedOrthography(
		{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"},
		{"a", "b", "c", "d", "e", "f", "g", "h", "i", "k", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"})

	''' <summary>
	''' The amount of glyphs in this orthography.
	''' </summary>
	''' <returns>The <see cref="Int32"/> count of glyphs.</returns>
	Public MustOverride ReadOnly Property Count As Int32 Implements IReadOnlyCollection(Of String).Count

	Public MustOverride Function GetEnumerator() As IEnumerator(Of String) Implements IEnumerable(Of String).GetEnumerator

	Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
		Return GetEnumerator()
	End Function
End Class
