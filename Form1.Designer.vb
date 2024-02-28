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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        lblPrecio = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        cbo = New ComboBox()
        ComboBox1 = New ComboBox()
        ListView1 = New ListView()
        btnSalir = New Button()
        btnCancelar = New Button()
        btnRegistrar = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(451, 9)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(327, 22)
        Label1.TabIndex = 0
        Label1.Text = "CONTROL REGISTRO DE VENTAS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(897, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 22)
        Label2.TabIndex = 1
        Label2.Text = "PRECIO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(543, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 22)
        Label3.TabIndex = 2
        Label3.Text = "CANTIDAD"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblPrecio)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(cbo)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Location = New Point(100, 121)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1013, 228)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "AREA DE VENTAS"
        ' 
        ' lblPrecio
        ' 
        lblPrecio.Location = New Point(757, 66)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(194, 30)
        lblPrecio.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(757, 41)
        Label7.Name = "Label7"
        Label7.Size = New Size(191, 22)
        Label7.TabIndex = 8
        Label7.Text = "Precio de Producto:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(443, 41)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 22)
        Label6.TabIndex = 8
        Label6.Text = "Cantidad:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(239, 22)
        Label4.TabIndex = 8
        Label4.Text = "Seleccione Tipo de Pago:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(199, 22)
        Label5.TabIndex = 9
        Label5.Text = "Seleccione Producto:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(432, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(127, 30)
        TextBox1.TabIndex = 2
        ' 
        ' cbo
        ' 
        cbo.FormattingEnabled = True
        cbo.Location = New Point(6, 169)
        cbo.Name = "cbo"
        cbo.Size = New Size(239, 30)
        cbo.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(6, 66)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(239, 30)
        ComboBox1.TabIndex = 0
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(100, 422)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1013, 161)
        ListView1.TabIndex = 4
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = SystemColors.MenuHighlight
        btnSalir.Location = New Point(1020, 600)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(93, 48)
        btnSalir.TabIndex = 5
        btnSalir.Text = "SALIR"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = SystemColors.MenuHighlight
        btnCancelar.Location = New Point(795, 361)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(125, 44)
        btnCancelar.TabIndex = 6
        btnCancelar.Text = "CANCELAR"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.BackColor = SystemColors.MenuHighlight
        btnRegistrar.Location = New Point(270, 361)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(126, 44)
        btnRegistrar.TabIndex = 7
        btnRegistrar.Text = "REGISTRAR"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1371, 660)
        Controls.Add(btnRegistrar)
        Controls.Add(btnCancelar)
        Controls.Add(btnSalir)
        Controls.Add(ListView1)
        Controls.Add(GroupBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Maiandra GD", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5, 4, 5, 4)
        Name = "Form1"
        Text = "Registro Control De Ventas"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cbo As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPrecio As TextBox
    Friend WithEvents Label7 As Label

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
