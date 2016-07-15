<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TBErg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportABugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÜberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForumToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.NewsletterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBErg
        '
        resources.ApplyResources(Me.TBErg, "TBErg")
        Me.HelpProvider1.SetHelpKeyword(Me.TBErg, resources.GetString("TBErg.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.TBErg, CType(resources.GetObject("TBErg.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.TBErg, resources.GetString("TBErg.HelpString"))
        Me.TBErg.Name = "TBErg"
        Me.TBErg.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.TBErg, CType(resources.GetObject("TBErg.ShowHelp"), Boolean))
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.HelpProvider1.SetHelpKeyword(Me.Label1, resources.GetString("Label1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Label1, CType(resources.GetObject("Label1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Label1, resources.GetString("Label1.HelpString"))
        Me.Label1.Name = "Label1"
        Me.HelpProvider1.SetShowHelp(Me.Label1, CType(resources.GetObject("Label1.ShowHelp"), Boolean))
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.HelpProvider1.SetHelpKeyword(Me.Button1, resources.GetString("Button1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.Button1, CType(resources.GetObject("Button1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.Button1, resources.GetString("Button1.HelpString"))
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, CType(resources.GetObject("Button1.ShowHelp"), Boolean))
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        resources.ApplyResources(Me.CheckBox1, "CheckBox1")
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HelpProvider1.SetHelpKeyword(Me.CheckBox1, resources.GetString("CheckBox1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.CheckBox1, CType(resources.GetObject("CheckBox1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.CheckBox1, resources.GetString("CheckBox1.HelpString"))
        Me.CheckBox1.Name = "CheckBox1"
        Me.HelpProvider1.SetShowHelp(Me.CheckBox1, CType(resources.GetObject("CheckBox1.ShowHelp"), Boolean))
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.HelpProvider1.SetHelpKeyword(Me.MenuStrip1, resources.GetString("MenuStrip1.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me.MenuStrip1, CType(resources.GetObject("MenuStrip1.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me.MenuStrip1, resources.GetString("MenuStrip1.HelpString"))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.ReportABugToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.HelpProvider1.SetShowHelp(Me.MenuStrip1, CType(resources.GetObject("MenuStrip1.ShowHelp"), Boolean))
        '
        'HelpToolStripMenuItem
        '
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        '
        'ReportABugToolStripMenuItem
        '
        resources.ApplyResources(Me.ReportABugToolStripMenuItem, "ReportABugToolStripMenuItem")
        Me.ReportABugToolStripMenuItem.Name = "ReportABugToolStripMenuItem"
        '
        'ToolStripMenuItem1
        '
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÜberToolStripMenuItem, Me.ChangelogToolStripMenuItem, Me.ForumToolStripMenuItem, Me.NewsletterToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        '
        'ÜberToolStripMenuItem
        '
        resources.ApplyResources(Me.ÜberToolStripMenuItem, "ÜberToolStripMenuItem")
        Me.ÜberToolStripMenuItem.Name = "ÜberToolStripMenuItem"
        '
        'ChangelogToolStripMenuItem
        '
        resources.ApplyResources(Me.ChangelogToolStripMenuItem, "ChangelogToolStripMenuItem")
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        '
        'ForumToolStripMenuItem
        '
        resources.ApplyResources(Me.ForumToolStripMenuItem, "ForumToolStripMenuItem")
        Me.ForumToolStripMenuItem.Name = "ForumToolStripMenuItem"
        '
        'HelpProvider1
        '
        resources.ApplyResources(Me.HelpProvider1, "HelpProvider1")
        '
        'NewsletterToolStripMenuItem
        '
        resources.ApplyResources(Me.NewsletterToolStripMenuItem, "NewsletterToolStripMenuItem")
        Me.NewsletterToolStripMenuItem.Name = "NewsletterToolStripMenuItem"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBErg)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBErg As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportABugToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÜberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForumToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewsletterToolStripMenuItem As ToolStripMenuItem
End Class
