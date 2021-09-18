namespace MetodosAbstratosCsharp.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude;
            Nome = nome;
            RendaAnual = rendaAnual;
            
        }

        public override double ValorPago()
        {
            double valor = 0;
            
            if(RendaAnual < 20000)
            {
                valor = RendaAnual * 0.15;

                if(GastosSaude != 0)
                {
                    valor -= GastosSaude * 0.5;
                }
            }
            else // renda anual acima de 20000
            {
                valor = RendaAnual * 0.25;
                if (GastosSaude != 0)
                {
                    valor -= GastosSaude * 0.5;
                }
            }


            return valor;
        }
    }
}
