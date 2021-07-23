using Bccr.PlaceHolder.Abstracciones.MAPI.Contenedores;
using Bccr.PlaceHolder.Abstracciones.MAPI.DA;
using Bccr.PlaceHolder.Abstracciones.MAPI.SG;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bccr.PlaceHolder.Abstracciones.MAPI.BW
{
    public interface ILlaveValorBW
    {
        ILlaveValorDA LlaveValorDA { get; set; }

        Task<IEnumerable<LlaveValor>> ObtenerTodosAsyn();

        Task<string> ObtenerPorLlaveAsync(int llave);

        Task<int> AgregarAsync(string valor);

        Task<int> EditarAsync(int llave, string valor);

        Task<int> EliminarAsync(int llave);
    }
}
