Imports System.Globalization
Imports System.Runtime.CompilerServices

''' <summary>
''' A collection of linguistics extension methods.
''' </summary>
<Extension>
Public Module LinguisticsExtensions

    ''' <summary>
    ''' Get the major orthography used by this <paramref name="Culture"/>.
    ''' </summary>
    ''' <param name="Culture">The <see cref="CultureInfo"/> to get the <see cref="Orthography"/> for.</param>
    ''' <returns>The major <see cref="Orthography"/> used by this <paramref name="Culture"/>; or <see langword="Nothing"/>.</returns>
    <Extension>
    Public Function GetOrthography(ByVal Culture As CultureInfo) As Orthography
        'This uses a double select-case setup to simplify things. In many cases, languages share the same orthography all around the world. So instead of an entry for every single one, slice out the language identifier and use that.
        Select Case Culture.Name
            Case Else
                Select Case Culture.Name.Substring(0, 2)
                    Case "en"
                        Return Orthography.English
                    Case Else
                        Return Nothing
                End Select
        End Select
    End Function

End Module
