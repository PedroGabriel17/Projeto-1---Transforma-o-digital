using System;
class finaldecompra {
  public void precoeCodigo ( string[] TotalCarrinho, string finalizar ) {

   if (finalizar=="carrinho"){
        for(int i=0; TotalCarrinho.Length>i; i++){ 
          if(TotalCarrinho[i]!= null) {
            Console.WriteLine (TotalCarrinho[i]);
          }
        }
      }
  }

  public void OlharCarrinho (string[,] produtosNomes, string printaCarrinho ){
    if( printaCarrinho == "carrinho" ) {
        for( int i = 0; i<10; i++ ) {
          Console.Write(produtosNomes[i, 1]);
          Console.WriteLine(" | " + produtosNomes[i, 0]);
        }
      }
  }

}