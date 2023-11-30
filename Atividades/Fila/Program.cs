// Adicionar, excluir, ver o primeiro, ver todos, verificar se contém um elemento, limpar 

using System.Collections;

Queue fila = new Queue();
bool sair = false;


while(sair == false){
    Console.Clear();

    Console.WriteLine("Por favor, selecione uma opção.");
	Console.WriteLine("1 - Inserir elemento na fila");
	Console.WriteLine("2 - Remover elemento da fila");
	Console.WriteLine("3 - Verificar qual elemento está à frente da fila");
	Console.WriteLine("4 - Imprimir todo o conteúdo da fila");
	Console.WriteLine("5 - Verificar se a fila contém determinado elemento");
    Console.WriteLine("6 - Limpar a fila");
    Console.WriteLine("7 - Sair");

    
    String opcao = Console.ReadLine()!;
    try{
        switch(opcao){
            case "1":
                Console.WriteLine("Digite o elemento a ser inserido: ");
                fila.Enqueue(Console.ReadLine());
                break;
            case "2":
                Console.WriteLine($"O elemento {fila.Dequeue} foi removido.");
                Thread.Sleep(2500);
                break;
            case "3":
                Console.WriteLine($"O elemento {fila.Peek()} está à frente da fila.");
                Thread.Sleep(2500);
                break;
            case "4":
                Console.Clear();
                foreach(object obj in fila){
                    Console.WriteLine("{0}", obj);
                }
                Thread.Sleep(2500);
                break;
            case "5":
                Console.Clear();
                Console.WriteLine("Digite o elemento a ser procurado na fila.");
                bool resultado = fila.Contains(Console.ReadLine());
                if(resultado){
                    Console.WriteLine("A fila contém o elemento citado.");
                }else{
                    Console.WriteLine("O elemento citado não está na fila.");
                }
                Thread.Sleep(2500);
                break;
            case "6":
                fila.Clear();
                Console.WriteLine("Todos os elementos da fila foram excluídos.");
                Thread.Sleep(2500);
                break;
            case "7":
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                Thread.Sleep(2500);
                break;
        }
    }catch(IOException ioex){
        Console.WriteLine("A fila está vazia. Por favor, preencha-a.");
        Console.WriteLine($"Mensagem de erro: {ioex.Message}");
        Thread.Sleep(2500);
    }
}

