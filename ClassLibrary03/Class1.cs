using System;

namespace ClassLibrary03
{
    /// <summary>
    /// Базовый класс
    /// защищенные поля name, category, sender
    /// 3 конструктора 
    /// </summary>
    public abstract class product
    {
        /// <summary>
        /// поле названия продукта
        /// </summary>
        protected string name;
        /// <summary>
        /// поле названия категории продукта
        /// </summary>
        protected string category;
        /// <summary>
        /// поле названия отправителя
        /// </summary>
        protected string sender;
        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public product()
        {
            this.name = "Неизвестен";
            this.category = "Неизвестен";
            this.sender = "Неизвестен";
        }
        /// <summary>
        /// конструктор с 2 параметрами
        /// </summary>
        /// <param name="n">Название</param>
        /// <param name="c">Категории</param>
        public product(string n, string c)
        {
            this.name = n;
            this.category = c;
            this.sender = "Неизвестен";
        }
        /// <summary>
        /// конструктор с 3 параметрами
        /// </summary>
        /// <param name="n">Название</param>
        /// <param name="c">Категория</param>
        /// <param name="s">Отправитель</param>
        public product(string n, string c, string s)
        {
            this.name = n;
            this.category = c;
            this.sender = s;
        }
        /// <summary>
        /// метод вывода информации продукта
        /// </summary>
        /// <returns>Всех значений ввиде строки</returns>
        public virtual string print() { return $"Название = {name}\nКатегория = {category}\nОтправитель = {sender}"; }
    }
    /// <summary>
    /// Дочерний класс от базового
    /// использования базовоых конструкторов и дочерних
    /// проверка на корректность ввода данных
    /// </summary>
    public class massproduct : product
    {
        /// <summary>
        /// поле веса
        /// </summary>        
        protected double weight;
        /// <summary>
        /// свойства для поля веса
        /// </summary>
        public double Weight { get { return weight; }
            set
            {
                // проверка на коректность
                try { weight = value; }
                catch (Exception) { weight = -1; }
            }
        }
        /// <summary>
        /// поле цена за кг
        /// </summary>
        private double weightofprice;
        /// <summary>
        /// свойста для поля цена за кг
        /// </summary>
        private double Weightofprice
        {
            get { return weightofprice; }
            set
            {
                try { weightofprice = value; }
                catch (Exception) { weightofprice = -1; }
            }
        }
        /// <summary>
        ///конструктор дочернего класса без параметров
        /// </summary>
        public massproduct() : base()
        {
            Weight = 1;
            Weightofprice = 1;
        }
        /// <summary>
        /// конструктор дочернего класса с 2 параметрами
        /// </summary>
        /// <param name="weight">Вес</param>
        /// <param name="weightofprice">Цена за кг</param>
        public massproduct(double weight, double weightofprice) : base()
        {
            try
            {
                Weight = weight;
                if (weight <= 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Weight = -1;}
            try
            {
                Weightofprice = weightofprice;
                if (weightofprice <= 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Weightofprice = -1;}
        }
        /// <summary>
        /// конструктор дочернего класса с 4 параметрами
        /// </summary>
        /// <param name="n">Название</param>
        /// <param name="c">Категория</param>
        /// <param name="weight">Вес</param>
        /// <param name="weightofprice">Цена за кг</param>
        public massproduct(string n, string c, double weight, double weightofprice) : base(n, c)
        {
            try
            {
                // проверка на коректность
                Weight = weight;
                if (weight <= 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Weight = -1;}
            try
            {
                Weightofprice = weightofprice;
                if (weightofprice <= 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Weightofprice = -1;}
        }
        /// <summary>
        /// конструктор дочернего класса с 5 параметрами
        /// </summary>
        /// <param name="n">Название</param>
        /// <param name="c">Категория</param>
        /// <param name="s">Отправитель</param>
        /// <param name="weight">Вес</param>
        /// <param name="weightofprice">Цена за кг</param>
        public massproduct(string n, string c, string s, double weight, double weightofprice) : base(n, c, s)
        {
            try
            {
                // проверка на коректность
                Weight = weight;
                if (weight <= 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Weight = -1;}
            try
            {
                Weightofprice = weightofprice;
                if (weightofprice <= 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Weightofprice = -1;}
        }
        /// <summary>
        /// переопределенный метод
        /// </summary>
        /// <returns>Всех значений ввиде строки</returns>
        public override string print()
        {
            return $"Название = {name}\nКатегория = {category}\nВес = {Weight}\nЦена за кг = {Weightofprice}\nЦена = {Weightofprice*Weight:f1}\nОтправитель = {sender}";
        }
    }
    /// <summary>
    /// Дочерний класс от базового
    /// использования базовоых конструкторов и дочерних
    /// проверка на корректность ввода данных
    /// </summary>
    public class pieceproduct : product
    {
        /// <summary>
        /// поле количества
        /// </summary>
        protected int cout;
        /// <summary>
        /// свойства поля количества
        /// </summary>
        public int Cout
        {
            get { return cout; }
            set
            {
                try { cout = value; }
                catch (Exception) { cout = -1; }
            }
        }
        /// <summary>
        /// поле цены за единицу
        /// </summary>
        protected double coutofprice;
        /// <summary>
        /// свойства поля цены за единицу
        /// </summary>
        public double Coutofprice
        {
            get { return coutofprice; }
            set
            {
                try { coutofprice = value; }
                catch (Exception) { coutofprice = -1; }
            }
        }
        /// <summary>
        /// конструктор дочернего класса без параметров 
        /// </summary>
        public pieceproduct()
        {
            Cout = 1;
            Coutofprice = 1;
        }
        /// <summary>
        /// конструктор дочернего класса с 2 параметрами
        /// </summary>
        /// <param name="cout">количество</param>
        /// <param name="coutofprice">цена за еденицу</param>
        public pieceproduct(int cout, double coutofprice) : base()
        {
            try
            {
                Cout = cout;
                if (Cout < 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Cout = -1;}
            try
            {
                Coutofprice = coutofprice;
                if (coutofprice <= 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Coutofprice = -1;}
        }
        /// <summary>
        /// конструктор дочернего класса с 4 параметрами
        /// </summary>
        /// <param name="n">Название</param>
        /// <param name="r">Категория</param>
        /// <param name="cout">Количество</param>
        /// <param name="coutofprice">цена за единицу</param>
        public pieceproduct(string n, string r, int cout, double coutofprice) : base(n, r)
        {
            try
            {
                Cout = cout;
                if (Cout < 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Cout = -1;}
            try
            {
                Coutofprice = coutofprice;
                if (coutofprice <= 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Coutofprice = -1;}
        }
        /// <summary>
        /// конструктор дочернего класса с 5 параметрами
        /// </summary>
        /// <param name="n">Название</param>
        /// <param name="r">Категории</param>
        /// <param name="s">Отправитель</param>
        /// <param name="cout">Количество</param>
        /// <param name="coutofprice">Цена за единицу</param>
        public pieceproduct(string n, string r,string s, int cout, double coutofprice) : base(n, r, s)
        {
            try
            {
                Cout = cout;
                if (Cout < 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Cout = -1;}
            try
            {
                Coutofprice = coutofprice;
                if (coutofprice <= 0)
                    throw new Exception("Некоректный ввод");
            }
            catch (Exception) { Coutofprice = -1;}
        }
        /// <summary>
        /// переопределенной метод
        /// </summary>
        /// <returns>Всех значений ввиде строки</returns>
        public override string print()
        {
            return $"Название = {name}\nКатегория = {category}\nКоличество = {Cout}\nЦена за еденицу = {Coutofprice}\nЦена = {Coutofprice * Cout:f1}\n";
        }

    }
}
