
public class Accauntant
{
    enum Post
    {
        Chief = 270,
        Engineer = 100,
        Manager = 260,
    }

       public bool AskForBonus(Post worker, int hours)
        {
            if ((int)worker < hours)
                return true;
            return false;
        }

}
          
   