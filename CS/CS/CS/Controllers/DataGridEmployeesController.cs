using System.Linq;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using T845675test.Models;

namespace CS.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class DataGridEmployeesController : Controller {
        InMemoryEmployeesDataContext _data;

        public DataGridEmployeesController(IHttpContextAccessor httpContextAccessor, IMemoryCache memoryCache) {
            _data = new InMemoryEmployeesDataContext(httpContextAccessor, memoryCache);
        }

        [HttpGet]
        public IActionResult Get(DataSourceLoadOptions loadOptions) {
            return Json(DataSourceLoader.Load(_data.Employees, loadOptions));
        }

        [HttpPost]
        public IActionResult Post([FromForm]string values) {
            var newEmployee = new Employee();
            JsonConvert.PopulateObject(values, newEmployee);

            if (!TryValidateModel(newEmployee))
                return BadRequest();

            _data.Employees.Add(newEmployee);
            _data.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromForm]int key, [FromForm]string values) {
            var employee = _data.Employees.First(a => a.ID == key);
            JsonConvert.PopulateObject(values, employee);

            if (!TryValidateModel(employee))
                return BadRequest();

            _data.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public void Delete([FromForm]int key) {
            var employee = _data.Employees.First(a => a.ID == key);
            _data.Employees.Remove(employee);
            _data.SaveChanges();
        }
    }
}