﻿Public Class Check_Most_Active
    Public SQL As New SQLControl

    Private Sub current_rentals_close_btn_Click(sender As Object, e As EventArgs) Handles current_rentals_close_btn.Click
        Me.Close()
    End Sub

    Private Sub data_grid_most_active_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid_most_active.CellContentClick

    End Sub

    Private Sub List_Current_Rentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MdiParent = Main_Interface
    End Sub

    Private Sub most_active_exebtn_Click(sender As Object, e As EventArgs) Handles most_active_exebtn.Click
        If most_rented_movies_rbutton.Checked = True Then
            ' Checking most popular movies.
            SQL.ExecuteQuery("Select Top " & top_x_tb.Text & " M.movie_id as ID, M.movie_name as Name, COUNT(*) as Rented " &
                             "From Movie_Data as M, Order_Data as O " &
                             "Where O.movie_id = M.movie_id " &
                             "GROUP BY M.movie_id, M.movie_name " &
                             "ORDER BY Rented desc;")
        ElseIf customers_rbutton.Checked = True Then
            ' Checking most active customers.
            SQL.ExecuteQuery("Select Top " & top_x_tb.Text & " C.account_number as Account, C.first_name as First, C.last_name as Last, COUNT(*) as Rented " &
                             "From Customer_Data as C, Order_Data as O " &
                             "Where O.account_number = C.account_number " &
                             "GROUP BY C.account_number, C.first_name, C.last_name " &
                             "ORDER BY Rented desc;")
        ElseIf sale_rep_rbutton.Checked = True Then
            ' Checking for most active sales reps.
            SQL.ExecuteQuery("Select Top " & top_x_tb.Text & " E.SIN, E.first_name as First, E.last_name as Last, COUNT(*) as Orders_Overlooked " &
                             "From Employee_Data as E, Order_Data as O " &
                             "Where O.SIN = E.SIN " &
                             "GROUP BY E.SIN, E.first_name, E.last_name " &
                             "ORDER BY Orders_Overlooked desc;")
        End If

        If SQL.HasException(True) Then Exit Sub
        data_grid_most_active.DataSource = SQL.SQLTable
    End Sub
End Class