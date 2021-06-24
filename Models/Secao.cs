using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Website_TecSys_NetCore.Models
{
    public class Secao
    {
        public int Id{get;set;}

        [Required]
        public string Nome{get;set;}

        public string Descricao{get;set;}

        public List<Conteudo> Conteudos{get;set;}
    }
}