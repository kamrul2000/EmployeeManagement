using EmployeeManagement.Models;
using EmployeeManagement.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [Authorize(Roles = "Employee,Admin")]
        public async Task<IActionResult> Index()
        {
            var employees = await _employeeService.GetAllAsync();
            return View(employees);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                await _employeeService.AddAsync(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.Id) return NotFound();

            if (ModelState.IsValid)
            {
                await _employeeService.UpdateAsync(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await _employeeService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var employee = await _employeeService.GetByIdAsync(id);
            if (employee == null) return NotFound();
            return View(employee);
        }
    }
}
