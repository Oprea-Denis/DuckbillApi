using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DuckbillApi.Data;
using DuckbillApi.Models;

namespace DuckbillApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuckbillsController : ControllerBase
    {
        private static List<Duckbill> duckbills = new List<Duckbill>()
        {
            new Duckbill() { ID = Guid.NewGuid(), Name = "Duckbill1"},
            new Duckbill() { ID = Guid.NewGuid(), Name = "Duckbill2"},
            new Duckbill() { ID = Guid.NewGuid(), Name = "Duckbill3"},
            new Duckbill() { ID = Guid.NewGuid(), Name = "Duckbill4"},
            new Duckbill() { ID = Guid.NewGuid(), Name = "Duckbill5"}
        };

        [HttpGet]
        public Duckbill[] Get()
        {
            return duckbills.ToArray();
        }

        [HttpPost]
        public void Post([FromBody] Duckbill duckbill)
        {
            if (duckbill.ID == Guid.Empty)
                duckbill.ID = Guid.NewGuid();

            duckbills.Add(duckbill);
        }

        [HttpPut]
        public void Put([FromBody] Duckbill duckbill)
        {
            Duckbill currentDuckbill = duckbills.FirstOrDefault(m => m.ID == duckbill.ID);
            currentDuckbill.Name = duckbill.Name;
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            duckbills.RemoveAll(duckbill => duckbill.ID == id);
        }
    }
}