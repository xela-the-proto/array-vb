<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_operArray
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
        Me.lst_array = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_carica = New System.Windows.Forms.Button()
        Me.btn_visualizza = New System.Windows.Forms.Button()
        Me.btn_esci = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst_array
        '
        Me.lst_array.FormattingEnabled = True
        Me.lst_array.ItemHeight = 15
        Me.lst_array.Location = New System.Drawing.Point(12, 43)
        Me.lst_array.Name = "lst_array"
        Me.lst_array.Size = New System.Drawing.Size(156, 94)
        Me.lst_array.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Elementi dell'array"
        '
        'btn_carica
        '
        Me.btn_carica.Location = New System.Drawing.Point(12, 143)
        Me.btn_carica.Name = "btn_carica"
        Me.btn_carica.Size = New System.Drawing.Size(75, 23)
        Me.btn_carica.TabIndex = 2
        Me.btn_carica.Text = "Carica"
        Me.btn_carica.UseVisualStyleBackColor = True
        '
        'btn_visualizza
        '
        Me.btn_visualizza.Location = New System.Drawing.Point(93, 143)
        Me.btn_visualizza.Name = "btn_visualizza"
        Me.btn_visualizza.Size = New System.Drawing.Size(75, 23)
        Me.btn_visualizza.TabIndex = 3
        Me.btn_visualizza.Text = "Visualizza"
        Me.btn_visualizza.UseVisualStyleBackColor = True
        '
        'btn_esci
        '
        Me.btn_esci.Location = New System.Drawing.Point(12, 415)
        Me.btn_esci.Name = "btn_esci"
        Me.btn_esci.Size = New System.Drawing.Size(75, 23)
        Me.btn_esci.TabIndex = 4
        Me.btn_esci.Text = "Esci"
        Me.btn_esci.UseVisualStyleBackColor = True
        '
        'frm_operArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_esci)
        Me.Controls.Add(Me.btn_visualizza)
        Me.Controls.Add(Me.btn_carica)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lst_array)
        Me.Name = "frm_operArray"
        Me.Text = "OPERAZIONI SU ARRAY"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_array As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_carica As Button
    Friend WithEvents btn_visualizza As Button
    Friend WithEvents btn_esci As Button
End Class
