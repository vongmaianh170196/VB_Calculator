<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        Me.txtNumb1 = New System.Windows.Forms.TextBox()
        Me.txtNumb2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.lblNumb1 = New System.Windows.Forms.Label()
        Me.lblNumb2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumb1
        '
        Me.txtNumb1.Location = New System.Drawing.Point(13, 45)
        Me.txtNumb1.Name = "txtNumb1"
        Me.txtNumb1.Size = New System.Drawing.Size(386, 22)
        Me.txtNumb1.TabIndex = 0
        '
        'txtNumb2
        '
        Me.txtNumb2.Location = New System.Drawing.Point(13, 101)
        Me.txtNumb2.Name = "txtNumb2"
        Me.txtNumb2.Size = New System.Drawing.Size(386, 22)
        Me.txtNumb2.TabIndex = 1
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(13, 160)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(170, 22)
        Me.txtResult.TabIndex = 2
        '
        'lblNumb1
        '
        Me.lblNumb1.AutoSize = True
        Me.lblNumb1.Location = New System.Drawing.Point(13, 25)
        Me.lblNumb1.Name = "lblNumb1"
        Me.lblNumb1.Size = New System.Drawing.Size(87, 17)
        Me.lblNumb1.TabIndex = 3
        Me.lblNumb1.Text = "First number"
        '
        'lblNumb2
        '
        Me.lblNumb2.AutoSize = True
        Me.lblNumb2.Location = New System.Drawing.Point(13, 81)
        Me.lblNumb2.Name = "lblNumb2"
        Me.lblNumb2.Size = New System.Drawing.Size(108, 17)
        Me.lblNumb2.TabIndex = 4
        Me.lblNumb2.Text = "Second number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Result"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 212)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(96, 28)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(309, 212)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(96, 28)
        Me.btnMultiply.TabIndex = 7
        Me.btnMultiply.Text = "Multiply"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(160, 211)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(96, 28)
        Me.btnSubtract.TabIndex = 8
        Me.btnSubtract.Text = "Subtract"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(12, 261)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(96, 28)
        Me.btnDivide.TabIndex = 9
        Me.btnDivide.Text = "Divide"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(160, 261)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(96, 28)
        Me.btnMod.TabIndex = 10
        Me.btnMod.Text = "Modulus"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Location = New System.Drawing.Point(309, 261)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(96, 28)
        Me.btnSqrt.TabIndex = 11
        Me.btnSqrt.Text = "Sqrt"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(160, 320)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 28)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'CalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSqrt)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNumb2)
        Me.Controls.Add(Me.lblNumb1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNumb2)
        Me.Controls.Add(Me.txtNumb1)
        Me.Name = "CalculatorForm"
        Me.Text = "Simple calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumb1 As TextBox
    Friend WithEvents txtNumb2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents lblNumb1 As Label
    Friend WithEvents lblNumb2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnClear As Button
End Class
