Public Class Form1

    Function Restar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero - 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function
    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim nuevoTexto As String
        numero = numero + 1
        nuevoTexto = numero.ToString()
        Return nuevoTexto
    End Function

    Private Sub btnmenos_Click(sender As Object, e As EventArgs) Handles btnmenos.Click

        'Dim numeroEntrante As String = Label1.Text
        'numeroEntrante = Restar(numeroEntrante)
        'Label1.Text = numeroEntrante

        Label1.Text = Restar(Label1.Text)
    End Sub

    Private Sub btnmas_Click(sender As Object, e As EventArgs) Handles btnmas.Click

        Label1.Text = Aumentar(Label1.Text)
    End Sub

    Private Sub btnmenos2_Click(sender As Object, e As EventArgs) Handles btnmenos2.Click
        Label3.Text = Restar(Label3.Text)
    End Sub

    Private Sub btnmas1_Click(sender As Object, e As EventArgs) Handles btnmas1.Click
        Label3.Text = Aumentar(Label3.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim txtA = Label1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Label3.Text
        Dim numB = Int32.Parse(txtB)

        Dim Resultadosuma = Suma(numA, numB)

        resultadi.Text = "El resultado de A + B es " + Resultadosuma.ToString()
    End Sub

    Function Suma(numaA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numaA + numB
        Return resultado
    End Function

    Function Resta(numaA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numaA - numB
        Return resultado
    End Function
    Function Mulplicar(numaA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numaA * numB
        Return resultado
    End Function

    Function Dividir(numaA As Integer, numB As Integer) As Integer
        Dim resultado As Integer
        resultado = numaA / numB
        Return resultado
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim txtA = Label1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Label3.Text
        Dim numB = Int32.Parse(txtB)

        Dim Resultadoresta = Resta(numA, numB)

        resultadi.Text = "El resultado de A - B es " + Resultadoresta.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim txtA = Label1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Label3.Text
        Dim numB = Int32.Parse(txtB)

        Dim Resultadomultiplicacion = Mulplicar(numA, numB)

        resultadi.Text = "El resultado de A * B es " + Resultadomultiplicacion.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim txtA = Label1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Label3.Text
        Dim numB = Int32.Parse(txtB)

        Dim ResultadoDivision = Dividir(numA, numB)

        resultadi.Text = "El resultado de A / B es " + ResultadoDivision.ToString()
    End Sub

End Class
