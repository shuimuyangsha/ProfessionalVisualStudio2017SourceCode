Imports System.Drawing
Imports System.Windows.Controls

<ToolboxBitmap(GetType(MyControl), "MyControlIcon.bmp")> _
Public Class MyControl
    Inherits UserControl

    Private Const cDefaultDescription As String = "<enter description>"

    <System.ComponentModel.DefaultValue(cDefaultDescription)> _
    <System.ComponentModel.Browsable(False)> _
    <System.ComponentModel.DisplayName("VS2012 Description")> _
    <System.ComponentModel.Description("My first customer property")> _
    <System.ComponentModel.Category("Appearance")> _
    Public Property Description As String = cDefaultDescription

End Class
