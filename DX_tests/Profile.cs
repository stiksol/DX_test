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

        string[] questions = new string[60]
        { 
                                 "1. Выяснять устройство электроприборов, изучать физику.",
                                 "2. Смотреть передачи о жизни растений и животных.",
                                 "3. Готовить и разрабатывать новые рецепты приготовления пищи, консервов ",
                                 "4. Читать научно-популярные технические журналы.",
                                 "5. Смотреть передачи о  жизни людей в разных странах.",
                                 "6. Бывать на выставках, концертах, спектаклях.",
                                 "7. Обсуждать и анализировать  события в стране и за рубежом.",
                                 "8. Организовывать и «зажигать» друзей, одноклассников на выполнение различных дел.",
                                 "9. Создавать уют и порядок в доме, классе, школе.",
                                 "10. Читать книги и смотреть фильмы о войнах и сражениях. ",
                                 "11. Смотреть фильмы или сериалы на иностранном языке",
                                 "12. Читать литературу, смотреть передачи о новых открытиях в сфере IT-технологий",
                                 "13. Заниматься математическими  расчетами и вычислениями.",
                                 "14. Узнавать  об открытиях в области  химии и биологии.",
                                 "15. Ремонтировать бытовые электроприборы.",
                                 "16. Посещать выставки достижений  науки  и техники.",
                                 "17. Ходить в походы, бывать в новых неизведанных местах.",
                                 "18. Читать отзывы и  статьи о книгах, фильмах, концертах.",
                                 "19. Участвовать в общественной  жизни школы, города.",
                                 "20. Объяснять одноклассникам, младшим детям учебный материал, давать полезные советы и рекомендации.",
                                 "21. Самостоятельно выполнять работу по хозяйству.",
                                 "22. Вести здоровый образ жизни, самостоятельно тренироваться и посещать спортивные секции.",
                                 "23. Общаться в интернете на иностранном языке.",
                                 "24. Разрабатывать собственные компьютерные программы. ",
                                 "25. Проводить опыты по физике, читать статьи об электронике и радиотехнике.",
                                 "26. Ухаживать за животными  и растениями.",
                                 "27. Делать качественные реакции по химии для изучения состава вещества.",
                                 "28. Собирать и ремонтировать  часы, замки, велосипеды. ",
                                 "29. Коллекционировать камни, минералы.",
                                 "30. Вести дневник, сочинять стихи и рассказы",
                                 "31. Читать биографии известных политиков, книги по истории.",
                                 "32. Играть с детьми, помогать делать уроки младшим школьникам.",
                                 "33. Закупать продукты для дома, вести учет расходов.",
                                 "34. Участвовать в военных играх, состязаниях, походах, спасательных операциях.",
                                 "35. Изучать самостоятельно иностранный язык",
                                 "36. Собирать, настраивать и ремонтировать компьютеры",
                                 "37. Заниматься физикой и математикой сверх школьной программы.",
                                 "38. Наблюдать за работой  медсестры, врача. Ухаживать за друзьями или родственниками, если они заболели.",
                                 "39. Изучать, исследовать, анализировать состояния различных веществ",
                                 "40. Строить чертежи, схемы, графики, в том числе и на компьютере.",
                                 "41. Участвовать в географических, геологических экспедициях.",
                                 "42. Рассказывать о прочитанной книге, увиденном фильме, спектакле.",
                                 "43. Следить за политической жизнью в стране и за рубежом",
                                 "44. Посещать лекции, читать журналы, смотреть телепередачи, фильмы по вопросам обучения и воспитания, о взаимоотношениях людей.",
                                 "45. Искать и находить различные способы зарабатывания денег.",
                                 "46. Заниматься физической культурой и спортом.",
                                 "47. Читать книги на иностранном языке",
                                 "48. Разбираться в программах и компьютерных базах данных",
                                 "49. Участвовать в физико-математических олимпиадах. ",
                                 "50. Выполнять лабораторные опыты по химии и биологии.",
                                 "51. Разбираться в принципах работы электроприборов.",
                                 "52. Разбираться в принципах работы различных механизмов.",
                                 "53. «Читать»  географические и геологические карты.",
                                 "54. Пробовать свои силы в живописи, дизайне, музыке, поэзии.",
                                 "55. Изучать политику и экономику других стран.",
                                 "56. Разбираться в причинах проблем человека и участвовать в поиске решения",
                                 "57. Вкладывать заработанные деньги в домашний бюджет..",
                                 "58. Участвовать в спортивных соревнованиях.",
                                 "59. Переводить иностранные тексты.",
                                 "60. Изучать системы мобильной связи, интересоваться устройством микросхем."
        };
        int count_Fizik = 0; // физика и математика
        int count_Biolog = 0; // химия и биология / медицина
        int count_Matem = 0; // химия и математика
        int count_Mech = 0; // механика и конструирование
        int count_Geo = 0; // география и геология
        int count_Lit = 0; // литература и исскуство
        int count_His = 0; // история и политика
        int count_Med = 0; // педагогика и психология
        int count_Home = 0; // предпринимательство и домоводство
        int count_Sport = 0; // спорт и военное дело
        int count_Lang = 0; // иностранные язык
        int count_IT = 0; // информатика
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
            if ((index == 0) || (index == 12) || (index == 24) || (index == 36) || (index == 48))
                count_Fizik += 1;

            if ((index == 1) || (index == 13) || (index == 25) || (index == 37) || (index == 49) )
                count_Biolog += 1;

            if ((index == 2) || (index == 14) || (index == 26) || (index == 38) || (index == 50))
                count_Matem += 1;

            if ((index == 3) || (index == 15) || (index == 27) || (index == 39) || (index == 51))
                count_Mech += 1;

            if ((index == 4) || (index == 16) || (index == 28) || (index == 40) || (index == 52) )
                count_Geo += 1;

            if ((index == 5) || (index == 17) || (index == 29) || (index == 41) || (index == 53) )
                count_Lit += 1;

            if ((index == 6) || (index == 18) || (index == 30) || (index == 42) || (index == 54))
                count_His += 1;

            if ((index == 7) || (index == 19) || (index == 31) || (index == 43) || (index == 55))
                count_Med += 1;

            if ((index == 8) || (index == 20) || (index == 32) || (index == 44) || (index == 56))
                count_Home += 1;

            if ((index == 9) || (index == 21) || (index == 33) || (index == 45) || (index == 57))
                count_Sport += 1;

            if ((index == 10) || (index == 22) || (index == 34) || (index == 46) || (index == 58))
                count_Lang += 1;

            if ((index == 11) || (index == 23) || (index == 35) || (index == 47) || (index == 59))
                count_IT += 1;
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
            string str = "";
            str = String.Format("{0}{1}\n\n", Settings.Default.COUNT_FIZ, Convert.ToString(count_Fizik));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_BIO, Convert.ToString(count_Biolog));
            str += String.Format("{0}{1}\n\n", "химия и математика ", Convert.ToString(count_Matem));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_MECH, Convert.ToString(count_Mech));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_GEO, Convert.ToString(count_Geo));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_LIT, Convert.ToString(count_Lit));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_HIS, Convert.ToString(count_His));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_MED, Convert.ToString(count_Med));
            str += String.Format("{0}{1}\n\n", "предпринимательство и домоводство ", Convert.ToString(count_Home));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_SPORT, Convert.ToString(count_Sport));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_LANG, Convert.ToString(count_Lang));
            str += String.Format("{0}{1}\n\n", Settings.Default.COUNT_SPORT, Convert.ToString(count_IT));

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
