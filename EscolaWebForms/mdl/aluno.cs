using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaWebForms.mdl
{
    public class aluno
    {
        
        public long cpf { get; set; }
       
        public string nome { get; set; }
        
        public int cep { get; set; }
       
        public int numero { get; set; }
       
        public string complemento { get; set; }
    }
}
