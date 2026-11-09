namespace ThreadpoolExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(MyMethod));
            Thread.Sleep(100);
        }

        public static void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            string message = $"Background: {thread.IsBackground}" +
                $"Thread Pool: {thread.IsThreadPoolThread}" +
                $"Thread ID: {thread.ManagedThreadId}";
            Console.WriteLine(message);
        }
    }
}
