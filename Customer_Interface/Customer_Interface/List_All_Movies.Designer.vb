﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_All_Movies
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.data_grid_movies = New System.Windows.Forms.DataGridView()
        Me.movie_list_close_btn = New System.Windows.Forms.Button()
        CType(Me.data_grid_movies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data_grid_movies
        '
        Me.data_grid_movies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data_grid_movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid_movies.Location = New System.Drawing.Point(12, 74)
        Me.data_grid_movies.Name = "data_grid_movies"
        Me.data_grid_movies.ReadOnly = True
        Me.data_grid_movies.Size = New System.Drawing.Size(1163, 641)
        Me.data_grid_movies.TabIndex = 0
        Me.data_grid_movies.VirtualMode = True
        '
        'movie_list_close_btn
        '
        Me.movie_list_close_btn.Location = New System.Drawing.Point(12, 45)
        Me.movie_list_close_btn.Name = "movie_list_close_btn"
        Me.movie_list_close_btn.Size = New System.Drawing.Size(75, 23)
        Me.movie_list_close_btn.TabIndex = 1
        Me.movie_list_close_btn.Text = "Close"
        Me.movie_list_close_btn.UseVisualStyleBackColor = True
        '
        'List_All_Movies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1200, 760)
        Me.ControlBox = False
        Me.Controls.Add(Me.movie_list_close_btn)
        Me.Controls.Add(Me.data_grid_movies)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "List_All_Movies"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "List of Movies"
        CType(Me.data_grid_movies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents data_grid_movies As DataGridView
    Friend WithEvents movie_list_close_btn As Button
End Class
