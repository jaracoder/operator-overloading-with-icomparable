Public Class Box
    Implements IComparable(Of Box)

    'Atributos
    Private _Alto As Single
    Private _Ancho As Single
    Private _Largo As Single

    'Constructores
    Public Sub New()
        Me._Alto = 1
        Me._Ancho = 1
        Me._Largo = 1
    End Sub

    Public Sub New(ByVal alto As Single, ByVal ancho As Single, ByVal largo As Single)
        If alto <= 0 OrElse ancho <= 0 OrElse largo <= 0 Then
            Throw New ArgumentException
        End If
        Me._Alto = alto
        Me._Ancho = ancho
        Me._Largo = largo
    End Sub

    'Propiedades
    Public Property Alto() As Single
        Get
            Return Me._Alto
        End Get
        Set(value As Single)
            Me._Alto = value
        End Set
    End Property

    Public Property Ancho() As Single
        Get
            Return Me._Ancho
        End Get
        Set(value As Single)
            Me._Ancho = value
        End Set
    End Property

    Public Property Largo() As Single
        Get
            Return Me._Largo
        End Get
        Set(value As Single)
            Me._Largo = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "Caja (Alto x Ancho x Largo): " & Me._Alto & "x" & Me._Ancho & "x" & Me._Largo
    End Function

    'Sobrecarga de operadores
    Public Shared Operator +(ByVal c1 As Box, ByVal c2 As Box) As Box
        Return New Box(c1._Alto + c2._Alto, c1._Ancho + c2._Ancho, c1._Largo + c2._Largo)
    End Operator

    Public Shared Operator -(ByVal c1 As Box, ByVal c2 As Box) As Box
        'Falta validar que no sean 0 o negativos
        Return New Box(c1._Alto - c2._Alto, c1._Ancho - c2._Ancho, c1._Largo - c2._Largo)
    End Operator

    'Ordenación de objetos para colecciones genéricas

    Public Function CompareTo(ByVal y As Box) As Integer Implements IComparable(Of Box).CompareTo
        If Me._Alto.CompareTo(y._Alto) <> 0 Then
            Return Me._Alto.CompareTo(y._Alto)
        ElseIf Me._Largo.CompareTo(y._Largo) <> 0 Then
            Return Me._Largo.CompareTo(y._Largo)
        ElseIf Me.Ancho.CompareTo(y._Ancho) <> 0 Then
            Return Me.Ancho.CompareTo(y._Ancho)
        Else
            Return 0
        End If
    End Function


    'Public Function Compare(ByVal x As Caja, ByVal y As Caja) As Integer Implements IComparer(Of Caja).Compare
    '    If x._Alto.CompareTo(y._Alto) <> 0 Then
    '        Return x._Alto.CompareTo(y._Alto)
    '    ElseIf x._Largo.CompareTo(y._Largo) <> 0 Then
    '        Return x._Largo.CompareTo(y._Largo)
    '    ElseIf x.Ancho.CompareTo(y._Ancho) <> 0 Then
    '        Return x.Ancho.CompareTo(y._Ancho)
    '    Else
    '        Return 0
    '    End If
    'End Function

    'Destructores
    Public Sub Dispose()
        Me._Alto = 0
        Me._Ancho = 0
        Me._Largo = 0
    End Sub

    Protected Overrides Sub Finalize()
        Me._Alto = 0
        Me._Ancho = 0
        Me._Largo = 0
    End Sub
End Class
