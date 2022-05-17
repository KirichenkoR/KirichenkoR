Sub AlexVong()
Application.ScreenUpdating = False
Application.DisplayAlerts = False
Dim ii As Integer
   Dim a As Integer
   Dim i As Integer
   Dim n As Integer
   Dim k As Integer
   Dim m As Integer
   Dim z As Integer
   Dim isp As Integer
   Dim Year As Integer
   Dim Month As Integer
   Dim dt As Variant
   Dim dpp As Variant
   Dim poisk As String
   
n = 1
i = 0 'ñ÷åò÷èê ñòóäåíòîâ
a = 0 'ñ÷åò÷èê îöåíîê ïðåäìåòà
k = 0 'ñ÷åò÷èê ïðåäìåòîâ

For i = 4 To 12 Step 2
    If IsEmpty(Cells(i, 1)) = False Then
       k = k + 1
    End If
Next

i = 0
While IsEmpty(Cells(«B» & n + 1)) = False
          i = i + 1
          n = n + 1
Wend

n = 0
  For n = 1 To i
    If IsEmpty(Cells(«D» & n + 2)) = False Then
       a = a + 1
       n = n + 1
    End If
  Next


End Sub

  