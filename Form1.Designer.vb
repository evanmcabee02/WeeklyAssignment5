<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComicConvention
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        Me.radSuperhero = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblRegistrationText = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblCostTickets = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WeeklyAssignment5.My.Resources.Resources.comic
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(807, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'grpType
        '
        Me.grpType.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.grpType.Controls.Add(Me.radConvention)
        Me.grpType.Controls.Add(Me.radAutographs)
        Me.grpType.Controls.Add(Me.radSuperhero)
        Me.grpType.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpType.ForeColor = System.Drawing.Color.Red
        Me.grpType.Location = New System.Drawing.Point(136, 315)
        Me.grpType.Margin = New System.Windows.Forms.Padding(4)
        Me.grpType.Name = "grpType"
        Me.grpType.Padding = New System.Windows.Forms.Padding(4)
        Me.grpType.Size = New System.Drawing.Size(493, 137)
        Me.grpType.TabIndex = 1
        Me.grpType.TabStop = False
        Me.grpType.Text = "Select Badge Type:"
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Location = New System.Drawing.Point(31, 94)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(144, 29)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.AutoSize = True
        Me.radAutographs.Location = New System.Drawing.Point(31, 60)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(278, 29)
        Me.radAutographs.TabIndex = 1
        Me.radAutographs.TabStop = True
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radSuperhero
        '
        Me.radSuperhero.AutoSize = True
        Me.radSuperhero.Location = New System.Drawing.Point(31, 27)
        Me.radSuperhero.Name = "radSuperhero"
        Me.radSuperhero.Size = New System.Drawing.Size(376, 29)
        Me.radSuperhero.TabIndex = 0
        Me.radSuperhero.TabStop = True
        Me.radSuperhero.Text = "Convention + Superhero Experience"
        Me.radSuperhero.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(136, 515)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(204, 51)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblRegistrationText
        '
        Me.lblRegistrationText.AutoSize = True
        Me.lblRegistrationText.Font = New System.Drawing.Font("Comic Sans MS", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationText.ForeColor = System.Drawing.Color.Red
        Me.lblRegistrationText.Location = New System.Drawing.Point(99, 190)
        Me.lblRegistrationText.Name = "lblRegistrationText"
        Me.lblRegistrationText.Size = New System.Drawing.Size(599, 55)
        Me.lblRegistrationText.TabIndex = 3
        Me.lblRegistrationText.Text = "Comic Convention Registration"
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Location = New System.Drawing.Point(477, 267)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(65, 26)
        Me.txtGroupSize.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(210, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Group Size:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(425, 515)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(204, 51)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblCostTickets
        '
        Me.lblCostTickets.AutoSize = True
        Me.lblCostTickets.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostTickets.ForeColor = System.Drawing.Color.Red
        Me.lblCostTickets.Location = New System.Drawing.Point(522, 468)
        Me.lblCostTickets.Name = "lblCostTickets"
        Me.lblCostTickets.Size = New System.Drawing.Size(107, 32)
        Me.lblCostTickets.TabIndex = 7
        Me.lblCostTickets.Text = "$0000.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(161, 468)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Registration Cost:"
        '
        'frmComicConvention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 578)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCostTickets)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblRegistrationText)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmComicConvention"
        Me.Text = "Comic Convention Registration"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpType As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblRegistrationText As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblCostTickets As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutographs As RadioButton
    Friend WithEvents radSuperhero As RadioButton
End Class
