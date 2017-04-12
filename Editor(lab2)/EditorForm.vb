Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions

Public Class EditorForm
    Dim bef As String

    Dim wasLoaded As Boolean = False
    Dim findWord As String
    Dim replaceWord As String
    Dim pattern As String
    Dim rgx As Regex


    <DllImport("C:\Users\progr\Desktop\find.dll",
        CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function Dif(<MarshalAs(UnmanagedType.I4)> ByVal b As Integer) As Double
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub


    Sub openFile()
        Dim openFile As New OpenFileDialog
        openFile.Filter = "txt Files (Text Files)|*.txt"


        openFile.Title = "Choose file."
        If (openFile.ShowDialog = System.Windows.Forms.DialogResult.OK) Then

            RTBText.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub


    Sub findWords(ByVal count As Integer)
        DisableInput()
        Dim word As String
        Dim head As Integer
        Dim tail As Integer = True
        Dim ask As Boolean = True
        Dim flag = True
        Dim text As String
        text = RTBText.Text
        text = text + " "
        word = ""
        head = count
        tail = count
        For i = count To text.Length - 1
            If text(i) = " " Then


                'If word Like findWord Then
                If rgx.IsMatch(word) Then
                    If word.Length >= findWord.Length / 6 Then
                        If ask Then
                            ChangeBackgroundWord(head, tail, Color.Black)
                            my_showDialog()
                            ChangeBackgroundWord(head, tail, Me.RTBText.BackColor)
                        End If


                        If DialogForm.getReplaceAll = False Then
                            If DialogForm.getZ = True Then
                                replace(head, tail, replaceWord)
                                tail = head + replaceWord.Length
                                ChangeWord(head, tail, Color.Red)
                            End If
                        Else
                            replace(head, tail, replaceWord)
                            tail = head + replaceWord.Length
                            ChangeWord(head, tail, Color.Red)
                            ask = False
                        End If
                    End If


                    End If
                    tail = tail + 1
                    head = tail
                    word = ""
                ElseIf text(i) = "," Or text(i) = "." Then
                    tail = tail + 1
                Else
                    word = word + text(i)
                    tail = tail + 1
                End If


        Next

    End Sub


    Sub withCursor()
        'Form1.ShowDialog()
        Me.Show()
        Me.Focus()

        Dim i As Integer
        Dim k As Integer
        Dim text As String
        i = Me.RTBText.SelectionStart
        Me.RTBText.SelectAll()
        text = Me.RTBText.Text.Substring(i, Me.RTBText.SelectionLength - i)
        findWords(i)
    End Sub



    Sub start()
        If Me.wasLoaded = False Then

            DialogForm.ShowDialog()
            findWord = DialogForm.txtFind.Text
            replaceWord = DialogForm.txtReplace.Text
            changeInputToPattern()
            If findWord.Length > 0 And replaceWord.Length > 0 And DialogForm.rbStart.Checked Then

                findWords(1)
            End If
            If findWord.Length > 0 And replaceWord.Length > 0 And DialogForm.rbCursor.Checked Then

                Me.Visible = False
                withCursor()


            End If
            wasLoaded = True
        End If

    End Sub


    Sub DisableInput()
        DialogForm.txtFind.Enabled = False
        DialogForm.txtReplace.Enabled = False
        DialogForm.rbStart.Enabled = False
        DialogForm.rbCursor.Enabled = False
    End Sub

    Sub EnableInput()
        DialogForm.txtFind.Enabled = True
        DialogForm.txtReplace.Enabled = True
        DialogForm.rbStart.Enabled = True
        DialogForm.rbCursor.Enabled = True
    End Sub


    Sub ChangeWord(ByVal head As Integer, ByRef tail As Integer, ByVal color As Color)
        RTBText.Select(head, tail - head)
        RTBText.SelectionColor = color

    End Sub


    Sub ChangeBackgroundWord(ByVal head As Integer, ByRef tail As Integer, ByVal color As Color)

        RTBText.Select(head, tail - head)
        RTBText.SelectionBackColor = color

    End Sub

    Sub my_showDialog()
        Me.Show()
        DialogForm.ShowDialog()
    End Sub


    Sub replace(ByVal head As Integer, ByVal tail As Integer, ByVal word As String)
        RTBText.Select(head, tail - head)
        RTBText.SelectedText = word
    End Sub


    Sub save()
        RTBText.SaveFile("C:\Users\progr\Desktop\out.txt")

    End Sub


    Sub changeInputToPattern()
        parsePattern(findWord)
        rgx = New Regex(findWord)
        pattern = findWord
    End Sub

    Sub parsePattern(ByVal str As String)
        Dim s As String = "^"
        Dim flag As Boolean = False
        Dim temp As String
        Dim k As String = ""
        Dim one As Boolean = False
        For i = 0 To str.Length - 1
            temp = "\w("
            If str(i) <> "$" Then
                flag = True
                k = k + str(i)
            Else
                If flag = True Then
                    one = False
                    temp = temp + k + ")"
                    s = s + temp
                    k = ""
                End If
                If one = False Then
                    s = s + "\d+"
                    one = True
                End If
                End If

        Next
        If k <> "" Then
            s = s + "\w(" + k + ")"
        End If
        s = s + "$"
        findWord = s
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bef = RTBText.Text
        Me.wasLoaded = False
        EnableInput()








        start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        openFile()
    End Sub
End Class



