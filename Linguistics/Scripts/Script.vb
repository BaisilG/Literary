Public NotInheritable Class Script

	Public Shared ReadOnly Latin As Script = New Script(ISO15924.Latn, ScriptType.Alphabet, Direction.LeftToRight)

	Private Sub New(ISO15924 As ISO15924, Type As ScriptType, Direction As Direction)
		Me.Direction = Direction
		Me.ISO15924 = ISO15924
		Me.Type = Type
	End Sub

	Public ReadOnly Property Direction As Direction

	Public ReadOnly Property ISO15924 As ISO15924

	Public ReadOnly Property Type As ScriptType

End Class
