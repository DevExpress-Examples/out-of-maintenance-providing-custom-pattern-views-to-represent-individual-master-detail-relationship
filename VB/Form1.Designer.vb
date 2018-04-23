Imports Microsoft.VisualBasic
Imports System
Namespace Grid_MasterDetail_GetRelationName
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
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
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Dim gridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSupplierID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colReorderLevel = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEAN13 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.suppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New Grid_MasterDetail_GetRelationName.nwindDataSet()
			Me.gridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductID1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSupplierID2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colSupplierID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colContactTitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colContactName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCompanyName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colPhone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colFax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colPostalCode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colHomePage = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCity = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colRegion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.suppliersTableAdapter = New Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.SuppliersTableAdapter()
			Me.categoryProductsTableAdapter1 = New Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.CategoryProductsTableAdapter()
			Me.productsTableAdapter1 = New Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.ProductsTableAdapter()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.suppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName, Me.colSupplierID1, Me.colCategoryID, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued, Me.colEAN13})
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' colProductID
			' 
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			' 
			' colProductName
			' 
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 0
			Me.colProductName.Width = 240
			' 
			' colSupplierID1
			' 
			Me.colSupplierID1.FieldName = "SupplierID"
			Me.colSupplierID1.Name = "colSupplierID1"
			' 
			' colCategoryID
			' 
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			' 
			' colQuantityPerUnit
			' 
			Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
			Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
			Me.colQuantityPerUnit.Visible = True
			Me.colQuantityPerUnit.VisibleIndex = 1
			Me.colQuantityPerUnit.Width = 118
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.DisplayFormat.FormatString = "c2"
			Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 2
			Me.colUnitPrice.Width = 118
			' 
			' colUnitsInStock
			' 
			Me.colUnitsInStock.FieldName = "UnitsInStock"
			Me.colUnitsInStock.Name = "colUnitsInStock"
			Me.colUnitsInStock.Width = 97
			' 
			' colUnitsOnOrder
			' 
			Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
			Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
			Me.colUnitsOnOrder.Visible = True
			Me.colUnitsOnOrder.VisibleIndex = 3
			Me.colUnitsOnOrder.Width = 133
			' 
			' colReorderLevel
			' 
			Me.colReorderLevel.FieldName = "ReorderLevel"
			Me.colReorderLevel.Name = "colReorderLevel"
			' 
			' colDiscontinued
			' 
			Me.colDiscontinued.FieldName = "Discontinued"
			Me.colDiscontinued.Name = "colDiscontinued"
			Me.colDiscontinued.Visible = True
			Me.colDiscontinued.VisibleIndex = 4
			Me.colDiscontinued.Width = 115
			' 
			' colEAN13
			' 
			Me.colEAN13.FieldName = "EAN13"
			Me.colEAN13.Name = "colEAN13"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.suppliersBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.gridView2
			gridLevelNode1.RelationName = "SuppliersProducts"
			gridLevelNode2.LevelTemplate = Me.gridView3
			gridLevelNode2.RelationName = "Suppliers_CategoryProducts"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1, gridLevelNode2})
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.advBandedGridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(586, 482)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView3, Me.advBandedGridView1, Me.gridView2})
			' 
			' suppliersBindingSource
			' 
			Me.suppliersBindingSource.DataMember = "Suppliers"
			Me.suppliersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView3
			' 
			Me.gridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID1, Me.colSupplierID2, Me.colProductName1, Me.colCategoryName, Me.colPicture, Me.colDescription})
			Me.gridView3.GridControl = Me.gridControl1
			Me.gridView3.Name = "gridView3"
			' 
			' colProductID1
			' 
			Me.colProductID1.FieldName = "ProductID"
			Me.colProductID1.Name = "colProductID1"
			Me.colProductID1.Visible = True
			Me.colProductID1.VisibleIndex = 0
			' 
			' colSupplierID2
			' 
			Me.colSupplierID2.FieldName = "SupplierID"
			Me.colSupplierID2.Name = "colSupplierID2"
			' 
			' colProductName1
			' 
			Me.colProductName1.FieldName = "ProductName"
			Me.colProductName1.Name = "colProductName1"
			Me.colProductName1.Visible = True
			Me.colProductName1.VisibleIndex = 1
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 2
			' 
			' colPicture
			' 
			Me.colPicture.FieldName = "Picture"
			Me.colPicture.Name = "colPicture"
			Me.colPicture.Visible = True
			Me.colPicture.VisibleIndex = 3
			' 
			' colDescription
			' 
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 4
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1, Me.gridBand2})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colSupplierID, Me.colCompanyName, Me.colContactName, Me.colContactTitle, Me.colAddress, Me.colCity, Me.colRegion, Me.colPostalCode, Me.colCountry, Me.colPhone, Me.colFax, Me.colHomePage})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsView.ColumnAutoWidth = True
			Me.advBandedGridView1.OptionsView.EnableAppearanceEvenRow = True
'			Me.advBandedGridView1.MasterRowGetRelationName += New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(Me.advBandedGridView1_MasterRowGetRelationName);
'			Me.advBandedGridView1.MasterRowGetRelationDisplayCaption += New DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(Me.advBandedGridView1_MasterRowGetRelationDisplayCaption);
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "Supplier"
			Me.gridBand1.Columns.Add(Me.colSupplierID)
			Me.gridBand1.Columns.Add(Me.colContactTitle)
			Me.gridBand1.Columns.Add(Me.colContactName)
			Me.gridBand1.Columns.Add(Me.colCompanyName)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 278
			' 
			' colSupplierID
			' 
			Me.colSupplierID.Caption = "ID"
			Me.colSupplierID.FieldName = "SupplierID"
			Me.colSupplierID.Name = "colSupplierID"
			Me.colSupplierID.Visible = True
			Me.colSupplierID.Width = 35
			' 
			' colContactTitle
			' 
			Me.colContactTitle.FieldName = "ContactTitle"
			Me.colContactTitle.Name = "colContactTitle"
			Me.colContactTitle.Visible = True
			Me.colContactTitle.Width = 121
			' 
			' colContactName
			' 
			Me.colContactName.FieldName = "ContactName"
			Me.colContactName.Name = "colContactName"
			Me.colContactName.Visible = True
			Me.colContactName.Width = 122
			' 
			' colCompanyName
			' 
			Me.colCompanyName.FieldName = "CompanyName"
			Me.colCompanyName.Name = "colCompanyName"
			Me.colCompanyName.RowIndex = 1
			Me.colCompanyName.Visible = True
			Me.colCompanyName.Width = 278
			' 
			' gridBand2
			' 
			Me.gridBand2.Caption = "Address"
			Me.gridBand2.Columns.Add(Me.colPhone)
			Me.gridBand2.Columns.Add(Me.colFax)
			Me.gridBand2.Columns.Add(Me.colCountry)
			Me.gridBand2.Columns.Add(Me.colPostalCode)
			Me.gridBand2.Columns.Add(Me.colHomePage)
			Me.gridBand2.Columns.Add(Me.colAddress)
			Me.gridBand2.Columns.Add(Me.colCity)
			Me.gridBand2.Columns.Add(Me.colRegion)
			Me.gridBand2.Name = "gridBand2"
			Me.gridBand2.Width = 290
			' 
			' colPhone
			' 
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.Visible = True
			Me.colPhone.Width = 93
			' 
			' colFax
			' 
			Me.colFax.FieldName = "Fax"
			Me.colFax.Name = "colFax"
			Me.colFax.Visible = True
			Me.colFax.Width = 84
			' 
			' colCountry
			' 
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			Me.colCountry.Width = 113
			' 
			' colPostalCode
			' 
			Me.colPostalCode.FieldName = "PostalCode"
			Me.colPostalCode.Name = "colPostalCode"
			Me.colPostalCode.Width = 55
			' 
			' colHomePage
			' 
			Me.colHomePage.FieldName = "HomePage"
			Me.colHomePage.Name = "colHomePage"
			Me.colHomePage.Width = 60
			' 
			' colAddress
			' 
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.RowIndex = 1
			Me.colAddress.Visible = True
			Me.colAddress.Width = 139
			' 
			' colCity
			' 
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.RowIndex = 1
			Me.colCity.Visible = True
			Me.colCity.Width = 90
			' 
			' colRegion
			' 
			Me.colRegion.FieldName = "Region"
			Me.colRegion.Name = "colRegion"
			Me.colRegion.RowIndex = 1
			Me.colRegion.Visible = True
			Me.colRegion.Width = 61
			' 
			' suppliersTableAdapter
			' 
			Me.suppliersTableAdapter.ClearBeforeFill = True
			' 
			' categoryProductsTableAdapter1
			' 
			Me.categoryProductsTableAdapter1.ClearBeforeFill = True
			' 
			' productsTableAdapter1
			' 
			Me.productsTableAdapter1.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(586, 482)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.suppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private nwindDataSet As nwindDataSet
		Private suppliersBindingSource As System.Windows.Forms.BindingSource
		Private suppliersTableAdapter As Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.SuppliersTableAdapter
		Private categoryProductsTableAdapter1 As Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.CategoryProductsTableAdapter
		Private productsTableAdapter1 As Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.ProductsTableAdapter
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView3 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colSupplierID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn
		Private colReorderLevel As DevExpress.XtraGrid.Columns.GridColumn
		Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
		Private colEAN13 As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductID1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colSupplierID2 As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colPicture As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private colSupplierID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCompanyName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colContactName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colContactTitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colAddress As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCity As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colRegion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPostalCode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCountry As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colPhone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colFax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colHomePage As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
	End Class
End Namespace

