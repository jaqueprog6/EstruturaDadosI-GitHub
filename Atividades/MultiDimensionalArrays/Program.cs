int [ , ] biNumbers = new int[5,2]; // vetor, criar instância de 5 linhas e 2 colunas

int[ , , ] triNumbers = new int[5,4,3]; // linha, coluna, profundidade

int[,] loadedBiNumbers = new int[,] {
    {  9,   5,  8},
    { 10, -11,  4},
    {101,  54, -9}
};

for(int i = 0; i < loadedBiNumbers.GetLength(0); i++) { // linha i
    for(int j = 0; j < loadedBiNumbers.GetLength(1); j++) { // coluna j
        Console.Write($"[{loadedBiNumbers[i,j]}]"); // deixar eles bonitinho // Write: imprimir corrido, um ao lado do outro // $ = string, agrupar os caracteres nos []
    }
    Console.WriteLine(""); // Writeline: 
}