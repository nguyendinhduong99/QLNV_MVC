using QLNV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNV.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            var listNhanVien = new DBNhanVienContext().NhanViens.ToList();
            return View(listNhanVien);
        }

        // GET: NhanVien/Decentralization/5
        public ActionResult Decentralization(int id)
        {
            var context = new DBNhanVienContext();
            var decentralizating = context.NhanViens.Find(id);
            return View(decentralizating);
        }

        [HttpPost]
        public ActionResult Decentralization(NhanVien model)
        {
            try
            {
                var context = new DBNhanVienContext();
                var decentralizating = context.NhanViens.Find(model.Id);
                decentralizating.LaQuanTri = model.LaQuanTri;
                decentralizating.LaChuyenVien = model.LaChuyenVien;
                decentralizating.LaNhanVien = model.LaNhanVien;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Create
        public ActionResult Create()
        {
            var context = new DBNhanVienContext();
            var chucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu");
            ViewBag.IdChucVu = chucVuSelect;
            return View();
        }

        // POST: NhanVien/Create
        [HttpPost]
        public ActionResult Create(NhanVien model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBNhanVienContext();
                context.NhanViens.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Edit/5
        public ActionResult Edit(int id)
        {
            var context = new DBNhanVienContext();
            var editting = context.NhanViens.Find(id);
            var chucvuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu", editting.IdChucVu);
            ViewBag.IdChucVu = chucvuSelect;
            return View(editting);
        }

        // POST: NhanVien/Edit/5
        [HttpPost]
        public ActionResult Edit(NhanVien model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new DBNhanVienContext();
                var oldItem = context.NhanViens.Find(model.Id);
                oldItem.HoVaTen = model.HoVaTen;
                oldItem.GioiTinh = model.GioiTinh;
                oldItem.Email = model.Email;
                oldItem.SoDienThoai = model.SoDienThoai;
                oldItem.SoCanCuoc = model.SoCanCuoc;
                oldItem.TenDangNhap = model.TenDangNhap;
                oldItem.MatKhau = model.MatKhau;
                oldItem.IdChucVu = model.IdChucVu;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanVien/Delete/5
        public ActionResult Delete(int id)
        {
            var context = new DBNhanVienContext();
            var deleting = context.NhanViens.Find(id);
            return View(deleting);
        }

        // POST: NhanVien/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new DBNhanVienContext();
                var deleting = context.NhanViens.Find(id);
                context.NhanViens.Remove(deleting);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}