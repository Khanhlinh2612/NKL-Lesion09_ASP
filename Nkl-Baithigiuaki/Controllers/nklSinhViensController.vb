Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Nkl_Baithigiuaki

Namespace Controllers
    Public Class nklSinhViensController
        Inherits System.Web.Mvc.Controller

        Private db As New Entities

        ' GET: nklSinhViens
        Function NklIndex() As ActionResult
            Dim nklSinhVien = db.nklSinhVien.Include(Function(n) n.nklKhoa)
            Return View(nklSinhVien.ToList())
        End Function

        ' GET: nklSinhViens/Details/5
        Function NklDetails(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim nklSinhVien As nklSinhVien = db.nklSinhVien.Find(id)
            If IsNothing(nklSinhVien) Then
                Return HttpNotFound()
            End If
            Return View(nklSinhVien)
        End Function

        ' GET: nklSinhViens/Create
        Function NklCreate() As ActionResult
            ViewBag.NklMaKH = New SelectList(db.nklKhoa, "NklMaKH", "NklTenKH")
            Return View()
        End Function

        ' POST: nklSinhViens/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function NklCreate(<Bind(Include:="NklMaSV,NklHoSV,NklNgaySinh,NklPhai,NklPhone,NkllEmail,NklMaKH")> ByVal nklSinhVien As nklSinhVien) As ActionResult
            If ModelState.IsValid Then
                db.nklSinhVien.Add(nklSinhVien)
                db.SaveChanges()
                Return RedirectToAction("NklIndex")
            End If
            ViewBag.NklMaKH = New SelectList(db.nklKhoa, "NklMaKH", "NklTenKH", nklSinhVien.NklMaKH)
            Return View(nklSinhVien)
        End Function

        ' GET: nklSinhViens/Edit/5
        Function NklEdit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim nklSinhVien As nklSinhVien = db.nklSinhVien.Find(id)
            If IsNothing(nklSinhVien) Then
                Return HttpNotFound()
            End If
            ViewBag.NklMaKH = New SelectList(db.nklKhoa, "NklMaKH", "NklTenKH", nklSinhVien.NklMaKH)
            Return View(nklSinhVien)
        End Function

        ' POST: nklSinhViens/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function NklEdit(<Bind(Include:="NklMaSV,NklHoSV,NklNgaySinh,NklPhai,NklPhone,NkllEmail,NklMaKH")> ByVal nklSinhVien As nklSinhVien) As ActionResult
            If ModelState.IsValid Then
                db.Entry(nklSinhVien).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("NklIndex")
            End If
            ViewBag.NklMaKH = New SelectList(db.nklKhoa, "NklMaKH", "NklTenKH", nklSinhVien.NklMaKH)
            Return View(nklSinhVien)
        End Function

        ' GET: nklSinhViens/Delete/5
        Function NklDelete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim nklSinhVien As nklSinhVien = db.nklSinhVien.Find(id)
            If IsNothing(nklSinhVien) Then
                Return HttpNotFound()
            End If
            Return View(nklSinhVien)
        End Function

        ' POST: nklSinhViens/Delete/5
        <HttpPost()>
        <ActionName("NklDelete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim nklSinhVien As nklSinhVien = db.nklSinhVien.Find(id)
            db.nklSinhVien.Remove(nklSinhVien)
            db.SaveChanges()
            Return RedirectToAction("NklIndex")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
