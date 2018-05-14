Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxBarcodeDecoder1.LinearFindBarcodes = 7
        AxBarcodeDecoder1.DecodeFile(TextBox1.Text)

        'show results
        Dim BarcodeList As BarcodeReaderLib.BarcodeList
        BarcodeList = AxBarcodeDecoder1.Barcodes

        Dim i As Integer
        For i = 0 To BarcodeList.length - 1
            Dim barcode As BarcodeReaderLib.Barcode
            barcode = BarcodeList.item(i)
            Dim sResult As String
            sResult = String.Format("[{0}] [{1}] [({2},{3}),({4},{5}),({6},{7}),({8},{9})] [Page: {10}]", barcode.BarcodeType.ToString(), barcode.Text, barcode.x1, barcode.y1, barcode.x2, barcode.y2, barcode.x3, barcode.y3, barcode.x4, barcode.y4, barcode.PageNum)
            MessageBox.Show(sResult)
        Next i
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        AxBarcodeDecoder1.AboutBox()
    End Sub
End Class
