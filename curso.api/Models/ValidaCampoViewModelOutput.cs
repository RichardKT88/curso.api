using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models
{
    public class ValidaCampoViewModelOutput
    {
        public ValidaCampoViewModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        }

        public IEnumerable<string> Erros { get; private set; }
    }
}
