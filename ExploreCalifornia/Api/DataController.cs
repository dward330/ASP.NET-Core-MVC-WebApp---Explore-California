using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.DAL;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Api
{
    [Produces("application/json")]
    [Route("api/Data")]
    public class DataController : Controller
    {
        private readonly SpecialsDataContext _SpecialsDb;

        public DataController(SpecialsDataContext specialsDb)
        {
            this._SpecialsDb = specialsDb;
        }

        [HttpGet]
        [Route("GetMonthlySpecials")]
        public JsonResult GetMonthlySpecials()
        {
            IEnumerable<Special> data = null;
            if (null != this._SpecialsDb)
            {
                data = this._SpecialsDb.GetMonthlySpecials();
            }

            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

            return Json(data);
        }
    }
}