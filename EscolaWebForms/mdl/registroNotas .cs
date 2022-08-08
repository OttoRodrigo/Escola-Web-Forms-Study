using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaWebForms.mdl
{
     public class registroNotas
    {
        public int id { get; set; }
        public long aluno { get; set; }
        public int disciplina { get; set; }
        public float nota1 { get; set; }
        public float nota2 { get; set; }
        public float nota3 { get; set; }
        public float nota4 { get; set; }
        public float media { get; set; }
    }
}
