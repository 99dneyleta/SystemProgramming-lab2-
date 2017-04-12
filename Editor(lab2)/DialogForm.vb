Public Class DialogForm

    Dim za As Boolean = False
    Dim replaceAll As Boolean = False

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        Me.Close()


    End Sub

    Private Sub rbStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbStart.CheckedChanged
        If txtFind.TextLength > 0 And txtReplace.TextLength > 0 Then


        End If
    End Sub



    Private Sub rbCursor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCursor.CheckedChanged

    End Sub

    Private Sub DialogForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        za = False
    End Sub

    Function getZ()
        getZ = za
    End Function

    Function getReplaceAll()
        getReplaceAll = replaceAll
    End Function


    Private Sub btnReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplace.Click
        za = True
        Me.Close()
    End Sub

    Private Sub btnReplaceAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplaceAll.Click
        replaceAll = True
        Me.Close()
    End Sub
End Class