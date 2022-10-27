using System;
using System.Collections.Generic;

class Servicos
{
  private int CapInternacao;
  private List<Animal> higiene;
  private List<Animal> internados;


  public Servicos(int Ca)
  {
    CapInternacao = Ca;
    higiene = new List<Animal> () ;
    internados = new List <Animal> () ;
  }

  public int ObterCap()
  {
    return CapInternacao;
  }

  public List<Animal> ObterLista() 
  {
    return internados;
  }

    public List<Animal> ObterListaB() 
  {
    return higiene;
  }

  
  public void banho_tosa(Animal a)
  {
    higiene.Add(a);
  }

  public void InternaAnimal(Animal a)
  {
    if (internados.Count < CapInternacao)
    {
      internados.Add(a);
    }
    else{
      Console.WriteLine("OCUPAÇÃO MÁXIMA ATINGIDA!!");
    }
  }
//Relatório de Faturamento
  public void relatorioPetshop(){

    Console.WriteLine("                                               ");
    Console.WriteLine("------------RELATÓRIO GERENCIAL----------------");   
    Console.WriteLine("                                               ");
    Console.WriteLine("---------------HIGIENIZAÇÃO-------------------");
    
    for(int h = 0; h < ObterListaB().Count; h ++){
      Animal hig = higiene[h];
      Console.WriteLine($"Animais: {hig.ObterNome()}   ");
    }
    
    float vlr_hig = ObterListaB().Count * 60f;

    Console.WriteLine($"Valor da Higiene é de R$ 60,00, Gerando um Total: R$ {vlr_hig}");

    Console.WriteLine("-----------------INTERNAÇÃO--------------------");
    
    for(int i = 0; i < ObterLista().Count; i ++){
      Animal x = internados[i];
      Console.WriteLine($"Animais: {x.ObterNome()}   ");
    }
    float vlr_intena = ObterLista().Count * 400f;

    Console.WriteLine($"Valor da Internação é de R$ 400,00, Gerando um Total: R$ {vlr_intena}");
  
    float vlr_Total = vlr_hig + vlr_intena;
    
    Console.WriteLine("-----------------FATURAMENTO--------------------");
    
    Console.WriteLine($"Valor da receita de Internação e Higienização é de: R$ {vlr_Total}");
    
  }
}