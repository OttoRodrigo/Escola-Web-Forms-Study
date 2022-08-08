using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaWebForms.mdl.gv
{
    public class gvRegistroNotas
    {
        public int id { get; set; }
        public long aluno { get; set; }
        public string nomeAluno { get; set; }
        public string nomeDisciplina { get; set; }
        public float nota1 { get; set; }
        public float nota2 { get; set; }
        public float nota3 { get; set; }
        public float nota4 { get; set; }
        public float media { get; set; }
    }
}
