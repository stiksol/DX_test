using System;
using DX_tests.Properties;
using System.Windows.Forms;



namespace DX_tests
{

    public partial class SocialInt : Form
    {
        string[] questions = new string[30]{"1.Для меня дороги как отрицательные, так и положительные эмоции в своей жизни",
                                 "2.Когда я испытваю давление со стороны, то обычно сопротивляюсь",
                                 "3.Я обычно терпеливо выслушиваю других людей, иногда в ущерб своим интересам",
                                 "4.В общественных местах или транспорте я с интересом рассматриваю других людей",
                                  "5.Когда я занимаюсь любимым делом все остальное отходит на второй план",
                                  "6.Отрицательные эмоции помогают мне понять, что мне нужно изменить в своей жизни",
                                  "7.Я отслеживаю свои эмоциальные реакции",
                                  "8.Мне легко понять переживания даже незнакомых людей",
                                  "9.Мне нравится работа, связанная с интенсивным общением",
                                  "10.Я не могу успокоиться, пока не доведу свою работу до совершенства",
                                  "11.Мне интересно наблюдать изменение своего эмоционального состояния",
                                  "12.Если меня что-то расстроило, я быстро прихожу в себя",
                                  "13.Я хорошо понимаю эмоции других людей, даже если они их стараются скрыть",
                                  "14.Мне нетрудно попросить незнакомого человека о помощи",
                                  "15.Когда я берусь за новое дело, я не сомневаюсь в его успехе",
                                  "16.Когда есть время, я обращаюсь к своим переживаниям, чтобы понять их причину",
                                  "17.Я не застреваю на отрицательны эмоциях",
                                  "18.Я чувствую настроение человека по выражению его лица",
                                  "19.Обычно я чувствую себя комфортно даже в компании незнакомых людей",
                                  "20.Профессиональная успешность во многом зависит от отношения человека к работе",
                                  "21.Знание своих истинных чувств необходимо мне для поддержания <Хорошей формы>",
                                  "22. Я обычно быстро прихожу в себя после неожиданного огорчения",
                                  "23.Я замечаю зависимость своего настроения от настроения окружающих меня людей",
                                  "24.В долгой дороге мне интереснее общаться с попутчиками, чем читать книгу",
                                  "25.Препятствия на пути к цели делают меня сильнее",
                                  "26.Люди, осознающие свои чувства, лучше управляют своей жизнью",
                                  "27.Я могу влиять на свое настроение",
                                  "28.Я обычно внимательно отношусь к просьбам незнакомых людей о помощи",
                                  "29.У меня много друзей, которые всегда поддержат меня в сложной ситуации",
                                  "30.Я хотел(а) бы работать не только из-за денег"
            };
        int count_Soz = 0; // самосознание 
        int count_Reg = 0; // саморегуляция
        int count_Em = 0;  //эмпатия
        int count_N = 0; // навыки взаимодействия
        int count_Sam = 0; // Самомотиваци
        int index = 0; 
        

        public SocialInt()
        {
            InitializeComponent();
            label1.Text = questions[0];
            button3.Visible = false;
            button4.Visible = false;
        }

        #region Control
        private void button1_Click(object sender, EventArgs e) //Да
        {
            if ((index == 0) || (index == 5) || (index == 10) || (index == 15) || (index == 20) || (index == 25)) 
                count_Soz += 1;

            if ((index == 1) || (index == 6) || (index == 11) || (index == 16) || (index == 21) || (index == 26))
                count_Reg += 1;

            if ((index == 2) || (index == 7) || (index == 12) || (index == 17) || (index == 22) || (index == 27))
                count_Em += 1;

            if ((index == 3) || (index == 8) || (index == 13) || (index == 18) || (index == 23) || (index == 28))
                count_N += 1;

            if ((index == 4) || (index == 9) || (index == 14) || (index == 19) || (index == 24) || (index == 29))
                count_Sam += 1;
            if (index != 29)
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
        //****************самосознание
            if (count_Soz <= 2)
             str = Settings.Default.Sam + "\n" + Settings.Default.Sam_low + "\n \n";

            if ((count_Soz >= 3) && (count_Soz <= 4))
                str = Settings.Default.Sam + "\n" + Settings.Default.Sam_med + "\n \n";

            if ((count_Soz >= 5) && (count_Soz <= 6))
                str = Settings.Default.Sam + "\n" + Settings.Default.Sam_high + "\n \n";
        //***************саморегуляция
            if (count_Reg <= 2)
                str += Settings.Default.Reg + "\n" + Settings.Default.Reg_low + "\n \n";

            if ((count_Reg >= 3) && (count_Reg <= 4))
                str += Settings.Default.Reg + "\n" + Settings.Default.Reg_med + "\n \n";

            if ((count_Reg >= 5) && (count_Reg <= 6))
                str += Settings.Default.Reg + "\n" + Settings.Default.Reg_high + "\n \n";
        //*********************эмпатия
            if (count_Em <= 2)
                str += Settings.Default.Empatia + "\n" + Settings.Default.Em_low + "\n \n";

            if ((count_Em >= 3) && (count_Em <= 4))
                str += Settings.Default.Empatia + "\n" + Settings.Default.Em_med + "\n \n";

            if ((count_Em >= 5) && (count_Em <= 6))
                str += Settings.Default.Empatia + "\n" + Settings.Default.Em_high + "\n \n";
           
        //*******************навыки взаимодействия 
            if (count_N <= 2)
                str += Settings.Default.Skills + "\n" + Settings.Default.Skills_low + "\n \n";

            if ((count_N >= 3) && (count_N <= 4))
                str += Settings.Default.Skills + "\n" + Settings.Default.Skills_med + "\n \n";

            if ((count_N >= 5) && (count_N <= 6))
                str += Settings.Default.Skills + "\n" + Settings.Default.Skills_high + "\n \n";
          
        //******************самомотивация
            if (count_Sam <= 2)
                str += Settings.Default.Motivation + "\n" + Settings.Default.Motivation_low + "\n \n";

            if ((count_Sam >= 3) && (count_Sam <= 4))
                str += Settings.Default.Motivation + "\n" + Settings.Default.Motivation_med + "\n \n";

            if ((count_Sam >= 5) && (count_Sam <= 6))
                str += Settings.Default.Motivation + "\n" + Settings.Default.Motivation_high + "\n \n";
          
            MessageBox.Show(str);
            Settings.Default.temp_str = str;
            button4.Visible = true;
            
        }

        private void button2_Click(object sender, EventArgs e) // нет
        {
            if (index != 29)
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

        #endregion Control

        private void button4_Click(object sender, EventArgs e)
        {
            Doc.Act(Settings.Default.temp_str);
        }
    }
    
  

}
