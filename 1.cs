using System;

class exercicio1 
{
    
  static void Main() 
    {
      
    int INDICE = 13, SOMA = 0, K = 0;
    
    while(K < INDICE)
    {
        K++;
        SOMA = SOMA + K;
    }
    
    Console.WriteLine(SOMA);
    }
}