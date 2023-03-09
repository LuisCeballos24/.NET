<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCaudal = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRugosidad = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDiametro = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtViscocidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFriccion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.rdbParalelo = New System.Windows.Forms.RadioButton()
        Me.rdbSerie = New System.Windows.Forms.RadioButton()
        Me.rdbSimple = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.rbdMixta = New System.Windows.Forms.RadioButton()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(558, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TUBERIAS HIDRAULICAS DATOS PARA SIMPLE, SERIE, PARALELO Y MIXTA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Altura"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(260, 109)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 20)
        Me.txtAltura.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(187, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Caudal"
        '
        'txtCaudal
        '
        Me.txtCaudal.Location = New System.Drawing.Point(260, 192)
        Me.txtCaudal.Name = "txtCaudal"
        Me.txtCaudal.Size = New System.Drawing.Size(100, 20)
        Me.txtCaudal.TabIndex = 10
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(243, 437)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(117, 29)
        Me.btnCalcular.TabIndex = 15
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(366, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "[m]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(366, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "m3/s"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(187, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Rugosidad"
        '
        'txtRugosidad
        '
        Me.txtRugosidad.Location = New System.Drawing.Point(260, 228)
        Me.txtRugosidad.Name = "txtRugosidad"
        Me.txtRugosidad.Size = New System.Drawing.Size(100, 20)
        Me.txtRugosidad.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(366, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "[m]"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(187, 270)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Diametro"
        '
        'txtDiametro
        '
        Me.txtDiametro.Location = New System.Drawing.Point(260, 270)
        Me.txtDiametro.Name = "txtDiametro"
        Me.txtDiametro.Size = New System.Drawing.Size(100, 20)
        Me.txtDiametro.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(366, 273)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "[m]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Viscocidad"
        '
        'txtViscocidad
        '
        Me.txtViscocidad.Location = New System.Drawing.Point(260, 319)
        Me.txtViscocidad.Name = "txtViscocidad"
        Me.txtViscocidad.Size = New System.Drawing.Size(100, 20)
        Me.txtViscocidad.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(366, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "[m]"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(193, 369)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Densidad"
        '
        'txtFriccion
        '
        Me.txtFriccion.Location = New System.Drawing.Point(260, 366)
        Me.txtFriccion.Name = "txtFriccion"
        Me.txtFriccion.Size = New System.Drawing.Size(100, 20)
        Me.txtFriccion.TabIndex = 32
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(366, 373)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "[m]"
        '
        'txtLongitud
        '
        Me.txtLongitud.Location = New System.Drawing.Point(260, 150)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(100, 20)
        Me.txtLongitud.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(187, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Longitud"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(366, 157)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "[m]"
        '
        'rdbParalelo
        '
        Me.rdbParalelo.AutoSize = True
        Me.rdbParalelo.Location = New System.Drawing.Point(456, 481)
        Me.rdbParalelo.Name = "rdbParalelo"
        Me.rdbParalelo.Size = New System.Drawing.Size(117, 17)
        Me.rdbParalelo.TabIndex = 41
        Me.rdbParalelo.TabStop = True
        Me.rdbParalelo.Text = "Tuberia en Paralelo"
        Me.rdbParalelo.UseVisualStyleBackColor = True
        '
        'rdbSerie
        '
        Me.rdbSerie.AutoSize = True
        Me.rdbSerie.Location = New System.Drawing.Point(456, 447)
        Me.rdbSerie.Name = "rdbSerie"
        Me.rdbSerie.Size = New System.Drawing.Size(104, 17)
        Me.rdbSerie.TabIndex = 40
        Me.rdbSerie.TabStop = True
        Me.rdbSerie.Text = "Tuberia En Serie"
        Me.rdbSerie.UseVisualStyleBackColor = True
        '
        'rdbSimple
        '
        Me.rdbSimple.AutoSize = True
        Me.rdbSimple.Location = New System.Drawing.Point(456, 413)
        Me.rdbSimple.Name = "rdbSimple"
        Me.rdbSimple.Size = New System.Drawing.Size(95, 17)
        Me.rdbSimple.TabIndex = 39
        Me.rdbSimple.TabStop = True
        Me.rdbSimple.Text = "Tuberia Simple"
        Me.rdbSimple.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(481, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Resultado"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(423, 377)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(183, 20)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Elija el tipo de tuberia"
        '
        'Chart1
        '
        ChartArea2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top
        ChartArea2.Name = "Paralelo"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(436, 132)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "Paralelo"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Legend = "Legend1"
        Series3.Name = "Paralelo"
        Series4.ChartArea = "Paralelo"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Legend = "Legend1"
        Series4.Name = "Serie"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(444, 226)
        Me.Chart1.TabIndex = 45
        Me.Chart1.Text = "Chart1"
        '
        'rbdMixta
        '
        Me.rbdMixta.AutoSize = True
        Me.rbdMixta.Location = New System.Drawing.Point(456, 511)
        Me.rbdMixta.Name = "rbdMixta"
        Me.rbdMixta.Size = New System.Drawing.Size(89, 17)
        Me.rbdMixta.TabIndex = 46
        Me.rbdMixta.TabStop = True
        Me.rbdMixta.Text = "Tuberia Mixta"
        Me.rbdMixta.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 540)
        Me.Controls.Add(Me.rbdMixta)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdbParalelo)
        Me.Controls.Add(Me.rdbSerie)
        Me.Controls.Add(Me.rdbSimple)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtLongitud)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtFriccion)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtViscocidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDiametro)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRugosidad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtCaudal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Tuberias Hidraulicas"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCaudal As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRugosidad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDiametro As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtViscocidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFriccion As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtLongitud As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents rdbParalelo As RadioButton
    Friend WithEvents rdbSerie As RadioButton
    Friend WithEvents rdbSimple As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents rbdMixta As RadioButton
End Class
