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
    Public Class ProfessorController
        Inherits System.Web.Mvc.Controller

        Private db As New IFA_A6LP2Entities

        ' GET: Professor
        Function Index() As ActionResult
            Return View(db.Professors.ToList())
        End Function

        ' GET: Professor/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim professor As Professor = db.Professors.Find(id)
            If IsNothing(professor) Then
                Return HttpNotFound()
            End If
            Return View(professor)
        End Function

        ' GET: Professor/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Professor/Create
        'Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        'Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Matricula,Nome")> ByVal professor As Professor) As ActionResult
            If ModelState.IsValid Then
                db.Professors.Add(professor)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(professor)
        End Function

        ' GET: Professor/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim professor As Professor = db.Professors.Find(id)
            If IsNothing(professor) Then
                Return HttpNotFound()
            End If
            Return View(professor)
        End Function

        ' POST: Professor/Edit/5
        'Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        'Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Matricula,Nome")> ByVal professor As Professor) As ActionResult
            If ModelState.IsValid Then
                db.Entry(professor).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(professor)
        End Function

        ' GET: Professor/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim professor As Professor = db.Professors.Find(id)
            If IsNothing(professor) Then
                Return HttpNotFound()
            End If
            Return View(professor)
        End Function

        ' POST: Professor/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim professor As Professor = db.Professors.Find(id)
            db.Professors.Remove(professor)
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
