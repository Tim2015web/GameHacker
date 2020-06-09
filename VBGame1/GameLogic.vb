'Логика
Public Class MoneyNothingException
    Inherits Exception
End Class


Public Class GameLogic

    Private Shared Money As Integer = 0 'Все деньги
    Public Shared JobMoney As Integer = 0 'Ставка з/п

    Public Shared Expexperience As Integer = 0 'Контейнер опыта для таймера
    Public Shared EduExp As Integer = 0 'Временные контейнер опыта

    Public Shared Life1 As Double = 1 'Жизненные показатели
    Public Shared Life2 As Double = 1
    Public Shared Life3 As Double = 1
    Public Shared Life4 As Double = 1

    Public Shared EduSt1 As Integer = 1 'Статус уровней образования
    Public Shared EduSt2 As Integer = 1
    Public Shared EduSt3 As Integer = 1
    Public Shared EduSt4 As Integer = 1
    Public Shared EduSt5 As Integer = 1

    Public Shared Function GetMoney() As Integer 'Обновление информации о балансе средств
        Return Money
    End Function

    Public Shared Sub AddMoney(Value As Integer) 'Начисление средств
        Money += Value
    End Sub

    Public Shared Sub BuyItem(Value As Integer) 'Списание средств
        If Money - Value >= 0 Then
            Money -= Value
        Else
            Throw New MoneyNothingException
        End If
    End Sub

End Class




