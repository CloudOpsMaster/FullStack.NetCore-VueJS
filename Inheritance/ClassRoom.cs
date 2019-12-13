using System;
using System.Collections.Generic;

class ClassRoom
{

    public List<Pupil> Pupils = new List<Pupil>();

    ClassRoom(params Pupil[] pupils)
    {
     Pupils.AddRange(pupils);
    }

    public void GetPupilsRead()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Read();
            }
        }

}

class Pupil
{
    public string pupilName{get; set;}
    public Pupil(string name)
    {
        pupilName = name;
    }
    private string GetPupilNameAndStatus()
        {
            return String.Format("{0} {1}", GetType().Name, pupilName);
        }
 
        public virtual void Read()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Reading");
        }
 
        public virtual void Write()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Writting");
        }
 
        public virtual void Relax()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Relaxing");
        }
 
        public virtual void Study()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Studying");
        }
    }


class ExcelentPupil : Pupil
{
    public ExcelentPupil(string name) :base(name)
    {
        
    }
     public override void Read()
        {
            Console.WriteLine("{0} reads more than usual pupil", pupilName);
        }

}
class GoodPupil : Pupil
{
    public GoodPupil(string name) :base(name)
    {
      
    }

}
class BadPupil : Pupil
{
   public BadPupil(string name)
            : base(name)
        { }
}

