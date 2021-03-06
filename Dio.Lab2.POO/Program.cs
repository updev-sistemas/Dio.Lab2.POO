using Dio.Lab2.POO.Domain;
using Dio.Lab2.POO.Infrastructure;
using Dio.Lab2.POO.Views;

namespace Dio.Lab2.POO
{
    public class Program
    {
        private static IUnitOfWork? db;


        private static void Initializer(string[] args)
        {
            db = new UnitOfWork();

            if(args.Length > 0)
            {
                try
                {
                    foreach (var arg in args)
                    {
                        if (arg.Contains(':'))
                        {
                            string[]? listCategories = args.Where(x => x.Contains("category")).FirstOrDefault(string.Empty).Split(':').ElementAt(1).Split('\u002C');

                            if (listCategories.Length > 0)
                            {
                                foreach (var category in listCategories)
                                {
                                    db.Category.Save(new CategoryEntity
                                    {
                                        Name = category
                                    });
                                }
                            }
                        }
                    }
                }
                catch
                {
#if DEBUG
                    Console.WriteLine("Não foi possível inicializar o banco de dados.");
#endif
                }
            }
 
        }


        private static void MenuPrint()
        {
            Console.WriteLine("+-----------------------------------------+");
            Console.WriteLine("| (1) Adicionar Categorias                |");
            Console.WriteLine("| (2) Listar Categorias                   |");
            Console.WriteLine("| (3) Editar Categorias                   |");
            Console.WriteLine("| (4) Visualizar Categorias               |");
            Console.WriteLine("| (5) Adicionar Filme                     |");
            Console.WriteLine("| (6) Editar Filme                        |");
            Console.WriteLine("| (7) Listar Filmes                       |");
            Console.WriteLine("| (0) Sair                                |");
            Console.WriteLine("+-----------------------------------------+");
        }


        // Em debug, passar como argumento: category:Categoria 1, Categoria 2, Categoria 3, Categoria 4
        public static void Main(string[] args)
        {
            Initializer(args);


            int optionSelected;

            do
            {
                MenuPrint();
                string input = Console.ReadLine();
                bool hasConverted = int.TryParse(input, out optionSelected);

                if(!hasConverted)
                    optionSelected = -1;

                switch(optionSelected)
                {
                    case 0:
                        {
                            Console.WriteLine("Obrigado por utilizar nossos serviços.");
                        } break;
                    case 1:
                        {

                        }
                        break;
                    case 2:
                        {

                        }
                        break;
                    case 3:
                        {

                        }
                        break;
                    case 4:
                        {

                        }
                        break;
                    case 5:
                        {

                        }
                        break;
                    case 6:
                        {

                        }
                        break;
                    case 7:
                        {

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Você digitou uma entrada incorreta, tente novamente.");
                        }break;
                }

            } while (optionSelected != 0);
        }
    }
}

