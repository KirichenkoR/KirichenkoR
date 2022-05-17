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
   
n = 1
m = 1
i = 4 'ñ÷åò÷èê ñòóäåíòîâ
a = 0 'ñ÷åò÷èê îöåíîê ïðåäìåòà
k = 0 'ñ÷åò÷èê ïðåäìåòîâ

While IsEmpty(Cells(1, i)) = False
          Cells(2 + m, 15).Value = Cells(1, i).Value
          m = m + 1
          i = i + 2
Wend


i = 0
For i = 4 To 12 Step 2

Next

i = 0
While IsEmpty(Cells(n + 1, 2)) = False
          i = i + 1
          n = n + 1
Wend

n = 0
  For n = 1 To i
    If IsEmpty(Cells(n + 2, 3)) = False Then
       a = a + 1
       n = n + 1
    End If
  Next


End Sub

  

