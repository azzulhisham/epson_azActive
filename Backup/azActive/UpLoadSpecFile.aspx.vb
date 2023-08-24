Public Partial Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        With Me
            .lbl_Msg.Visible = False

            If IsPostBack Then
                Dim NewSpecFileName As String = .FileUpload1.FileName
                .FileUpload1.SaveAs(IMI_Path & "\" & NewSpecFileName)

                .lbl_Msg.Text = "The new spec. file has been successfully upload to the system as : " & NewSpecFileName
                .lbl_Msg.Visible = True
            End If
        End With

    End Sub

End Class