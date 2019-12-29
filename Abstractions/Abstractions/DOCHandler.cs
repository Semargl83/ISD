using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    class DOCHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыть документ в формате 'DOC'");
        }
        public override void Create()
        {
            Console.WriteLine("Создать документ в формате 'DOC'");
        }
        public override void Change()
        {
            Console.WriteLine("Изменить документ в формате 'DOC'");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранить документ в формате 'DOC'");
        }
    }
}
