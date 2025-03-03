using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RandomRPG
{
    interface IEntity //Интересный факт - Entity транслитом будет Утешен
    {
        //Это самый базовый интерфейс любого около-существа. Все классы существ должны выполнять этот интерфейс
        //Все функции, которые работают с любыми существами должны использовать этот интерфейс как параметр
        //Бочки, Сундуки итд это тоже существа, но блоки-постройки - нет
        int Health { get; set; }
        Vector<Int64> Position { get; set; }
        public void Spawn(Vector<Int64> position);
        public void Delete();
        public Vector<Int64> GetPosition();
    }
}
