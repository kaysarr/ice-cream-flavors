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
        Me.lstIceCream = New System.Windows.Forms.ListBox()
        Me.picBox = New System.Windows.Forms.PictureBox()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstIceCream
        '
        Me.lstIceCream.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIceCream.FormattingEnabled = True
        Me.lstIceCream.ItemHeight = 18
        Me.lstIceCream.Items.AddRange(New Object() {"Vanilla", "Chocolate", "Strawberry", "Mint Chocolate Chip", "Cookie Dough"})
        Me.lstIceCream.Location = New System.Drawing.Point(237, 39)
        Me.lstIceCream.Name = "lstIceCream"
        Me.lstIceCream.Size = New System.Drawing.Size(120, 112)
        Me.lstIceCream.TabIndex = 0
        '
        'picBox
        '
        Me.picBox.Location = New System.Drawing.Point(28, 39)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(117, 112)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox.TabIndex = 1
        Me.picBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 192)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.lstIceCream)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstIceCream As ListBox
    Friend WithEvents picBox As PictureBox
End Class
