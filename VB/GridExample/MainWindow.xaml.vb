' Developer Express Code Central Example:
' How to use custom printing templates
' 
' This example demonstrates how to use grid's printing templates to change the
' grid printing appearance.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3228

' Developer Express Code Central Example:
' How to use custom printing templates
' 
' This example demonstrates how to use grid's printing templates to change the
' grid printing appearance.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3228

Imports System
Imports System.Windows
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Collections.Generic
Imports System.Windows.Resources
Imports System.IO
Imports System.Drawing
Imports System.Windows.Data
Imports DevExpress.Xpf.Printing


Namespace GridExample
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            AddHandler Loaded, AddressOf MainWindow_Loaded
        End Sub

        Private Sub MainWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            grid.ItemsSource = New List(Of TestData)() From { _
                New TestData() With {.PlainText = "Mercedes-Benz SLK", .MemoText = "LMA AG " & ControlChars.Lf & "2004 " & ControlChars.Lf & "Silver", .BooleanMember = True, .Image = GetImage("/Images/1.jpg"), .Price = 25}, _
                New TestData() With {.PlainText = "Rolls-Royce Corniche", .MemoText ="Western Motors " & ControlChars.Lf & "1975 " & ControlChars.Lf & "Snowy whight", .BooleanMember = False, .Image = GetImage("/Images/2.jpg"), .Price = 15}, _
                New TestData() With {.PlainText = "Ford Ranger FX-4", .MemoText = "Sun car rent" & ControlChars.Lf & "1999 " & ControlChars.Lf & "Red rock", .BooleanMember = True, .Image = GetImage("/Images/3.jpg"), .Price = 20} _
            }
        End Sub

        Private Function GetImage(ByVal path As String) As ImageSource
            Return New BitmapImage(New Uri(path, UriKind.Relative))
        End Function

        Private Sub PrintButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            view.ShowPrintPreview(Me)
        End Sub
    End Class
End Namespace
