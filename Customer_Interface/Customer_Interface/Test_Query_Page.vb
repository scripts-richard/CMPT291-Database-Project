﻿Imports System.Data.OleDb

Public Class Test_Query_Page
    Private Shared Function GetConnectionString() As String
        Return "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=DESKTOP-C77900C; Initial Catalog=CMPT291_Project; Integrated Security=True"

    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'SQL QUERY
        Dim connectionString As String = GetConnectionString()

        Dim queryString As String = "SELECT first_name FROM Customer_Data" ' + Idtxt.Text.ToString

        Using connection As New OleDbConnection(connectionString)
            Dim command As OleDbCommand = connection.CreateCommand()
            command.CommandText = queryString
            Try
                connection.Open()
                Dim dataReader As OleDbDataReader = command.ExecuteReader()

                Do While dataReader.Read()
                    Answer1.Text = dataReader(0).ToString
                    'Answer2.Text = dataReader(1).ToString
                Loop
                Answer1.Refresh()
                'Answer2.Refresh()

                dataReader.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                ' Console.WriteLine(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

End Class