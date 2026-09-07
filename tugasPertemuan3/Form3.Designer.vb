<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim ListViewItem1 As ListViewItem = New ListViewItem("Mahasiswa")
        Dim ListViewItem2 As ListViewItem = New ListViewItem("Dosen" & vbLf)
        Dim ListViewItem3 As ListViewItem = New ListViewItem("Umum")
        Dim TreeNode1 As TreeNode = New TreeNode("Artificial Intelligence")
        Dim TreeNode2 As TreeNode = New TreeNode("Cyber Security")
        Dim TreeNode3 As TreeNode = New TreeNode("Web Development")
        Dim TreeNode4 As TreeNode = New TreeNode("Teknologi", New TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        DateTimePickerSeminar = New DateTimePicker()
        ComboBoxBidang = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ListViewPeserta = New ListView()
        TreeViewBidang = New TreeView()
        Label4 = New Label()
        RichTextBoxCatatan = New RichTextBox()
        Label5 = New Label()
        LinkLabelSeminar = New LinkLabel()
        ButtonSimpanSeminar = New Button()
        SuspendLayout()
        ' 
        ' DateTimePickerSeminar
        ' 
        DateTimePickerSeminar.Location = New Point(149, 30)
        DateTimePickerSeminar.Name = "DateTimePickerSeminar"
        DateTimePickerSeminar.Size = New Size(300, 31)
        DateTimePickerSeminar.TabIndex = 0
        ' 
        ' ComboBoxBidang
        ' 
        ComboBoxBidang.FormattingEnabled = True
        ComboBoxBidang.Items.AddRange(New Object() {"Artificial Intelligence", "Web Development", "Cyber Security", "Data Science"})
        ComboBoxBidang.Location = New Point(181, 96)
        ComboBoxBidang.Name = "ComboBoxBidang"
        ComboBoxBidang.Size = New Size(268, 33)
        ComboBoxBidang.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(41, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 25)
        Label1.TabIndex = 2
        Label1.Text = "Tanggal"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(41, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 25)
        Label2.TabIndex = 3
        Label2.Text = "Bidang seminar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 25)
        Label3.TabIndex = 4
        Label3.Text = "Peserta"
        ' 
        ' ListViewPeserta
        ' 
        ListViewPeserta.Items.AddRange(New ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        ListViewPeserta.Location = New Point(149, 165)
        ListViewPeserta.Name = "ListViewPeserta"
        ListViewPeserta.Size = New Size(300, 146)
        ListViewPeserta.TabIndex = 5
        ListViewPeserta.UseCompatibleStateImageBehavior = False
        ' 
        ' TreeViewBidang
        ' 
        TreeViewBidang.Location = New Point(561, 30)
        TreeViewBidang.Name = "TreeViewBidang"
        TreeNode1.Name = "Node1"
        TreeNode1.Text = "Artificial Intelligence"
        TreeNode2.Name = "Node2"
        TreeNode2.Text = "Cyber Security"
        TreeNode3.Name = "Node4"
        TreeNode3.Text = "Web Development"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "Teknologi"
        TreeViewBidang.Nodes.AddRange(New TreeNode() {TreeNode4})
        TreeViewBidang.Size = New Size(182, 146)
        TreeViewBidang.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(488, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 25)
        Label4.TabIndex = 7
        Label4.Text = "Bidang"
        ' 
        ' RichTextBoxCatatan
        ' 
        RichTextBoxCatatan.Location = New Point(561, 194)
        RichTextBoxCatatan.Name = "RichTextBoxCatatan"
        RichTextBoxCatatan.Size = New Size(182, 144)
        RichTextBoxCatatan.TabIndex = 8
        RichTextBoxCatatan.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(468, 197)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 25)
        Label5.TabIndex = 9
        Label5.Text = "Catatan"
        ' 
        ' LinkLabelSeminar
        ' 
        LinkLabelSeminar.AutoSize = True
        LinkLabelSeminar.Location = New Point(453, 367)
        LinkLabelSeminar.Name = "LinkLabelSeminar"
        LinkLabelSeminar.Size = New Size(156, 25)
        LinkLabelSeminar.TabIndex = 10
        LinkLabelSeminar.TabStop = True
        LinkLabelSeminar.Text = "Informasi Seminar"
        ' 
        ' ButtonSimpanSeminar
        ' 
        ButtonSimpanSeminar.Location = New Point(41, 338)
        ButtonSimpanSeminar.Name = "ButtonSimpanSeminar"
        ButtonSimpanSeminar.Size = New Size(327, 34)
        ButtonSimpanSeminar.TabIndex = 11
        ButtonSimpanSeminar.Text = "SIMPAN DAN LIHAT RINGKASAN"
        ButtonSimpanSeminar.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonSimpanSeminar)
        Controls.Add(LinkLabelSeminar)
        Controls.Add(Label5)
        Controls.Add(RichTextBoxCatatan)
        Controls.Add(Label4)
        Controls.Add(TreeViewBidang)
        Controls.Add(ListViewPeserta)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBoxBidang)
        Controls.Add(DateTimePickerSeminar)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Seminar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DateTimePickerSeminar As DateTimePicker
    Friend WithEvents ComboBoxBidang As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListViewPeserta As ListView
    Friend WithEvents TreeViewBidang As TreeView
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBoxCatatan As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabelSeminar As LinkLabel
    Friend WithEvents ButtonSimpanSeminar As Button
End Class
