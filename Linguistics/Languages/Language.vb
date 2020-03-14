''' <summary>
''' Represents a spoken or writen language.
''' </summary>
Public NotInheritable Class Language
	Public Shared ReadOnly English As Language = New Language((Script.Latin, Orthography.English))

	''' <summary>
	''' Initialize a new <see cref="Language"/> object.
	''' </summary>
	''' <param name="WritingSystems">The mapping of writing systems used for this language.</param>
	Private Sub New(ParamArray WritingSystems As (Script As Script, Orthography As Orthography)())
		Dim Scripts As Script() = New Script(WritingSystems.Length) {}
		Dim Orthographies As Dictionary(Of Script, Orthography) = New Dictionary(Of Script, Orthography)(WritingSystems.Length)
		For i = 0 To WritingSystems.Length - 1
			Scripts(i) = WritingSystems(i).Script
			Orthographies.Add(WritingSystems(i).Script, WritingSystems(i).Orthography)
		Next
		Me.Scripts = Scripts
		Me.Orthographies = Orthographies
	End Sub

	''' <summary>
	''' Looks up the <see cref="Orthography"/> used for this <see cref="Language"/> when using the <paramref name="Script"/>.
	''' </summary>
	''' <param name="Script">The <see cref="Script"/> to get the <see cref="Orthography"/> for.</param>
	''' <returns>The <see cref="Script"/> if found, otherwise <see langword="null"/>.</returns>
	Default Public ReadOnly Property Item(Script As Script)
		Get
			Return Orthographies(Script)
		End Get
	End Property

	''' <summary>
	''' The collection of scripts used to write in this language.
	''' </summary>
	''' <returns></returns>
	Public ReadOnly Property Scripts As IReadOnlyCollection(Of Script)

	''' <summary>
	''' The mapping of <see cref="Script"/> to <see cref="Orthography"/> for this <see cref="Language"/>.
	''' </summary>
	''' <returns></returns>
	Public ReadOnly Property Orthographies As IReadOnlyDictionary(Of Script, Orthography)
End Class
