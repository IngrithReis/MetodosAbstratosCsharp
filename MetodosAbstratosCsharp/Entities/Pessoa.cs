namespace MetodosAbstratosCsharp.Entities
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }

        public double RendaAnual { get; set; }

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double ValorPago();
        
    }
}
