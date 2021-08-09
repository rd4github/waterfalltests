using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintToDos
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DownloadFromUrl jsondownload = new DownloadFromUrl())
            {
                jsondownload.DownloadAndPrintJson($"https://jsonplaceholder.typicode.com/todos");
            }
            Console.Read();
        }
    }
}
