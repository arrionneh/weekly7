<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraoke
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.picBlack = New System.Windows.Forms.PictureBox()
        Me.picMic = New System.Windows.Forms.PictureBox()
        Me.cboSelection = New System.Windows.Forms.ComboBox()
        CType(Me.picBlack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Black
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(570, 73)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(437, 48)
        Me.lblHeading.TabIndex = 2
        Me.lblHeading.Text = "Karaoke Music Night"
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.White
        Me.btnCost.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(507, 475)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(187, 57)
        Me.btnCost.TabIndex = 3
        Me.btnCost.Text = "Total Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(913, 475)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(187, 57)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Black
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(603, 603)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(62, 34)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "text"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.BackColor = System.Drawing.Color.Black
        Me.lblDisplay.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.White
        Me.lblDisplay.Location = New System.Drawing.Point(603, 306)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(404, 34)
        Me.lblDisplay.TabIndex = 6
        Me.lblDisplay.Text = "Hourly Rental of Karaoke Room"
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(744, 377)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 36)
        Me.txtInput.TabIndex = 7
        '
        'picBlack
        '
        Me.picBlack.BackColor = System.Drawing.Color.Black
        Me.picBlack.Location = New System.Drawing.Point(417, -1)
        Me.picBlack.Name = "picBlack"
        Me.picBlack.Size = New System.Drawing.Size(726, 704)
        Me.picBlack.TabIndex = 1
        Me.picBlack.TabStop = False
        '
        'picMic
        '
        Me.picMic.Image = Global.weekly8.My.Resources.Resources.karaoke
        Me.picMic.Location = New System.Drawing.Point(-2, -1)
        Me.picMic.Name = "picMic"
        Me.picMic.Size = New System.Drawing.Size(1145, 704)
        Me.picMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMic.TabIndex = 0
        Me.picMic.TabStop = False
        '
        'cboSelection
        '
        Me.cboSelection.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelection.FormattingEnabled = True
        Me.cboSelection.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.cboSelection.Location = New System.Drawing.Point(470, 170)
        Me.cboSelection.Name = "cboSelection"
        Me.cboSelection.Size = New System.Drawing.Size(630, 42)
        Me.cboSelection.TabIndex = 8
        Me.cboSelection.Text = "Customize your Night"
        '
        'frmKaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1141, 701)
        Me.Controls.Add(Me.cboSelection)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picBlack)
        Me.Controls.Add(Me.picMic)
        Me.Name = "frmKaraoke"
        Me.Text = "Karaoke Music Night"
        CType(Me.picBlack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMic As PictureBox
    Friend WithEvents picBlack As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents cboSelection As ComboBox
End Class
