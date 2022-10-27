using System.Collections.Generic;

class Animal
  {
    private string nome;
    private string especie;
    private float peso;
    private Pessoa dono;


    public Animal()
    {
      List<Animal> animais = new List<Animal>();
    }

    public Animal(string n, string e, float p, Pessoa pess)
    {
      this.nome = n;
      this.especie = e;
      SetPeso(p);
      this.dono = pess;

    }
  
    public void SetPeso(float pe)
    {
      if (pe > 0f)
      {
        peso = pe;
      }
    }

    public float ObterPeso()
    {
      return peso;
    }

    public string ObterNome()
    {
      return nome;
    }

    public string ObterEspecie()
    {
      return especie;
    }
    
    public string ConsultaAnimal()
      {
        return $"\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\nInformações do animal ---> Nome: {ObterNome()} ; Especie: {ObterEspecie()} ; Peso: {ObterPeso()}Kg \nInformações do dono ---> Dono: {dono.ObterNome()} ; Sexo: {dono.ObterSexo()} ; CPF: {dono.ObterCpf()}\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-";
      }
  }