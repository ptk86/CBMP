using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CBMP.Api.Dal;
using CBMP.Api.Dtos;

namespace CBMP.Api.Controllers
{
    public class OsobyController : ApiController
    {
        private readonly AppContext _ctx;
        public OsobyController(AppContext ctx)
        {
            if (ctx == null)
                throw new ArgumentNullException(nameof(ctx));

            _ctx = ctx;
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var osoba = _ctx.Osoby.FirstOrDefault(o => o.Id == id);
            if (osoba == null)
                return NotFound();
            var osobaDto = Mapper.Map<OsobaDto>(osoba);

            return Ok(osobaDto);
        }
    }
}
