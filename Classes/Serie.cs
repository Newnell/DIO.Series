namespace DIO.Series
{
    public class Serie : EntidadeBase //Herda da Classe abstrata EntidadeBase
    {
        //Atributos
        private Genero Genero { get; set;}
        private string Titulo { get; set;}
        private string Descricao { get; set;}
        private int Ano { get; set;}
        private bool Excluido { get; set;}

        //Método de constructor
        public Serie(int Id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = Id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        //Método ToString
        public override string ToString()
        {
            string retorno = "";            
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }

        //Métodos de encapsulamento
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        //Método Exclui para marcar ítens como excluídos (sem excluir os mesmos do BD)

        public void Excluir()
        {
            this.Excluido = true;
        }
    }    
}