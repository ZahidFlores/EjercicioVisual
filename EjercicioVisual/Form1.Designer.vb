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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtY2 = New System.Windows.Forms.TextBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.txtY1 = New System.Windows.Forms.TextBox()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(192, 252)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 22
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(145, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(304, 37)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Distancia entre 2 puntos"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(34, 252)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 20
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtY2
        '
        Me.txtY2.Location = New System.Drawing.Point(167, 200)
        Me.txtY2.Name = "txtY2"
        Me.txtY2.Size = New System.Drawing.Size(100, 23)
        Me.txtY2.TabIndex = 19
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(167, 162)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(100, 23)
        Me.txtX2.TabIndex = 18
        '
        'txtY1
        '
        Me.txtY1.Location = New System.Drawing.Point(167, 120)
        Me.txtY1.Name = "txtY1"
        Me.txtY1.Size = New System.Drawing.Size(100, 23)
        Me.txtY1.TabIndex = 17
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(167, 78)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(100, 23)
        Me.txtX1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(34, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Introduce Y2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(34, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Introduce X2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(34, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Introduce Y1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(34, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Introduce X1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.EjercicioVisual.My.Resources.Resources._1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(316, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(209, 145)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(586, 312)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtY2)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.txtY1)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtY2 As TextBox
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents txtY1 As TextBox
    Friend WithEvents txtX1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
