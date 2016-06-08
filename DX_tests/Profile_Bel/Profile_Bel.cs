using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DX_tests.Properties;

namespace DX_tests.Profile_Bel
{
    public partial class Profile_Bel : Form
    {
        string[] questions = new string[60]
        {
                      " 1. Следить за новостями в сфере электроники и радиотехники, транспорта и строительства.",
                      " 2.Читать книги и смотреть фильмы о путешественниках и географических открытиях..",
                      " 3.Следить за новостями в сфере экономики.",
                      " 4.Проводить  химические опыты в лабораторных условиях.",
                      " 5.Следить за новостями книгоиздательства.",
                      " 6.Узнавать  об открытиях в области  химии.",
                      " 7.Следить за политической жизнью в городе, стране и за рубежом.",
                      " 8.Объяснять одноклассникам учебный материал, помогать делать уроки.",
                      " 9.Следить за новостями культуры.",
                      " 10. Изучать военную технику .",
                      " 11.Ремонтировать электроприборы, компьютеры.",
                      " 12.Знакомиться с  жизнью людей в разных странах.",
                      " 13.Обсуждать и анализировать состояние экономики.",
                      " 14.Узнавать  об открытиях в области  биологии.",
                      " 15.Рассказывать друзьям о прочитанной книге, увиденном фильме, спектакле.",
                      " 16.Изучать, исследовать, анализировать состояния различных веществ.",
                      " 17.Участвовать в общественной  жизни школы, города.",
                      " 18.Быть организатором различных мероприятий в классе и школе.",
                      " 19.Бывать на художественных выставках, концертах, спектаклях.",
                      " 20.Читать книги и смотреть фильмы о войнах и сражениях.",
                      " 21.Заниматься испытаниями технических устройств.",
                      " 22.Обсуждать и анализировать  события в стране и за рубежом.",
                      " 23.Заниматься математическими  расчетами и вычислениями.",
                      " 24.Смотреть передачи, читать о жизни растений, микроорганизмов, и животных.",
                      " 25.Вести дневник, сочинять стихи и рассказы.",
                      " 26.Разрабатывать и производить продукты питания, лекарства.",
                      " 27.Читать биографии известных политиков и общественных деятелей.",
                      " 28.Наблюдать за педагогическими приемами учителей.",
                      " 29.Рисовать, сочинять музыку, стихи.",
                      " 30.Участвовать в военных играх, состязаниях, походах, спасательных операциях.",
                      " 31.Следить за новостями IT-технологий",
                      " 32.Ходить в походы, бывать в новых неизведанных местах..",
                      " 33.Следить за новостями рекламных компаний на телевидении, интернет-форумах",
                      " 34.Участвовать в олимпиадах по химии и биологии.",
                      " 35.Читать отзывы и  статьи о книгах, фильмах, концертах.",
                      " 36.Разбираться в технологии приготовления различных блюд, напитков.",
                      " 37.Смотреть исторические фильмы, читать книги по истории.",
                      " 38.Понимать причины поведения людей, помогать им разобраться в своих проблемах.",
                      " 39.Участвовать  в школьных спектаклях и концертах.",
                      " 40.Заниматься регулярно физической культурой и спортом или заниматься спортом профессионально.",
                      " 41.Разрабатывать собственные компьютерные программы.",
                      " 42.Составлять, изучать и читать географические карты.",
                      " 43.Заниматься продажей товаров и услуг.",
                      " 44.Изучать закономерности развития живых организмов.",
                      " 45.Общаться в интернете на иностранном языке.",
                      " 46.Работать с химическими реактивами и оборудованием.",
                      " 47.Обсуждать и анализировать закономерности общественного развития.",
                      " 48.Заниматься с младшими детьми, заботиться о них.",
                      " 49.Заниматься в музыкальной студии, литературном кружке, изостудии и др.",
                      " 50.Участвовать в спортивных соревнованиях.",
                      " 51.Следить за новостями в сфере математики и вычислительной техники.",
                      " 52.Вести природоохранную и краеведческую работу.",
                      " 53.Обрабатывать, проверять информацию, работать с числами.",
                      " 54.Изучать литературу, смотреть передачи о здоровье, правильном питании.",
                      " 55.Смотреть зарубежные фильмы без перевода, читать  книги на иностранном языке.",
                      " 56.Смотреть научно-популярные фильмы о химических, пищевых, деревообрабатывающих производствах.",
                      " 57. Участвовать в дискуссиях и дебатах.",
                      " 58.Читать книги и смотреть передачи о взаимоотношениях людей.",
                      " 59.Создавать новые образы в одежде, интерьере.",
                      " 60. Следить за спортивными новостями и событиями."
           
        };

        private int countFizMat = 0; 
        private int countMatGeo = 0;
        private int countEco= 0;
        private int countBioChe = 0;
        private int countFil = 0;
        private int countTech = 0;
        private int countHistory = 0;
        private int countPedag = 0;
        private int countArt = 0;
        private int countSport = 0;

        //specializations
        private int specIt = 0;
        private int specMed = 0;
        private int specLang = 0;
        private int specPsy = 0;
        private int specSport = 0;


        private int index = 0;

        public Profile_Bel()
        {
            InitializeComponent();
            label1.Text = questions[0];
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((index == 0) || (index == 10) || (index == 20) || (index == 30) || (index == 40) || (index == 50))
            {
                countFizMat += 1;
                if ((index == 30) || (index == 40) || (index == 50))
                {
                    specIt += 1;
                }
            }

            if ((index == 1) || (index == 11) || (index == 21) || (index == 31) || (index == 41) || (index == 50))
                countMatGeo += 1;

            if ((index == 2) || (index == 12) || (index == 22) || (index == 32) || (index == 42) || (index == 52))
                countEco += 1;

            if ((index == 3) || (index == 13) || (index == 23) || (index == 33) || (index == 43) || (index == 53))
            {
                countBioChe += 1;
                if ((index == 33) || (index == 43) || (index == 53))
                {
                    specMed += 1;
                }
            }

            if ((index == 4) || (index == 14) || (index == 24) || (index == 34) || (index == 44) || (index == 54))
                countFil += 1;

            if ((index == 5) || (index == 15) || (index == 25) || (index == 35) || (index == 45) || (index == 55))
            {
                countTech += 1;
                if ((index == 45) || (index == 55))
                {
                    specLang += 1;
                }
            }

            if ((index == 6) || (index == 16) || (index == 26) || (index == 36) || (index == 46) || (index == 56))
                countHistory += 1;

            if ((index == 7) || (index == 17) || (index == 27) || (index == 37) || (index == 47) || (index == 57))
            {
                countPedag += 1;
                if ((index == 37) || (index == 47) || (index == 57))
                {
                    specPsy += 1;
                }
            }

            if ((index == 8) || (index == 18) || (index == 28) || (index == 38) || (index == 48) || (index == 58))
                countArt += 1;

            if ((index == 9) || (index == 19) || (index == 29) || (index == 39) || (index == 49) || (index == 59))
            {
                countSport += 1;
                if ((index == 39) || (index == 49) || (index == 59))
                {
                    specSport += 1;
                }
            }


            if (index != 59)
            {
                index++;
                label1.Text = questions[index];
            }

            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index != 59)
            {
                index++;
                label1.Text = questions[index];
            }

            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("{0}{1}\n\n", "I. Физико-математический профиль (физика, математика, информатика) - ", Convert.ToString(countFizMat));
            str.AppendFormat("{0}{1}\n\n", "II. Математико-географический (математика и география) - ", Convert.ToString(countMatGeo));
            str.AppendFormat("{0}{1}\n\n", "III. Экономический профиль (математика, иностранный язык) - ", Convert.ToString(countEco));
            str.AppendFormat("{0}{1}\n\n", "IV. Биолого-химический профиль (химия и биология) - ", Convert.ToString(countBioChe));
            str.AppendFormat("{0}{1}\n\n", "V. Филологический профиль (литература, русский и белорусский языки, иностранные языки) - ", Convert.ToString(countFil));
            str.AppendFormat("{0}{1}\n\n", "VI. Технологический профиль (химия и математика) - ", Convert.ToString(countTech));
            str.AppendFormat("{0}{1}\n\n", "VII. Историко-обществоведческий профиль (история Беларуси, обществоведение, Всемирная история) - ", Convert.ToString(countHistory));
            str.AppendFormat("{0}{1}\n\n", "VIII. Педагогический профиль - ", Convert.ToString(countPedag));
            str.AppendFormat("{0}{1}\n\n", "IX. Художественно-эстетический профиль - ", Convert.ToString(countArt));
            str.AppendFormat("{0}{1}\n\n", "X. Оборонно-спортивный профиль (физическая культура и здоровье, допризывная подготовка) - ", Convert.ToString(countSport));


            str.AppendFormat("{0}\n", "5-6 баллов – ярко выраженный интерес");
            str.AppendFormat("{0}\n", "3-4 балла – умеренно выраженный интерес");
            str.AppendFormat("{0}\n\n", "0-2 балла – слабо выраженный интерес");



            if ((specIt != 0) || (specLang != 0) || (specMed != 0) || (specPsy != 0) || (specSport != 0))
                str.AppendFormat("{0}\n\n", "Специализации:");

            if (specIt != 0)
                str.AppendFormat("{0}{1}{2}\n\n", "Интерес к IT сфере - ", Convert.ToString(specIt)," (макс.3)");

            if (specMed != 0)
                str.AppendFormat("{0}{1}{2}\n\n", "Интерес к направлению медицина - ", Convert.ToString(specMed), " (макс.3)");

            if (specLang != 0)
                str.AppendFormat("{0}{1}{2}\n\n", "Интерес к направлению иностранный язык - ", Convert.ToString(specLang), " (макс.)");

            if (specPsy != 0)
                str.AppendFormat("{0}{1}{2}\n\n", "Интерес к направлению психология - ", Convert.ToString(specPsy), " (макс.3)");

            if (specSport != 0)
                str.AppendFormat("{0}{1}{2}\n\n", "Интерес к направлению физкультура и спорт - ", Convert.ToString(specSport), " (макс.3)");


            MessageBox.Show(str.ToString());
            Settings.Default.temp_str = str.ToString();
            button4.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doc.Act(Settings.Default.temp_str);
        }
    }
}
