<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        invoice = New ListView()
        nama_menu = New ColumnHeader()
        harga = New ColumnHeader()
        pax = New ColumnHeader()
        total = New ColumnHeader()
        Label1 = New Label()
        grandTotalLabel = New Label()
        Label3 = New Label()
        pembayaranLabel = New Label()
        Label4 = New Label()
        kembalianLabel = New Label()
        Label6 = New Label()
        doneButton = New Button()
        SuspendLayout()
        ' 
        ' invoice
        ' 
        invoice.Columns.AddRange(New ColumnHeader() {nama_menu, harga, pax, total})
        invoice.Location = New Point(11, 76)
        invoice.Name = "invoice"
        invoice.Size = New Size(617, 113)
        invoice.TabIndex = 4
        invoice.UseCompatibleStateImageBehavior = False
        invoice.View = View.Details
        ' 
        ' nama_menu
        ' 
        nama_menu.Text = "Nama Menu"
        nama_menu.Width = 210
        ' 
        ' harga
        ' 
        harga.Tag = ""
        harga.Text = "Harga"
        harga.TextAlign = HorizontalAlignment.Right
        harga.Width = 120
        ' 
        ' pax
        ' 
        pax.Text = "Jumlah"
        pax.TextAlign = HorizontalAlignment.Right
        pax.Width = 120
        ' 
        ' total
        ' 
        total.Text = "Total"
        total.TextAlign = HorizontalAlignment.Right
        total.Width = 160
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(11, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 32)
        Label1.TabIndex = 5
        Label1.Text = "Invoice"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        Label1.UseMnemonic = False
        ' 
        ' grandTotalLabel
        ' 
        grandTotalLabel.BackColor = Color.White
        grandTotalLabel.Location = New Point(528, 201)
        grandTotalLabel.Name = "grandTotalLabel"
        grandTotalLabel.Size = New Size(100, 15)
        grandTotalLabel.TabIndex = 27
        grandTotalLabel.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(449, 201)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 26
        Label3.Text = "Grand Total: "
        ' 
        ' pembayaranLabel
        ' 
        pembayaranLabel.BackColor = Color.White
        pembayaranLabel.Location = New Point(528, 226)
        pembayaranLabel.Name = "pembayaranLabel"
        pembayaranLabel.Size = New Size(100, 15)
        pembayaranLabel.TabIndex = 29
        pembayaranLabel.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(449, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 28
        Label4.Text = "Bayar: "
        ' 
        ' kembalianLabel
        ' 
        kembalianLabel.BackColor = Color.White
        kembalianLabel.Location = New Point(528, 251)
        kembalianLabel.Name = "kembalianLabel"
        kembalianLabel.Size = New Size(100, 15)
        kembalianLabel.TabIndex = 31
        kembalianLabel.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(449, 251)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 15)
        Label6.TabIndex = 30
        Label6.Text = "Kembalian: "
        ' 
        ' doneButton
        ' 
        doneButton.Location = New Point(538, 311)
        doneButton.Name = "doneButton"
        doneButton.Size = New Size(75, 23)
        doneButton.TabIndex = 32
        doneButton.Text = "Done"
        doneButton.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 354)
        Controls.Add(doneButton)
        Controls.Add(kembalianLabel)
        Controls.Add(Label6)
        Controls.Add(pembayaranLabel)
        Controls.Add(Label4)
        Controls.Add(grandTotalLabel)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(invoice)
        Name = "Form2"
        Text = "Invoice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents invoice As ListView
    Friend WithEvents nama_menu As ColumnHeader
    Friend WithEvents harga As ColumnHeader
    Friend WithEvents pax As ColumnHeader
    Friend WithEvents total As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents grandTotalLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pembayaranLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents kembalianLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents doneButton As Button
End Class
