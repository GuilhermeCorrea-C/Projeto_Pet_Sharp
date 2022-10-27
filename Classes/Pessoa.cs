class Pessoa
{
  private string nome;
  private string sexo;
  private long CPF;

  public Pessoa()
  {
    nome = "Não informado.";
    sexo = "Não informado.";
    CPF = 0;
  }

  public Pessoa(string n, string s, long c)
  {
    nome = n;
    SetSexo(s);
    CPF = c;
  }

  public void SetSexo(string sex)
  {
    if (sex == "F" || sex == "f")
    {
      sexo = "Feminino";
    }
    else if (sex == "M" || sex == "m")
    {
      sexo = "Masculino";
    }
    else
    {
      sexo = "Outro";
    }
  }

  public string ObterSexo()
  {
    return sexo;
  
  }
   public string ObterNome()
  {
    return nome;
  }

  public long ObterCpf()
  {
    return CPF;
  }

} 