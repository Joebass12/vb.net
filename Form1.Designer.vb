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
        Me.components = New System.ComponentModel.Container()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSubtract = New System.Windows.Forms.Button()
        Me.BtnMultiply = New System.Windows.Forms.Button()
        Me.BtnDivide = New System.Windows.Forms.Button()
        Me.BtnModulus = New System.Windows.Forms.Button()
        Me.BtnPI = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnOff = New System.Windows.Forms.Button()
        Me.tlTipPI = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'BtnAdd
        '
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(12, 137)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 0
        Me.BtnAdd.Text = "add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSubtract
        '
        Me.BtnSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubtract.Location = New System.Drawing.Point(110, 137)
        Me.BtnSubtract.Name = "BtnSubtract"
        Me.BtnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubtract.TabIndex = 1
        Me.BtnSubtract.Text = "subtract"
        Me.BtnSubtract.UseVisualStyleBackColor = True
        '
        'BtnMultiply
        '
        Me.BtnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMultiply.Location = New System.Drawing.Point(191, 137)
        Me.BtnMultiply.Name = "BtnMultiply"
        Me.BtnMultiply.Size = New System.Drawing.Size(75, 23)
        Me.BtnMultiply.TabIndex = 2
        Me.BtnMultiply.Text = "multiply"
        Me.BtnMultiply.UseVisualStyleBackColor = True
        '
        'BtnDivide
        '
        Me.BtnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDivide.Location = New System.Drawing.Point(12, 166)
        Me.BtnDivide.Name = "BtnDivide"
        Me.BtnDivide.Size = New System.Drawing.Size(75, 23)
        Me.BtnDivide.TabIndex = 3
        Me.BtnDivide.Text = "divide"
        Me.BtnDivide.UseVisualStyleBackColor = True
        '
        'BtnModulus
        '
        Me.BtnModulus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModulus.Location = New System.Drawing.Point(110, 166)
        Me.BtnModulus.Name = "BtnModulus"
        Me.BtnModulus.Size = New System.Drawing.Size(75, 23)
        Me.BtnModulus.TabIndex = 4
        Me.BtnModulus.Text = "modulus"
        Me.BtnModulus.UseVisualStyleBackColor = True
        '
        'BtnPI
        '
        Me.BtnPI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPI.Location = New System.Drawing.Point(191, 166)
        Me.BtnPI.Name = "BtnPI"
        Me.BtnPI.Size = New System.Drawing.Size(75, 23)
        Me.BtnPI.TabIndex = 5
        Me.BtnPI.Text = "PI"
        Me.BtnPI.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 13)
        Me.label1.TabIndex = 6
        Me.label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Answer"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(12, 25)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(254, 20)
        Me.txtNum1.TabIndex = 9
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(12, 64)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(254, 20)
        Me.txtNum2.TabIndex = 10
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(12, 111)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(254, 20)
        Me.txtAnswer.TabIndex = 11
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(110, 195)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 12
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnOff
        '
        Me.BtnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOff.Location = New System.Drawing.Point(191, 195)
        Me.BtnOff.Name = "BtnOff"
        Me.BtnOff.Size = New System.Drawing.Size(75, 23)
        Me.BtnOff.TabIndex = 13
        Me.BtnOff.Text = "Off"
        Me.BtnOff.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 253)
        Me.Controls.Add(Me.BtnOff)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.BtnPI)
        Me.Controls.Add(Me.BtnModulus)
        Me.Controls.Add(Me.BtnDivide)
        Me.Controls.Add(Me.BtnMultiply)
        Me.Controls.Add(Me.BtnSubtract)
        Me.Controls.Add(Me.BtnAdd)
        Me.Name = "Form1"
        Me.Text = "CALCULATOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnSubtract As System.Windows.Forms.Button
    Friend WithEvents BtnMultiply As System.Windows.Forms.Button
    Friend WithEvents BtnDivide As System.Windows.Forms.Button
    Friend WithEvents BtnModulus As System.Windows.Forms.Button
    Friend WithEvents BtnPI As System.Windows.Forms.Button
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnOff As System.Windows.Forms.Button
    Friend WithEvents tlTipPI As System.Windows.Forms.ToolTip

End Class
