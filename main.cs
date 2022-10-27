using System;
using System.Linq;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    //Capacidade Atual -----------------------------------------------------
    Console.WriteLine("Insira a capacidade de internação.");
    
    int Cap = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Capacidade apresentada, Pressione qualquer tecla continuar.");

    Servicos meu_petshop;
    meu_petshop = new Servicos(Cap);
    
    Console.ReadKey();
    Console.Clear();
    
    string opcao = "";
    //----------------------------------------------------------------------
    
    //Inicio do Sistema   
    while(opcao != "0" ){
      Console.Clear();
      
      Console.WriteLine("===  BEM VINDO! A PET SHARP   ===");
      Console.WriteLine("----------------------------------");
      Console.WriteLine("0 - Sair.");
      Console.WriteLine("1 - Cadastrar Serviço.");
      Console.WriteLine("2 - Consultar Pet");
      Console.WriteLine("3 - Relatório de Serviços: ");
      Console.WriteLine("------------------------------------");
      
      Console.WriteLine("Informe a opção desejada: ");
      opcao = Console.ReadLine();
      
      switch(opcao){
        case "0":
          return;
        case "1":
          
          Console.Clear();
          
          //Cadastrar Animal e tipo de serviço atribuido a ele
          
          int tipoServ = 0;
  
          Console.WriteLine("===  CADASTRO DO DONO   ===\n");
    
          
          Console.WriteLine("Informe o nome do dono: ");
          string nome = Console.ReadLine();
          
          Console.WriteLine("Informe o sexo: ");
          string sexo = Console.ReadLine();
          
          Console.WriteLine("Informe o CPF do dono: ");
          long cpf = long.Parse(Console.ReadLine());

          Pessoa dono = new Pessoa(nome,sexo,cpf);

          Console.WriteLine("\n--------------------------------------------------------\n");
          
          //Informações do Pet
          Console.WriteLine("===  CADASTRO DO ANIMAL   ===\n");
          
          Console.WriteLine("Informe o nome do animal: ");
          string nom = Console.ReadLine();
          
          Console.WriteLine("Informe a espécie: ");
          string especie = Console.ReadLine();
          
          Console.WriteLine("Informe o peso: ");
          float peso = float.Parse(Console.ReadLine());
          
          Animal ani = new Animal(nom, especie, peso, dono);
 
          Console.WriteLine("\n------------------------------------\n");
          Console.WriteLine("Informe o tipo de serviço: 1-HIGIENE ; 2-INTERNAÇÃO");
          tipoServ = int.Parse(Console.ReadLine());

          if (tipoServ == 1)
          {
            meu_petshop.banho_tosa(ani);
            Console.WriteLine("Animal cadastrado com sucesso. Serviço: Pacote Higiene. Pressione qualquer tecla para continuar.");
          }
          
          else if (tipoServ == 2)
          {
            meu_petshop.InternaAnimal(ani);
            Console.WriteLine("Animal cadastrado com sucesso. Serviço: Internação. Pressione qualquer tecla para continuar.");
          }
          else
          {
            Console.WriteLine("Serviço inválido. Por favor, selecione um dos serviços disponíveis.");
          }

          
          Console.ReadKey();
          Console.Clear();
          break;
          
          
        case "2":     
          Console.Clear();
          Console.WriteLine("===  CONSULTA DE ANIMAL   ===");
          
          List<Animal> l_completa = (meu_petshop.ObterLista()).Concat(meu_petshop.ObterListaB()).ToList(); 
          //https://learn.microsoft.com/pt-br/dotnet/api/system.linq.enumerable.tolist?view=net-6.0
          
          int len = l_completa.Count;

          if (l_completa.Count == 0)
          {
            Console.WriteLine("\nNENHUM ANIMAL CADASTRADO ATÉ O MOMENTO! \n-*- Pressione qualquer tecla para continuar -*-");
            Console.ReadKey();
            Console.Clear();
            break;
          }
          else
          {
            for (int i = 0; i < len; i++)
            {
              Console.WriteLine($"\nAnimal {i+1} - {l_completa[i].ObterNome()}"); 
            }
  
            Console.WriteLine("Insira o número do animal a ser consultado: ");
            int selecionar = int.Parse(Console.ReadLine());
  
            Console.WriteLine($"{l_completa[selecionar-1].ConsultaAnimal()}");
            

            Console.WriteLine("\nInsira qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            break;  
          }
          
          
        
        case "3":
          
          meu_petshop.relatorioPetshop();
          Console.WriteLine("\nRelatório Exibido!, Pressione qualquer tecla para continuar");
          Console.ReadKey();
          
          break;
          
        default:
          Console.WriteLine("Opção Inválida! Pressione qualquer teclar para tentar novamente:");
          Console.ReadKey();
          break; 
      }   
      opcao = "";
    }
  }
}