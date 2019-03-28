Public Class Form1
    'Declare Array
    Dim setPeople(2, 9) As String

    'Create form event (data runs before the form hits the screen)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ''Use multidimentional array to store names, emails, and countries of 10 different people
        setPeople(0, 0) = "Joseph Grant"
        setPeople(1, 0) = "j.grant@gmail.com"
        setPeople(2, 0) = "Switzerland"

        setPeople(0, 1) = "Katie Gerad"
        setPeople(1, 1) = "katie@jeradsolutions.com"
        setPeople(2, 1) = "France"

        setPeople(0, 2) = "Reuben Drake"
        setPeople(1, 2) = "r.drake@gmail.com"
        setPeople(2, 2) = "Germany"

        setPeople(0, 3) = "Terry Wayne"
        setPeople(1, 3) = "terry@wayneenterprises.com"
        setPeople(2, 3) = "South Africa"

        setPeople(0, 4) = "Angela Kobin"
        setPeople(1, 4) = "kobin@kobincrafts.com"
        setPeople(2, 4) = "Indonesia"

        setPeople(0, 5) = "Tommy Baxton"
        setPeople(1, 5) = "t.baxton@baxmedia.co.uk"
        setPeople(2, 5) = "England"

        setPeople(0, 6) = "Diane Leonard"
        setPeople(1, 6) = "d.leonard@gmail.com"
        setPeople(2, 6) = "USA"

        setPeople(0, 7) = "Tim Folley"
        setPeople(1, 7) = "folley.t@yahoo.com"
        setPeople(2, 7) = "USA"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Declare variables 
        'Dim inputX As Integer = CType(Me.setSearch.Text, Integer)
        'Dim inputY As Integer = CType(txtY.Text, Integer)
        Dim iCount As Integer
        Dim setSearch As String = Me.setSearch.Text
        Dim bFound As Integer

        'Run "For Loop" to iterate the array 
        For iCount = 0 To 9
            If setPeople(0, iCount) = setSearch Then
                'Return boolean
                bFound = True
                Exit For
            End If
        Next
        ' Print searched array on a message box
        If bFound = True Then
            MsgBox(setPeople(0, iCount) & ", " _
                   & setPeople(1, iCount) & ", " _
                & setPeople(2, iCount))
        Else
            MsgBox(setSearch & " not found")
        End If




        'MsgBox(setPeople(inputX, inputY))

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

    End Sub

End Class
