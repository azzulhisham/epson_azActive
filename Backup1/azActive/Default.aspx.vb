Imports System.Data.SqlClient


Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        With Me
            FieldDisp(False)

            If IsPostBack Then
                Dim Records As Rec = Nothing
                Dim SearchLotNo As String = .TextBox1.Text.ToUpper
                Dim RecCnt As Integer = GetRecordsFromServer(SearchLotNo, Records)


                '.TextBox1.Text = ""

                If RecCnt > 0 Then
                    If Not Records.Lot_No = "-" Then
                        .lbl_LotNo_.Text = ": " & Records.Lot_No
                        .lbl_LotNo_.Visible = True
                        .lbl_LotNo.Visible = True
                    End If

                    If Not Records.IMI_No = "-" Then
                        .lbl_IMINo_.Text = ": " & Records.IMI_No
                        .lbl_IMINo_.Visible = True
                        .lbl_IMINo.Visible = True
                    End If

                    If Not Records.FreqVal = "-" Then
                        .lbl_FreqVal_.Text = ": " & String.Format("{0:F6} MHz", CType(Records.FreqVal, Decimal))
                        .lbl_FreqVal_.Visible = True
                        .lbl_FreqVal.Visible = True
                    End If

                    If Not Records.Opt = "-" Then
                        .lbl_Opt_.Text = ": " & Records.Opt
                        .lbl_Opt_.Visible = True
                        .lbl_Opt.Visible = True
                    End If

                    If Not Records.RecDate = "-" Then
                        Dim MarkDate As Date = Records.RecDate
                        .lbl_DateVal_.Text = ": " & String.Format("{0:D2}-{1:D2}-{2:D4} ({3:D2}:{4:D2}:{5:D2})", MarkDate.Day, MarkDate.Month, MarkDate.Year, MarkDate.Hour, MarkDate.Minute, MarkDate.Second)
                        .lbl_DateVal_.Visible = True
                        .lbl_DateVal.Visible = True
                    End If

                    If Not Records.Profile = "-" Then
                        .lbl_Profile_.Text = ": " & Records.Profile
                        .lbl_Profile_.Visible = True
                        .lbl_Profile.Visible = True
                    End If

                    If Not Records.CtrlNo = "-" Then
                        .lbl_MacNo_.Text = ": " & Records.CtrlNo
                        .lbl_MacNo_.Visible = True
                        .lbl_MacNo.Visible = True
                    End If

                    If Not Records.MData1 = "-" Then
                        .lbl_MData1_.Text = ": " & Records.MData1
                        .lbl_MData1_.Visible = True
                        .lbl_MData1.Visible = True
                    End If

                    If Not Records.MData2 = "-" Then
                        .lbl_MData2_.Text = ": " & Records.MData2
                        .lbl_MData2_.Visible = True
                        .lbl_MData2.Visible = True
                    End If

                    If Not Records.MData3 = "-" Then
                        .lbl_MData3_.Text = ": " & Records.MData3
                        .lbl_MData3_.Visible = True
                        .lbl_MData3.Visible = True
                    End If

                    If Not Records.MData4 = "-" Then
                        .lbl_MData4_.Text = ": " & Records.MData4
                        .lbl_MData4_.Visible = True
                        .lbl_MData4.Visible = True
                    End If

                    If Not Records.MData5 = "-" Then
                        .lbl_MData5_.Text = ": " & Records.MData5
                        .lbl_MData5_.Visible = True
                        .lbl_MData5.Visible = True
                    End If

                    If Not Records.MData6 = "-" Then
                        .lbl_MData6_.Text = ": " & Records.MData6
                        .lbl_MData6_.Visible = True
                        .lbl_MData6.Visible = True
                    End If

                    .btn_DelRec.Visible = True
                Else
                    .lbl_LotNo_.Text = ": " & SearchLotNo & " was not found from the database... Sorry!!!"
                    .lbl_LotNo_.Visible = True
                    .lbl_LotNo.Visible = True
                    .btn_DelRec.Visible = False
                End If
            End If
        End With

    End Sub

    Private Sub FieldDisp(ByVal bVisible As Boolean)

        With Me
            .lbl_LotNo.Visible = bVisible
            .lbl_LotNo_.Visible = bVisible

            .lbl_IMINo.Visible = bVisible
            .lbl_IMINo_.Visible = bVisible

            .lbl_FreqVal.Visible = bVisible
            .lbl_FreqVal_.Visible = bVisible

            .lbl_Opt.Visible = bVisible
            .lbl_Opt_.Visible = bVisible

            .lbl_DateVal.Visible = bVisible
            .lbl_DateVal_.Visible = bVisible

            .lbl_Profile.Visible = bVisible
            .lbl_Profile_.Visible = bVisible

            .lbl_MacNo.Visible = bVisible
            .lbl_MacNo_.Visible = bVisible

            .lbl_MData1.Visible = bVisible
            .lbl_MData1_.Visible = bVisible

            .lbl_MData2.Visible = bVisible
            .lbl_MData2_.Visible = bVisible

            .lbl_MData3.Visible = bVisible
            .lbl_MData3_.Visible = bVisible

            .lbl_MData4.Visible = bVisible
            .lbl_MData4_.Visible = bVisible

            .lbl_MData5.Visible = bVisible
            .lbl_MData5_.Visible = bVisible

            .lbl_MData6.Visible = bVisible
            .lbl_MData6_.Visible = bVisible

            .btn_DelRec.Visible = bVisible
        End With

    End Sub

    Private Function GetRecordsFromServer(ByVal Lot_No As String, ByRef RecData As Rec) As Integer

        Dim RetVal As Integer = 0
        Dim sConnStr As String = _
            "SERVER=" & sqlServer & "; " & _
            "DataBase=" & sqlName & "; " & _
            "uid=" & sqluid & ";" & _
            "pwd=" & sqlpwd
        '"Integrated Security=SSPI"

        Dim dbConnection As New SqlConnection(sConnStr)
        Dim ch As Char = ChrW(39)
        Dim strSQL As String = _
            "SELECT * FROM Records WHERE Lot_No='" & Lot_No & "' " & _
            "ORDER BY Lot_No"

        Try
            dbConnection.Open()

            Dim cmd As New SqlCommand(strSQL, dbConnection)
            cmd.ExecuteNonQuery()

            Dim sqlReader As SqlDataReader = cmd.ExecuteReader()

            With sqlReader
                Dim iFieldCnt As Integer = .FieldCount
                Dim iRecNo As Integer = 0

                If .HasRows Then
                    Dim sRetData(iFieldCnt - 1) As String

                    Do While .Read()
                        With RecData
                            .Lot_No = sqlReader.GetString(0)
                            .IMI_No = sqlReader.GetString(1)
                            .FreqVal = sqlReader.GetString(2)
                            .Opt = sqlReader.GetString(3)
                            .RecDate = sqlReader.GetDateTime(4).ToString
                            .Profile = sqlReader.GetString(5)
                            .CtrlNo = sqlReader.GetString(6)
                            .MacNo = sqlReader.GetString(7)
                            .MData1 = sqlReader.GetString(8)
                            .MData2 = sqlReader.GetString(9)
                            .MData3 = sqlReader.GetString(10)
                            .MData4 = sqlReader.GetString(11)
                            .MData5 = sqlReader.GetString(12)
                            .MData6 = sqlReader.GetString(13)
                        End With

                        iRecNo += 1
                    Loop

                    RetVal = iRecNo
                Else
                    RetVal = 0
                End If
            End With
        Catch sqlExc As SqlException
            RetVal = 0
        End Try

        dbConnection.Close()
        Return RetVal

    End Function

    Private Function DelRecordsFromServer(ByVal Lot_No As String) As Integer

        Dim RetVal As Integer = 0
        Dim sConnStr As String = _
            "SERVER=" & sqlServer & "; " & _
            "DataBase=" & sqlName & "; " & _
            "uid=" & sqluid & ";" & _
            "pwd=" & sqlpwd
        '"Integrated Security=SSPI"

        Dim dbConnection As New SqlConnection(sConnStr)
        Dim ch As Char = ChrW(39)
        Dim strSQL As String = _
            "DELETE FROM Records WHERE Lot_No='" & Lot_No & "' "

        Try
            dbConnection.Open()

            Dim cmd As New SqlCommand(strSQL, dbConnection)
            'cmd.ExecuteNonQuery()

            Dim sqlReader As SqlDataReader = cmd.ExecuteReader()

            With sqlReader
                Dim iFieldCnt As Integer = .RecordsAffected
                RetVal = iFieldCnt
            End With
        Catch sqlExc As SqlException
            RetVal = 0
        End Try

        dbConnection.Close()
        Return RetVal

    End Function

    Private Sub Page_LoadComplete(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LoadComplete

        With Me
            .TextBox1.Focus()
        End With

    End Sub

    Private Sub btn_DelRec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_DelRec.Click

        Dim SearchLotNo As String = Me.TextBox1.Text.ToUpper
        Dim EffectedRecords As Integer = DelRecordsFromServer(SearchLotNo)

        If Not EffectedRecords = 0 Then
            Me.TextBox1.Text = ""
            FieldDisp(False)
        End If

    End Sub

End Class