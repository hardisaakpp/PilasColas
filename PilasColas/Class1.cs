using System;
using System.Collections.Generic;

namespace PilasColas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Pilas
            Stack<int> stack = new Stack<int>();

            // Agregar elementos a la pila
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Eliminar y obtener el elemento superior
            int topElement = stack.Pop();

            // Obtener el elemento superior sin eliminarlo
            int peekedElement = stack.Peek();


            // Colas
            Queue<int> queue = new Queue<int>();

            // Agregar elementos a la cola
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Eliminar y obtener el elemento al principio de la cola
            int frontElement = queue.Dequeue();

            // Obtener el elemento al principio de la cola sin eliminarlo
            int peekedQueueElement = queue.Peek();
        }
    }
}
