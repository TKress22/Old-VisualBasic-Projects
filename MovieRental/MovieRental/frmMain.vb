Public Class frmMain
    Dim expand As Boolean = False
    Private Sub cmbGen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGen.SelectedIndexChanged
        'Handles loading the movie lists
        lstMovSel.Items.Clear()
        Dim x As Integer
        x = cmbGen.SelectedIndex
        If x = 7 Then
            rdb2Day.Enabled = True
            rdb5Day.Enabled = False
            rdb7Day.Enabled = False
        Else
            rdb2Day.Enabled = False
            rdb5Day.Enabled = True
            rdb7Day.Enabled = True
        End If
        Select Case x
            Case 0
                LoadThingies(Action)
                selectedGenre = "Action"
            Case 1
                LoadThingies(Classic)
                selectedGenre = "Classic"
            Case 2
                LoadThingies(Comedy)
                selectedGenre = "Comedy"
            Case 3
                LoadThingies(Romance)
                selectedGenre = "Romance"
            Case 4
                LoadThingies(Horror)
                selectedGenre = "Horror"
            Case 5
                LoadThingies(Musical)
                selectedGenre = "Musical"
            Case 6
                LoadThingies(Suspense)
                selectedGenre = "Suspsense"
            Case 7
                LoadThingies(NeuReleases)
                selectedGenre = "New Releases"
        End Select
    End Sub
    Sub LoadThingies(mov() As String)
        'Loads the movie titles to the listbox
        For i = 0 To mov.Length - 1
            lstMovSel.Items.Add(mov(i))
        Next
    End Sub
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnCart.Click, btnCheckout.Click, btnClear.Click, btnAdd.Click, btnRem.Click
        'Handles ALL button presses in the main form
        If sender.Equals(btnCart) Then
            'Expands or hides the cart
            If expand Then
                Me.Size = New Size(500, 250)
                expand = False
                btnCart.Text = "Show Cart"
            Else
                Me.Size = New Size(500, 430)
                expand = True
                btnCart.Text = "Hide Cart"
            End If
        ElseIf sender.Equals(btnCheckout) Then
            'Opens checkout window
            Me.Hide()
            frmCheckout.Show()
        ElseIf sender.Equals(btnAdd) Then
            'Checks if movie has been selected, and if cart is not full, then add the movie
            If lstMovSel.SelectedIndex <> -1 Then
                If currentIndex < 5 Then
                    cartList(currentIndex).Title = lstMovSel.Text
                    cartList(currentIndex).Genre = selectedGenre
                    LoadCart()
                    Console.WriteLine("SI IN CLICK: " & currentIndex)
                    GetCostAndLength()
                    GetDueDate()
                    currentIndex += 1
                Else
                    btnAdd.Enabled = False
                    MsgBox("Your cart is full!")
                End If
            Else
                MsgBox("Please select a movie, genre and rental period first!")
            End If
        ElseIf sender.Equals(btnRem) Then
            'Removes a selected movie from the cart
            If lstCart.SelectedIndex <> -1 Then
                Dim ind As Integer = lstCart.SelectedIndex
                Wipe(ind)
                currentIndex -= 1
                LoadCart()
                btnAdd.Enabled = True
            Else
                MsgBox("Please select a movie to remove!")
            End If
        ElseIf sender.Equals(btnClear) Then
            'Removes all movies from the cart
            For i = 0 To currentIndex
                Wipe(i)
            Next
            currentIndex = 0
            lstCart.Items.Clear()
            btnAdd.Enabled = True
        End If
    End Sub
    Sub LoadCart()
        'Loads the items into the cart listbox
        lstCart.Items.Clear()
        For t = 0 To currentIndex
            shift()
            lstCart.Items.Add(cartList(t).Title)
        Next
    End Sub
    Sub shift()
        'Shifts all items down to fill gaps in cart list
        For t = 0 To currentIndex
            If t <> 4 Then
                If cartList(t).Title = "" And cartList(t + 1).Title <> "" Then
                    cartList(t).Title = cartList(t + 1).Title
                    cartList(t + 1).Title = ""
                End If
            End If
        Next
    End Sub
    Sub Wipe(ind As Integer)
        'Clears a specific cart item
        cartList(ind).Title = ""
        cartList(ind).Genre = ""
        cartList(ind).DueDate = Nothing
        cartList(ind).Price = Nothing
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For r = 0 To cartList.Length - 1
            cartList(r).Title = "BLANK"
        Next
    End Sub
End Class
Module StuffandStuff
    Public Action() As String = {"Inception", "Pirates of the Caribbean", "Slow and Content 7"}
    Public Classic() As String = {"The Good, The Bad, and The Ugly", "Wizard of Oz", "That One Old Movie"}
    Public Comedy() As String = {"Click", "Pixels", "Horrible Bosses"}
    Public Romance() As String = {"Romeo and Juliet", "The Notebook", "Titanic"}
    Public Horror() As String = {"Twilight", "Teletubbies", "Rubber"}
    Public Musical() As String = {"The Sound of Music", "Mary Poppins", "Cats"}
    Public Suspense() As String = {"Jaws", "The Silence of the Lambs", "Shutter Island"}
    Public NeuReleases() As String = {"Star Wars: The Force Awakens", "Mockingjay Part 2", "Rogue Nation"}
    Public Structure Movie
        Dim Title As String
        Dim Price As Decimal
        Dim Genre As String
        Dim DueDate As Date
        Dim rentLength As Integer
    End Structure
    Public cartList(4) As Movie
    Public currentIndex As Integer = 0
    Public selectedGenre As String
    Public Total As Decimal
    Public Sub GetCostAndLength()
        'Console.WriteLine("SI: " & currentIndex)
        If frmMain.rdb2Day.Checked Then
            cartList(currentIndex).rentLength = 2
            cartList(currentIndex).Price = 3.5
        ElseIf frmMain.rdb5Day.Checked Then
            cartList(currentIndex).rentLength = 5
            cartList(currentIndex).Price = 2.5
        ElseIf frmMain.rdb7Day.Checked Then
            cartList(currentIndex).rentLength = 7
            cartList(currentIndex).Price = 3.0
        End If
        Console.WriteLine(cartList(currentIndex).Price)
    End Sub
    Public Sub GetDueDate()
        cartList(currentIndex).DueDate = DateAdd(DateInterval.Day, cartList(currentIndex).rentLength, Date.Now)
        Console.WriteLine("DUE DATE: " & cartList(currentIndex).DueDate.ToString())
    End Sub
    Public Sub FindTotal()
        For x = 0 To cartList.Length - 1
            Total += cartList(x).Price
        Next
    End Sub
    Public Function CalcTax() As Decimal

        Dim tax As Decimal
        tax = Total * 0.06
        Return tax
    End Function
End Module