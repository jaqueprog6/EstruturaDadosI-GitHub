int[] numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; // Recebendo valores

Random random = new Random(); // Desordenar os números
for (int i = 0; i < numbers.Length; i++) { // Inicia a contagem com 0, até que i seja menor que o tamanho do vetor (10), cada vez que rodar acumula 1
    int j = random.Next(i, numbers.Length); // Elemento I vai ser trocado pelo J
    int temp = numbers[i]; // Temp: Armazena temporariamente os números desordenados
    numbers[i] = numbers[j]; // Substituindo os valores do índice I (normais) pelo índice J (desordenados)
    numbers[j] = temp; // J = a variável temporária
}

Console.WriteLine("Valores desordenados:");
foreach (int number in numbers) {
    Console.WriteLine(number);
}

Array.Sort(numbers); // Ordenar os números
Console.WriteLine("Valores ordenados:"); // Imprime os valores ordenados
foreach (int number in numbers) {
    Console.WriteLine(number);
}

// Versão do professor
int[] arr = {800, 11, 50, 771, 649, 770, 240,9 };
for(int i = 0; i < arr.Length; i++) {
    Console.WriteLine($"arr[{i}] = {arr[i]}");
}

Console.WriteLine("ORDENANDO");

for(int i = 0; i < arr.Length - 1; i++) { // compara o I com o J até descobrir o menor número para começar a ordenação
    for(int j = i + 1; j < arr.Length; j++) {
        int aux = arr[j];
        if(arr[i] > arr[j]) {
            arr[j] = arr[i];
            arr[i] = aux;
        }
    }
}

Console.WriteLine("IMPRIMINDO ORDENADO");
for(int i = 0; i < arr.Length; i++) {
    Console.WriteLine($"arr[{i}] = {arr[i]}");
}

int[] arr2 = {800, 11, 50, 771, 649, 770, 240,9 };

Console.WriteLine("IMPRIMINDO ORDENADO arr2");

Array.Sort(arr2);
for(int i = 0; i < arr.Length; i++) {
    Console.WriteLine($"arr2[{i}] = {arr2[i]}");
}   