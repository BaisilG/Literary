''' <summary>
''' Represents an <see cref="Orthography"/> with casing.
''' </summary>
Friend NotInheritable Class CasedOrthography
	Inherits Orthography

	Private ReadOnly UppercaseGlyphs As IReadOnlyCollection(Of String)

	Private ReadOnly LowercaseGlyphs As IReadOnlyCollection(Of String)

	Friend Sub New(UppercaseGlyphs As String(), LowercaseGlyphs As String())
		Me.UppercaseGlyphs = UppercaseGlyphs
		Me.LowercaseGlyphs = LowercaseGlyphs
	End Sub

	Public Overrides ReadOnly Property Count As Int32
		Get
			Return UppercaseGlyphs.Count + LowercaseGlyphs.Count
		End Get
	End Property

	Public Overrides Function GetEnumerator() As IEnumerator(Of String)
		Return UppercaseGlyphs.Concat(LowercaseGlyphs).GetEnumerator()
	End Function
End Class
