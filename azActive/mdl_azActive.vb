﻿Module mdl_azActive

    Public Const sqlServer As String = "20.10.30.2\SQLEXPRESS"
    Public Const sqlName As String = "Marking"
    Public Const sqluid As String = "VB-SQL"
    Public Const sqlpwd As String = "Anyn0m0us"

    Public Const IMI_Path As String = "D:\MachineNet\MacDB\Marking\PX\IMI"
    Public Const ALineIMI_Path As String = "C:\Data\ALineIMI"


    Public Structure Rec
        Public Lot_No As String
        Public IMI_No As String
        Public FreqVal As String
        Public Opt As String
        Public RecDate As String
        Public Profile As String
        Public CtrlNo As String
        Public MacNo As String
        Public MData1 As String
        Public MData2 As String
        Public MData3 As String
        Public MData4 As String
        Public MData5 As String
        Public MData6 As String
    End Structure

    Public Structure SpecItem
        Public sFreq As String
        Public sPlant As String
        Public sProdCode As String
        Public sVersion As String
        Public sWkCdFormat As String
        Public sParameter As String
        Public sFormat As String
    End Structure

    Public IMIDataItem As SpecItem


End Module
