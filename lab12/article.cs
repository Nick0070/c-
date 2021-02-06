using System;
using System.Collections.Generic;
using System.Text;


namespace lab12
{
 
    class article
    {

        public string surname_avtor { get; set; } = " Дементьев";
        public string name_avtor { get; set; } = " Михаил";
        public string name_statia { get; set; } = " Кибер безопасноть";
        public double reat_statia { get; set; } = 10;

        public article()
        {
        }
        
    }

    class article_konstryktor
    {
        public string surname_avtor = " Дементьев";
        public string name_avtor = " Михаил";
        public string name_statia = " Кибер безопасноть";
        public double reat_statia = 10;
       

        public article_konstryktor() { surname_avtor = " Петров "; name_avtor = " Дмитрий"; name_statia = " Изучение с#"; reat_statia = 9.5; }              // 1 конструктор

        public article_konstryktor(string s , string n, string ns, double r) { surname_avtor = s; name_avtor = n; name_statia = ns; reat_statia = r; }     // 2 конструктор

        

        //override
        public override string ToString()
        {
            return " Фамилия автора -" + surname_avtor + "; \n \n"
               + "Имя автора - " + name_avtor + "; \n \n"
               + "Название статьи - " + name_statia + "; \n \n"
               + "Рейтинг статьи  - " + reat_statia + "/10 ";
        }
        

        public void GetInfo()
        {
            Console.WriteLine($"Фамилия автора - {surname_avtor};  Имя автора - {name_avtor};  Название статьи - {name_statia}; Рейтинг статьи - {reat_statia}. \n \n");
        }


    }


}

