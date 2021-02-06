using System;
using System.Collections.Generic;
using System.Text;

namespace lab12
{
    enum Frequency { Weekly, Monthly, Yearly }

    class magazine
    {

        private string nazvanie_zhyrnala { get; set; } = " Журнал посещения";
        private Frequency periodichnost_viohoda { get; set; } = Frequency.Monthly;
        private DateTime Data_vhoda { get; set; } = DateTime.Now;
        private int tirash_shyrnala { get; set; } = 5;
        private article[] spisok_v_shyrnale { get; set; }

        private static double Sum_reat = 100;
        private static double kol_statei = 10;


        public double AverageAge
        {
            get
            {
                return Sum_reat / kol_statei; 
            }

        }


        public Frequency Frenquency { get; set; }

        public bool this[Frequency index]
        {
           get { return Frenquency == index; }
        }
      

    }


    class magazine_konstryktor
    {

      
        private string nazvanie_zhyrnala;
        private Frequency periodichnost_viohoda;
        private DateTime Data_vhoda;
        private int tirash_shyrnala;

        
        public magazine_konstryktor() { nazvanie_zhyrnala = " Журнал посещений "; periodichnost_viohoda = Frequency.Yearly; Data_vhoda = DateTime.Now ; tirash_shyrnala = 5; }

        public magazine_konstryktor(string nz, Frequency pv, DateTime dv, int ts) {  }



        public void GetInfo()
        {
            Console.WriteLine($"Название журнала - {nazvanie_zhyrnala};  Переодичность входа - {periodichnost_viohoda};  Дата входа - {Data_vhoda}; Тираж журнала - {tirash_shyrnala}. \n \n");
        }


    }




}
