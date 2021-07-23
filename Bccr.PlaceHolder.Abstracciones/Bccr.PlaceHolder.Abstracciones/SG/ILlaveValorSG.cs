using Bccr.PlaceHolder.Abstracciones.Contenedores;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bccr.PlaceHolder.Abstracciones.SG
{
    public interface ILlaveValorSG
    {
        Task<IEnumerable<LlaveValor>> ObtenerTodosAsync();
        Task<string> ObtenerValorPorLlaveAsync(int llave);
        Task<IEnumerable<LlaveValor>> ObtenerObjetoPorLlaveAsync(int llave);
        Task<int> AgregarAsync(string valor);
        Task<int> EditarAsync(int llave, string valor);
        Task<int> EliminarAsync(int llave);
    }
}
