
Public Class Class1
    Private intYear As Integer
    Private strCoinName As String
    Private decCoinWeight As Decimal
    Private Enum Currency As Integer
        USD = 0
        GBP = 1
        EUR = 2

    End Enum
    Private Enum Metal As Integer
        Copper = 0
        Zinc = 1
        Gold = 2
        Silver = 3
        Platinum = 4
        Palladium = 5
        Other = 6

    End Enum
    Private IsEnc As Boolean
    Private decFaceValue As Decimal
    Private decColValue As Decimal

    Public Property Year As Integer
        Get
            Return intYear
        End Get
        Set(value As Integer)
            intYear = value
        End Set
    End Property

    Public Property CoinName As String
        Get
            Return strCoinName
        End Get
        Set(value As String)
            strCoinName = value
        End Set
    End Property

    Public Property CoinWeight As Decimal
        Get
            Return decCoinWeight
        End Get
        Set(value As Decimal)
            decCoinWeight = value
        End Set
    End Property

    Public Property FaceValue As Decimal
        Get
            Return decFaceValue
        End Get
        Set(value As Decimal)
            decFaceValue = value
        End Set
    End Property

    Public Property ColValue As Decimal
        Get
            Return decColValue
        End Get
        Set(value As Decimal)
            decColValue = value
        End Set
    End Property

End Class
