﻿Public Class Customer_Login
    Private SQL As New SQLControl
    Public ValidUser As String

    Public Function UserAccount() As String
        Return ValidUser
    End Function

    Private Sub Customer_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Function IsAuthenticated() As Boolean
        ' Clear Existing records
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        SQL.ExecuteQuery("SELECT * " &
                         "FROM Customer_Passwords " &
                         "WHERE username='" & username.Text & "' " &
                         "AND password='" & passwd.Text & "' " &
                         "COLLATE SQL_Latin1_General_CP1_CS_AS") ' force case sensitive nature

        If SQL.SQLTable.Rows.Count() <= 0 Then
            MsgBox("Invalid Credentials", MsgBoxStyle.Critical, "LOGIN FAILED")
            username.Clear()
            passwd.Clear()
            Return False
        End If
        Return True
    End Function

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        username.Clear()
        passwd.Clear()
    End Sub

    Private Sub AccessAccount_Click(sender As Object, e As EventArgs) Handles AccessAccount.Click
        If SQL.HasConnection = True Then
            If IsAuthenticated() = True Then
                GetAccount()
                'MsgBox(ValidUser)
                MsgBox("Login Successful")
                ' need to find way to keep user logged in for duration
                Me.Hide() ' connection should stay open while this is open
                Customer_Interface.Show()
            End If
        End If
    End Sub


    Public Sub GetAccount()
        If SQL.SQLTable IsNot Nothing Then
            SQL.SQLTable.Clear()
        End If

        SQL.ExecuteQuery("SELECT account_number FROM Customer_Passwords WHERE username='" & username.Text & "';")
        'DataGridView1.DataSource = SQL.SQLTable ' for test
        ValidUser = SQL.SQLTable.Rows(0).Item("account_number")
        'MsgBox(ValidUser)
    End Sub


End Class