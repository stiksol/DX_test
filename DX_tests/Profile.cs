using DX_tests.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DX_tests
{
    public partial class Profile : Form
    {

        string[] questions = new string[50]{"1. Узнавать об открытиях в области физики и  математики.",
                                 "2. Смотреть передачи о жизни растений и животных.",
                                 "3. Выяснять устройство электроприборов.",
                                 "4. Читать научно-популярные технические журналы.",
                                 "5. Смотреть передачи о  жизни людей в разных странах.",
                                 "6. Бывать на выставках, концертах, спектаклях.",
                                 "7. Обсуждать и анализировать  события в стране и за рубежом.",
                                 "8.  Наблюдать за работой  медсестры, врача.",
                                 "9.Смотреть фильмы или сериалы на иностранном языке.",
                                 "10. Читать книги и смотреть фильмы о войнах и сражениях. ",
                                 "11. Заниматься математическими  расчетами и вычислениями.",
                                 "12. Узнавать  об открытиях в области  химии и биологии.",
                                 "13. Ремонтировать бытовые электроприборы.",
                                 "14.Посещать выставки достижений  науки  и техники.",
                                 "15. Ходить в походы, бывать в новых неизведанных местах.",
                                 "16.Читать отзывы и  статьи о книгах, фильмах, концертах.",
                                 "17.Участвовать в общественной  жизни школы, города.",
                                 "18.Объяснять одноклассникам учебный материал.",
                                 "19. Общаться в интернете на иностранном языке.",
                                 "20. Соблюдать режим, вести здоровый образ жизни.",
                                 "21.Проводить опыты по физике.",
                                 "22. Ухаживать за животными  растениями.",
                                 "23.Читать статьи об электронике и радиотехнике.",
                                 "24.Собирать и ремонтировать  часы, замки, велосипеды. ",
                                 "25. Коллекционировать камни, минералы.",
                                 "26. Вести дневник, сочинять стихи и рассказы.",
                                 "27.Читать биографии известных политиков, книги по истории.",
                                 "28. Играть с детьми, помогать делать уроки младшим школьникам.",
                                 "29. Изучать иностранные языки.",
                                 "30.Участвовать в военных играх, походах.",
                                 "31. Заниматься физикой и математикой сверх школьной программы.",
                                 "32. Замечать и объяснять природные явления.",
                                 "33. Собирать и ремонтировать компьютеры.",
                                 "34. Строить чертежи, схемы, графики, в том числе на компьютере.",
                                 "35.Участвовать в географических, геологических экспедициях.",
                                 "36. Рассказывать о прочитанной книге, увиденном фильме, спектакле.",
                                 "37. Следить за политической жизнью в стране и за рубежом",
                                 "38. Ухаживать за друзьями или родственниками, если они заболели.",
                                 "39. Читать книги на иностранном языке.",
                                 "40.Заниматься физической культурой и спортом.",
                                 "41.Участвовать в физико-математических олимпиадах.",
                                 "42. Выполнять лабораторные опыты по химии и биологии.",
                                 "43. Разбираться в принципах работы электроприборов.",
                                 "44. Разбираться в принципах работы различных механизмов.",
                                 "45. «Читать»  географические и геологические карты.",
                                 "46.Участвовать в спектаклях, концертах.",
                                 "47. Изучать политику и экономику других стран.",
                                 "48.Изучать причины поведения людей, строение организма человека.",
                                 "49. Переводить иностранные тексты. ",
                                 "50. Участвовать в спортивных соревнованиях."
            };
        int count_Fizik = 0; // физика и математика
        int count_Biolog = 0; // химия и биология
        int count_Elec = 0;  //радиотехника и электроника
        int count_Mech = 0; // механика и конструирование
        int count_Geo = 0; // география и геология
        int count_Lit = 0; // литература и исскуство
        int count_His = 0; // история и политика
        int count_Med = 0; // педагогика и медицина
        int count_Lang = 0; // иностранные языки
        int count_Sport = 0; // спорт и военное дело
        int index = 0; 

        public Profile()
        {
            InitializeComponent();
            label1.Text = questions[0];
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((index == 0) || (index == 10) || (index == 20) || (index == 30) || (index == 40))
                count_Fizik += 1;

            if ((index == 1) || (index == 11) || (index == 21) || (index == 31) || (index == 41) )
                count_Biolog += 1;

            if ((index == 2) || (index == 12) || (index == 22) || (index == 32) || (index == 42) )
                count_Elec += 1;

            if ((index == 3) || (index == 13) || (index == 23) || (index == 33) || (index == 43) )
                count_Mech += 1;

            if ((index == 4) || (index == 14) || (index == 24) || (index == 34) || (index == 44) )
                count_Geo += 1;

            if ((index == 5) || (index == 15) || (index == 25) || (index == 35) || (index == 45))
                count_Lit += 1;

            if ((index == 6) || (index == 16) || (index == 26) || (index == 36) || (index == 46))
                count_His += 1;

            if ((index == 7) || (index == 17) || (index == 27) || (index == 37) || (index == 47))
                count_Med += 1;

            if ((index == 8) || (index == 18) || (index == 28) || (index == 38) || (index == 48))
                count_Lang += 1;

            if ((index == 9) || (index == 19) || (index == 29) || (index == 39) || (index == 49))
                count_Sport += 1;
            if (index != 49)
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
            if (index != 49)
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
            string str = "";
            str = String.Format("{0}{1}\n\n", Settings.Default.COUNT_FIZ, Convert.ToString(count_Fizik));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_BIO, Convert.ToString(count_Biolog));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_ELEC, Convert.ToString(count_Elec));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_MECH, Convert.ToString(count_Mech));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_GEO, Convert.ToString(count_Geo));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_LIT, Convert.ToString(count_Lit));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_HIS, Convert.ToString(count_His));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_MED, Convert.ToString(count_Med));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_LANG, Convert.ToString(count_Lang));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_SPORT, Convert.ToString(count_Sport));

            str += String.Format("{0}{1}", Settings.Default.Profile_info, Settings.Default.Profile_info2);

            MessageBox.Show(str);
            Settings.Default.temp_str = str;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Doc.Act(Settings.Default.temp_str);
        }
    }
}
