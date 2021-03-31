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
    Public Class AlunoController
        Inherits System.Web.Mvc.Controller

        Private db As New IFA_A6LP2Entities

        ' GET: Aluno
        Function Index() As ActionResult
            Dim alunoes = db.Alunoes.Include(Function(a) a.Professor1).Include(Function(a) a.Projeto1)
            Return View(alunoes.ToList())
        End Function

        ' GET: Aluno/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim aluno As Aluno = db.Alunoes.Find(id)
            If IsNothing(aluno) Then
                Return HttpNotFound()
            End If
            Return View(aluno)
        End Function

        ' GET: Aluno/Create
        Function Create() As ActionResult
            ViewBag.Professor = New SelectList(db.Professors, "Matricula", "Nome")
            ViewBag.Projeto = New SelectList(db.Projetoes, "Código", "Nome")
            Return View()
        End Function

        ' POST: Aluno/Create
        'Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        'Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Matricula,Nome,Projeto,Recebe_bolsa,Professor")> ByVal aluno As Aluno) As ActionResult
            If ModelState.IsValid Then
                db.Alunoes.Add(aluno)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Professor = New SelectList(db.Professors, "Matricula", "Nome", aluno.Professor)
            ViewBag.Projeto = New SelectList(db.Projetoes, "Código", "Nome", aluno.Projeto)
            Return View(aluno)
        End Function

        ' GET: Aluno/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim aluno As Aluno = db.Alunoes.Find(id)
            If IsNothing(aluno) Then
                Return HttpNotFound()
            End If
            ViewBag.Professor = New SelectList(db.Professors, "Matricula", "Nome", aluno.Professor)
            ViewBag.Projeto = New SelectList(db.Projetoes, "Código", "Nome", aluno.Projeto)
            Return View(aluno)
        End Function

        ' POST: Aluno/Edit/5
        'Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        'Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Matricula,Nome,Projeto,Recebe_bolsa,Professor")> ByVal aluno As Aluno) As ActionResult
            If ModelState.IsValid Then
                db.Entry(aluno).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Professor = New SelectList(db.Professors, "Matricula", "Nome", aluno.Professor)
            ViewBag.Projeto = New SelectList(db.Projetoes, "Código", "Nome", aluno.Projeto)
            Return View(aluno)
        End Function

        ' GET: Aluno/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim aluno As Aluno = db.Alunoes.Find(id)
            If IsNothing(aluno) Then
                Return HttpNotFound()
            End If
            Return View(aluno)
        End Function

        ' POST: Aluno/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim aluno As Aluno = db.Alunoes.Find(id)
            db.Alunoes.Remove(aluno)
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
