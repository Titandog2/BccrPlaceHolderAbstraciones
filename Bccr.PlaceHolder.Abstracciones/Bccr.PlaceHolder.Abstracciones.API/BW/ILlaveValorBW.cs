using Bccr.PlaceHolder.Abstracciones.API.Contenedores;
using Bccr.PlaceHolder.Abstracciones.API.DA;
using Bccr.PlaceHolder.Abstracciones.API.SG;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bccr.PlaceHolder.Abstracciones.API.BW
{
    public interface ILlaveValorBW
    {
        //ILlaveValorDA LlaveValorDA { get; set; }

        Task<IEnumerable<LlaveValor>> ObtenerTodosAsyn();

        Task<string> ObtenerPorLlaveAsync(int llave);

        Task<int> AgregarAsync(string valor);

        Task<int> EditarAsync(int llave, string valor);

        Task<int> EliminarAsync(int llave);
    }
}
