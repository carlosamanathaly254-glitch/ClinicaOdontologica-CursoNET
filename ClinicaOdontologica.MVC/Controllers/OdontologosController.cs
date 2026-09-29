
using ClinicaOdontologica.Consumer;
using ClinicaOdontologicaModelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class OdontologosController : Controller
{

    // GET: ODONTOLOGOS
    public ActionResult Index()
    {
        var odontologo = CRUD<Odontologo>.GetAll();
        return View(odontologo);
    }

    // GET: ODONTOLOGOS/Details/5
    public ActionResult Details(int id)
    {
        var odontologo = CRUD<Odontologo>.GetById(id);
        if (id == null)
        {
            return NotFound();
        }
        return View(odontologo);
    }

    // GET: ODONTOLOGOS/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: ODONTOLOGOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Odontologo odontologo)
    {
        try
        {
            CRUD<Odontologo>.Create(odontologo);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            // Handle the exception (e.g., log it, display an error message, etc.)
            ModelState.AddModelError("", ex.Message);
            return View(odontologo);
        }
    }

    // GET: ODONTOLOGOS/Edit/5
    public ActionResult Edit(int id)
    {
        var odontologo = CRUD<Odontologo>.GetById(id);
        if (odontologo == null)
        {
            return NotFound();
        }
        return View(odontologo);
    }

    // POST: ODONTOLOGOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, Odontologo odontologo)
    {
        try
        {
            CRUD<Odontologo>.Update(id, odontologo);
            return RedirectToAction(nameof(Index));

        }
        catch (Exception ex)
        {
            // Handle the exception (e.g., log it, display an error message, etc.)
            ModelState.AddModelError("", ex.Message);
            return View(odontologo);
        }
    }
    // GET: ODONTOLOGOS/Delete/5
    public ActionResult Delete(int id)
    {
        var odontologo = CRUD<Odontologo>.GetById(id);
        if (odontologo == null)
        {
            return NotFound();
        }

        return View(odontologo);
    }

    // POST: ODONTOLOGOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, Odontologo odontologo)
    {
        try
        {
            CRUD<Odontologo>.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            ModelState.AddModelError("", ex.Message);
            return View(odontologo);
        }
    }
}
