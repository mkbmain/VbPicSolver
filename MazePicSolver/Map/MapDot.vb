Imports System.Drawing

Namespace Map
    ''' <summary>
    ''' So called as its one pixel
    ''' </summary>
    Class MapDot
        Public Property PreviousLocation() As Point
        Private Property MyLocation() As Point
        Public ReadOnly Property Location As Point
            Get
                Return MyLocation
            End Get
        End Property
        Public Property DeadEnd() As Boolean = False
        Private Property EverBeen() As Boolean = False
        Public ReadOnly Property EverBeenUsed() As Boolean
            Get
                Return EverBeen
            End Get
        End Property
        Private Property Used() As Boolean = False
        Public Property PathUsed() As Boolean
            Get
                Return Used
            End Get
            Set
                If IsWall Then
                    Return
                End If
                Used = Value
                If Value Then
                    EverBeen = Value
                End If
            End Set
        End Property
        Private Property IsStartPoint() As Boolean = False
        Public ReadOnly Property StartPoint As Boolean
            Get
                Return IsStartPoint
            End Get
        End Property
        Private Property IsEndPoint() As Boolean = False
        Public ReadOnly Property EndPoint As Boolean
            Get
                Return IsEndPoint
            End Get
        End Property
        Private Property IsWall() As Boolean


        Public ReadOnly Property Wall As Boolean
            Get
                Return IsWall
            End Get
        End Property


        Public Sub New(wall As Boolean, loc As Point, Optional startPoint As Boolean = False, Optional endPoint As Boolean = False)
            IsWall = wall
            MyLocation = loc
            IsStartPoint = startPoint
            IsEndPoint = endPoint
        End Sub

    End Class
End Namespace