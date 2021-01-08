Imports Tulpep.NotificationWindow
Imports System.Text
Imports System.Security.Cryptography
Public Class Biblioteca

    '********** Método que bloqueia ou desbloqueia TextBox, Button, ComboBox, DateTimePicker e NumericUpDown de qualquer formulário
    Public Shared Sub gerenciarControles(ByVal estado As Boolean, formulario As Form)
        For Each controle1 In formulario.Controls
            If TypeOf controle1 Is TextBox Or TypeOf controle1 Is Button Or TypeOf controle1 Is DateTimePicker Or TypeOf controle1 Is NumericUpDown Or TypeOf controle1 Is ComboBox Then
                controle1.Enabled = estado
            ElseIf TypeOf controle1 Is GroupBox Then
                For Each controle2 In controle1.Controls
                    If TypeOf controle2 Is TextBox Or TypeOf controle2 Is Button Or TypeOf controle2 Is DateTimePicker Or TypeOf controle2 Is NumericUpDown Or TypeOf controle2 Is ComboBox Then
                        controle2.Enabled = estado
                    End If
                Next
            End If
        Next
    End Sub


    Public Shared Sub exibirBotoes(ByVal estado As Boolean, formulario As Form)
        For Each controle1 In formulario.Controls
            If TypeOf controle1 Is Button Then
                controle1.Visible = estado
            ElseIf TypeOf controle1 Is GroupBox Then
                For Each controle2 In controle1.Controls
                    If TypeOf controle2 Is Button Then
                        controle2.Visible = estado
                    End If
                Next
            End If
        Next

    End Sub

    '********** Método que limpa o texto de todas as TextBox de um formulário
    Public Shared Sub limparTextBox(formulario As Form)
        For Each controle1 In formulario.Controls
            If TypeOf controle1 Is TextBox Then
                controle1.Text = ""
            ElseIf TypeOf controle1 Is NumericUpDown Then
                controle1.Value = 0
            ElseIf TypeOf controle1 Is GroupBox Then
                For Each controle2 In controle1.Controls
                    If TypeOf controle2 Is TextBox Then
                        controle2.Text = ""
                    ElseIf TypeOf controle2 Is NumericUpDown Then
                        controle2.Value = 0
                    End If
                Next
            End If
        Next
    End Sub

    Public Shared Sub exibirNotificacao(ByVal titulo As String, ByVal conteudo As String, ByVal tipo As String)

        Dim notificacao As New PopupNotifier()
        If tipo = "Sucesso" Then
            notificacao.HeaderColor = Color.MediumSeaGreen
            notificacao.TitleColor = Color.MediumSeaGreen
        End If

        If tipo = "Cancelamento" Then
            notificacao.HeaderColor = Color.Orange
            notificacao.TitleColor = Color.Orange
        End If

        If tipo = "Erro" Then
            notificacao.HeaderColor = Color.Crimson
            notificacao.TitleColor = Color.Crimson
        End If

        notificacao.BodyColor = Color.Black
        notificacao.ContentColor = Color.White
        notificacao.TitleText = titulo
        notificacao.ContentText = conteudo
        notificacao.AnimationInterval = 10
        notificacao.Popup()
    End Sub

    'Método de criptografar
    Public Shared Function Criptografar(valor As String) As String
        Dim Bytes() As Byte
        Dim sb As New StringBuilder()
        Bytes = Encoding.Default.GetBytes(valor)
        Bytes = MD5.Create().ComputeHash(Bytes)
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next
        Return sb.ToString()
    End Function
    Public Shared Function removerEspaçoDuplo(ByRef texto As String)
        Dim retorno As String = texto
        For x As Integer = 0 To texto.Length - 1
            If x = texto.Length - 1 Then
                Exit For
            Else
                If texto.Substring(x, 2) = "  " Then
                    texto = texto.Remove(x + 1, 1)
                End If
            End If
        Next
        Return retorno
    End Function
    Public Shared Function ValidaCPF(ByVal CPF As String) As Boolean
        Dim dadosArray() As String = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44",
                                              "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}
        Dim retorno As Boolean = True
        Dim i, x, n1, n2 As Integer
        CPF = Trim(CPF)
        For i = 0 To dadosArray.Length - 1
            If CPF.Length <> 14 Or dadosArray(i).Equals(CPF) Then
                retorno = False
            End If
        Next
        CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)
        For x = 0 To 1
            n1 = 0
            For i = 0 To 8 + x
                n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
            Next
            n2 = 11 - (n1 - (Int(n1 / 11) * 11))
            If n2 = 10 Or n2 = 11 Then n2 = 0
            If n2 <> Val(CPF.Substring(9 + x, 1)) Then
                retorno = False
            End If
        Next
        Return retorno
    End Function
    Public Shared Function validaNumero(ByVal texto As String) As Boolean
        Dim retorno As Boolean
        If IsNumeric(texto) Then
            retorno = True
        Else
            retorno = False
        End If
        Return retorno
    End Function
    Public Shared Function validaCaractere(ByVal texto As String) As Boolean
        Dim retorno As Boolean = True
        For x As Integer = 0 To texto.Length - 1
            If IsNumeric(texto.Substring(x, 1)) Then
                retorno = False
                Exit For
            End If
        Next
        Return retorno
    End Function
    Public Shared Function validaEspaco(ByVal texto As String) As Boolean
        Dim retorno As Boolean = True
        For x As Integer = 0 To texto.Length - 1
            If texto.Substring(x, 1) = "  " Then
                retorno = False
                Exit For
            End If
        Next
        Return retorno
    End Function

    Public Shared Function verificaEmail(ByVal texto As String) As Boolean
        texto = LCase(texto)
        Dim retornoPrimario As Boolean = False
        Dim retornoSecundario As Boolean = False
        Dim retornoTerciario As Boolean = False
        Dim retornoFinal As Boolean = False
        Dim contadorPrimario As Integer = 0
        Dim contadorSecundario As Integer = 0
        Dim contadorTerciario As Integer = 0
        Dim ordenador As Integer = 0
        Dim alfabeto() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}

        For x As Integer = 0 To texto.Length - 2
            For y As Integer = 0 To alfabeto.Length - 1
                If (texto.Substring(x, 2) = (alfabeto(y) & "@")) Then
                    contadorTerciario += 1
                    ordenador = x
                End If
            Next
        Next

        If contadorTerciario = 1 Then
            retornoTerciario = True
            For x As Integer = ordenador To texto.Length - 2
                For y As Integer = 0 To alfabeto.Length - 1
                    If (texto.Substring(x, 2) = ("@" & alfabeto(y))) Then
                        contadorPrimario += 1
                        ordenador = x
                    End If
                Next
            Next
            If contadorPrimario = 1 Then
                retornoPrimario = True
                For x As Integer = ordenador To texto.Length - 1
                    If x = texto.Length - 2 Then
                        Exit For
                    Else
                        For y As Integer = 0 To alfabeto.Length - 1
                            For z As Integer = 0 To alfabeto.Length - 1
                                If (texto.Substring(x, 3) = "." & alfabeto(y) & alfabeto(z)) Then
                                    contadorSecundario += 1
                                End If
                            Next
                        Next
                    End If
                Next
                If contadorSecundario >= 1 Then
                    retornoSecundario = True
                End If
                If retornoPrimario And retornoSecundario And retornoTerciario Then
                    retornoFinal = True
                End If
            End If
        End If

        Return retornoFinal

    End Function
End Class
