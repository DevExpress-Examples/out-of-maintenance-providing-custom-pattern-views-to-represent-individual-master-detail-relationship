using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace Grid_MasterDetail_GetRelationName {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Load data
            this.suppliersTableAdapter.Fill(this.nwindDataSet.Suppliers);
            categoryProductsTableAdapter1.Fill(this.nwindDataSet.CategoryProducts);
            productsTableAdapter1.Fill(this.nwindDataSet.Products);

            // Create and customize a custom pattern View
            GridView customPatternView = new GridView(gridControl1);
            customPatternView.Columns.AddField("ProductName").VisibleIndex = 0;
            customPatternView.Columns.AddField("Discontinued").VisibleIndex = 1;
            customPatternView.OptionsView.ShowGroupPanel = false;
            // Associate the pattern View with the "CustomRelation" name
            gridControl1.LevelTree.Nodes.Add("CustomRelation", customPatternView);
        }

        // Provide a pattern View for the first master-detail relationship in the first master row
        private void advBandedGridView1_MasterRowGetRelationName(object sender, MasterRowGetRelationNameEventArgs e) {
            if (e.RowHandle == 0 && e.RelationIndex == 0)
                e.RelationName = "CustomRelation";
        }
        // Provide a display caption for the first master-detail relationship in the first master row
        private void advBandedGridView1_MasterRowGetRelationDisplayCaption(object sender, MasterRowGetRelationNameEventArgs e) {
            if (e.RowHandle == 0 && e.RelationIndex == 0)
                e.RelationName = "Custom Relation";
        }

    }
}
