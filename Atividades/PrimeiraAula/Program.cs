int[] numbers; // tem colchete [], é vetor
numbers = new int[5]; // numbers recebeu o valor 5, só pode por 5 posições
// o último índice do vetor vai ser sempre o total dele -1

numbers[0] = 9; //valor recebido na posição 0
numbers[1] = -11; //valor recebido na posição 1
numbers[2] = 5; //valor recebido na posição 2
numbers[3] = 7; //valor recebido na posição 3
numbers[4] = -4; //valor recebido na posição 4
//numbers[5] = 8; ERRO! FORA DOS LIMITES

int[] numbers2 = new int[] {9, -11, 5, 7, -4}; //atribuindo o que está do lado direito para o lado esquerdo (new int para int)

int[] numbers3 = {9, -11, 5, 7, -4};

//As três formas acima tem o mesmo resultado

// três tipos de variáveis: contador(quantas vezes), acumulador(coisas que acumulam enquanto o vetor roda) e flag(em que momento deve ser interrompido)

for(int i = 0; i < numbers.Length; i++) { //Inicia a contagem com 0, até que i seja menor que o tamanho do vetor (5), cada vez que rodar acumula 1
    Console.WriteLine(numbers[i]); //vai imprimit as 5 casas (0 a 4)
}