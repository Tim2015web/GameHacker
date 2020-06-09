'''Интрефейс
Public Class ModuleUI

    'Стиль шрифта - образование
    Private EduStrike As New Font("Microsoft Sans Serif", 9.75, FontStyle.Strikeout) 'Смена стиля шрифта для образования

    Public Enum Edu_Style
        Black
        Green1
        Green2
    End Enum

    Public Sub EduChangeColorLabel(Lbl As Label, Style As Edu_Style)
        Select Case Style
            Case Edu_Style.Black
                Lbl.ForeColor = Color.Black

            Case Edu_Style.Green1 'Готово
                Lbl.ForeColor = Color.Green
                Lbl.Font = EduStrike

            Case Edu_Style.Green2
                Lbl.Text = "Ок"
                Lbl.ForeColor = Color.Green
        End Select
    End Sub

    'Вывод текста в информационное поле
    Private frmUI As Form_Main

    Public Sub New(f As Form) 'Конструктор OK!!!!!!
        frmUI = f
    End Sub

    Public Sub LogMessage(Message As String)
        frmUI.TextBox_Event.Text = Message.Replace(vbCrLf, "") & vbCrLf & vbCrLf & frmUI.TextBox_Event.Text
    End Sub

    Public Sub RefreshMoney() 'Обновление информации о балансе средств
        frmUI.Label_Money2.Text = GameLogic.GetMoney()
    End Sub
End Class
