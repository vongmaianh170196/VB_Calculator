Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Structure Contact
        Public Firstname As String
        Public Lastname As String
        Public Email As String
        Public Position As String
        Public Overrides Function ToString() As String
            Return Firstname & " " & Lastname & " is our " & Position & ". Contact email: " & Email
        End Function
    End Structure

    Private contacts As New ArrayList

    Private Enum Position As Integer
        other = 0
        ceo = 1
        cfo = 2
        cto = 3
        hr = 4
        customerservice = 5
    End Enum

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private newCont As Contact
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddContact.Click

        If txtFistname.TextLength <> -1 And txtLastname.TextLength <> -1 Then

            newCont.Firstname = txtFistname.Text
            newCont.Lastname = txtLastname.Text
            newCont.Email = txtEmail.Text
            For Each pos As Integer In System.Enum.GetValues(GetType(Position))
                If pos = optPosition.SelectedIndex And optPosition.SelectedIndex <> 0 Then
                    newCont.Position = optPosition.SelectedItem.ToString()
                ElseIf optPosition.SelectedIndex = 0 Then
                    newCont.Position = "employee"
                End If
            Next
            contacts.Add(newCont)
            contactList.Items.Add(newCont.ToString())
        End If
    End Sub

    Private Sub optPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles optPosition.SelectedIndexChanged

    End Sub
    Private Sub AddContact(ByVal firstname As String, ByVal lastname As String, ByVal position As Integer, Optional ByVal email As String = "")
        Dim cont As Contact = New Contact
        cont.Firstname = firstname
        cont.Lastname = lastname
        cont.Email = email
        Select Case position
            Case 1
                cont.Position = "CEO"
            Case 2
                cont.Position = "CFO"
            Case 3
                cont.Position = "CTO"
            Case 4
                cont.Position = "HR Manager"
            Case 5
                cont.Position = "Customer service"
            Case Else
                cont.Position = "employee"
        End Select
        contacts.Add(cont)
        contactList.Items.Add(cont)
    End Sub
    Private Sub btnAllContacts_Click(sender As Object, e As EventArgs) Handles btnAllContacts.Click
        AddContact("Tero", "Suominen", 1, "tero.suominen@email.fi")
        AddContact("Ari", "Hapaniemi", 3, "ari.hapaniemi@email.fi")
        AddContact("Pauliina", "Salonen", 2, "pauliina.salonen@email.fi")
        AddContact("Mia", "Sepponen", 4, "hr@email.fi")
        AddContact("Lauri", "Koivisto", 5, "customer@email.fi")

    End Sub

    Private Sub btnClearContacts_Click(sender As Object, e As EventArgs) Handles btnClearContacts.Click
        contactList.Items.Clear()

    End Sub

    Private Sub DisplayContact(ByVal selectedCont As Contact)
        txtFistname.Text = selectedCont.Firstname
        txtLastname.Text = selectedCont.Lastname
        txtEmail.Text = selectedCont.Email
        For Each item In optPosition.Items
            If selectedCont.Position = item.ToString() Then
                optPosition.SelectedItem = item
            Else
                optPosition.SelectedIndex = 0
            End If
        Next
    End Sub

    Private Sub contactList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles contactList.SelectedIndexChanged
        DisplayContact(CType(contacts(contactList.SelectedIndex), Contact))
    End Sub
End Class
