using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_5
{
    public class Triad
    {
        /// Создать класс Triad (тройка чисел).
        /// Создать необходимые методы и свойства.
        /// Определить метод вычисления произведения на число,суммы с числом,проверка на равенство.    
        
        //Поля класса
        private int _aFirstNumber;
        private int _aSecondNumber;
        private int _aThirdNumber;
        private int _Value;

        public Triad(int aFirstNumber, int aSecondNumber,int aThirdNumber)
        {
            //Поля класса
            _aFirstNumber = aFirstNumber;
            _aSecondNumber = aSecondNumber;
            _aThirdNumber = aThirdNumber;
        }
        //Св-ва 1-го числа
        public int FirstNumber
        {
            //Возвращаем значение
            get
            {
                return _aFirstNumber;
            }
            //Устанавливаем значение
            set
            {
                _aFirstNumber = value;
            }
        }
        //Св-ва 2-го числа
        public int SecondNumber
        {
            //Возвращаем значение
            get
            {
                return _aSecondNumber;
            }
            //Устанавливаем значение
            set
            { 
                _aSecondNumber = value;
            }
        }
        //Св-ва 3-го числа
        public int ThirdNumber
        {
            //Возвращаем значение
            get
            {
                return _aThirdNumber;
            }
            //Устанавливаем значение
            set
            {
                _aThirdNumber = value;
            }
        }
        //Св-ва числа,с которым производятся операции
       

        //Сумма  триады с числом
        public static int operator +(Triad triad,int value)
        {
            int result = triad.FirstNumber + triad.SecondNumber + triad.ThirdNumber + value;
            return result;
        }
        public static int operator +(Triad triad, Triad triad2)
        {
            int result = triad.FirstNumber + triad.SecondNumber + triad.ThirdNumber + triad2.FirstNumber + triad2.SecondNumber + triad2.ThirdNumber;
            return result;
        }
        //Произведение трады с числом
        public void GetMultiplay2(int value)
        {
            _aFirstNumber *= value;
            _aSecondNumber *= value;
            _aThirdNumber *= value;

        }
        //Проверка на равенство
        public bool Proverka()
        {
            if (_aFirstNumber == _aSecondNumber && _aSecondNumber == _aThirdNumber)
            {
                return true;
            } 
            else return false;
        }

    }
}
