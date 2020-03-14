''' <summary>
''' Implements a counter for glyphs of an orthography.
''' </summary>
Public NotInheritable Class OrthographyCounter
	Implements IReadOnlyDictionary(Of String, Int32)

	Private ReadOnly Glyphs As IDictionary(Of String, Int32)

	Friend Sub New(Orthography As Orthography)
		Glyphs = New Dictionary(Of String, Int32)(Orthography.Count)
		For Each Glyph In Orthography
			If Not Glyphs.ContainsKey(Glyph.ToUpper) Then
				Glyphs.Add(Glyph.ToUpper, 0)
			End If
		Next
	End Sub

	Public ReadOnly Property Count As Int32 Implements IReadOnlyCollection(Of KeyValuePair(Of String, Int32)).Count
		Get
			Return Glyphs.Count
		End Get
	End Property

	Public ReadOnly Property Keys As IEnumerable(Of String) Implements IReadOnlyDictionary(Of String, Int32).Keys
		Get
			Return Glyphs.Keys
		End Get
	End Property

	Public ReadOnly Property Values As IEnumerable(Of Int32) Implements IReadOnlyDictionary(Of String, Int32).Values
		Get
			Return Glyphs.Values
		End Get
	End Property

	Default Public ReadOnly Property Item(key As String) As Int32 Implements IReadOnlyDictionary(Of String, Int32).Item
		Get
			If ContainsKey(key) Then
				Return Glyphs(key.ToUpper)
			Else
				Return 0
			End If
		End Get
	End Property

	Public Sub Add(Source As String)
		For Each S In Source.ToUpper
			If ContainsKey(S) Then
				Glyphs(S) += 1
			End If
		Next
	End Sub

	Public Sub Clear()
		For i = 0 To Count - 1
			Glyphs(i) = 0
		Next
	End Sub

	Public Function ContainsKey(key As String) As Boolean Implements IReadOnlyDictionary(Of String, Int32).ContainsKey
		Return Glyphs.ContainsKey(key.ToUpper)
	End Function

	Public Function GetEnumerator() As IEnumerator(Of KeyValuePair(Of String, Int32)) Implements IEnumerable(Of KeyValuePair(Of String, Int32)).GetEnumerator
		Return Glyphs.GetEnumerator()
	End Function

	Public Function TryGetValue(key As String, ByRef value As Int32) As Boolean Implements IReadOnlyDictionary(Of String, Int32).TryGetValue
		Return Glyphs.TryGetValue(key.ToUpper, value)
	End Function

	Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
		Return GetEnumerator()
	End Function
End Class
