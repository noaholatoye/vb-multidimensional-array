<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.setSearch = New System.Windows.Forms.TextBox()
        Me.contactInput = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.printMsg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Index"
        '
        'setSearch
        '
        Me.setSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.setSearch.Location = New System.Drawing.Point(217, 156)
        Me.setSearch.MaxLength = 15
        Me.setSearch.Name = "setSearch"
        Me.setSearch.Size = New System.Drawing.Size(149, 26)
        Me.setSearch.TabIndex = 1
        '
        'contactInput
        '
        Me.contactInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.contactInput.Location = New System.Drawing.Point(411, 156)
        Me.contactInput.MaxLength = 10
        Me.contactInput.Name = "contactInput"
        Me.contactInput.Size = New System.Drawing.Size(100, 26)
        Me.contactInput.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(408, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Add Contact"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(217, 193)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(149, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(411, 193)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 23)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(261, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Look Up Address Based On Index"
        '
        'printMsg
        '
        Me.printMsg.AutoSize = True
        Me.printMsg.Location = New System.Drawing.Point(232, 228)
        Me.printMsg.Name = "printMsg"
        Me.printMsg.Size = New System.Drawing.Size(0, 13)
        Me.printMsg.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.printMsg)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.contactInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.setSearch)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents setSearch As TextBox
    Friend WithEvents contactInput As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents printMsg As Label
End Class
