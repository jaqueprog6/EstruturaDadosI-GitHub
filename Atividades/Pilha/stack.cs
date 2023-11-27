using System;

namespace StackClass { // Espaço de nomes
    public class Stack {
        static readonly int MAX = 1000;
        int top = -1;
        int[] stack = new int[MAX]; // operador de atribuição
        
        // verificar se a pilha está vazia ou não
        bool IsEmpty() { // () = função/método / booleano = true or false
            return(top < 0); // vai retornar booleano pois está na frente da função, função = IsEmpty
        }

        public bool Push(int data) {
            if(top >= MAX) {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top += 1; // top = top +1 / top++ / ++top
            stack[top] = data;
            return true;
        }

        public int Pop() {
            if(top < 0) {
                Console.WriteLine("Stack Underflow");
                return 0;
            }

            int valor = stack[top]; // top-- (decrementar depois) / --top (decrementar antes)
            top -= 1;
            return valor;
        }

        public void Peek() {
            if (top < 0) {
                Console.WriteLine("Stack underflow");
                return;
            }

            Console.WriteLine($"O topo da pilha é: {stack[top]}"); // Está passando um método String para o writeline
        }

        public void PrintStack() {
            if (top < 0) {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine("Itens da pilha: ");
            for(int i = top; i >= 0; i--) {
                string texto = $"Stack[{stack[i]}]";
                Console.WriteLine(texto);
            }
        }
    }
}