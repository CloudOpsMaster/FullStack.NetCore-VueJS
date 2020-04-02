using System;
using System.Diagnostics;
using System.IO;

namespace asynchronousVSsynchronous
{
    class Program
    {

   static void ReadWriteSync()
   {
           
            string text = "sync/Await is a type of Promise. Promises in JavaScript are objects that can have multiple states (kind of like the real-life ones ☺️). Promises do this because sometimes what we ask for isn’t available immediately, and we’ll need to be able to detect what state it is in.";
          try
            {
            using (FileStream fstream = new FileStream($"sync.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);

            }
            
            using (FileStream fstream = File.OpenRead($"sync.txt"))
            {           
                byte[] array = new byte[fstream.Length];
              
                fstream.Read(array, 0, array.Length);
              
                string textFromFile = System.Text.Encoding.Default.GetString(array);    
            }
           
            }
              catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
        }

    static async void ReadWriteAsync()
        {
            string text = "sync/Await is a type of Promise. Promises in JavaScript are objects that can have multiple states (kind of like the real-life ones ☺️). Promises do this because sometimes what we ask for isn’t available immediately, and we’ll need to be able to detect what state it is in.";
 
            try
            {
            using (StreamWriter writer = new StreamWriter("async.txt", false))
            { 
                await writer.WriteLineAsync(text);  
            }
            using (StreamReader reader = new StreamReader("async.txt"))
            {
                string result = await reader.ReadToEndAsync();  
                //Console.WriteLine(result);
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
        static void Main(string[] args)
        {
           Stopwatch stopwatch = new Stopwatch();
           Stopwatch stopwatch2 = new Stopwatch();
            stopwatch.Start();
            ReadWriteAsync();
            stopwatch.Stop();
            Console.WriteLine("Async: " + stopwatch.ElapsedMilliseconds.ToString() + " ms" );
    
            stopwatch2.Start();
            ReadWriteSync();
            stopwatch2.Stop();
            Console.WriteLine("Sync: " + stopwatch2.ElapsedMilliseconds.ToString() + " ms" );
             
        
            Console.Read();
        }
    }
}
