using System;

class MainClass {
  public static void Main () {
    // Variável que vai ser usada para tirar os dados randons
    Random random = new Random();
    
    Console.WriteLine("INICIAR COMPRA");
    
    Console.WriteLine("ADICIONE UM PRODUTO");

    Random codigoCompra = new Random();
    
    int codigo =  codigoCompra.Next(10000, 99999);

    
    // Produtos que serão 
    // Chocolate, Cheetos, Coquinha gelada, Pepsi, Calculadora, Garrafa D'agua, caderno, mouse, lixeira, Minecraft
    string[,] produtosNomes = new string[10,2] {
      {"Chocolate",        "4613"},
      {"Cheetos",          "1373"},
      {"Coquinha gelada",  "2235"},
      {"Pepsi",            "4503"},
      {"Calculadora",      "4140"},
      {"Garrafa d'agua",   "4482"},
      {"caderno",          "3368"},
      {"mouse",            "4316"},
      {"lixeira",          "2848"},
      {"Minecraft",        "4818"}
   };
    double[] produtosPrecos = new double[] {
      4.99, 3.99, 5.00, 4.00, 6.50, 2.30, 16.20, 120.00, 32.00, 80.00
    };

    for( int i = 0; i<10; i++ ) {
      Console.Write(produtosNomes[i, 1]);
      Console.WriteLine(" | " + produtosNomes[i, 0]);
    }

    string finalizar;
    string printaCarrinho = "";
    double precoTotal = 0;
    string idProdutoAtual;
    int quantidadeAtual = 0;
    string[] TotalCarrinho= new string[500];
    int Contador= 0;
    int Contador2= 0;
    int teste = 0;
    do {
      Console.WriteLine(" ID DO PRODUTO");
      idProdutoAtual = Console.ReadLine();

      Console.WriteLine("QUANTIDADE DO PRODUTO");
      quantidadeAtual = int.Parse(Console.ReadLine());

      precoTotal += analisaCarrinho.precoTotal(produtosNomes, idProdutoAtual, produtosPrecos, quantidadeAtual);

      Contador+=quantidadeAtual;
     
      for(int i=0; quantidadeAtual>i; i++){ 
        if(TotalCarrinho[i]==null&&i<teste+quantidadeAtual){
            TotalCarrinho[i]= idProdutoAtual;
          }else if(TotalCarrinho[i]!=null){
            teste++;
          }
         Contador2++;
      } 

      Console.WriteLine("FINALIZAR COMPRA?");
      finalizar = Console.ReadLine();
      
      finaldecompra valor = new finaldecompra();
      //TotalCarrinho
      valor.precoeCodigo(TotalCarrinho, finalizar);
      //produtosNomes
      valor.OlharCarrinho(produtosNomes, printaCarrinho);
        
    } while( finalizar != "sim" );
      Console.WriteLine (codigo);
      Console.WriteLine(precoTotal);
  }
} 