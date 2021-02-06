using System;
using System.Collections.Generic;
using System.Text;

namespace lab12
{
    class main
    {

        static void Main(string[] args)
        {

            Console.WriteLine("/////////////////// article  /////////////////////////" + "\n \n");

            //article

            article article = new article();
            Console.WriteLine(
            "Фамилия автора - " + article.surname_avtor + "; \n \n"
            + "Имя автора - " + article.name_avtor + "; \n \n"
            + "Название статьи - " + article.name_statia + ";  \n \n"
            + "Рейтинг статьи  - " + article.reat_statia + "/10 " + "\n \n"
                );

            Console.WriteLine("/////////////////// Далее вывод конструкторов article  /////////////////////////" + "\n \n");

            article_konstryktor konstryktor_1 = new article_konstryktor();
            article_konstryktor konstryktor_2 = new article_konstryktor();

            konstryktor_1.GetInfo();
            konstryktor_2.GetInfo();


            Console.WriteLine("/////////////////// Далее вывод конструкторов magazine /////////////////////////" + "\n \n");


            //magazine

            magazine magazine = new magazine();


            magazine_konstryktor konstryktor_3 = new magazine_konstryktor();
            magazine_konstryktor konstryktor_4 = new magazine_konstryktor();

            konstryktor_3.GetInfo();
            konstryktor_4.GetInfo();

            Console.WriteLine("///////////////////  magazine  /////////////////////////" + "\n \n");




            Console.WriteLine("Индекс месяца - " + magazine[Frequency.Weekly]);    
            Console.WriteLine("Индекс недели - " + magazine[Frequency.Monthly]);  
            Console.WriteLine("Индекс года - " + magazine[Frequency.Yearly]);   
          

        }



    }

}












