namespace MetodosAbstratosCsharp.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int funcionarios) : base(nome, rendaAnual)
        {
            Funcionarios = funcionarios;
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public override double ValorPago()
        {
            double valor = 0;

            if (Funcionarios < 10)
            {
                valor = RendaAnual * 0.16;         
            }
            else 
            {
                valor = RendaAnual * 0.14;
                
            }
            return valor;
        }
    }
}
