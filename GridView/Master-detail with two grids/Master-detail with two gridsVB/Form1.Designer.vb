Imports Microsoft.VisualBasic
Imports System
Namespace Master_detail_with_two_grids
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
			Dim gridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewImageColumn2 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.categoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.nwindDataSet = New NwindDataSet()
			Me.radGridView2 = New Telerik.WinControls.UI.RadGridView()
            Me.categoriesTableAdapter = New NwindDataSetTableAdapters.CategoriesTableAdapter()
			Me.productsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.productsTableAdapter = New NwindDataSetTableAdapters.ProductsTableAdapter()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radGridView1
			' 
			Me.radGridView1.Location = New System.Drawing.Point(203, 12)
			' 
			' radGridView1
			' 
			gridViewDecimalColumn2.DataType = GetType(Integer)
			gridViewDecimalColumn2.FieldName = "CategoryID"
			gridViewDecimalColumn2.FormatString = ""
			gridViewDecimalColumn2.HeaderText = "CategoryID"
			gridViewDecimalColumn2.IsAutoGenerated = True
			gridViewDecimalColumn2.Name = "CategoryID"
			gridViewTextBoxColumn3.FieldName = "CategoryName"
			gridViewTextBoxColumn3.HeaderText = "CategoryName"
			gridViewTextBoxColumn3.IsAutoGenerated = True
			gridViewTextBoxColumn3.Name = "CategoryName"
			gridViewTextBoxColumn4.FieldName = "Description"
			gridViewTextBoxColumn4.HeaderText = "Description"
			gridViewTextBoxColumn4.IsAutoGenerated = True
			gridViewTextBoxColumn4.Name = "Description"
			gridViewImageColumn2.DataType = GetType(Byte() )
			gridViewImageColumn2.FieldName = "Picture"
			gridViewImageColumn2.HeaderText = "Picture"
			gridViewImageColumn2.IsAutoGenerated = True
			gridViewImageColumn2.Name = "Picture"
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { gridViewDecimalColumn2, gridViewTextBoxColumn3, gridViewTextBoxColumn4, gridViewImageColumn2})
			Me.radGridView1.MasterTemplate.DataSource = Me.categoriesBindingSource
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(470, 270)
			Me.radGridView1.TabIndex = 0
			Me.radGridView1.Text = "radGridView1"
			' 
			' categoriesBindingSource
			' 
			Me.categoriesBindingSource.DataMember = "Categories"
			Me.categoriesBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "NwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' radGridView2
			' 
			Me.radGridView2.Location = New System.Drawing.Point(12, 288)
			Me.radGridView2.Name = "radGridView2"
			Me.radGridView2.Size = New System.Drawing.Size(844, 318)
			Me.radGridView2.TabIndex = 1
			Me.radGridView2.Text = "radGridView2"
			' 
			' categoriesTableAdapter
			' 
			Me.categoriesTableAdapter.ClearBeforeFill = True
			' 
			' productsBindingSource
			' 
			Me.productsBindingSource.DataMember = "Products"
			Me.productsBindingSource.DataSource = Me.nwindDataSet
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(868, 609)
			Me.Controls.Add(Me.radGridView2)
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.categoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.productsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radGridView2 As Telerik.WinControls.UI.RadGridView
		Private nwindDataSet As NwindDataSet
		Private categoriesBindingSource As System.Windows.Forms.BindingSource
		Private categoriesTableAdapter As NwindDataSetTableAdapters.CategoriesTableAdapter
		Private productsBindingSource As System.Windows.Forms.BindingSource
		Private productsTableAdapter As NwindDataSetTableAdapters.ProductsTableAdapter
	End Class
End Namespace

