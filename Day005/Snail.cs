using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N ? ");
            int n= int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];
            int x = 0, y = 0, cnt = 1,m=n;
            while (true)
            {
                if (cnt == n * n +1)
                    break;
                for (; y < m; y++)
                {
                    arr[x, y] = cnt;
                    if (cnt == n * n+1)
                        break;
                    cnt++;
                }
                if (cnt == n * n + 1)
                    break;
                y--; cnt--;
                for (; x < m; x++)
                {
                    arr[x, y] = cnt;
                    if (cnt == n * n + 1)
                        break;
                    cnt++;
                }
                if (cnt == n * n + 1)
                    break;
                x--; cnt--;
                for (; y > (n - m); y--)
                {
                    arr[x, y] = cnt;
                    if (cnt == n * n + 1)
                        break;
                    cnt++;
                }
                if (cnt == n * n + 1)
                    break;
                for (; x > (n - m); x--)
                {
                    arr[x, y] = cnt;
                    if (cnt == n * n + 1)
                        break;
                    cnt++;
                }
                if (cnt== n * n + 1)
                    break;
                m--;y++;x++;
            }
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.Write($"{arr[i,j],-1}");
                }
                Console.WriteLine();
            }

        }
    }
}
