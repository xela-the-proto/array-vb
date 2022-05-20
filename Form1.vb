Public Class frm_operArray
    Dim n As Byte
    Dim v() As Single
    Private Sub btn_esci_Click(sender As Object, e As EventArgs) Handles btn_esci.Click
        End
    End Sub

    Private Sub btn_carica_Click(sender As Object, e As EventArgs) Handles btn_carica.Click
        n = Val(InputBox("numero di elementi da elaborare", "caricamento"))
        ReDim v(n - 1)
        carica(v, n)
    End Sub

    Private Sub carica(ByRef a() As Single, ByVal d As Byte)
        Dim i As Byte
        For i = 0 To d - 1
            a(i) = InputBox("inserire il dato n." & CStr(i + 1), "caricamento array")
        Next i
    End Sub

    Private Sub btn_visualizza_Click(sender As Object, e As EventArgs) Handles btn_visualizza.Click
        visualizza(v, n)
    End Sub

    Private Sub visualizza(ByRef a() As Single, ByVal d As Byte)
        Dim i As Byte
        lst_array.Items.Clear()
        For i = 0 To d - 1
            lst_array.Items.Add(a(i))
        Next
    End Sub
End Class
