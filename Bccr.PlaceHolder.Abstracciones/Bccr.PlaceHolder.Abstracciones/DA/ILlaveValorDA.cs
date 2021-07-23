using Bccr.PlaceHolder.Abstracciones.Contenedores;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bccr.PlaceHolder.Abstracciones.DA
{
    public interface ILlaveValorDA
    {
        Task<IEnumerable<LlaveValor>> ObtenerTodosAsyn();

        Task<string> ObtenerPorLlaveAsync(int llave);

        Task<int> AgregarAsync(string valor);

        Task<int> EditarAsync(int llave, string valor);

        Task<int> EliminarAsync(int llave);
    }
}
