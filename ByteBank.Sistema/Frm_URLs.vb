Public Class Frm_URLs
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Gerenciador de Páginas Web"
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Dim F As New Frm_PaginaWeb
        F.MdiParent = Me
        F.Show()
    End Sub

    Private Sub JanelaHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JanelaHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub JanelaVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JanelaVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub JanelaCascataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JanelaCascataToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
End Class
