<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pbEscuela = New System.Windows.Forms.PictureBox()
        Me.lblAcceder = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnIngresar = New System.Windows.Forms.Button()
        CType(Me.pbEscuela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.btnCerrar.Location = New System.Drawing.Point(349, 12)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(39, 31)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "x"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'pbEscuela
        '
        Me.pbEscuela.Image = Global.Sistema_Colegio.My.Resources.Resources.esc
        Me.pbEscuela.Location = New System.Drawing.Point(120, 47)
        Me.pbEscuela.Name = "pbEscuela"
        Me.pbEscuela.Size = New System.Drawing.Size(172, 122)
        Me.pbEscuela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEscuela.TabIndex = 1
        Me.pbEscuela.TabStop = False
        '
        'lblAcceder
        '
        Me.lblAcceder.AutoSize = True
        Me.lblAcceder.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.lblAcceder.Location = New System.Drawing.Point(123, 189)
        Me.lblAcceder.Name = "lblAcceder"
        Me.lblAcceder.Size = New System.Drawing.Size(169, 31)
        Me.lblAcceder.TabIndex = 2
        Me.lblAcceder.Text = "Iniciar Sesión "
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Calibri Light", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(1, Byte), True)
        Me.txtUsuario.Location = New System.Drawing.Point(92, 262)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(220, 22)
        Me.txtUsuario.TabIndex = 3
        Me.txtUsuario.Text = "Usuario"
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Location = New System.Drawing.Point(79, 286)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(245, 1)
        Me.Panel1.TabIndex = 4
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Calibri Light", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.txtContraseña.Location = New System.Drawing.Point(92, 315)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(220, 22)
        Me.txtContraseña.TabIndex = 5
        Me.txtContraseña.Text = "Contraseña"
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Location = New System.Drawing.Point(79, 336)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(245, 1)
        Me.Panel2.TabIndex = 6
        '
        'btnIngresar
        '
        Me.btnIngresar.AutoEllipsis = True
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Calibri Light", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(0, Byte), True)
        Me.btnIngresar.Location = New System.Drawing.Point(120, 372)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(172, 26)
        Me.btnIngresar.TabIndex = 7
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 500)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblAcceder)
        Me.Controls.Add(Me.pbEscuela)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Colegio"
        CType(Me.pbEscuela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents pbEscuela As PictureBox
    Friend WithEvents lblAcceder As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnIngresar As Button
End Class
