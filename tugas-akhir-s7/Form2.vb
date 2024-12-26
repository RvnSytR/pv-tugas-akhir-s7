Imports System.Data.SqlClient

Public Class Form2
    Dim connection As New SqlConnection("Server=RVNS\SQLEXPRESS;Database=db_latihan;Integrated Security=True;")
    Dim idHistory As Integer

    Private Sub LoadData()
        Try
            Dim query As String = "SELECT * FROM history"
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvHistory.DataSource = table
        Catch e As Exception
            MessageBox.Show("Error: " & e.Message)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDelete.Visible = False
        LoadData()
    End Sub

    Private Sub dgvHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellContentClick
        If e.RowIndex >= 0 Then
            idHistory = dgvHistory.Rows(e.RowIndex).Cells("id_history").Value.ToString()
            btnDelete.Visible = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim confirm As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus history ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Exit Sub

        connection.Open()
        Dim query As String = "DELETE FROM history WHERE id_history = @id"
        Dim cmd As New SqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@id", idHistory)

        cmd.ExecuteNonQuery()
        connection.Close()
        MessageBox.Show("History berhasil dihapus!")

        LoadData()
        btnDelete.Visible = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim form1 As New Form1()
        form1.Show()
        Me.Dispose()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


End Class