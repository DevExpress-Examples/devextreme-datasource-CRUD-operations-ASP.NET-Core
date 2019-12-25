using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T845675test.Models
{
    public class InMemoryEmployeesDataContext : InMemoryDataContext<Employee>
    {

        public InMemoryEmployeesDataContext(IHttpContextAccessor contextAccessor, IMemoryCache memoryCache)
            : base(contextAccessor, memoryCache)
        {
        }

        public ICollection<Employee> Employees => ItemsInternal;


        protected override IEnumerable<Employee> Source => SampleData.SampleData.DataGridEmployees;

        protected override int GetKey(Employee item) => item.ID;

        protected override void SetKey(Employee item, int key) => item.ID = key;
    }
}
