<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.contactList = New System.Windows.Forms.ListBox()
        Me.txtFistname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.optPosition = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddContact = New System.Windows.Forms.Button()
        Me.btnAllContacts = New System.Windows.Forms.Button()
        Me.btnClearContacts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'contactList
        '
        Me.contactList.FormattingEnabled = True
        Me.contactList.ItemHeight = 16
        Me.contactList.Location = New System.Drawing.Point(40, 12)
        Me.contactList.Name = "contactList"
        Me.contactList.Size = New System.Drawing.Size(566, 100)
        Me.contactList.TabIndex = 0
        '
        'txtFistname
        '
        Me.txtFistname.Location = New System.Drawing.Point(192, 132)
        Me.txtFistname.Name = "txtFistname"
        Me.txtFistname.Size = New System.Drawing.Size(414, 22)
        Me.txtFistname.TabIndex = 1
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(192, 175)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(414, 22)
        Me.txtLastname.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(192, 214)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(414, 22)
        Me.txtEmail.TabIndex = 3
        '
        'optPosition
        '
        Me.optPosition.FormattingEnabled = True
        Me.optPosition.Items.AddRange(New Object() {"Other", "CEO", "CFO", "CTO", "HR Manager", "Customer Service"})
        Me.optPosition.Location = New System.Drawing.Point(192, 257)
        Me.optPosition.Name = "optPosition"
        Me.optPosition.Size = New System.Drawing.Size(414, 24)
        Me.optPosition.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Position"
        '
        'btnAddContact
        '
        Me.btnAddContact.Location = New System.Drawing.Point(334, 307)
        Me.btnAddContact.Name = "btnAddContact"
        Me.btnAddContact.Size = New System.Drawing.Size(118, 38)
        Me.btnAddContact.TabIndex = 9
        Me.btnAddContact.Text = "Add contact"
        Me.btnAddContact.UseVisualStyleBackColor = True
        '
        'btnAllContacts
        '
        Me.btnAllContacts.Location = New System.Drawing.Point(632, 12)
        Me.btnAllContacts.Name = "btnAllContacts"
        Me.btnAllContacts.Size = New System.Drawing.Size(156, 37)
        Me.btnAllContacts.TabIndex = 10
        Me.btnAllContacts.Text = "All default contacts"
        Me.btnAllContacts.UseVisualStyleBackColor = True
        '
        'btnClearContacts
        '
        Me.btnClearContacts.Location = New System.Drawing.Point(632, 75)
        Me.btnClearContacts.Name = "btnClearContacts"
        Me.btnClearContacts.Size = New System.Drawing.Size(156, 37)
        Me.btnClearContacts.TabIndex = 11
        Me.btnClearContacts.Text = "Clear contacts"
        Me.btnClearContacts.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClearContacts)
        Me.Controls.Add(Me.btnAllContacts)
        Me.Controls.Add(Me.btnAddContact)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.optPosition)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFistname)
        Me.Controls.Add(Me.contactList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents contactList As ListBox
    Friend WithEvents txtFistname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents optPosition As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddContact As Button
    Friend WithEvents btnAllContacts As Button
    Friend WithEvents btnClearContacts As Button
End Class
