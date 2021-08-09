using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PrintToDos
{
    public class DownloadFromUrl : IDisposable
    {
        WebClient wc;
        Dictionary<int, List<ToDo>> userToDos;
        bool disposed = false;
        public DownloadFromUrl()
        {
            userToDos = new Dictionary<int, List<ToDo>>();
            wc = new WebClient();
            wc.DownloadStringCompleted += OnDownloadStringCompleted;
        }

        private void OnDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if(e.Error != null)
            {
                Console.WriteLine($"Error downloading json: {e.Error.Message}");
            }
            else if(e.Result !=null)
            {
                try {
                    var result = e.Result.Replace('\n', ' '); ;
                    JArray alltodos = JsonConvert.DeserializeObject(result) as JArray;
                    foreach (var todo in alltodos.Children<JObject>())
                    {
                        ToDo item = JsonConvert.DeserializeObject<ToDo>(todo.ToString());

                        if (!userToDos.ContainsKey(item.userId)) userToDos[item.userId] = new List<ToDo>();
                        userToDos[item.userId].Add(item);
                    }
                    PrintJson();
                }
                catch(Exception exception)
                {
                    Console.WriteLine($"Failed to download and parse json. {exception.Message}");
                }

            }
        }

        private void PrintJson()
        {
            Console.WriteLine($"******* TOTAL USERS :{userToDos.Count} **********");

            foreach (KeyValuePair<int, List<ToDo>> todoitem in userToDos)
            {
                Console.WriteLine($"### User {todoitem.Key} has {todoitem.Value.Count} todo items");

                foreach (ToDo item in todoitem.Value)
                {
                    Console.WriteLine($" ITEM Id:{item.id}, Title: {item.title}, Completed: {item.completed}");
                }

            }
        }

        public void DownloadAndPrintJson(string url)
        {
            Uri uri = new Uri(url);
            wc.DownloadStringAsync(uri);
        }


        protected void Dispose(bool disposing)
        {
            if(!disposed)
            {
                if(disposing)
                {
                    if(wc != null)
                    {
                        wc.Dispose();
                        Console.WriteLine($"Cleaned resources");
                    }
                }

            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
