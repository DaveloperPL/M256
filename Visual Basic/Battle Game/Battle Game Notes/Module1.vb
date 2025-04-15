Module Module1
    Public Money As Integer
    Public Multiplyer As Integer
    Public Structure battleStats
        Public offense As Integer
        Public defense As Integer
        Public HP As Integer ' health points
        Public MaxHP As Integer
    End Structure

    Public hero As battleStats
    Public enemy(5) As battleStats ' can have up to 6 enemies

End Module
