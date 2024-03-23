namespace Day8
{
    class queue<t>
    {
        t[] arr;
        int front;
        int rear;
        int size;
        public queue(int size)
        {
            arr = new t[size];
            front = -1;
            rear = -1;
            this.size = size;
        }
        public void enqueue(t data)
        {
            if (rear == size - 1)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                if (front == -1)
                {
                    front = 0;
                }
                rear++;
                arr[rear] = data;
            }
        }
        public void dequeue()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Element deleted from queue is : " + arr[front]);
                front++;
                if (front > rear)
                {
                    front = rear = -1;
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing with integers:");
            queue<int> intQueue = new queue<int>(5);

            intQueue.enqueue(10);
            intQueue.enqueue(20);
            intQueue.enqueue(30);

            intQueue.dequeue(); 
            intQueue.dequeue(); 

            intQueue.enqueue(40);
            intQueue.enqueue(50);

            intQueue.dequeue(); 
            intQueue.dequeue(); 
            intQueue.dequeue(); 

            intQueue.dequeue();

            Console.WriteLine("\nTesting with strings:");
            queue<string> stringQueue = new queue<string>(3);

            stringQueue.enqueue("Apple");
            stringQueue.enqueue("Banana");
            stringQueue.enqueue("Orange");

            stringQueue.dequeue(); 
            stringQueue.dequeue(); 

            stringQueue.enqueue("Grapes");
            stringQueue.enqueue("Pineapple");

            stringQueue.dequeue(); 
            stringQueue.dequeue(); 
            stringQueue.dequeue(); 
            stringQueue.dequeue(); 
        }
    }
}
