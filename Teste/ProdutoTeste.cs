namespace Teste

/*
    Eu como almoxarife preciso cadastrar produtos para que sejam 
   consumidos pelos funcionarios da empresa

   Critérios de aceite:
   - Check: Um novo produto deve ter obrigatoriamente um codigo único, nome, saldo 0, custo 0, unidade de medida.
   - As unidades de medidas são: PC, KG, MT, GR, LT, CX.
   - Um produto PODE ter uma descrição.
   - Um produto pode ter um codigo de barras.
    */
{
    public class ProdutoTeste
    {
        //Propriedades.

        private int _codigo;
        private string _nome, _medida;
        private float _saldo, _custo;

        //Metodo construtor.
        
        public ProdutoTeste()
        {
            _codigo = 1;
            _nome = "Mouse";
            _medida = "PC";
            _saldo = 0;
            _custo = 0;
        }

        public class Produto
        {
            public int Codigo { get; }
            public string Nome { get; }
            public string Medida { get; }
            public float Saldo { get; }
            public float Custo { get; }
            public Produto(int codigo, string nome, string medida, float saldo, float custo)
            {
                Codigo = codigo;
                Nome = nome;
                Medida = medida;
                Saldo = saldo;
                Custo = custo;
            }
        }

        [Fact] // Theory: Repede e pede o teste com parametros, diferente de Fact que roda apenas uma vez
        public void CriarObjeto()
        {
            //Arrange: crio as variaveis.

            //Act: criamos o objeto.

            Produto prod = new Produto(_codigo, _nome, _medida, _saldo, _custo);

            //Assert: verifico se ele foi criado.

            Assert.Equal(_codigo, prod.Codigo);
            Assert.Equal(_nome, prod.Nome);
            Assert.Equal(_medida, prod.Medida);
            Assert.Equal(_saldo, prod.Saldo);
            Assert.Equal(_custo, prod.Custo); 

        }
    }
}