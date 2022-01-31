using System;

namespace DIO.Series
{
    public class Series : EntidadeBase
    {
        private Genero Genero{ get; set; }
        private  string Título { get; set; }
        private string Descricao { get; set; }       
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Series(int id, Genero genero, string titulo, string descricao, int ano)
        { 
            this.Id = id;
            this.Genero = genero;
            this.Título = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public Series()
        {
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero ;
            retorno += "Título: " + this.Título ;
            retorno += "Descrição: " + this.Descricao ;
            retorno += "Ano de Início: " + this.Ano;
            return retorno;
        }
        public string retornaTitulo()
        {
            return this.Título;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }

        internal object retornaExcluido()
        {
            throw new NotImplementedException();
        }
    }
}