<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FComprobante
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.GenerarComprobanteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datosventasDataSet = New SistemaVentas.datosventasDataSet()
        Me.GenerarComprobanteTableAdapter = New SistemaVentas.datosventasDataSetTableAdapters.GenerarComprobanteTableAdapter()
        Me.datosventasDataSet1 = New SistemaVentas.datosventasDataSet1()
        CType(Me.GenerarComprobanteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datosventasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datosventasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.GenerarComprobanteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVentas.RReporteVenta.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(635, 486)
        Me.ReportViewer1.TabIndex = 0
        '
        'GenerarComprobanteBindingSource
        '
        Me.GenerarComprobanteBindingSource.DataMember = "GenerarComprobante"
        Me.GenerarComprobanteBindingSource.DataSource = Me.datosventasDataSet
        '
        'datosventasDataSet
        '
        Me.datosventasDataSet.DataSetName = "datosventasDataSet"
        Me.datosventasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GenerarComprobanteTableAdapter
        '
        Me.GenerarComprobanteTableAdapter.ClearBeforeFill = True
        '
        'datosventasDataSet1
        '
        Me.datosventasDataSet1.DataSetName = "datosventasDataSet1"
        Me.datosventasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FComprobante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 486)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FComprobante"
        Me.Text = "FComprobante"
        CType(Me.GenerarComprobanteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datosventasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datosventasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents GenerarComprobanteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents datosventasDataSet As SistemaVentas.datosventasDataSet
    Friend WithEvents GenerarComprobanteTableAdapter As SistemaVentas.datosventasDataSetTableAdapters.GenerarComprobanteTableAdapter
    Friend WithEvents datosventasDataSet1 As SistemaVentas.datosventasDataSet1
End Class
