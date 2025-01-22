using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebQuery.DataBaseEntity;
using WebQuery.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebQuery.Controllers
{
    public class ProductDTO
    {
        public List<Product>? Data { get; set; }
    }

    public class ProductController(ProductDbContext context) : Controller
    {
        private readonly ProductDbContext _context = context;

        // GET: Product
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.Products.ToList();
            return Json(new ProductDTO { Data = products });
        }
 
        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Вх_N,Заказчик,Предмет_запроса,Объект,Примечание1,На_сервере,Реестр_ТКП,Ответственный,Price,Date,Примечание2,Статус,status")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Вх_N,Заказчик,Предмет_запроса,Объект,Примечание1,На_сервере,Реестр_ТКП,Ответственный,Price,Date,Примечание2,Статус,status")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }

        // Action method to delete a product
        [HttpPost]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        //public ActionResult Index()
        //{
        //    DropdownViewModel dropdownViewModel = new DropdownViewModel();
        //    using (var context = new EmployeeDetailsEntities())
        //    {
        //        //create SelectListItem
        //        dropdownViewModel.EmpList = context.EmpDetails.
        //                                   Select(a => new SelectListItem
        //                                   {
        //                                       Text = a.EmpName, // name to show in html dropdown
        //                                       Value = a.EmpName // value of html dropdown
        //                                   }).ToList();
        //    }
        //    //pass Model to view
        //    return View(dropdownViewModel);
        //}
        //
        ////to get form values, submitted by user
        //[HttpPost]
        //public ActionResult Index(DropdownViewModel dropdownViewModel)
        //{

        //    using (var context = new EmployeeDetailsEntities())
        //    {
        //        //create SelectListItem again
        //        dropdownViewModel.EmpList = context.EmpDetails.
        //                                   Select(a => new SelectListItem
        //                                   {
        //                                       Text = a.EmpName, // name to show in html dropdown
        //                                       Value = a.EmpName // value of html dropdown
        //                                   }).ToList();

        //    }
        //    //pass Model to view, but we will have selected value also this time
        //    return View(dropdownViewModel);
        //}
        //-----------------------------------------------------------------------------------
        // GET: Product/Edit/5
        public async Task<IActionResult> Reformers(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reformers(int id, [Bind("Id,Вх_N,Заказчик,Предмет_запроса,Объект,Примечание1,На_сервере,Реестр_ТКП,Ответственный,Price,Date,Примечание2,Статус,status")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.Id))
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
            return View(product);
        }


    }
}

