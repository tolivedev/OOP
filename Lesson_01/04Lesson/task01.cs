using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons._04Lesson
{
    /// <summary>
    /// 1. Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов). 
    /// Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати. 
    /// Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д. 
    /// Предусмотреть возможность, чтобы уникальный номер здания генерировался программно. Для этого в классе предусмотреть 
    /// статическое поле, которое бы хранило последний использованный номер здания, 
    /// и предусмотреть метод, который увеличивал бы значение этого поля.
    /// </summary>

    class task01
    {
        public task01()
        {
            Logger log = new ConsoleLogger();
            Building building1 = Сreator.CreateBuild();
            Building building2 = Сreator.CreateBuild(28, 4, 4, 5);
            building1.Info();
            building2.Info();

            building1.Apartments = 120;
            building1.Floor = 5;
            building1.High = 15;
            building1.Entrances = 6;

            building1.Info();

            building1.GetFloorHigh();
            building1.GetApartmentsPerEntrances();
            building1.GetApartmentsPerFloor();

            log.ShowMessage("");
            log.ShowMessage($"Всего создано объектов: {Сreator.Buildings.Count.ToString()}");
            log.ShowMessage("Пробуем удалить из хеш таблицы дом с номером 25");
            Сreator.DeleteBuild(25);
            log.ShowMessage($"Всего создано объектов: {Сreator.Buildings.Count.ToString()}");
            log.ShowMessage("Пробуем удалить из хеш таблицы дом с номером 2");
            Сreator.DeleteBuild(2);
            log.ShowMessage($"Всего создано объектов: {Сreator.Buildings.Count.ToString()}");
            log.ShowMessage("Выводим инфо об объекте дома с номером 2, который мы удалили из хеш таблицы");
            building2.Info();
            System.Console.ReadKey();
        }
    }
}
