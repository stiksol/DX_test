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
    public partial class Trevog : Form
    {
        string[] questions = new string[20]{"1.	У меня бывают головные боли после напряженной работы.",
                                                "2.	Перед важными уроками мне снятся тревожные сны.",
                                                "3.	В школе я чувствую себя неуютно. ",
                                                "4.	Мне трудно сосредоточить внимание на объяснении учителя",
                                                "5.	Если преподаватель отступает от темы урока, меня это сбивает.",
                                                "6.	Меня тревожат мысли о предстоящем зачете или экзамене.",
                                                "7.	Иногда мне кажется, что я почти ничего не знаю о предмете.",
                                                "8.	Если у меня что-то не получается, я опускаю руки.",
                                                "9. Я часто не успеваю усвоить учебный материал на уроке.",
                                                "10. Я болезненно реагирую на критические замечания.",
                                                "11. Неожиданный вопрос приводит меня в замешательство.",
                                                "12. Мне часто трудно сосредоточиться на задании или предмете.",
                                                "13. Я боюсь отвечать, даже если хорошо знаю предмет. ",
                                                "14. Иногда мне кажется, что я не смогу усвоить весь учебный материал.",
                                                "15. Мне больше нравятся письменные ответы, чем устные ответы у доски.",
                                                "16. Меня тревожат возможные неудачи в учебе.",
                                                "17. Когда я волнуюсь, я краснею и заикаюсь.",
                                                "18. Я часто ссорюсь с друзьями из-за пустяков и потом жалею об этом.",
                                                "19. Психологический климат в классе влияет на мое состояние.",
                                                "20. После спора или ссоры с друзьями я долго не могу успокоиться. "
                                            
            };

        int count = 0;
        int index = 0;

        public Trevog()
        {
            InitializeComponent();
            label1.Text = questions[0];
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count += 1;
            if (index != 19)
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
           
            if (count <= 6)
                str += String.Format("{0}\n \n{1}\n \n", Settings.Default.Trevog_low1, Settings.Default.Trevog_low2);
            //    str = String.Format("{0}\n{1}\n\n", Settings.Default.Trevog_low1, Settings.Default.Trevog_low2);

            if ((count >= 7) && (count <= 13))
                str = Settings.Default.Trevog_med + "\n \n";

            if ((count >= 14) && (count <= 20))
                str = String.Format("{0}\n{1}\n\n", Settings.Default.Trevog_high1, Settings.Default.Trevog_high2);

            MessageBox.Show(str);
            Settings.Default.temp_str = str;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (index != 19)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Doc.Act(Settings.Default.temp_str);
        }
    }
}
