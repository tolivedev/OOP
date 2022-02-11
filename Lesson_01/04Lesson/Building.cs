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
    public class Building
    {
        private readonly Logger _logger = new ConsoleLogger();

        static uint uniNumber;

        uint number;
        float high;
        uint floor;
        uint apartments;
        uint entrances;
        internal Building()
        {
            uniNumber++;
            number = uniNumber;
        }

        public uint Number => number;

        public float High
        {
            get => high;
            set
            {
                if (value < 0) { _logger.ShowMessage("Ошибка ввода!Высота здания не может быть меньше 0 метров"); }
                else { high = value; }
            }
        }
        public uint Floor
        {
            get => floor;
            set { floor = value; }
        }
        public uint Apartments
        {
            get => apartments;
            set { apartments = value; }
        }
        public uint Entrances
        {
            get => entrances;
            set { entrances = value; }
        }

        public float GetFloorHigh()
        {
            float res = 0;
            if (Floor != 0)
            {
                res = High / Floor;
                _logger.ShowMessage($"В этом доме высота этажа -  {res:f0} метра(-ов).");
            }
            else
            {
                _logger.ShowMessage("Ошибка! Не указано количество этажей в этом доме!");
            }
            return res;
        }
        public uint GetApartmentsPerEntrances()
        {
            uint res = 0;
            if (Entrances > 0)
            {
                res = Apartments / Entrances;
                _logger.ShowMessage($"В этом доме {res} квартир(ы) в каждом подъезде.");
            }
            else
            {
                _logger.ShowMessage("Ошибка! Не указано количество подъездов в этом доме!");
            }
            return res;
        }
        public uint GetApartmentsPerFloor()
        {
            uint res = 0;
            if (Floor == 0)
            {
                _logger.ShowMessage("Ошибка! Не указано количество этажей в этом доме!");
            }
            else if (Entrances == 0)
            {
                _logger.ShowMessage("Ошибка! Не указано количество подъездов в этом доме!");
            }
            else
            {
                res = Apartments / Entrances / Floor;
                _logger.ShowMessage($"В этом доме {res} квартир(ы) на каждом этаже.");
            }
            return res;
        }

        internal static void ClearBuild(int number)
        {
            Building build = (Building)Сreator.Buildings[number];
            build.number = 0;
            build.Apartments = 0;
            build.Entrances = 0;
            build.Floor = 0;
            build.High = 0;
        }
        public void Info()
        {
            _logger.ShowMessage($"");
            _logger.ShowMessage($"    Паспорт дома № {Number}");
            _logger.ShowMessage($"Высота               - {High:f0} метров");
            _logger.ShowMessage($"Количество этажей    - {Floor}");
            _logger.ShowMessage($"Количество квартир   - {Apartments}");
            _logger.ShowMessage($"Количество подъездов - {Entrances}");
            _logger.ShowMessage($"");
        }
    }
}
