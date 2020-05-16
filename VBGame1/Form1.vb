Public Class Form_Main

    Dim Cash As Integer
    Dim Life1, Life2, Life3, Life4 As Double
    Dim EduEx As Integer 'Контейнер опыта для таймера



    Dim UI As New ModuleUI(Me)


    Dim aa As New ClassStatus()




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cash = 0
        Life1 = 1
        Life2 = 1
        Life3 = 1
        Life4 = 1

        'Статус уровней образования

    End Sub

    Private Sub Rang1() ' Процедура проверки ранга №1
        'TextBox_Event.Text = "Проверка ранга" & vbCrLf & TextBox_Event.Text
        If Label_Ex2.Text = "120" Then
            TextBox_Event.Text = "Поздравляем! Статус повышен" & vbCrLf & TextBox_Event.Text
            Button_PC12.Enabled = True
            Button_PC22.Enabled = True
            Button_PC32.Enabled = True
            Button_PC42.Enabled = True
            Button_PC52.Enabled = True
            Button_PC62.Enabled = True
            Button_PC72.Enabled = True
        End If
    End Sub

    Private Sub Rang2() ' Процедура проверки ранга №2
        'TextBox_Event.Text = "Проверка ранга" & vbCrLf & TextBox_Event.Text
        If Label_Ex2.Text = "210" Then
            TextBox_Event.Text = "Поздравляем! Доступны новые улучшения компьютера 3 уровня" & vbCrLf & TextBox_Event.Text
            Button_PC13.Enabled = True
            Button_PC23.Enabled = True
            Button_PC33.Enabled = True
            Button_PC43.Enabled = True
            Button_PC53.Enabled = True
            Button_PC63.Enabled = True
            Button_PC73.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer_Life.Tick 'Основной таймер
        Label_Calendar2.Text = Label_Calendar2.Text + 1 '+ 1 час
        If Label_Calendar2.Text = 25 Then 'Начало нового дня
            Label_Calendar2.Text = 0 ' Сброс счетчика часов
            Label_Calendar5.Text = Label_Calendar5.Text + 1 '+ 1 день
            Money.Text = Money.Text + Cash 'Выдача недельной зарплаты
        End If

        'Шкала жизненных потребностей
        ProgressBar_Life1.Value = ProgressBar_Life1.Value - Life1
        If ProgressBar_Life1.Value = 0 Then ProgressBar_Life1.Value = 1

        ProgressBar_Life2.Value = ProgressBar_Life2.Value - Life2
        If ProgressBar_Life2.Value = 0 Then ProgressBar_Life2.Value = 1

        ProgressBar_Life3.Value = ProgressBar_Life3.Value - Life3
        If ProgressBar_Life3.Value = 0 Then ProgressBar_Life3.Value = 1
    End Sub

    Private Sub Timer_Edu_Tick(sender As Object, e As EventArgs) Handles Timer_Edu.Tick 'Образовательный таймер
        If ProgressBar_Edu.Value = 100 Then
            Timer_Edu.Enabled = False
            ProgressBar_Edu.Value = 0
            TextBox_Event.Text = $"Обучение завершено, получено +" & EduEx & " опыта" & vbCrLf & vbCrLf & TextBox_Event.Text 'Вывод информации
            Label_Ex2.Text += EduEx
        Else
            ProgressBar_Edu.Value += 25
        End If
    End Sub

    Private Sub ServiceButton1_Click(sender As Object, e As EventArgs) Handles Button_Service1.Click
        Timer_Life.Interval = 1000 'Скорость игры x1
    End Sub

    Private Sub ServiceButton2_Click(sender As Object, e As EventArgs) Handles Button_Service2.Click
        Timer_Life.Interval = 100 'Скорость игры x10
    End Sub

    Private Sub ServiceButton3_Click(sender As Object, e As EventArgs) Handles Button_Service3.Click
        Timer_Life.Interval = 10 'Скорость игры x100
    End Sub

    Private Sub Button_Work1_Click(sender As Object, e As EventArgs) Handles Button_Work1.Click
        Cash = 10 '1 уровень работы
        Label_Life2.Text = Button_Work1.Text
        Label_Money4.Text = Cash

        Button_Work1.Enabled = False
        Button_Work1.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Work2.Click
        Cash = 50 '2 уровень работы
        Button_Work2.Enabled = False
        Label_Life2.Text = Button_Work2.Text
        Label_Money4.Text = Cash
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button_Work3.Click
        Cash = 100 '3 уровень работы
        Button_Work3.Enabled = False
        Label_Life2.Text = Button_Work3.Text
        Label_Money4.Text = Cash
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button_Work4.Click
        Cash = 200 '4 уровень работы
        Button_Work4.Enabled = False
        Label_Life2.Text = Button_Work4.Text
        Label_Money4.Text = Cash
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_Work5.Click
        Cash = 300 '5 уровень работы
        Button_Work5.Enabled = False
        Label_Life2.Text = Button_Work5.Text
        Label_Money4.Text = Cash
    End Sub

    Private Sub Button_House1_Click(sender As Object, e As EventArgs) Handles Button_House1.Click
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
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Остановка игры" & vbCrLf & TextBox_Event.Text
        Else
            Button_Calendar1.Text = "стоп"
            Timer_Life.Enabled = True
            Label_Calendar2.ForeColor = Color.Black
            Label_Calendar3.ForeColor = Color.Black
            Label_Calendar5.ForeColor = Color.Black
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Игра продолжена" & vbCrLf & TextBox_Event.Text
        End If
    End Sub

    Private Sub Button_Life12_Click(sender As Object, e As EventArgs) Handles Button_Life12.Click
        If ProgressBar_Life2.Value <= 80 And Money.Text >= 20 Then
            ProgressBar_Life2.Value = ProgressBar_Life2.Value + 20
            Money.Text = Money.Text - 20
        End If
    End Sub

    Private Sub Button_Life13_Click(sender As Object, e As EventArgs) Handles Button_Life13.Click
        If ProgressBar_Life2.Value <= 70 And Money.Text >= 30 Then
            ProgressBar_Life2.Value = ProgressBar_Life2.Value + 30
            Money.Text = Money.Text - 30
        End If
    End Sub

    Private Sub Button_Life14_Click(sender As Object, e As EventArgs) Handles Button_Life14.Click
        If ProgressBar_Life2.Value <= 60 And Money.Text >= 40 Then
            ProgressBar_Life2.Value = ProgressBar_Life2.Value + 40
            Money.Text = Money.Text - 40
        End If
    End Sub

    Private Sub Button_Life15_Click(sender As Object, e As EventArgs) Handles Button_Life15.Click
        If ProgressBar_Life2.Value <= 50 And Money.Text >= 50 Then
            ProgressBar_Life2.Value = ProgressBar_Life2.Value + 50
            Money.Text = Money.Text - 50
        End If
    End Sub

    Private Sub Button_Life21_Click(sender As Object, e As EventArgs) Handles Button_Life21.Click
        If ProgressBar_Life3.Value <= 90 And Money.Text >= 10 Then
            ProgressBar_Life3.Value = ProgressBar_Life3.Value + 10
            Money.Text = Money.Text - 10
        End If
    End Sub

    Private Sub Button_Life22_Click(sender As Object, e As EventArgs) Handles Button_Life22.Click
        If ProgressBar_Life3.Value <= 80 And Money.Text >= 20 Then
            ProgressBar_Life3.Value = ProgressBar_Life3.Value + 20
            Money.Text = Money.Text - 20
        End If
    End Sub

    Private Sub Button_Life23_Click(sender As Object, e As EventArgs) Handles Button_Life23.Click
        If ProgressBar_Life3.Value <= 70 And Money.Text >= 30 Then
            ProgressBar_Life3.Value = ProgressBar_Life3.Value + 30
            Money.Text = Money.Text - 30
        End If
    End Sub

    Private Sub Button_Life24_Click(sender As Object, e As EventArgs) Handles Button_Life24.Click
        If ProgressBar_Life3.Value <= 60 And Money.Text >= 40 Then
            ProgressBar_Life3.Value = ProgressBar_Life3.Value + 40
            Money.Text = Money.Text - 40
        End If
    End Sub

    Private Sub Button_Life25_Click(sender As Object, e As EventArgs) Handles Button_Life25.Click
        If ProgressBar_Life3.Value <= 50 And Money.Text >= 50 Then
            ProgressBar_Life3.Value = ProgressBar_Life3.Value + 50
            Money.Text = Money.Text - 50
        End If
    End Sub

    Private Sub Button_PC21_Click(sender As Object, e As EventArgs) Handles Button_PC21.Click 'ОЗУ
        If Money.Text >= 10 Then
            Label_Ex2.Text = Label_Ex2.Text + 10
            Money.Text = Money.Text - 10

            UI.LogMessage($"Покупка: {Button_PC21.Text} за 10 $, получено опыта +10")

            'TextBox_Event.Text = "" & vbCrLf & TextBox_Event.Text
            'TextBox_Event.Text = "Покупка: ОЗУ 4 Gb за 10 $ за 10 $, получено опыта +10" & vbCrLf & TextBox_Event.Text
            Button_PC21.Enabled = False
            Button_PC21.Text = "Куплено"
            Rang1()
        Else
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Не хватает денег" & vbCrLf & TextBox_Event.Text
        End If
    End Sub

    Private Sub Button_PC31_Click(sender As Object, e As EventArgs) Handles Button_PC31.Click 'Память
        If Money.Text >= 10 Then
            Label_Ex2.Text = Label_Ex2.Text + 10
            Money.Text = Money.Text - 10
            TextBox_Event.Text = "" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Покупка: HDD 500 Gb за 10 $, получено опыта +10" & vbCrLf & TextBox_Event.Text
            Button_PC31.Enabled = False
            Button_PC31.Text = "Куплено"
            Rang1()
        Else
            TextBox_Event.Text = "" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Не хватает денег" & vbCrLf & TextBox_Event.Text
        End If
    End Sub

    Private Sub Button_PC41_Click(sender As Object, e As EventArgs) Handles Button_PC41.Click 'Видеокарта
        If Money.Text >= 10 Then
            Label_Ex2.Text = Label_Ex2.Text + 10
            Money.Text = Money.Text - 10
            TextBox_Event.Text = "" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Покупка: DDR3, 1 Gb за 10 $, получено опыта +10" & vbCrLf & TextBox_Event.Text
            Button_PC41.Enabled = False
            Button_PC41.Text = "Куплено"
            Rang1()
        Else
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Не хватает денег" & vbCrLf & TextBox_Event.Text
        End If
    End Sub

    Private Sub Button_PC51_Click(sender As Object, e As EventArgs) Handles Button_PC51.Click
        If Money.Text >= 10 Then
            Label_Ex2.Text = Label_Ex2.Text + 10
            Money.Text = Money.Text - 10
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Покупка: TN матрица за 10 $, получено опыта +10" & vbCrLf & TextBox_Event.Text
            Button_PC51.Enabled = False
            Button_PC51.Text = "Куплено"
            Rang1()
        Else
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Не хватает денег" & vbCrLf & TextBox_Event.Text
        End If


    End Sub

    Private Sub Button_PC61_Click(sender As Object, e As EventArgs) Handles Button_PC61.Click
        If Money.Text >= 10 Then
            Label_Ex2.Text = Label_Ex2.Text + 10
            Money.Text = Money.Text - 10
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Покупка: Игровая мышь за 10 $, получено опыта +10" & vbCrLf & TextBox_Event.Text
            Button_PC61.Enabled = False
            Button_PC61.Text = "Куплено"
            Rang1()
        Else
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Не хватает денег" & vbCrLf & TextBox_Event.Text
        End If
    End Sub

    Private Sub Button_PC71_Click(sender As Object, e As EventArgs) Handles Button_PC71.Click
        If Money.Text >= 10 Then
            Label_Ex2.Text = Label_Ex2.Text + 10
            Money.Text = Money.Text - 10
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Покупка: 20 Мбит/с за 10 $, получено опыта +10" & vbCrLf & TextBox_Event.Text
            Button_PC71.Enabled = False
            Button_PC71.Text = "Куплено"
            Rang1()
        Else
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Не хватает денег" & vbCrLf & TextBox_Event.Text
        End If
    End Sub

    Private Sub Button_PC12_Click(sender As Object, e As EventArgs) Handles Button_PC12.Click
        If Money.Text >= 20 Then
            Label_Ex2.Text = Label_Ex2.Text + 20
            Money.Text = Money.Text - 20
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Покупка: процессор 4-ядерный за 20 $, получено опыта +20" & vbCrLf & TextBox_Event.Text
            Button_PC12.Enabled = False
            Button_PC11.Text = "Куплено"
            Rang1()
        Else
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Не хватает денег" & vbCrLf & TextBox_Event.Text
        End If
    End Sub

    Private Sub Button_Edu1_Click(sender As Object, e As EventArgs) Handles Button_Edu1.Click 'Образование 1
        If Timer_Edu.Enabled = True Then MsgBox("Обучение уже идёт",, "Терпение") : Return


        Select Case ClassStatus.EduSt1 'Проверка статуса обучения
            Case 1
                If Money.Text <= 10 Then MsgBox("Не хватает денег",, "Нищеброд") : Return 'Проверка наличия стредств
                EduSt1 += 1 'Счетчик статуса
                Money.Text -= 10 'Списание средств
                UI.LogMessage("Обучение началось, -10$") ' Вывод информации в поле
                EduEx = 10 'Передаем значение опыта в переменную
                Timer_Edu.Enabled = True 'Запускаем таймер
                UI.EduChangeColorLabel(Label_Edu11, ModuleUI.Edu_Style.Green1) 'Прорисовка шрифта
                UI.EduChangeColorLabel(Label_Edu16, ModuleUI.Edu_Style.Green2)
            Case 2
                If Money.Text <= 20 Then MsgBox("Не хватает денег",, "Нищеброд") : Return
                EduSt1 += 1
                Money.Text -= 20
                EduEx = 20
                Timer_Edu.Enabled = True
                UI.EduChangeColorLabel(Label_Edu12, ModuleUI.Edu_Style.Green1)
                UI.EduChangeColorLabel(Label_Edu17, ModuleUI.Edu_Style.Green2)
            Case 3
                If Money.Text <= 30 Then MsgBox("Не хватает денег",, "Нищеброд") : Return
                EduSt1 += 1
                Money.Text -= 30
                EduEx = 30
                Timer_Edu.Enabled = True
                UI.EduChangeColorLabel(Label_Edu13, ModuleUI.Edu_Style.Green1)
                UI.EduChangeColorLabel(Label_Edu18, ModuleUI.Edu_Style.Green2)
            Case 4
                If Money.Text <= 40 Then MsgBox("Не хватает денег",, "Нищеброд") : Return
                EduSt1 += 1
                Money.Text -= 40
                EduEx = 40
                Timer_Edu.Enabled = True
                UI.EduChangeColorLabel(Label_Edu14, ModuleUI.Edu_Style.Green1)
                UI.EduChangeColorLabel(Label_Edu19, ModuleUI.Edu_Style.Green2)
            Case 5
                If Money.Text <= 50 Then MsgBox("Не хватает денег",, "Нищеброд") : Return
                EduSt1 += 1
                Money.Text -= 50
                EduEx = 50
                Timer_Edu.Enabled = True
                Button_Edu1.Enabled = False
                Button_Edu1.Text = "Обучение закончено"
                UI.EduChangeColorLabel(Label_Edu15, ModuleUI.Edu_Style.Green1)
                UI.EduChangeColorLabel(Label_Edu110, ModuleUI.Edu_Style.Green2)
        End Select

        'TextBox_Event.Text = "EduSt1 = " & EduSt1 & vbCrLf & vbCrLf & TextBox_Event.Text 'Вывод информации (Для разработки)
    End Sub

    Private Sub Button_Service4_Click(sender As Object, e As EventArgs) Handles Button_Service4.Click
        Money.Text += 1000
    End Sub

    Private Sub Button_PC11_Click(sender As Object, e As EventArgs) Handles Button_PC11.Click 'Процессор
        If Money.Text >= 10 Then
            Label_Ex2.Text = Label_Ex2.Text + 10
            Money.Text = Money.Text - 10
            TextBox_Event.Text = "" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Покупка: процессор 2-ядерный за 10 $, получено опыта +10" & vbCrLf & TextBox_Event.Text
            Button_PC11.Enabled = False
            Button_PC11.Text = "Куплено"
            Rang1()
        Else
            TextBox_Event.Text = "-----" & vbCrLf & TextBox_Event.Text
            TextBox_Event.Text = "Не хватает денег" & vbCrLf & TextBox_Event.Text
        End If
    End Sub

    Private Sub Button_Life11_Click(sender As Object, e As EventArgs) Handles Button_Life11.Click
        If ProgressBar_Life2.Value <= 90 And Money.Text >= 10 Then
            ProgressBar_Life2.Value = ProgressBar_Life2.Value + 10
            Money.Text = Money.Text - 10
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
End Class


'TextBox_Event.Text = "dsfsdfdsf" & vbCrLf & TextBox_Event.Text
'UI.LogMessage($"Покупка {Button_PC21.Text} за 10 $, получено опыта +10")