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
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dgv_sample = New System.Windows.Forms.DataGridView()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        CType(Me.dgv_sample, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(57, 46)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(145, 55)
        Me.btn_add.TabIndex = 0
        Me.btn_add.Text = "Tambah Data"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'dgv_sample
        '
        Me.dgv_sample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_sample.Location = New System.Drawing.Point(24, 130)
        Me.dgv_sample.Name = "dgv_sample"
        Me.dgv_sample.RowHeadersWidth = 62
        Me.dgv_sample.RowTemplate.Height = 28
        Me.dgv_sample.Size = New System.Drawing.Size(843, 524)
        Me.dgv_sample.TabIndex = 1
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(241, 46)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(165, 55)
        Me.btn_hapus.TabIndex = 2
        Me.btn_hapus.Text = "Hapus Data"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(436, 46)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(165, 55)
        Me.btn_update.TabIndex = 3
        Me.btn_update.Text = "Update Data"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 681)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.dgv_sample)
        Me.Controls.Add(Me.btn_add)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgv_sample, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents dgv_sample As DataGridView
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_update As Button
End Class
