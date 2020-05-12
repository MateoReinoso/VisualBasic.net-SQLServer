Public Class Ejercicio

    Private Sub Ejercicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Fecha As Date
        Dim Mensaje As String

        Fecha = Date.Now
        lblFecha.Text = Fecha

        Mensaje = "Calculadora"

        lblMensaje.Text = Mensaje

    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        numero1 = txtNum1.Text
        numero2 = txtNum2.Text

        resultado = numero1 + numero2

        txtResultado.Text = resultado
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double

        numero1 = txtNum1.Text
        numero2 = txtNum2.Text

        resultado = numero1 - numero2

        txtResultado.Text = resultado
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim resultado As Integer

        numero1 = txtNum1.Text
        numero2 = txtNum2.Text

        resultado = numero1 * numero2

        txtResultado.Text = resultado
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim resultado As Integer

        numero1 = txtNum1.Text
        numero2 = txtNum2.Text

        resultado = numero1 / numero2

        txtResultado.Text = resultado
    End Sub
End Class