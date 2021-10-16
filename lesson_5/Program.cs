//Поиск в дереве по ширине BFS
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        //Очередь хранит номера вершин
        Queue<int> q = new Queue<int>();
        
        Console.WriteLine("Введите размер массива от 3 до 10:");
        int u = Convert.ToInt32(Console.ReadLine()) - 1;
       
        //Массив отмечает посещённые вершины
        bool[] used = new bool[u + 1]; 
        //Массив содержит смежные вершины
        int[][] g = new int[u + 1][]; 

            for (int i = 0; i < u + 1; i++)
            {
                g[i] = new int[u + 1];
                Console.Write("\n{0} вершина [", i + 1);
                for (int j = 0; j < u + 1; j++)
                {
                    g[i][j] = rand.Next(0, 2);
                }
                g[i][i] = 0;
                foreach (var item in g[i])
                {
                    Console.Write(" {0}", item);
                }
                Console.Write("]\n");

            }

            Console.WriteLine(new string ('*', 100));

            //Массив указывает посещали вершину или нет
            used[u] = true;  
            q.Enqueue(u);
            Console.WriteLine("Начинаем обход с {0} вершины", u + 1);
            while (q.Count != 0)
            {
                u = q.Peek();
                q.Dequeue();
                Console.WriteLine("Перешли к узлу {0}", u + 1);

                for (int i = 0; i < g.Length; i++)
                {
                    if (Convert.ToBoolean(g[u][i]))
                    {
                        if (!used[i])
                        {
                            used[i] = true;
                            q.Enqueue(i);
                            Console.WriteLine("Добавили в очередь узел {0}", i + 1);
                        }
                    }
                }
            }
            
    }
}
