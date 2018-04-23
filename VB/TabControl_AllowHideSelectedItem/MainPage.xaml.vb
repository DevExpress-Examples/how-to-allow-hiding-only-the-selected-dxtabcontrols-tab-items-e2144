Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Utils
Imports DevExpress.Xpf.Core
Imports DXExample.DemoData

Namespace TabControl_AllowHideSelectedItem
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub LayoutRoot_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			tabControl.ItemsSource = Invoice.GetData()
		End Sub
		Private Sub tabControl_SelectionChanged(ByVal sender As Object, ByVal e As TabControlSelectionChangedEventArgs)
			Dim oldItem As DXTabItem = tabControl.GetTabItem(e.OldSelectedIndex)
			Dim newItem As DXTabItem = tabControl.GetTabItem(tabControl.SelectedIndex)
			If oldItem IsNot Nothing Then
				oldItem.AllowHide = DefaultBoolean.Default
			End If
			If newItem IsNot Nothing Then
				newItem.AllowHide = DefaultBoolean.True
			End If
		End Sub
	End Class
End Namespace
