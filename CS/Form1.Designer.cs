namespace Grid_MasterDetail_GetRelationName {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantityPerUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsInStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsOnOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReorderLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscontinued = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEAN13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new Grid_MasterDetail_GetRelationName.nwindDataSet();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colSupplierID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colContactTitle = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colContactName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCompanyName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colPhone = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFax = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCountry = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHomePage = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAddress = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colRegion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.suppliersTableAdapter = new Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.SuppliersTableAdapter();
            this.categoryProductsTableAdapter1 = new Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.CategoryProductsTableAdapter();
            this.productsTableAdapter1 = new Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID,
            this.colProductName,
            this.colSupplierID1,
            this.colCategoryID,
            this.colQuantityPerUnit,
            this.colUnitPrice,
            this.colUnitsInStock,
            this.colUnitsOnOrder,
            this.colReorderLevel,
            this.colDiscontinued,
            this.colEAN13});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colProductID
            // 
            this.colProductID.FieldName = "ProductID";
            this.colProductID.Name = "colProductID";
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            this.colProductName.Width = 240;
            // 
            // colSupplierID1
            // 
            this.colSupplierID1.FieldName = "SupplierID";
            this.colSupplierID1.Name = "colSupplierID1";
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            // 
            // colQuantityPerUnit
            // 
            this.colQuantityPerUnit.FieldName = "QuantityPerUnit";
            this.colQuantityPerUnit.Name = "colQuantityPerUnit";
            this.colQuantityPerUnit.Visible = true;
            this.colQuantityPerUnit.VisibleIndex = 1;
            this.colQuantityPerUnit.Width = 118;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DisplayFormat.FormatString = "c2";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 2;
            this.colUnitPrice.Width = 118;
            // 
            // colUnitsInStock
            // 
            this.colUnitsInStock.FieldName = "UnitsInStock";
            this.colUnitsInStock.Name = "colUnitsInStock";
            this.colUnitsInStock.Width = 97;
            // 
            // colUnitsOnOrder
            // 
            this.colUnitsOnOrder.FieldName = "UnitsOnOrder";
            this.colUnitsOnOrder.Name = "colUnitsOnOrder";
            this.colUnitsOnOrder.Visible = true;
            this.colUnitsOnOrder.VisibleIndex = 3;
            this.colUnitsOnOrder.Width = 133;
            // 
            // colReorderLevel
            // 
            this.colReorderLevel.FieldName = "ReorderLevel";
            this.colReorderLevel.Name = "colReorderLevel";
            // 
            // colDiscontinued
            // 
            this.colDiscontinued.FieldName = "Discontinued";
            this.colDiscontinued.Name = "colDiscontinued";
            this.colDiscontinued.Visible = true;
            this.colDiscontinued.VisibleIndex = 4;
            this.colDiscontinued.Width = 115;
            // 
            // colEAN13
            // 
            this.colEAN13.FieldName = "EAN13";
            this.colEAN13.Name = "colEAN13";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.suppliersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "SuppliersProducts";
            gridLevelNode2.LevelTemplate = this.gridView3;
            gridLevelNode2.RelationName = "Suppliers_CategoryProducts";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(586, 482);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3,
            this.advBandedGridView1,
            this.gridView2});
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductID1,
            this.colSupplierID2,
            this.colProductName1,
            this.colCategoryName,
            this.colPicture,
            this.colDescription});
            this.gridView3.GridControl = this.gridControl1;
            this.gridView3.Name = "gridView3";
            // 
            // colProductID1
            // 
            this.colProductID1.FieldName = "ProductID";
            this.colProductID1.Name = "colProductID1";
            this.colProductID1.Visible = true;
            this.colProductID1.VisibleIndex = 0;
            // 
            // colSupplierID2
            // 
            this.colSupplierID2.FieldName = "SupplierID";
            this.colSupplierID2.Name = "colSupplierID2";
            // 
            // colProductName1
            // 
            this.colProductName1.FieldName = "ProductName";
            this.colProductName1.Name = "colProductName1";
            this.colProductName1.Visible = true;
            this.colProductName1.VisibleIndex = 1;
            // 
            // colCategoryName
            // 
            this.colCategoryName.FieldName = "CategoryName";
            this.colCategoryName.Name = "colCategoryName";
            this.colCategoryName.Visible = true;
            this.colCategoryName.VisibleIndex = 2;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colSupplierID,
            this.colCompanyName,
            this.colContactName,
            this.colContactTitle,
            this.colAddress,
            this.colCity,
            this.colRegion,
            this.colPostalCode,
            this.colCountry,
            this.colPhone,
            this.colFax,
            this.colHomePage});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsView.ColumnAutoWidth = true;
            this.advBandedGridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.advBandedGridView1.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.advBandedGridView1_MasterRowGetRelationName);
            this.advBandedGridView1.MasterRowGetRelationDisplayCaption += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.advBandedGridView1_MasterRowGetRelationDisplayCaption);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Supplier";
            this.gridBand1.Columns.Add(this.colSupplierID);
            this.gridBand1.Columns.Add(this.colContactTitle);
            this.gridBand1.Columns.Add(this.colContactName);
            this.gridBand1.Columns.Add(this.colCompanyName);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 278;
            // 
            // colSupplierID
            // 
            this.colSupplierID.Caption = "ID";
            this.colSupplierID.FieldName = "SupplierID";
            this.colSupplierID.Name = "colSupplierID";
            this.colSupplierID.Visible = true;
            this.colSupplierID.Width = 35;
            // 
            // colContactTitle
            // 
            this.colContactTitle.FieldName = "ContactTitle";
            this.colContactTitle.Name = "colContactTitle";
            this.colContactTitle.Visible = true;
            this.colContactTitle.Width = 121;
            // 
            // colContactName
            // 
            this.colContactName.FieldName = "ContactName";
            this.colContactName.Name = "colContactName";
            this.colContactName.Visible = true;
            this.colContactName.Width = 122;
            // 
            // colCompanyName
            // 
            this.colCompanyName.FieldName = "CompanyName";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.RowIndex = 1;
            this.colCompanyName.Visible = true;
            this.colCompanyName.Width = 278;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Address";
            this.gridBand2.Columns.Add(this.colPhone);
            this.gridBand2.Columns.Add(this.colFax);
            this.gridBand2.Columns.Add(this.colCountry);
            this.gridBand2.Columns.Add(this.colPostalCode);
            this.gridBand2.Columns.Add(this.colHomePage);
            this.gridBand2.Columns.Add(this.colAddress);
            this.gridBand2.Columns.Add(this.colCity);
            this.gridBand2.Columns.Add(this.colRegion);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 290;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.Width = 93;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.Width = 84;
            // 
            // colCountry
            // 
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.Width = 113;
            // 
            // colPostalCode
            // 
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.Width = 55;
            // 
            // colHomePage
            // 
            this.colHomePage.FieldName = "HomePage";
            this.colHomePage.Name = "colHomePage";
            this.colHomePage.Width = 60;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.RowIndex = 1;
            this.colAddress.Visible = true;
            this.colAddress.Width = 139;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.RowIndex = 1;
            this.colCity.Visible = true;
            this.colCity.Width = 90;
            // 
            // colRegion
            // 
            this.colRegion.FieldName = "Region";
            this.colRegion.Name = "colRegion";
            this.colRegion.RowIndex = 1;
            this.colRegion.Visible = true;
            this.colRegion.Width = 61;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // categoryProductsTableAdapter1
            // 
            this.categoryProductsTableAdapter1.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 482);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.CategoryProductsTableAdapter categoryProductsTableAdapter1;
        private Grid_MasterDetail_GetRelationName.nwindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierID1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantityPerUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsInStock;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitsOnOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colReorderLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscontinued;
        private DevExpress.XtraGrid.Columns.GridColumn colEAN13;
        private DevExpress.XtraGrid.Columns.GridColumn colProductID1;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierID2;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSupplierID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCompanyName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colContactName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colContactTitle;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAddress;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colRegion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPostalCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCountry;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPhone;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFax;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHomePage;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    }
}

