Public Class Form_Main

    Dim UI As New ModuleUI(Me)


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_Life.Tick 'Основной таймер
        Label_Calendar2.Text += 1 '+ 1 час
        If Label_Calendar2.Text = 25 Then 'Начало нового дня
            Label_Calendar2.Text = 0 ' Сброс счетчика часов
            Label_Calendar5.Text += 1 '+ 1 день
            'Money.Text += GameLogic.GetMoney() 'Выдача недельной зарплаты
        End If

        'Шкала жизненных потреьностей
        ProgressBar_Life1.Value = ProgressBar_Life1.Value - GameLogic.Life1
        If ProgressBar_Life1.Value = 0 Then ProgressBar_Life1.Value = 1

        ProgressBar_Life2.Value = ProgressBar_Life2.Value - GameLogic.Life2
        If ProgressBar_Life2.Value = 0 Then ProgressBar_Life2.Value = 1

        ProgressBar_Life3.Value = ProgressBar_Life3.Value - GameLogic.Life3
        If ProgressBar_Life3.Value = 0 Then ProgressBar_Life3.Value = 1
    End Sub

    Private Sub Timer_Edu_Tick(sender As Object, e As EventArgs) Handles Timer_Edu.Tick 'Образовательный таймер
        If ProgressBar_Edu.Value = 100 Then
            Timer_Edu.Enabled = False
            ProgressBar_Edu.Value = 0
            UI.LogMessage("Обучение завершено, получено +" & GameLogic.Expexperience & " опыта")
            Label_Ex2.Text += GameLogic.Expexperience
        Else
            ProgressBar_Edu.Value += 25
        End If
    End Sub

    Private Sub ServiceButton1_Click(sender As Object, e As EventArgs) Handles Button_Service1.Click 'Скорость игры x1
        Timer_Life.Interval = 1000
    End Sub

    Private Sub ServiceButton2_Click(sender As Object, e As EventArgs) Handles Button_Service2.Click 'Скорость игры x10
        Timer_Life.Interval = 100
    End Sub

    Private Sub ServiceButton3_Click(sender As Object, e As EventArgs) Handles Button_Service3.Click 'Скорость игры x100
        Timer_Life.Interval = 10
    End Sub

    Private Sub Button_Work1_Click(sender As Object, e As EventArgs) Handles Button_Work1.Click '1 уровень работы
        GameLogic.JobMoney = 10
        Label_Money4.Text = GameLogic.JobMoney

        Label_Life2.Text = Button_Work1.Text

        Button_Work1.Enabled = False
        Button_Work1.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Work2.Click
        'GameLogic.JobMoney = 50 '2 уровень работы
        Button_Work2.Enabled = False
        Label_Life2.Text = Button_Work2.Text
        'Label_Money4.Text = GameLogic.JobMoney
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Work3.Click
        'GameLogic.JobMoney = 100 '3 уровень работы
        Button_Work3.Enabled = False
        Label_Life2.Text = Button_Work3.Text
        'Label_Money4.Text = GameLogic.JobMoney
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_Work4.Click
        'GameLogic.JobMoney = 200 '4 уровень работы
        Button_Work4.Enabled = False
        Label_Life2.Text = Button_Work4.Text
        'Label_Money4.Text = GameLogic.JobMoney
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_Work5.Click
        ' GameLogic.JobMoney = 300 '5 уровень работы
        Button_Work5.Enabled = False
        Label_Life2.Text = Button_Work5.Text
        ' Label_Money4.Text = GameLogic.JobMoney
    End Sub

    Private Sub Button_House1_Click(sender As Object, e As EventArgs) Handles Button_House1.Click 'Дом +1
        Label_Life4.Text = Button_House1.Text '1 уровень дома
        Button_House1.Enabled = False
    End Sub

    Private Sub Button_House2_Click(sender As Object, e As EventArgs) Handles Button_House2.Click
        Label_Life4.Text = Button_House2.Text '2 уровень дома
        Button_House2.Enabled = False
    End Sub

    Private Sub Button_House3_Click(sender As Object, e As EventArgs) Handles Button_House3.Click
        Label_Life4.Text = Button_House3.Text '3 уровень дома
        Button_House3.Enabled = False
    End Sub

    Private Sub Button_House4_Click(sender As Object, e As EventArgs) Handles Button_House4.Click
        Label_Life4.Text = Button_House4.Text '4 уровень дома
        Button_House4.Enabled = False
    End Sub

    Private Sub Button_House5_Click(sender As Object, e As EventArgs) Handles Button_House5.Click
        Label_Life4.Text = Button_House5.Text '5 уровень дома
        Button_House5.Enabled = False
    End Sub

    Private Sub Button_Comfort1_Click(sender As Object, e As EventArgs) Handles Button_Comfort1.Click
        Label_Life6.Text = Button_Comfort1.Text '1 уровень кофорта
        Button_Comfort1.Enabled = False
    End Sub

    Private Sub Button_Comfort2_Click(sender As Object, e As EventArgs) Handles Button_Comfort2.Click
        Label_Life6.Text = Button_Comfort2.Text '2 уровень кофорта
        Button_Comfort2.Enabled = False
    End Sub

    Private Sub Button_Comfort3_Click(sender As Object, e As EventArgs) Handles Button_Comfort3.Click
        Label_Life6.Text = Button_Comfort3.Text '3 уровень кофорта
        Button_Comfort3.Enabled = False
    End Sub

    Private Sub Button_Comfort4_Click(sender As Object, e As EventArgs) Handles Button_Comfort4.Click
        Label_Life6.Text = Button_Comfort4.Text '4 уровень кофорта
        Button_Comfort4.Enabled = False
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button_Calendar1.Click 'Кнопка остановки игрового времени
        If Timer_Life.Enabled = True Then
            Button_Calendar1.Text = "старт"
            Timer_Life.Enabled = False
            Label_Calendar2.ForeColor = Color.Red
            Label_Calendar3.ForeColor = Color.Red
            Label_Calendar5.ForeColor = Color.Red
            UI.LogMessage("Остановка игры")
        Else
            Button_Calendar1.Text = "стоп"
            Timer_Life.Enabled = True
            Label_Calendar2.ForeColor = Color.Black
            Label_Calendar3.ForeColor = Color.Black
            Label_Calendar5.ForeColor = Color.Black
            UI.LogMessage("Игра продолжена")
        End If
    End Sub

    Private Sub Button_Life12_Click(sender As Object, e As EventArgs) Handles Button_Life12.Click 'Еда +20
        If ProgressBar_Life2.Value <= 80 And Label_Money2.Text >= 20 Then
            ProgressBar_Life2.Value += 20
            Label_Money2.Text -= 20
        End If
    End Sub

    Private Sub Button_Life13_Click(sender As Object, e As EventArgs) Handles Button_Life13.Click 'Еда +30
        If ProgressBar_Life2.Value <= 70 And Label_Money2.Text >= 30 Then
            ProgressBar_Life2.Value += 30
            Label_Money2.Text -= 30
        End If
    End Sub

    Private Sub Button_Life14_Click(sender As Object, e As EventArgs) Handles Button_Life14.Click 'Еда +40
        If ProgressBar_Life2.Value <= 60 And Label_Money2.Text >= 40 Then
            ProgressBar_Life2.Value += 40
            Label_Money2.Text -= 40
        End If
    End Sub

    Private Sub Button_Life15_Click(sender As Object, e As EventArgs) Handles Button_Life15.Click 'Еда +50
        If ProgressBar_Life2.Value <= 50 And Label_Money2.Text >= 50 Then
            ProgressBar_Life2.Value = ProgressBar_Life2.Value + 50
            Label_Money2.Text -= 50
        End If
    End Sub

    Private Sub Button_Life21_Click(sender As Object, e As EventArgs) Handles Button_Life21.Click 'Отдых + 10
        If ProgressBar_Life3.Value <= 90 And Label_Money2.Text >= 10 Then
            ProgressBar_Life3.Value += 10
            Label_Money2.Text = Label_Money2.Text - 10
        End If
    End Sub

    Private Sub Button_Life22_Click(sender As Object, e As EventArgs) Handles Button_Life22.Click 'Отдых + 20
        If ProgressBar_Life3.Value <= 80 And Label_Money2.Text >= 20 Then
            ProgressBar_Life3.Value += 20
            Label_Money2.Text -= 20
        End If
    End Sub

    Private Sub Button_Life23_Click(sender As Object, e As EventArgs) Handles Button_Life23.Click 'Отдых + 30
        If ProgressBar_Life3.Value <= 70 And Label_Money2.Text >= 30 Then
            ProgressBar_Life3.Value += 30
            Label_Money2.Text -= 30
        End If
    End Sub

    Private Sub Button_Life24_Click(sender As Object, e As EventArgs) Handles Button_Life24.Click 'Отдых + 40
        If ProgressBar_Life3.Value <= 60 And Label_Money2.Text >= 40 Then
            ProgressBar_Life3.Value += 40
            Label_Money2.Text -= 40
        End If
    End Sub

    Private Sub Button_Life25_Click(sender As Object, e As EventArgs) Handles Button_Life25.Click 'Отдых + 50
        If ProgressBar_Life3.Value <= 50 And Label_Money2.Text >= 50 Then
            ProgressBar_Life3.Value += 50
            Label_Money2.Text -= 50
        End If
    End Sub

    Private Sub Button_Edu1_Click(sender As Object, e As EventArgs) Handles Button_Edu1.Click 'Образование 1
        Try
            If Timer_Edu.Enabled = True Then MsgBox("Обучение уже идёт",, "Терпение") : Return

            Dim lblEducationName As Label = Nothing
            Dim lblEducationCost As Label = Nothing
            Dim ItemCost As Integer

            Select Case GameLogic.EduSt1 'Проверка статуса обучения
                Case 1
                    lblEducationName = Label_Edu11
                    lblEducationCost = Label_Edu16
                    ItemCost = 10

                    GameLogic.Expexperience = 10 'Передаем значение опыта в переменную
                Case 2
                    lblEducationName = Label_Edu12
                    lblEducationCost = Label_Edu17
                    ItemCost = 20

                    GameLogic.Expexperience = 20
                Case 3
                    lblEducationName = Label_Edu13
                    lblEducationCost = Label_Edu18
                    ItemCost = 30

                    GameLogic.Expexperience = 30
                Case 4
                    lblEducationName = Label_Edu14
                    lblEducationCost = Label_Edu19
                    ItemCost = 40

                    GameLogic.Expexperience = 40
                Case 5
                    lblEducationName = Label_Edu15
                    lblEducationCost = Label_Edu110
                    ItemCost = 50

                    GameLogic.Expexperience = 50
                    Button_Edu1.Enabled = False
                    Button_Edu1.Text = "Обучение закончено"

            End Select

            GameLogic.BuyItem(ItemCost)
            GameLogic.EduSt1 += 1

            UI.LogMessage($"Обучение началось, -{ItemCost}$") ' Вывод информации в поле
            UI.EduChangeColorLabel(lblEducationName, ModuleUI.Edu_Style.Green1)
            UI.EduChangeColorLabel(lblEducationCost, ModuleUI.Edu_Style.Green2)
            UI.RefreshMoney()

            Timer_Edu.Enabled = True 'Запускаем таймер

        Catch ex As MoneyNothingException
            MessageBox.Show("Не хватает денег", "Нищеброд")

        Catch ex As Exception
            MessageBox.Show("Ошибка")
        End Try
    End Sub

    Private Sub Button_Service4_Click(sender As Object, e As EventArgs) Handles Button_Service4.Click '+ 1000 $
        GameLogic.AddMoney(1000)
        UI.RefreshMoney()
    End Sub

    Private Sub Button_Life11_Click(sender As Object, e As EventArgs) Handles Button_Life11.Click 'Еда + 10
        If ProgressBar_Life2.Value <= 90 And Label_Money2.Text >= 10 Then
            ProgressBar_Life2.Value += 10
            Label_Money2.Text -= 10
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Покушали на +10, стоимость - 10$" & vbCrLf & TextBox_Event.Text
        Else
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Не хватает денег или уже сыты" & vbCrLf & TextBox_Event.Text
        End If
    End Sub

    Private Sub Button_Comfort5_Click(sender As Object, e As EventArgs) Handles Button_Comfort5.Click
        Label_Life6.Text = Button_Comfort5.Text '5 уровень кофорта
        Button_Comfort5.Enabled = False
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ItemCost As Integer

            ItemCost = 100

            GameLogic.BuyItem(ItemCost)
            GameLogic.EduSt1 += 1

            UI.LogMessage($"Обучение началось, -{ItemCost}$") ' Вывод информации в поле
            UI.RefreshMoney()

        Catch ex As MoneyNothingException
            MessageBox.Show("Не хватает денег", "Нищеброд")

        Catch ex As Exception
            MessageBox.Show("Ошибка")
        End Try
    End Sub
End Class