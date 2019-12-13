using System;


internal class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Про");
    }

    public void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Про");
    }


}

 internal class ProDocumentWorker : DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public void EditDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, cохранение в остальных форматах доступно в версии Эксперт");
        }

       
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
         public void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }

    }