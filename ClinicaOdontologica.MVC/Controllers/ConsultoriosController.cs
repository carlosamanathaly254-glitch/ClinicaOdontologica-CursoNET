
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClinicaOdontologicaModelos;

public class ConsultoriosController : Controller
{
    private readonly ClinicaOdontologicaAPIContext _context;

    public ConsultoriosController(ClinicaOdontologicaAPIContext context)
    {
        _context = context;
    }

    // GET: CONSULTORIOS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Consultorio.ToListAsync());
    }

    // GET: CONSULTORIOS/Details/5
    public async Task<IActionResult> Details(int? idconsultorio)
    {
        if (idconsultorio == null)
        {
            return NotFound();
        }

        var consultorio = await _context.Consultorio
            .FirstOrDefaultAsync(m => m.IdConsultorio == idconsultorio);
        if (consultorio == null)
        {
            return NotFound();
        }

        return View(consultorio);
    }

    // GET: CONSULTORIOS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CONSULTORIOS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("IdConsultorio,NumeroSala,Piso,EquipamientoPrincipal,Citas")] Consultorio consultorio)
    {
        if (ModelState.IsValid)
        {
            _context.Add(consultorio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(consultorio);
    }

    // GET: CONSULTORIOS/Edit/5
    public async Task<IActionResult> Edit(int? idconsultorio)
    {
        if (idconsultorio == null)
        {
            return NotFound();
        }

        var consultorio = await _context.Consultorio.FindAsync(idconsultorio);
        if (consultorio == null)
        {
            return NotFound();
        }
        return View(consultorio);
    }

    // POST: CONSULTORIOS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? idconsultorio, [Bind("IdConsultorio,NumeroSala,Piso,EquipamientoPrincipal,Citas")] Consultorio consultorio)
    {
        if (idconsultorio != consultorio.IdConsultorio)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(consultorio);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConsultorioExists(consultorio.IdConsultorio))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(consultorio);
    }

    // GET: CONSULTORIOS/Delete/5
    public async Task<IActionResult> Delete(int? idconsultorio)
    {
        if (idconsultorio == null)
        {
            return NotFound();
        }

        var consultorio = await _context.Consultorio
            .FirstOrDefaultAsync(m => m.IdConsultorio == idconsultorio);
        if (consultorio == null)
        {
            return NotFound();
        }

        return View(consultorio);
    }

    // POST: CONSULTORIOS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? idconsultorio)
    {
        var consultorio = await _context.Consultorio.FindAsync(idconsultorio);
        if (consultorio != null)
        {
            _context.Consultorio.Remove(consultorio);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ConsultorioExists(int? idconsultorio)
    {
        return _context.Consultorio.Any(e => e.IdConsultorio == idconsultorio);
    }
}
