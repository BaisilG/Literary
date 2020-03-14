''' <summary>
''' Represents an <see cref="Orthography"/> without casing.
''' </summary>
Friend NotInheritable Class UncasedOrthography
	Inherits Orthography

	Private ReadOnly Glyphs As IReadOnlyCollection(Of String)

	Friend Sub New(ParamArray Glyphs As String())
		Me.Glyphs = Glyphs
	End Sub

	Public Overrides ReadOnly Property Count As Int32
		Get
			Return Glyphs.Count
		End Get
	End Property

	Public Overrides Function GetEnumerator() As IEnumerator(Of String)
		Throw New NotImplementedException()
	End Function
End Class
