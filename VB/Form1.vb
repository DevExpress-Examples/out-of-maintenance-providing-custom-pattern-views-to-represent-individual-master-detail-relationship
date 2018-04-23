Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace Grid_MasterDetail_GetRelationName
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Load data
			Me.suppliersTableAdapter.Fill(Me.nwindDataSet.Suppliers)
			categoryProductsTableAdapter1.Fill(Me.nwindDataSet.CategoryProducts)
			productsTableAdapter1.Fill(Me.nwindDataSet.Products)

			' Create and customize a custom pattern View
			Dim customPatternView As New GridView(gridControl1)
			customPatternView.Columns.AddField("ProductName").VisibleIndex = 0
			customPatternView.Columns.AddField("Discontinued").VisibleIndex = 1
			customPatternView.OptionsView.ShowGroupPanel = False
			' Associate the pattern View with the "CustomRelation" name
			gridControl1.LevelTree.Nodes.Add("CustomRelation", customPatternView)
		End Sub

		' Provide a pattern View for the first master-detail relationship in the first master row
		Private Sub advBandedGridView1_MasterRowGetRelationName(ByVal sender As Object, ByVal e As MasterRowGetRelationNameEventArgs) Handles advBandedGridView1.MasterRowGetRelationName
			If e.RowHandle = 0 AndAlso e.RelationIndex = 0 Then
				e.RelationName = "CustomRelation"
			End If
		End Sub
		' Provide a display caption for the first master-detail relationship in the first master row
		Private Sub advBandedGridView1_MasterRowGetRelationDisplayCaption(ByVal sender As Object, ByVal e As MasterRowGetRelationNameEventArgs) Handles advBandedGridView1.MasterRowGetRelationDisplayCaption
			If e.RowHandle = 0 AndAlso e.RelationIndex = 0 Then
				e.RelationName = "Custom Relation"
			End If
		End Sub

	End Class
End Namespace
