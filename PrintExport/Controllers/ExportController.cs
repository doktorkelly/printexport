using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExportService;

namespace PrintExport.Controllers
{
    public class ExportController : Controller
    {
        IExportService ExportService { get; set; }

        public ExportController(IExportService exportService)
        {
            this.ExportService = exportService;
        }

        // GET: Export
        public ActionResult Index()
        {
            IEnumerable<ExportFormat> expFormatList = ExportService.GetAllFormats();
            return View(expFormatList);
        }

        // GET: Export/Details/5
        public ActionResult Details(int id)
        {
            ExportFormat exportFormat = ExportService.GetFormat(id);
            return View(exportFormat);
        }

        // GET: Export/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Export/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: Export/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Export/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: Export/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Export/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }
    }
}