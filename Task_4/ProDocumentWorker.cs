using System;
namespace Task_4
{
    public class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате,\n    сохранение в остальных\n    форматах доступно в версии Экспертт");
        }
    }
}
