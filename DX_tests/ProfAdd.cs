using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DX_tests.Properties;

namespace DX_tests
{
    public partial class ProfAdd : Form
    {
        string[] questions = new string[24]
        {
            "1. Мне хотелось бы в своей профессиональной деятельности",
            "2. В книге или кинофильме меня больше всего привлекает ",
            "3. Меня больше обрадует Нобелевская премия",
            "4. Я скорее соглашусь стать",
            "5. Будущее людей определяют",
            "6. Если я стану руководителем, то в первую очередь займусь",
            "7. На технической выставке меня больше привлечет",
            "8. В людях я ценю, прежде всего	",
            "9. В свободное время мне хотелось бы",
            "10. В заграничных поездках меня скорее заинтересует ",
            "11. Мне интереснее беседовать о",
            "12. Если бы в моей школе было всего три кружка, я бы выбрал",
            "13. В школе следует обратить особое внимание на",
            "14. Я с большим удовольствием смотрю",
            "15. Мне хотелось бы работать",
            "16. Школа в первую очередь должна учить",
            "17. Главное в жизни",
            "18. Государство должно в первую очередь заботиться о",
            "19. Мне больше всего нравятся уроки",
            "20. Мне интереснее было бы",
            "21. Я предпочитаю читать статьи о",
            "22. В свободное время я люблю	",
            "23. Больший интерес у меня вызовет сообщение о",
            "24. Я предпочту работать "
        };

        string[] answersA = new string[24]{
             "а) общаться с самыми разными людьми;	",
             "а) возможность следить за ходом мыслей автора;",
             "а) за общественную деятельность;",
             "а) механиком;",
             "а) взаимопонимание между людьми;",
             "а) созданием дружного, сплоченного коллектива;",
             "а) устройство экспонатов;",
             "а) дружелюбие; ",
             "а) ставить различные опыты, эксперименты;",
             "а) возможность знакомства с историей и культурой другой страны;",
             "а) человеческих взаимоотношениях; ",
             "а) технический;",
             "а) улучшение взаимопонимания между учителями и учениками;",
             "а) научно-популярные фильмы;",
             "а) с людьми;",
             "а) общению с другими людьми;",
             "а) иметь возможность заниматься творчеством; ",
             "а) защите интересов и прав граждан;	",
             "а) труда;",
             "а) заниматься сбытом товаров; ",
             "а) выдающихся ученых и их открытиях;	",
             "а) читать, думать, рассуждать;",
             "а) научном открытии;",
             "а) в помещении, где много людей;"    
        };

        string[] answersB = new string[24]{
              "б) снимать фильмы, писать книги, рисовать, выступать на сцене и т.д.",
              "б) художественная форма, мастерство писателя или режиссера; ",
              "б) в области науки;	",
              "б) спасателем;",
              "б) научные открытия;",
              "б) разработкой новых технологий обучения;",
              "б) их практическое применение.",
              "б) смелость;",
              "б) писать стихи, сочинять музыку или рисовать;",
              "б) экстремальный туризм (альпинизм, виндсерфинг, горные лыжи);",
              "б) новой научной гипотезе;",
              "б) музыкальный;",
              "б) поддержание здоровья учащихся, занятия спортом;",
              "б) программы о культуре и искусстве;",
              "б) с машинами и механизмами;",
              "б) навыкам работы;",
              "б) вести здоровый образ жизни;",
              "б) достижениях в области науки и техники;",
              "б) физкультуры;",
              "б) изготавливать изделия;",
              "б) интересных изобретениях; ",
              "б) что-нибудь мастерить, шить, ухаживать за животными, растениями;",
              "б) художественной выставке;",
              "б) в необычных условиях;",      
        };

        string[] answersC = new string[24]{
              "в) заниматься расчетами; вести документацию.",
              "в) сюжет, действия героев.",
              "в) в области искусства.",
              "в) бухгалтером.",
              "в) развитие производства.",
              "в) работой с документами.",
              "в) внешний вид экспонатов (цвет, форма);",
              "в) аккуратность.",
              "в) тренироваться.",
              "в) деловое общение. ",
              "в) технических характеристиках новой модели машины, компьютера.",
              "в) спортивный.",
              "в) укрепление дисциплины.",
              "в) спортивные программы.",
              "в) с объектами природы.",
              "в) навыкам планирования своей жизни.",
              "в) тщательно планировать свои дела.",
              "в) материальном благополучии граждан.",
              "в) математики.",
              "в) планировать производство товаров.",
              "в) жизни и творчестве писателей, художников, музыкантов. ",
              "в) ходить на выставки, концерты, в музеи.",
              "в) экономической ситуации.",
              "в) в обычном кабинете. "
         };


        int index = 0;
        int I = 0;
        int II = 0;
        int III = 0;
        int IV = 0;
        int V = 0;
        int VI = 0;
        bool flag = true;

        public ProfAdd()
        {
            InitializeComponent();
            label1.Text = questions[index];
            radioButton1.Text = answersA[index];
            radioButton2.Text = answersB[index];
            radioButton3.Text = answersC[index];
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (index)
            {
                case 0:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) IV++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 1:
                    if (radioButton1.Checked) II++;
                    if (radioButton2.Checked) IV++;
                    if (radioButton3.Checked) V++;
                    break;

                case 2:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) II++;
                    if (radioButton3.Checked) IV++;
                    break;

                case 3:
                    if (radioButton1.Checked) III++;
                    if (radioButton2.Checked) V++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 4:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) II++;
                    if (radioButton3.Checked) III++;
                    break;

                case 5:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) II++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 6:
                    if (radioButton1.Checked) II++;
                    if (radioButton2.Checked) III++;
                    if (radioButton3.Checked) IV++;
                    break;

                case 7:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) V++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 8:
                    if (radioButton1.Checked) II++;
                    if (radioButton2.Checked) IV++;
                    if (radioButton3.Checked) V++;
                    break;

                case 9:
                    if (radioButton1.Checked) IV++;
                    if (radioButton2.Checked) V++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 10:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) II++;
                    if (radioButton3.Checked) III++;
                    break;

                case 11:
                    if (radioButton1.Checked) III++;
                    if (radioButton2.Checked) IV++;
                    if (radioButton3.Checked) V++;
                    break;

                case 12:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) V++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 13:
                    if (radioButton1.Checked) II++;
                    if (radioButton2.Checked) IV++;
                    if (radioButton3.Checked) V++;
                    break;

                case 14:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) III++;
                    if (radioButton3.Checked) V++;
                    break;

                case 15:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) III++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 16:
                    if (radioButton1.Checked) IV++;
                    if (radioButton2.Checked) V++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 17:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) II++;
                    if (radioButton3.Checked) III++;
                    break;

                case 18:
                    if (radioButton1.Checked) III++;
                    if (radioButton2.Checked) V++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 19:
                    if (radioButton1.Checked) I++;
                    if (radioButton2.Checked) III++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 20:
                    if (radioButton1.Checked) II++;
                    if (radioButton2.Checked) III++;
                    if (radioButton3.Checked) IV++;
                    break;

                case 21:
                    if (radioButton1.Checked) II++;
                    if (radioButton2.Checked) III++;
                    if (radioButton3.Checked) IV++;
                    break;

                case 22:
                    if (radioButton1.Checked) II++;
                    if (radioButton2.Checked) IV++;
                    if (radioButton3.Checked) VI++;
                    break;

                case 23:
                    if (flag)
                    {
                        if (radioButton1.Checked) I++;
                        if (radioButton2.Checked) V++;
                        if (radioButton3.Checked) VI++;
                        flag = false;
                    }
                    break;

                default:
                    break;
            }
            
            if (index != 23)
            {
                index++;
                label1.Text = questions[index];
                radioButton1.Text = answersA[index];
                radioButton2.Text = answersB[index];
                radioButton3.Text = answersC[index];
            }
            else 
            {
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string  str = "";
            string temp_str = "";
            //I
            if (I < 4) temp_str = Resources.ProfVeryLow;
            if ((I > 3) && (I < 7)) temp_str = Resources.ProfLow;
            if ((I > 6) && (I < 10)) temp_str = Resources.ProfMedium;
            if (I > 9) temp_str = Resources.ProfHigh;
            str = String.Format("{0}\nРезультат: {1} {2}\n{3}\n\n", Resources.I, Convert.ToString(I), temp_str, Resources.I_);

            //II
            if (II < 4) temp_str = Resources.ProfVeryLow;
            if ((II > 3) && (II < 7)) temp_str = Resources.ProfLow;
            if ((II > 6) && (II < 10)) temp_str = Resources.ProfMedium;
            if (II > 9) temp_str = Resources.ProfHigh;
            str += String.Format("{0}\nРезультат: {1} {2}\n{3}\n\n", Resources.II, Convert.ToString(II), temp_str, Resources.II_);
            
            //III
            if (III < 4) temp_str = Resources.ProfVeryLow;
            if ((III > 3) && (III < 7)) temp_str = Resources.ProfLow;
            if ((III > 6) && (III <10)) temp_str = Resources.ProfMedium;
            if (III > 9) temp_str = Resources.ProfHigh;
            str += String.Format("{0}\nРезультат: {1} {2}\n{3}\n\n", Resources.III, Convert.ToString(III), temp_str, Resources.III_);

            //IV
            if (IV < 4) temp_str = Resources.ProfVeryLow;
            if ((IV > 3) && (IV < 7)) temp_str = Resources.ProfLow;
            if ((IV > 6) && (IV <10)) temp_str = Resources.ProfMedium;
            if (IV > 9) temp_str = Resources.ProfHigh;
            str += String.Format("{0}\nРезультат: {1} {2}\n{3}\n\n", Resources.IV, Convert.ToString(IV), temp_str, Resources.IV_);

            //V
            if (V < 4) temp_str = Resources.ProfVeryLow;
            if ((V > 3) && (V < 7)) temp_str = Resources.ProfLow;
            if ((V > 6) && (V <10)) temp_str = Resources.ProfMedium;
            if (V > 9) temp_str = Resources.ProfHigh;
            str += String.Format("{0}\nРезультат: {1} {2}\n{3}\n\n", Resources.V, Convert.ToString(V), temp_str, Resources.V_);

            //VI
            if (VI < 4) temp_str = Resources.ProfVeryLow;
            if ((VI > 3) && (VI < 7)) temp_str = Resources.ProfLow;
            if ((VI > 6) && (VI < 10))temp_str = Resources.ProfMedium;
            if (VI > 9) temp_str = Resources.ProfHigh;
            str += String.Format("{0}\nРезультат: {1} {2}\n{3}\n\n", Resources.VI, Convert.ToString(VI), temp_str, Resources.VI_);

            MessageBox.Show(Convert.ToString(str));
            Settings.Default.temp_str = str;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doc.Act(Settings.Default.temp_str);
        }


    }
}
