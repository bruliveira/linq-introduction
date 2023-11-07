
namespace linqIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------> LINQ <----------\n");

            // Fontes de dados - listas
            var listaProdutos = new List<Produto>()
            {
            new Produto{Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100},
            new Produto{Id = 8, CategoriaId = 1, Nome = "Geladeira", Status = true, Valor = 10},
            new Produto{Id = 9, CategoriaId = 3, Nome = "Boné", Status = false, Valor = 5},
            new Produto{Id = 10, CategoriaId = 3, Nome = "Melancia", Status = false, Valor = 5},
            new Produto{Id = 4, CategoriaId = 1, Nome = "TV", Status = true, Valor = 45},
            new Produto{Id = 5, CategoriaId = 1, Nome = "Maquina de lavar", Status = true, Valor = 90},
            new Produto{Id = 6, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 55},
            new Produto{Id = 7, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 12},
            new Produto{Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 1},
            new Produto{Id = 3, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 99},
            };
            var listCategorias = new List<Categoria>()
            {
            new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
            new Categoria{Id = 2, Status = true, Nome = "Alimentos"},
            new Categoria{Id = 3, Status = true, Nome = "Vestuario"}
            };

            //Consulta LINQ
            var resultado = from produto in listaProdutos
                            where produto.Valor > 60
                            select produto;

            // Executar consulta
            foreach (var result in resultado)
            {
                Console.WriteLine($"Produto de Id: {result.Id}  \nNome: {result.Nome}  \nValor: R${result.Valor}  \nStatus: {result.Status}  \nCategoria Id:{result.CategoriaId}");
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("\n\n\n");

            #region Algumas consultas testes

            //// 1 - Filtrar por nome
            //var resultadoNome = from produto in listaProdutos
            //                    where produto.Nome.ToLower() == "Arroz".ToLower()
            //                    select produto;
            //foreach (var result in resultadoNome)
            //{
            //    Console.WriteLine($"Produto de Id: {result.Id}  \nNome: {result.Nome}  \nValor: R${result.Valor}  \nStatus: {result.Status}  \nCategoria Id:{result.CategoriaId}");
            //    Console.WriteLine("-------------------------");
            //}



            //// 2 - Filtrar pela Primeira letra do nome
            //var resultadoPrimeiroNome = from produto in listaProdutos
            //                    where produto.Nome.ToLower().Substring(0, 1) == "m".ToLower()
            //                    select produto;
            //foreach (var resultPrimeiro in resultadoPrimeiroNome)
            //{
            //    Console.WriteLine($"Produto de Id: {resultPrimeiro.Id}  \nNome: {resultPrimeiro.Nome}  \nValor: R${resultPrimeiro.Valor}  \nStatus: {resultPrimeiro.Status}  \nCategoria Id:{resultPrimeiro.CategoriaId}");
            //    Console.WriteLine("-------------------------");
            //}



            //// 3 - Filtrar produtos pela primeira letra do nome e status ativo
            //var resultadoPrimeiroNomeStatus = from produto in listaProdutos
            //                            where produto.Nome.ToLower().Substring(0, 1) == "m".ToLower() &&
            //                            produto.Status == true
            //                            select produto;
            //foreach (var resultPrimeiro in resultadoPrimeiroNomeStatus)
            //{
            //    Console.WriteLine($"Produto de Id: {resultPrimeiro.Id}  \nNome: {resultPrimeiro.Nome}  \nValor: R${resultPrimeiro.Valor}  \nStatus: {resultPrimeiro.Status}  \nCategoria Id:{resultPrimeiro.CategoriaId}");
            //    Console.WriteLine("-------------------------");
            //}



            //// 4 - Ordenar pelo id
            //var resultadoPrimeiroNomeStatus = from produto in listaProdutos
            //                                  where produto.Id > 1 && produto.Id < 6
            //                                  orderby produto.Id descending
            //                                  select produto;
            //foreach (var resultPrimeiro in resultadoPrimeiroNomeStatus)
            //{
            //    Console.WriteLine($"Produto de Id: {resultPrimeiro.Id}  \nNome: {resultPrimeiro.Nome}  \nValor: R${resultPrimeiro.Valor}  \nStatus: {resultPrimeiro.Status}  \nCategoria Id:{resultPrimeiro.CategoriaId}");
            //    Console.WriteLine("-------------------------");
            //}

            #endregion


        }
    }

    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
    }
    class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }

    }
}