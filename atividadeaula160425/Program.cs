using atividadeaula160425;


//Criar lista para armazenar o que o usuário quiser guadar
List<Livro> livros = new();
List<DVD> dvds = new();
List<CD> cds = new();
List<Revista> revistas = new();

//while: enquanto não der a opção de sair ele estará em execução
while (true)
{
    Console.WriteLine("Nome: Saulo Liers dos Santos   RA:G938542\"");
    Console.WriteLine("\nMenu Principal:");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Exibir");
    Console.WriteLine("0 - Sair");
    string opcaoPrincipal = Console.ReadLine() ?? "";

    //switc case: vai dar opção para realizar uma determinada atividade
    //escolhinda sem que a outra seja afetada 
    switch (opcaoPrincipal)
    {
        case "1":
            bool continuarCadastro = true;

            while (continuarCadastro)
            {
                //Clear(): realiza a limpeza da tela
                Console.Clear();
                Console.WriteLine("\nEscolha o tipo de item para cadastrar:");
                Console.WriteLine("1 - Livro");
                Console.WriteLine("2 - DVD");
                Console.WriteLine("3 - CD");
                Console.WriteLine("4 - Revista");
                Console.WriteLine("0 - Voltar ao menu principal");
                string opcaoCadastro = Console.ReadLine() ?? "";

                //foi criado um switch dentro do outro por organização
                switch (opcaoCadastro)
                {
                    //cadastro dos livros e seus atributos
                    case "1":
                        Livro livro = new Livro();
                        Console.Write("Nome: ");
                        livro.SetNome(Console.ReadLine() ?? "");
                        Console.Write("Código: ");
                        livro.SetCodigo(int.Parse(Console.ReadLine() ?? "0"));
                        Console.Write("Data de aquisição (dd/MM/yyyy): ");
                        livro.SetAquisicao(Console.ReadLine() ?? "");
                        Console.Write("Autores: ");
                        livro.SetAutores(Console.ReadLine());
                        Console.Write("Editora: ");
                        livro.SetEditora(Console.ReadLine() ?? "");
                        Console.Write("Ano de publicação: ");
                        livro.SetAnoPublicacao(Console.ReadLine() ?? "");
                        Console.Write("INBS: ");
                        livro.SetINBS(long.Parse(Console.ReadLine() ?? "0"));
                        livros.Add(livro);
                        break;

                    //cadastro dos DVDs e seus atributos atraves de set
                    case "2":
                        DVD dvd = new DVD();
                        Console.Write("Nome: ");
                        dvd.SetNome(Console.ReadLine() ?? "");
                        Console.Write("Código: ");
                        dvd.SetCodigo(int.Parse(Console.ReadLine() ?? "0"));
                        Console.Write("Data de aquisição (dd/MM/yyyy): ");
                        dvd.SetAquisicao(Console.ReadLine() ?? "");
                        Console.Write("Descrição geral: ");
                        dvd.SetDescricaoGeral(Console.ReadLine() ?? "");
                        Console.Write("Tipo: ");
                        dvd.SetTipo(Console.ReadLine() ?? "");
                        dvds.Add(dvd);
                        break;

                        //cadastro dos  CDs e seus atributos atraves de set
                    case "3":
                        CD cd = new CD();
                        Console.Write("Nome: ");
                        cd.SetNome(Console.ReadLine() ?? "");
                        Console.Write("Código: ");
                        cd.SetCodigo(int.Parse(Console.ReadLine() ?? "0"));
                        Console.Write("Data de aquisição (dd/MM/yyyy): ");
                        cd.SetAquisicao(Console.ReadLine() ?? "");
                        Console.Write("Gênero: ");
                        cd.SetGenero(Console.ReadLine() ?? "");
                        Console.Write("Faixa: ");
                        cd.SetFaixa(Console.ReadLine() ?? "");
                        cds.Add(cd);
                        break;

                        //cadastro das revistas e seus atributos atraves de set
                    case "4":
                        Revista revista = new Revista();
                        Console.Write("Nome: ");
                        revista.SetNome(Console.ReadLine() ?? "");
                        Console.Write("Código: ");
                        revista.SetCodigo(int.Parse(Console.ReadLine() ?? "0"));
                        Console.Write("Data de aquisição (dd/MM/yyyy): ");
                        revista.SetAquisicao(Console.ReadLine() ?? "");
                        Console.Write("Autores: ");
                        revista.SetAutores(Console.ReadLine() ?? "");
                        Console.Write("Editora: ");
                        revista.SetEditora(Console.ReadLine() ?? "");
                        Console.Write("Ano de publicação: ");
                        revista.SetAnoPublicacao(Console.ReadLine() ?? "");
                        Console.Write("Volume: ");
                        revista.SetVolume(Console.ReadLine() ?? "");
                        Console.Write("Principais assuntos: ");
                        revista.SetPrincipaisAssuntos(Console.ReadLine() ?? "");
                        revistas.Add(revista);
                        break;

                    case "0":
                        continuarCadastro = false;
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                
                //apos o cadastro de um item pergunto se quer continar, se quiser cadastra outro item se não volta ao menu principal
                if (opcaoCadastro != "0")
                {
                    Console.WriteLine("\nDeseja cadastrar outro item? (s/n)");
                    string resposta = Console.ReadLine() ?? "";
                    if (resposta.ToLower() != "s")
                    {
                        continuarCadastro = false;
                        Console.Clear();
                    }
                }
            }
            break;

        case "2"://vai listar os produtos cadastrados
            Console.Clear();
            Console.WriteLine("\n--- LIVROS ---");
            foreach (var l in livros)
            {
                Console.WriteLine($"Nome: {l.GetNome()}, Código: {l.GetCodigo()}, Data: {l.GetAquisicao():dd/MM/yyyy}, Autores: {l.GetAutores()}, Editora: {l.GetEditora()}, Ano: {l.GetAnoPublicacao()}, INBS: {l.GetINBS()}");
            }

            Console.WriteLine("\n--- DVDS ---");
            foreach (var d in dvds)
            {
                Console.WriteLine($"Nome: {d.GetNome()}, Código: {d.GetCodigo()}, Data: {d.GetAquisicao():dd/MM/yyyy}," +
                    $" Descrição: {d.GetDescricaoGeral()}, Tipo: {d.GetTipo()}");
            }

            Console.WriteLine("\n--- CDS ---");
            foreach (var c in cds)
            {
                Console.WriteLine($"Nome: {c.GetNome()}, Código: {c.GetCodigo()}, Data: {c.GetAquisicao():dd/MM/yyyy}," +
                    $" Gênero: {c.GetGenero()}, Faixa: {c.GetFaixa()}");
            }

            Console.WriteLine("\n--- REVISTAS ---");
            foreach (var r in revistas)
            {
                Console.WriteLine($"Nome: {r.GetNome()}, Código: {r.GetCodigo()}, Data: {r.GetAquisicao():dd/MM/yyyy}," +
                    $" Autores: {r.GetAutores()}, Editora: {r.GetEditora()}, Ano: {r.GetAnoPublicacao()}, Volume: {r.GetVolume()}, Assuntos: {r.GetPrincipaisAssuntos()}");
            }
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para continuar");
            Console.ReadLine();
            Console.Clear();
            break;

        case "0":
            Console.WriteLine("Saindo...");
            return;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}


