Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports IFA_A6LP2

Namespace Controllers
    Public Class ProjetoController
        Inherits System.Web.Mvc.Controller

        Private db As New IFA_A6LP2Entities

        ' GET: Projeto
        Function Index() As ActionResult
            Return View(db.Projetoes.ToList())
        End Function

        ' GET: Projeto/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim projeto As Projeto = db.Projetoes.Find(id)
            If IsNothing(projeto) Then
                Return HttpNotFound()
            End If
            Return View(projeto)
        End Function

        ' GET: Projeto/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Projeto/Create
        'Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        'Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Código,Nome,Tipo")> ByVal projeto As Projeto) As ActionResult
            If ModelState.IsValid Then
                db.Projetoes.Add(projeto)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(projeto)
        End Function

        ' GET: Projeto/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim projeto As Projeto = db.Projetoes.Find(id)
            If IsNothing(projeto) Then
                Return HttpNotFound()
            End If
            Return View(projeto)
        End Function

        ' POST: Projeto/Edit/5
        'Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        'Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Código,Nome,Tipo")> ByVal projeto As Projeto) As ActionResult
            If ModelState.IsValid Then
                db.Entry(projeto).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(projeto)
        End Function

        ' GET: Projeto/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim projeto As Projeto = db.Projetoes.Find(id)
            If IsNothing(projeto) Then
                Return HttpNotFound()
            End If
            Return View(projeto)
        End Function

        ' POST: Projeto/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim projeto As Projeto = db.Projetoes.Find(id)
            db.Projetoes.Remove(projeto)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
