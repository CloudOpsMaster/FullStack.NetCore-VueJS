using System;
using System.Text.RegularExpressions;

namespace Abstraction
{

    #region Task 1 AbstractHandler


    public abstract class AbstractHandler
    {

        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }

    public class XMLHendler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XMLHendler.Change");
        }

        public override void Create()
        {
            Console.WriteLine("XMLHendler.Create");
        }

        public override void Open()
        {
            Console.WriteLine("XMLHendler.Open");
        }

        public override void Save()
        {
            Console.WriteLine("XMLHendler.Save");
        }
    }

    public class TXTHendler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXTHendler.Change");
        }

        public override void Create()
        {
            Console.WriteLine("TXTHendler.Create");
        }

        public override void Open()
        {
            Console.WriteLine("TXTHendler.Open");
        }

        public override void Save()
        {
            Console.WriteLine("TXTHendler.Save");
        }
    }

    public class DOCHendler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Change");
        }

        public override void Create()
        {
            Console.WriteLine("Create");
        }

        public override void Open()
        {
            Console.WriteLine("Open");
        }

        public override void Save()
        {
            Console.WriteLine("Save");
        }
    }

    #endregion

    #region Interface
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }


    public class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
        public void Record()
        {
            Console.WriteLine("Record");
        }
    }


    #endregion
    class Program
    {

        static void Main(string[] args)
        {
            // Task 1 Abstraction 
            /*
            string[] targetfiles = System.IO.Directory.GetFiles(@"C:\work\web Eng\ISD G\FullStrackNetVue\Abstraction\", "test.*");
            string pattern = @"(?<=\.)[a-z]{2,}$";
            string someClass = "Abstract." + Regex.Match(targetfiles[0], pattern).ToString().ToUpper() + "Hendler";
            Type type = Type.GetType(someClass, true);
            AbstractHandler docs = (AbstractHandler)Activator.CreateInstance(type);
            docs.Open();
            docs.Create();
            docs.Change();
            docs.Save();
            Console.ReadKey();
            */

            // Task 2 Interface
            /*
            Player myPlayer = new Player();
            myPlayer.Play();
            (myPlayer as IPlayable).Stop();
            myPlayer.Record();
            (myPlayer as IRecodable).Stop();
            */
        }
    }
}
