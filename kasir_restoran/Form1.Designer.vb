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
        Dim ListViewItem1 As ListViewItem = New ListViewItem(New String() {"Ayam Goreng", "10000"}, -1)
        Dim ListViewItem2 As ListViewItem = New ListViewItem(New String() {"Ayam Geprek", "15000"}, -1)
        Dim ListViewItem3 As ListViewItem = New ListViewItem(New String() {"Pecel Lele", "8000"}, -1)
        Dim ListViewItem4 As ListViewItem = New ListViewItem(New String() {"Nasi", "4000"}, -1)
        Dim ListViewItem5 As ListViewItem = New ListViewItem(New String() {"Teh Manis", "3000"}, -1)
        addButton = New Button()
        jumlah_input = New NumericUpDown()
        orderList = New ListView()
        nama = New ColumnHeader()
        harga = New ColumnHeader()
        pax = New ColumnHeader()
        total = New ColumnHeader()
        menuList = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        grandTotalLabel = New Label()
        Label5 = New Label()
        bayarButton = New Button()
        hapusButton = New Button()
        resetButton = New Button()
        pembayaranInput = New TextBox()
        Label6 = New Label()
        CType(jumlah_input, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' addButton
        ' 
        addButton.Location = New Point(482, 208)
        addButton.Name = "addButton"
        addButton.Size = New Size(147, 23)
        addButton.TabIndex = 1
        addButton.Text = "Tambah ke Order List"
        addButton.UseVisualStyleBackColor = True
        ' 
        ' jumlah_input
        ' 
        jumlah_input.Location = New Point(426, 208)
        jumlah_input.Name = "jumlah_input"
        jumlah_input.Size = New Size(50, 23)
        jumlah_input.TabIndex = 2
        ' 
        ' orderList
        ' 
        orderList.Columns.AddRange(New ColumnHeader() {nama, harga, pax, total})
        orderList.Location = New Point(12, 28)
        orderList.Name = "orderList"
        orderList.Size = New Size(617, 113)
        orderList.TabIndex = 3
        orderList.UseCompatibleStateImageBehavior = False
        orderList.View = View.Details
        ' 
        ' nama
        ' 
        nama.Text = "Nama Menu"
        nama.Width = 210
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
        ' menuList
        ' 
        menuList.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        menuList.Items.AddRange(New ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
        menuList.Location = New Point(12, 210)
        menuList.Name = "menuList"
        menuList.Size = New Size(351, 113)
        menuList.TabIndex = 21
        menuList.UseCompatibleStateImageBehavior = False
        menuList.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Nama Menu"
        ColumnHeader1.Width = 210
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Tag = ""
        ColumnHeader2.Text = "Harga"
        ColumnHeader2.TextAlign = HorizontalAlignment.Right
        ColumnHeader2.Width = 120
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(369, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 22
        Label2.Text = "Jumlah: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 15)
        Label1.TabIndex = 23
        Label1.Text = "Order List"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(450, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 24
        Label3.Text = "Grand Total: "
        ' 
        ' grandTotalLabel
        ' 
        grandTotalLabel.BackColor = Color.White
        grandTotalLabel.Location = New Point(529, 154)
        grandTotalLabel.Name = "grandTotalLabel"
        grandTotalLabel.Size = New Size(100, 15)
        grandTotalLabel.TabIndex = 25
        grandTotalLabel.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 187)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 26
        Label5.Text = "Daftar Menu"
        ' 
        ' bayarButton
        ' 
        bayarButton.Location = New Point(482, 298)
        bayarButton.Name = "bayarButton"
        bayarButton.Size = New Size(147, 23)
        bayarButton.TabIndex = 27
        bayarButton.Text = "Bayar"
        bayarButton.UseVisualStyleBackColor = True
        ' 
        ' hapusButton
        ' 
        hapusButton.Location = New Point(12, 147)
        hapusButton.Name = "hapusButton"
        hapusButton.Size = New Size(116, 23)
        hapusButton.TabIndex = 28
        hapusButton.Text = "Hapus Order Item "
        hapusButton.UseVisualStyleBackColor = True
        ' 
        ' resetButton
        ' 
        resetButton.Location = New Point(134, 147)
        resetButton.Name = "resetButton"
        resetButton.Size = New Size(87, 23)
        resetButton.TabIndex = 29
        resetButton.Text = "Reset Order"
        resetButton.UseVisualStyleBackColor = True
        ' 
        ' pembayaranInput
        ' 
        pembayaranInput.Location = New Point(482, 269)
        pembayaranInput.Name = "pembayaranInput"
        pembayaranInput.Size = New Size(147, 23)
        pembayaranInput.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(403, 272)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 15)
        Label6.TabIndex = 31
        Label6.Text = "Pembayaran: "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(641, 333)
        Controls.Add(Label6)
        Controls.Add(pembayaranInput)
        Controls.Add(resetButton)
        Controls.Add(hapusButton)
        Controls.Add(bayarButton)
        Controls.Add(Label5)
        Controls.Add(grandTotalLabel)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(menuList)
        Controls.Add(orderList)
        Controls.Add(jumlah_input)
        Controls.Add(addButton)
        Name = "Form1"
        Text = " Program Kasir Restoran"
        CType(jumlah_input, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents addButton As Button
    Friend WithEvents jumlah_input As NumericUpDown
    Friend WithEvents orderList As ListView
    Friend WithEvents nama As ColumnHeader
    Friend WithEvents harga As ColumnHeader
    Friend WithEvents pax As ColumnHeader
    Friend WithEvents total As ColumnHeader
    Friend WithEvents menuList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grandTotalLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bayarButton As Button
    Friend WithEvents hapusButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents pembayaranInput As TextBox
    Friend WithEvents Label6 As Label
End Class
