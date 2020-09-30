using System;
class analisaCarrinho {
  public static double precoTotal( string[,] produtoIDNome, string id, double[] precos, int quantidade ) {
    double preco = 0;

    for(int i = 0; i<10; i++) {
      if( produtoIDNome[i, 1] == id ) {
        preco = precos[i];
      }
    }
    preco *= quantidade;

  return preco;
  }


}