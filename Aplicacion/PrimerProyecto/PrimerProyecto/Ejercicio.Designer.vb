<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblN1 = New System.Windows.Forms.Label()
        Me.lblN2 = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMultiplicacion = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblN1
        '
        Me.lblN1.AutoSize = True
        Me.lblN1.Location = New System.Drawing.Point(141, 88)
        Me.lblN1.Name = "lblN1"
        Me.lblN1.Size = New System.Drawing.Size(56, 13)
        Me.lblN1.TabIndex = 0
        Me.lblN1.Text = "Numero 1:"
        '
        'lblN2
        '
        Me.lblN2.AutoSize = True
        Me.lblN2.Location = New System.Drawing.Point(141, 148)
        Me.lblN2.Name = "lblN2"
        Me.lblN2.Size = New System.Drawing.Size(56, 13)
        Me.lblN2.TabIndex = 1
        Me.lblN2.Text = "Numero 2:"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(218, 81)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 2
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(218, 141)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 3
        '
        'btnSuma
        '
        Me.btnSuma.Font = New System.Drawing.Font("Cambria", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(407, 59)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(61, 60)
        Me.btnSuma.TabIndex = 4
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(141, 215)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(55, 13)
        Me.lblResultado.TabIndex = 5
        Me.lblResultado.Text = "Resultado"
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(218, 208)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblMensaje)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.btnDivision)
        Me.Panel1.Controls.Add(Me.btnMultiplicacion)
        Me.Panel1.Controls.Add(Me.btnResta)
        Me.Panel1.Controls.Add(Me.txtResultado)
        Me.Panel1.Controls.Add(Me.lblResultado)
        Me.Panel1.Controls.Add(Me.btnSuma)
        Me.Panel1.Controls.Add(Me.txtNum2)
        Me.Panel1.Controls.Add(Me.txtNum1)
        Me.Panel1.Controls.Add(Me.lblN2)
        Me.Panel1.Controls.Add(Me.lblN1)
        Me.Panel1.Location = New System.Drawing.Point(137, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 300)
        Me.Panel1.TabIndex = 0
        '
        'btnResta
        '
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(407, 125)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(61, 50)
        Me.btnResta.TabIndex = 7
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplicacion.Location = New System.Drawing.Point(407, 181)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(61, 47)
        Me.btnMultiplicacion.TabIndex = 8
        Me.btnMultiplicacion.Text = "x"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(407, 246)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(61, 51)
        Me.btnDivision.TabIndex = 9
        Me.btnDivision.Text = "%"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(14, 10)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(37, 13)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(213, 30)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(97, 28)
        Me.lblMensaje.TabIndex = 10
        Me.lblMensaje.Text = "Mensaje"
        '
        'Ejercicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Ejercicio"
        Me.Text = "Ejercicio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblN1 As Label
    Friend WithEvents lblN2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnSuma As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnResta As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnMultiplicacion As Button
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblMensaje As Label
End Class
