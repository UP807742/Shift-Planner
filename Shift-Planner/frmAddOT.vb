﻿Public Class frmAddOT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddOvertime.Click

        sql = "INSERT INTO CREATEOVERTIME (overtimeType, overtimeDate, overtimeStartTime, overtimeEndTime, overtimePay) VALUES ("
        sql &= "'" & txtOType.Text & "',"
        sql &= "'" & dtODate.Value.Date & "',"
        sql &= "'" & cmbH1.SelectedIndex & ":" & CmbM1.SelectedIndex & "',"
        sql &= "'" & cmbH1.SelectedIndex & ":" & cmbM2.SelectedIndex & "',"
        sql &= "'" & txtOPay.Text & "')"

        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "tblAddOvertime")
        con.Close()

        MessageBox.Show("Overtime added succsessfully")

    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Me.Hide()
        AdminDashboard.Show()
    End Sub
End Class