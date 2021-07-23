﻿using Bccr.PlaceHolder.Abstracciones.BW;
using Bccr.PlaceHolder.Abstracciones.Contenedores;
using Bccr.PlaceHolder.Abstracciones.SG;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bccr.PlaceHolder.Abstracciones.MAPI
{
    public interface ILlaveValorController
    {
        //ILlaveValorBW LlaveValorBW { get; set; }

        [HttpGet]
        Task<ActionResult<IEnumerable<LlaveValor>>> ObtenerTodosAsyn();

        [HttpGet("{llave}")]
        Task<ActionResult<string>> ObtenerPorLlaveAsync(int llave);

        [HttpPost]
        Task<ActionResult<int>> AgregarAsync([FromBody] string valor);

        [HttpPut("{llave}")]
        Task<ActionResult<int>> EditarAsync(int llave, [FromBody] string valor);

        [HttpDelete("{llave}")]
        Task<ActionResult<int>> EliminarAsync(int llave);
    }
}
