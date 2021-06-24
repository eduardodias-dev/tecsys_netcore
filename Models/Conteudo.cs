namespace Website_TecSys_NetCore.Models
{
    public class Conteudo
    {
        public int Id{get;set;}
        public string Titulo{get;set;}
        public string Descricao{get;set;}
        
        public int SecaoId{get;set;}
        public Secao Secao{get;set;}
    }
}