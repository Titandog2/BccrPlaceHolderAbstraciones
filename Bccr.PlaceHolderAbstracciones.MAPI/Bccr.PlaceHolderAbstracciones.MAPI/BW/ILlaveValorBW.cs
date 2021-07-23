using Bccr.PlaceHolderAbstracciones.MAPI.Contenedores;
using Bccr.PlaceHolderAbstracciones.MAPI.DA;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bccr.PlaceHolderAbstracciones.MAPI.BW
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
