Public Partial Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        With Me
            .lbl_Msg.Visible = False

            If IsPostBack Then
                Dim NewSpecFileName As String = .FileUpload1.FileName
                .FileUpload1.SaveAs(IMI_Path & "\" & NewSpecFileName)

                If ParseSpecData(IMI_Path & "\" & NewSpecFileName) >= 0 Then
                    If IMIDataItem.sPlant.EndsWith("@@") Then
                        .FileUpload1.SaveAs(ALineIMI_Path & "\" & NewSpecFileName)
                    End If
                End If

                .lbl_Msg.Text = "The new spec. file has been successfully upload to the system as : " & NewSpecFileName
                .lbl_Msg.Visible = True
            End If
        End With

    End Sub

    Private Function ParseSpecData(ByVal SpecFile As String) As Integer

        Dim FuncRet As Integer = 0
        Dim FileDataItem As String = My.Computer.FileSystem.ReadAllText(SpecFile, System.Text.Encoding.ASCII)

        If FileDataItem = "" Then Return -1
        Dim DataItems() As String = FileDataItem.Split(vbCrLf)

        If DataItems.GetUpperBound(0) < 6 Then Return -1
        Dim Record() As String = {}

        With IMIDataItem
            Try
                Record = DataItems(0).Split(",")
                .sFreq = Record(2).Trim

                If IsNumeric(Val(.sFreq)) And Not Val(.sFreq) < 0 Then
                    Dim dFreq As Decimal = Val(.sFreq)
                    .sFreq = String.Format("{0:F6}", dFreq)
                Else
                    Return -1
                End If

                Record = DataItems(1).Split(",")
                .sPlant = Record(2).Trim

                Record = DataItems(2).Split(",")
                .sProdCode = Record(2).Trim

                Record = DataItems(3).Split(",")
                .sVersion = Record(2).Trim

                Record = DataItems(4).Split(",")
                .sWkCdFormat = Record(2).Trim

                Record = DataItems(5).Split(",")
                .sParameter = Record(2).Trim

                Record = DataItems(6).Split(",")
                .sFormat = Record(2).Trim

            Catch ex As Exception
                FuncRet = -1
            End Try
        End With

        Return FuncRet

    End Function


End Class