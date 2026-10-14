using System;
using System.Collections.Generic;

class Produto
{
    public string Nome;
    public string Categoria;
    public double Preco;
    public int Quantidade;

    public void MostrarProduto()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Categoria: " + Categoria);
        Console.WriteLine("Preco: R$ " + Preco.ToString("F2"));
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Valor total em estoque: R$ " +
            (Preco * Quantidade).ToString("F2"));
    }
}

class Livro
{
    public string Titulo;
    public string Autor;
    public int Ano;
    public string Categoria;
    public bool Disponivel;

    public void MostrarLivro()
    {
        Console.WriteLine("Titulo: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Categoria: " + Categoria);
        Console.WriteLine(Disponivel ? "DISPONIVEL" : "EMPRESTADO");
    }
}

class Funcionario
{
    public string Nome;
    public int Idade;
    public string Cargo;
    public double Salario;
    public string Setor;

    public void Apresentar()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Setor: " + Setor);
        Console.WriteLine("Salario: R$ " + Salario.ToString("F2"));
        Console.WriteLine("Salario anual: R$ " +
            CalcularSalarioAnual().ToString("F2"));
    }

    public double CalcularSalarioAnual()
    {
        return Salario * 12;
    }
}

class Veiculo
{
    public string Marca;
    public string Modelo;
    public int Ano;
    public string Cor;
    public string Placa;

    public void MostrarVeiculo()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Cor: " + Cor);
        Console.WriteLine("Placa: " + Placa);
    }
}

class Filme
{
    public string Titulo;
    public string Genero;
    public int Ano;
    public int Duracao;
    public double Nota;

    public void ExibirInformacoes()
    {
        Console.WriteLine("Titulo: " + Titulo);
        Console.WriteLine("Genero: " + Genero);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Duracao: " + Duracao + " minutos");
        Console.WriteLine("Nota: " + Nota);

        if (Nota >= 8)
            Console.WriteLine("Filme bem avaliado!");
    }
}

class Cliente
{
    public string Nome;
    public int Idade;
    public string Cidade;
    public string Email;
    public string Telefone;

    public void ApresentarCliente()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Cidade: " + Cidade);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Telefone: " + Telefone);
    }
}

class Curso
{
    public string Nome;
    public int CargaHoraria;
    public string Professor;
    public string Modalidade;
    public int QuantidadeVagas;

    public void MostrarCurso()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Carga horaria: " + CargaHoraria + " horas");
        Console.WriteLine("Professor: " + Professor);
        Console.WriteLine("Modalidade: " + Modalidade);
        Console.WriteLine("Vagas disponiveis: " + QuantidadeVagas);
    }
}

class Pedido
{
    public int Numero;
    public string Cliente;
    public string Produto;
    public int Quantidade;
    public double ValorUnitario;

    public double CalcularTotal()
    {
        return Quantidade * ValorUnitario;
    }

    public void MostrarPedido()
    {
        Console.WriteLine("Pedido: " + Numero.ToString("D3"));
        Console.WriteLine("Cliente: " + Cliente);
        Console.WriteLine("Produto: " + Produto);
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Valor unitario: R$ " +
            ValorUnitario.ToString("F2"));
        Console.WriteLine("Total: R$ " + CalcularTotal().ToString("F2"));
    }
}

class Equipamento
{
    public string Patrimonio;
    public string Tipo;
    public string Marca;
    public string Modelo;
    public string NumeroSerie;
    public string Status;

    public void MostrarEquipamento()
    {
        Console.WriteLine("Patrimonio: " + Patrimonio);
        Console.WriteLine("Tipo: " + Tipo);
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Numero de serie: " + NumeroSerie);
        Console.WriteLine("Status: " + Status);
    }
}

// Exercicio 10 - Sistema escolhido: Cadastro de Smartphones
class Smartphone
{
    public string Marca;
    public string Modelo;
    public string Cor;
    public double Preco;
    public int Quantidade;

    public void MostrarSmartphone()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Cor: " + Cor);
        Console.WriteLine("Preco: R$ " + Preco.ToString("F2"));
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Valor total: R$ " +
            (Preco * Quantidade).ToString("F2"));
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Listas para guardar varios objetos de cada classe
        List<Produto> produtos = new List<Produto>();
        List<Livro> livros = new List<Livro>();
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Veiculo> veiculos = new List<Veiculo>();
        List<Filme> filmes = new List<Filme>();
        List<Cliente> clientes = new List<Cliente>();
        List<Curso> cursos = new List<Curso>();
        List<Pedido> pedidos = new List<Pedido>();
        List<Equipamento> equipamentos = new List<Equipamento>();
        List<Smartphone> smartphones = new List<Smartphone>();

        int opcao = -1;

        while (opcao != 0)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("       ATIVIDADE PRATICA 02 - POO");
            Console.WriteLine("========================================");
            Console.WriteLine("1 - Cadastro de Produtos");
            Console.WriteLine("2 - Cadastro de Livros");
            Console.WriteLine("3 - Cadastro de Funcionarios");
            Console.WriteLine("4 - Cadastro de Veiculos");
            Console.WriteLine("5 - Cadastro de Filmes");
            Console.WriteLine("6 - Cadastro de Clientes");
            Console.WriteLine("7 - Cadastro de Cursos");
            Console.WriteLine("8 - Cadastro de Pedidos");
            Console.WriteLine("9 - Cadastro de Equipamentos");
            Console.WriteLine("10 - Cadastro de Smartphones");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("========================================");
            Console.Write("Escolha uma opcao: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = -1;
            }

            Console.Clear();

            switch (opcao)
            {
                // EXERCICIO 01 - PRODUTOS
                case 1:
                    int opProduto = -1;

                    while (opProduto != 3)
                    {
                        Console.WriteLine("\n--- CADASTRO DE PRODUTOS ---");
                        Console.WriteLine("1 - Cadastrar produto");
                        Console.WriteLine("2 - Listar produtos");
                        Console.WriteLine("3 - Voltar");
                        Console.Write("Opcao: ");

                        if (!int.TryParse(Console.ReadLine(), out opProduto))
                            opProduto = -1;

                        if (opProduto == 1)
                        {
                            Produto p = new Produto();

                            Console.Write("Nome: ");
                            p.Nome = Console.ReadLine();

                            Console.Write("Categoria: ");
                            p.Categoria = Console.ReadLine();

                            Console.Write("Preco: ");
                            double.TryParse(Console.ReadLine(), out p.Preco);

                            Console.Write("Quantidade: ");
                            int.TryParse(Console.ReadLine(), out p.Quantidade);

                            produtos.Add(p);
                            Console.WriteLine("Produto cadastrado!");
                        }
                        else if (opProduto == 2)
                        {
                            foreach (Produto p in produtos)
                            {
                                Console.WriteLine("\n--------------------");
                                p.MostrarProduto();
                            }

                            if (produtos.Count == 0)
                                Console.WriteLine("Nenhum produto cadastrado.");
                        }
                    }
                    break;

                // EXERCICIO 02 - LIVROS
                case 2:
                    int opLivro = -1;

                    while (opLivro != 3)
                    {
                        Console.WriteLine("\n--- CADASTRO DE LIVROS ---");
                        Console.WriteLine("1 - Cadastrar livro");
                        Console.WriteLine("2 - Listar livros");
                        Console.WriteLine("3 - Voltar");
                        Console.Write("Opcao: ");

                        if (!int.TryParse(Console.ReadLine(), out opLivro))
                            opLivro = -1;

                        if (opLivro == 1)
                        {
                            Livro l = new Livro();

                            Console.Write("Titulo: ");
                            l.Titulo = Console.ReadLine();

                            Console.Write("Autor: ");
                            l.Autor = Console.ReadLine();

                            Console.Write("Ano: ");
                            int.TryParse(Console.ReadLine(), out l.Ano);

                            Console.Write("Categoria: ");
                            l.Categoria = Console.ReadLine();

                            Console.Write("Disponivel? (true/false): ");
                            bool.TryParse(Console.ReadLine(), out l.Disponivel);

                            livros.Add(l);
                            Console.WriteLine("Livro cadastrado!");
                        }
                        else if (opLivro == 2)
                        {
                            foreach (Livro l in livros)
                            {
                                Console.WriteLine("\n--------------------");
                                l.MostrarLivro();
                            }

                            if (livros.Count == 0)
                                Console.WriteLine("Nenhum livro cadastrado.");
                        }
                    }
                    break;

                // EXERCICIO 03 - FUNCIONARIOS
                case 3:
                    int opFuncionario = -1;

                    while (opFuncionario != 3)
                    {
                        Console.WriteLine("\n--- CADASTRO DE FUNCIONARIOS ---");
                        Console.WriteLine("1 - Cadastrar funcionario");
                        Console.WriteLine("2 - Listar funcionarios");
                        Console.WriteLine("3 - Voltar");
                        Console.Write("Opcao: ");

                        if (!int.TryParse(Console.ReadLine(), out opFuncionario))
                            opFuncionario = -1;

                        if (opFuncionario == 1)
                        {
                            Funcionario f = new Funcionario();

                            Console.Write("Nome: ");
                            f.Nome = Console.ReadLine();

                            Console.Write("Idade: ");
                            int.TryParse(Console.ReadLine(), out f.Idade);

                            Console.Write("Cargo: ");
                            f.Cargo = Console.ReadLine();

                            Console.Write("Salario: ");
                            double.TryParse(Console.ReadLine(), out f.Salario);

                            Console.Write("Setor: ");
                            f.Setor = Console.ReadLine();

                            funcionarios.Add(f);
                            Console.WriteLine("Funcionario cadastrado!");
                        }
                        else if (opFuncionario == 2)
                        {
                            foreach (Funcionario f in funcionarios)
                            {
                                Console.WriteLine("\n--------------------");
                                f.Apresentar();
                            }

                            if (funcionarios.Count == 0)
                                Console.WriteLine("Nenhum funcionario cadastrado.");
                        }
                    }
                    break;

                // EXERCICIO 04 - VEICULOS
                case 4:
                    int opVeiculo = -1;

                    while (opVeiculo != 4)
                    {
                        Console.WriteLine("\n--- CADASTRO DE VEICULOS ---");
                        Console.WriteLine("1 - Cadastrar veiculo");
                        Console.WriteLine("2 - Listar veiculos");
                        Console.WriteLine("3 - Pesquisar veiculo");
                        Console.WriteLine("4 - Voltar");
                        Console.Write("Opcao: ");

                        if (!int.TryParse(Console.ReadLine(), out opVeiculo))
                            opVeiculo = -1;

                        if (opVeiculo == 1)
                        {
                            Veiculo v = new Veiculo();

                            Console.Write("Marca: ");
                            v.Marca = Console.ReadLine();

                            Console.Write("Modelo: ");
                            v.Modelo = Console.ReadLine();

                            Console.Write("Ano: ");
                            int.TryParse(Console.ReadLine(), out v.Ano);

                            Console.Write("Cor: ");
                            v.Cor = Console.ReadLine();

                            Console.Write("Placa: ");
                            v.Placa = Console.ReadLine();

                            veiculos.Add(v);
                            Console.WriteLine("Veiculo cadastrado!");
                        }
                        else if (opVeiculo == 2)
                        {
                            foreach (Veiculo v in veiculos)
                            {
                                Console.WriteLine("\n--------------------");
                                v.MostrarVeiculo();
                            }

                            if (veiculos.Count == 0)
                                Console.WriteLine("Nenhum veiculo cadastrado.");
                        }
                        else if (opVeiculo == 3)
                        {
                            Console.Write("Digite a marca ou modelo: ");
                            string busca = Console.ReadLine();
                            bool encontrou = false;

                            foreach (Veiculo v in veiculos)
                            {
                                if (v.Marca.IndexOf(busca,
                                    StringComparison.OrdinalIgnoreCase) >= 0 ||
                                    v.Modelo.IndexOf(busca,
                                    StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    v.MostrarVeiculo();
                                    encontrou = true;
                                }
                            }

                            if (!encontrou)
                                Console.WriteLine("Veiculo nao encontrado.");
                        }
                    }
                    break;

                // EXERCICIO 05 - FILMES
                case 5:
                    int opFilme = -1;

                    while (opFilme != 3)
                    {
                        Console.WriteLine("\n--- CADASTRO DE FILMES ---");
                        Console.WriteLine("1 - Cadastrar filme");
                        Console.WriteLine("2 - Listar filmes");
                        Console.WriteLine("3 - Voltar");
                        Console.Write("Opcao: ");

                        if (!int.TryParse(Console.ReadLine(), out opFilme))
                            opFilme = -1;

                        if (opFilme == 1)
                        {
                            Filme f = new Filme();

                            Console.Write("Titulo: ");
                            f.Titulo = Console.ReadLine();

                            Console.Write("Genero: ");
                            f.Genero = Console.ReadLine();

                            Console.Write("Ano: ");
                            int.TryParse(Console.ReadLine(), out f.Ano);

                            Console.Write("Duracao em minutos: ");
                            int.TryParse(Console.ReadLine(), out f.Duracao);

                            Console.Write("Nota: ");
                            double.TryParse(Console.ReadLine(), out f.Nota);

                            filmes.Add(f);
                            Console.WriteLine("Filme cadastrado!");
                        }
                        else if (opFilme == 2)
                        {
                            foreach (Filme f in filmes)
                            {
                                Console.WriteLine("\n--------------------");
                                f.ExibirInformacoes();
                            }

                            if (filmes.Count == 0)
                                Console.WriteLine("Nenhum filme cadastrado.");
                        }
                    }
                    break;

                // EXERCICIO 06 - CLIENTES
                case 6:
                    int opCliente = -1;

                    while (opCliente != 4)
                    {
                        Console.WriteLine("\n--- CADASTRO DE CLIENTES ---");
                        Console.WriteLine("1 - Cadastrar cliente");
                        Console.WriteLine("2 - Listar clientes");
                        Console.WriteLine("3 - Pesquisar cliente");
                        Console.WriteLine("4 - Voltar");
                        Console.Write("Opcao: ");

                        if (!int.TryParse(Console.ReadLine(), out opCliente))
                            opCliente = -1;

                        if (opCliente == 1)
                        {
                            Cliente c = new Cliente();

                            Console.Write("Nome: ");
                            c.Nome = Console.ReadLine();

                            Console.Write("Idade: ");
                            int.TryParse(Console.ReadLine(), out c.Idade);

                            Console.Write("Cidade: ");
                            c.Cidade = Console.ReadLine();

                            Console.Write("Email: ");
                            c.Email = Console.ReadLine();

                            Console.Write("Telefone: ");
                            c.Telefone = Console.ReadLine();

                            clientes.Add(c);
                            Console.WriteLine("Cliente cadastrado!");
                        }
                        else if (opCliente == 2)
                        {
                            foreach (Cliente c in clientes)
                            {
                                Console.WriteLine("\n--------------------");
                                c.ApresentarCliente();
                            }

                            if (clientes.Count == 0)
                                Console.WriteLine("Nenhum cliente cadastrado.");
                        }
                        else if (opCliente == 3)
                        {
                            Console.Write("Digite o nome do cliente: ");
                            string busca = Console.ReadLine();
                            bool encontrou = false;

                            foreach (Cliente c in clientes)
                            {
                                if (c.Nome.IndexOf(busca,
                                    StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    c.ApresentarCliente();
                                    encontrou = true;
                                }
                            }

                            if (!encontrou)
                                Console.WriteLine("Cliente nao encontrado.");
                        }
                    }
                    break;

                // EXERCICIO 07 - CURSOS
                case 7:
                    int opCurso = -1;

                    while (opCurso != 4)
                    {
                        Console.WriteLine("\n--- CADASTRO DE CURSOS ---");
                        Console.WriteLine("1 - Cadastrar curso");
                        Console.WriteLine("2 - Listar cursos");
                        Console.WriteLine("3 - Ver cursos com vagas");
                        Console.WriteLine("4 - Voltar");
                        Console.Write("Opcao: ");

                        if (!int.TryParse(Console.ReadLine(), out opCurso))
                            opCurso = -1;

                        if (opCurso == 1)
                        {
                            Curso c = new Curso();

                            Console.Write("Nome: ");
                            c.Nome = Console.ReadLine();

                            Console.Write("Carga horaria: ");
                            int.TryParse(Console.ReadLine(), out c.CargaHoraria);

                            Console.Write("Professor: ");
                            c.Professor = Console.ReadLine();

                            Console.Write("Modalidade: ");
                            c.Modalidade = Console.ReadLine();

                            Console.Write("Quantidade de vagas: ");
                            int.TryParse(Console.ReadLine(), out c.QuantidadeVagas);

                            cursos.Add(c);
                            Console.WriteLine("Curso cadastrado!");
                        }
                        else if (opCurso == 2)
                        {
                            foreach (Curso c in cursos)
                            {
                                Console.WriteLine("\n--------------------");
                                c.MostrarCurso();
                            }

                            if (cursos.Count == 0)
                                Console.WriteLine("Nenhum curso cadastrado.");
                        }
                        else if (opCurso == 3)
                        {
                            bool encontrou = false;

                            foreach (Curso c in cursos)
                            {
                                if (c.QuantidadeVagas > 0)
                                {
                                    c.MostrarCurso();
                                    encontrou = true;
                                    Console.WriteLine("--------------------");
                                }
                            }

                            if (!encontrou)
                                Console.WriteLine("Nenhum curso com vagas disponiveis.");
                        }
                    }
                    break;

                // EXERCICIO 08 - PEDIDOS
                case 8:
                    int opPedido = -1;

                    while (opPedido != 3)
                    {
                        Console.WriteLine("\n--- CADASTRO DE PEDIDOS ---");
                        Console.WriteLine("1 - Cadastrar pedido");
                        Console.WriteLine("2 - Listar pedidos");
                        Console.WriteLine("3 - Voltar");
                        Console.Write("Opcao: ");

                        if (!int.TryParse(Console.ReadLine(), out opPedido))
                            opPedido = -1;

                        if (opPedido == 1)
                        {
                            Pedido p = new Pedido();

                            Console.Write("Numero do pedido: ");
                            int.TryParse(Console.ReadLine(), out p.Numero);

                            Console.Write("Nome do cliente: ");
                            p.Cliente = Console.ReadLine();

                            Console.Write("Produto: ");
                            p.Produto = Console.ReadLine();

                            Console.Write("Quantidade: ");
                            int.TryParse(Console.ReadLine(), out p.Quantidade);

                            Console.Write("Valor unitario: ");
                            double.TryParse(Console.ReadLine(), out p.ValorUnitario);

                            pedidos.Add(p);
                            Console.WriteLine("Pedido cadastrado!");
                        }
                        else if (opPedido == 2)
                        {
                            foreach (Pedido p in pedidos)
                            {
                                Console.WriteLine("\n--------------------");
                                p.MostrarPedido();
                            }

                            if (pedidos.Count == 0)
                                Console.WriteLine("Nenhum pedido cadastrado.");
                        }
                    }
                    break;

                // EXERCICIO 09 - EQUIPAMENTOS
                case 9:
                    int opEquipamento = -1;

                    while (opEquipamento != 5)
                    {
                        Console.WriteLine("\n--- CADASTRO DE EQUIPAMENTOS ---");
                        Console.WriteLine("1 - Cadastrar equipamento");
                        Console.WriteLine("2 - Listar equipamentos");
                        Console.WriteLine("3 - Pesquisar por patrimonio");
                        Console.WriteLine("4 - Equipamentos em manutencao");
                        Console.WriteLine("5 - Voltar");
                        Console.Write("Opcao: ");

                        if (!int.TryParse(Console.ReadLine(), out opEquipamento))
                            opEquipamento = -1;

                        if (opEquipamento == 1)
                        {
                            Equipamento e = new Equipamento();

                            Console.Write("Patrimonio: ");
                            e.Patrimonio = Console.ReadLine();

                            Console.Write("Tipo: ");
                            e.Tipo = Console.ReadLine();

                            Console.Write("Marca: ");
                            e.Marca = Console.ReadLine();

                            Console.Write("Modelo: ");
                            e.Modelo = Console.ReadLine();

                            Console.Write("Numero de serie: ");
                            e.NumeroSerie = Console.ReadLine();

                            Console.Write("Status (Disponivel, Em uso ou Manutencao): ");
                            e.Status = Console.ReadLine();

                            equipamentos.Add(e);
                            Console.WriteLine("Equipamento cadastrado!");
                        }
                        else if (opEquipamento == 2)
                        {
                            foreach (Equipamento e in equipamentos)
                            {
                                Console.WriteLine("\n--------------------");
                                e.MostrarEquipamento();
                            }

                            if (equipamentos.Count == 0)
                                Console.WriteLine("Nenhum equipamento cadastrado.");
                        }
                        else if (opEquipamento == 3)
                        {
                            Console.Write("Digite o patrimonio: ");
                            string busca = Console.ReadLine();
                            bool encontrou = false;

                            foreach (Equipamento e in equipamentos)
                            {
                                if (e.Patrimonio.Equals(busca,
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    e.MostrarEquipamento();
                                    encontrou = true;
                                }
                            }

                            if (!encontrou)
                                Console.WriteLine("Equipamento nao encontrado.");
                        }
                        else if (opEquipamento == 4)
                        {
                            bool encontrou = false;

                            foreach (Equipamento e in equipamentos)
                            {
                                if (e.Status.Equals("Manutencao",
                                    StringComparison.OrdinalIgnoreCase) ||
                                    e.Status.Equals("Manutenção",
                                    StringComparison.OrdinalIgnoreCase))
                                {
                                    e.MostrarEquipamento();
                                    encontrou = true;
                                }
                            }

                            if (!encontrou)
                                Console.WriteLine("Nenhum equipamento em manutencao.");
                        }
                    }
                    break;

                // EXERCICIO 10 - SMARTPHONES
                case 10:
                    int opSmartphone = -1;

                    while (opSmartphone != 4)
                    {
                        Console.WriteLine("\n--- CADASTRO DE SMARTPHONES ---");
                        Console.WriteLine("1 - Cadastrar smartphone");
                        Console.WriteLine("2 - Listar smartphones");
                        Console.WriteLine("3 - Pesquisar por marca ou modelo");
                        Console.WriteLine("4 - Voltar");
                        Console.Write("Opcao: ");

                        if (!int.TryParse(Console.ReadLine(), out opSmartphone))
                            opSmartphone = -1;

                        if (opSmartphone == 1)
                        {
                            Smartphone s = new Smartphone();

                            Console.Write("Marca: ");
                            s.Marca = Console.ReadLine();

                            Console.Write("Modelo: ");
                            s.Modelo = Console.ReadLine();

                            Console.Write("Cor: ");
                            s.Cor = Console.ReadLine();

                            Console.Write("Preco: ");
                            double.TryParse(Console.ReadLine(), out s.Preco);

                            Console.Write("Quantidade: ");
                            int.TryParse(Console.ReadLine(), out s.Quantidade);

                            smartphones.Add(s);
                            Console.WriteLine("Smartphone cadastrado!");
                        }
                        else if (opSmartphone == 2)
                        {
                            foreach (Smartphone s in smartphones)
                            {
                                Console.WriteLine("\n--------------------");
                                s.MostrarSmartphone();
                            }

                            if (smartphones.Count == 0)
                                Console.WriteLine("Nenhum smartphone cadastrado.");
                        }
                        else if (opSmartphone == 3)
                        {
                            Console.Write("Digite a marca ou modelo: ");
                            string busca = Console.ReadLine();
                            bool encontrou = false;

                            foreach (Smartphone s in smartphones)
                            {
                                if (s.Marca.IndexOf(busca,
                                    StringComparison.OrdinalIgnoreCase) >= 0 ||
                                    s.Modelo.IndexOf(busca,
                                    StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    s.MostrarSmartphone();
                                    encontrou = true;
                                }
                            }

                            if (!encontrou)
                                Console.WriteLine("Smartphone nao encontrado.");
                        }
                    }
                    break;

                case 0:
                    Console.WriteLine("Programa encerrado!");
                    break;

                default:
                    Console.WriteLine("Opcao invalida!");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione uma tecla para continuar...");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Pressione uma tecla para finalizar.");
        Console.ReadKey();
    }
}
```
