using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_5
{
    public class Triad
    {
        /// Создать класс Pair (пара четных чисел).
        /// Создать необходимые методы и свойства.
        /// Определить метод вычисления произведения на число,суммы с числом,проверка на равенство.
        /// Создать перегруженный метод для вычисления.
        
        
        //Поля класса
        private int _aFirstNumber;
        private int _aSecondNumber;
        private int _aThirdNumber;
        private int _Value;

        public Triad(int aFirstNumber, int aSecondNumber,int aThirdNumber, int Value1)
        {
            //Поля класса
            _aFirstNumber = aFirstNumber;
            _aSecondNumber = aSecondNumber;
            _aThirdNumber = aThirdNumber;
            _Value = Value1;
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
        public int Value1
        {
            get
            {
                return _Value;
            }
            set
            {
                _Value = Value1;
            }
        }

        //Сумма  триады с числом
        public void GetMultiplay1()
        {
            _aFirstNumber += Value1;
            _aSecondNumber += Value1;
            _aThirdNumber += Value1;

        }
        //Произведение трады с числом
        public void GetMultiplay2()
        {
            _aFirstNumber *= Value1;
            _aSecondNumber *= Value1;
            _aThirdNumber *= Value1;

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
