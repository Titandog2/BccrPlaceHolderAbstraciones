using System;
using System.Collections.Generic;
using System.Text;
using Bccr.WebApi.ManejoDeExcepciones.Abstracciones;
using Microsoft.Extensions.Logging;

namespace Bccr.PlaceHolder.Abstracciones.API.Contenedores
{
    public class LlaveValorException : BccrBaseException
    {
        public LlaveValorException() : base(LogLevel.Error, String.Empty) { }
        public LlaveValorException(string message) : base(LogLevel.Error, message) { }
        public LlaveValorException(LogLevel severidad, string message) : base(severidad, message) { }
    }
}
