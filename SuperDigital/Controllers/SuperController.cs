using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SuperApplication.Interfaces;
using SuperDigital.ViewModels;

namespace SuperDigital.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class SuperController : ControllerBase
    {
        private readonly IWordSwitchApplication _wordSwitchApplication;

        public SuperController(IWordSwitchApplication wordSwitchApplication)
        {
            _wordSwitchApplication = wordSwitchApplication;
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] ComparaPalavrasViewModel comparaPalavras)
        {
            comparaPalavras.TotalDeMovimentosParaTrasmutar = _wordSwitchApplication.TotalMovimentosTransmutacao(comparaPalavras.PrimeiraPalavra, comparaPalavras.SegundaPalavra);
            Ok(comparaPalavras);
        }
    }
}
