using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_._29._03._25.DZ
{
    public class SevenWonders
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }





        public class ChinaWall : SevenWonders
        {
            public ChinaWall()
            {
                Name = "Великая Китайская стена";
                Description = "Огромная защитная стена, построенная для защиты от нападений. " +
                "Ее длина составляет около 21 196 километров.";
            }
        }




        public class PyramidCheops : SevenWonders
        {
            public PyramidCheops()
            {
                Name = "Пирамида Хеопса";
                Description = "Построена около 2580–2560 гг. до н.э. как гробница для фараона Хеопса. " +
                    "Это единственное из чудес, которое сохранилось до наших дней. Пирамида высотой около 146 метров была" +
                    " самой высокой искусственной структурой в мире более 3 800 лет.";
            }
        }





        public class GarderSemiramis : SevenWonders
        {
            public GarderSemiramis()
            {
                Name = "Сад Семирамида";
                Description = "Легендарные висячие сады, которые, как считается, были построены в Вавилоне, " +
                    "хотя их существование оспаривается. Они описываются как террасы с зелеными насаждениями и водопадами.";
            }
        }





        public class StatueZeus : SevenWonders
        {
            public StatueZeus()
            {
                Name = "Статуя Зевса";
                Description = "Огромная статуя бога Зевса, выполненная скульптором Фидием около 435 года до н.э. " +
                    "Статуя была высотой около 12 метров и сделана из дерева, слоновой кости и золота.";
            }
        }





        public class TempleArtemis : SevenWonders
        {
            public TempleArtemis()
            {
                Name = "Храм Артемиды";
                Description = "Великолепный храм, посвященный богине Артемиде, построенный около 550 года до н.э. " +
                    "Он славился своей архитектурной красотой и размерами, но был разрушен в 262 году н.э.";
            }
        }





        public class AlexandriaLighthouse : SevenWonders
        {
            public AlexandriaLighthouse()
            {
                Name = "Александрийский маяк ";
                Description = "Построен на острове Фарос около 280 года до н.э." +
                    " Маяк высотой около 100 метров служил навигационным ориентиром для моряков и был одним из" +
                    " самых высоких сооружений древности.";
            }
        }


        public class ColossusRhodes : SevenWonders
        {
            public ColossusRhodes()
            {
                Name = "Колосс Родосский";
                Description = "Огромная статуя бога солнца Гелиоса, возведенная около 280 года до н.э. " +
                    "Она стояла на входе в гавань Родоса и была высотой около 33 метров.";
            }
        }

    }

