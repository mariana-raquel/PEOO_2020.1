using System;
  class MainClass {
    public static void Main(string[] args) {
      Compromisso a1 = new Compromisso();
      a1.Assunto = "Aniversário de Mariana";
      a1.Local = "Casa dela";
      a1.Data = DateTime.Parse("07-13-21 09:45");

      Compromisso a2 = new Compromisso();
      a2.Assunto = "Aniversário de Adriana";
      a2.Local = "Casa dela";
      a2.Data = DateTime.Parse("10-22-21");

      Compromisso a3 = new Compromisso();
      a3.Assunto = "Aniversário de Terezinha";
      a3.Local = "Casa dela";
      a3.Data = DateTime.Parse("03-24-21");

      Agenda a = new Agenda();
      a.Inserir(a1);
      a.Inserir(a2);
      a.Inserir(a3);
      
      foreach (Compromisso m in a.Listar()) {
        if (m != null) {
          Console.WriteLine(m);
        }
      }

      a.Excluir(a2);

      foreach (Compromisso m in a.Listar()) {
        if (m != null) {
          Console.WriteLine(m);
        }
      }
    }
  }
  class Compromisso {
    public string Assunto { get; set; }
    public string Local { get; set; }
    public DateTime Data  { get; set; }
    public override string ToString() {
      return $"Assunto: {Assunto} - Data: {Data:dd/MM/yyyy} - Local:{Local}";
    }
  }
  class Agenda {
    private Compromisso[] comp = new Compromisso[20];
    private int k;
    public int Qtd {
      get { return k; }
    }
    public void Inserir(Compromisso c) {
      if (k < 20) {
        comp[k] = c;
        k++;
      }
    }
    public void Excluir(Compromisso c) {
      c = null;
      //for (int i = 0; i <= comp.Length; i--) {
      //  comp[i] = comp[i+1];
      //}
    }
    public Compromisso[] Listar() {
      return comp;
    }
    //public Compromisso[] Pesquisar(int mes, int ano) {
      
    //}

  }