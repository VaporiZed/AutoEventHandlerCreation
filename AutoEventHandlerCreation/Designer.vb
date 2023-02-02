<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
		Me.BsFoo = New AutoEventHandlerCreation.FooBindingSource()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		CType(Me.BsFoo, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ListBox1
		'
		Me.ListBox1.ColumnWidth = 60
		Me.ListBox1.DataSource = Me.BsFoo
		Me.ListBox1.DisplayMember = "Name"
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.Location = New System.Drawing.Point(25, 12)
		Me.ListBox1.MultiColumn = True
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(289, 95)
		Me.ListBox1.TabIndex = 30
		Me.ListBox1.ValueMember = "ID"
		'
		'FrmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(326, 119)
		Me.Controls.Add(Me.ListBox1)
		Me.Enabled = False
		Me.Name = "FrmMain"
		Me.Text = "FrmMain"
		CType(Me.BsFoo, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
	Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
	Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
	Friend WithEvents AmountInEurosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents BsFoo As FooBindingSource
End Class
