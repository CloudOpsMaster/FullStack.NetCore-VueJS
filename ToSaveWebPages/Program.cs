using System;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;

namespace ToSaveWebPages
{
    class Program
    {
        static void Main(string[] args)
        {  
        string text = GetCode("http://selin.in.ua");
        Console.WriteLine(text);
        Console.Read();


         static String GetCode(string urlAddress)
          {
        string data = "";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        if (response.StatusCode == HttpStatusCode.OK)
        {
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = null;
            if (response.CharacterSet == null)
            {
                readStream = new StreamReader(receiveStream);
            }
            else
            {
                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
            }
             data = readStream.ReadToEnd();
            response.Close();
            readStream.Close();
        }
        return data;
    }


     MultiTextWriter multiWriter = new MultiTextWriter();
 
            TextWriter consoleWriter = Console.Out;
            TextWriter fileWriter = File.CreateText("output.html");
 
            multiWriter.AddWriter(consoleWriter);
            multiWriter.AddWriter(fileWriter);
           
            Console.SetOut(multiWriter);
 
            Console.WriteLine(text);
            
 
            multiWriter.Close();
        }

        
        }



         public class MultiTextWriter : TextWriter
    {
        private List<TextWriter> _writers = new List<TextWriter>();
 
        public override Encoding Encoding => Encoding.UTF8;
 
        public void AddWriter(TextWriter writer) => _writers.Add(writer);
 
        public override void Write(char ch)
        {
            foreach (var writer in _writers)
                writer.Write(ch);
        }
 
        public override void Close()
        {
            _writers.ForEach(w => w.Close());
            base.Close();            
        }
    }
    
}
