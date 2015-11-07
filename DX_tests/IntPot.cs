using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;




namespace DX_tests
{
    public partial class IntPot : Form
    {
        string[] pictur = {
                                 "t1.png",
                                 "t2.png",
                                 "t3.png",
                                 "t4.png"
                                 
            };

        string[] mainP = new string[29] {
                                        "s1.png",
                                        "s2.png",
                                        "s3.png",
                                        "s4.png",
                                        "s5.png",
                                        "s6.png",
                                        "s7.png",
                                        "s8.png",
                                        "s9.png",
                                        "s10.png",
                                        "s11.png",
                                        "s12.png",
                                        "s13.png",
                                        "s14.png",
                                        "s15.png",
                                        "s16.png",
                                        "s17.png",
                                        "s18.png",
                                        "s19.png",
                                        "s20.png",
                                        "s21.png",
                                        "s22.png",
                                        "s23.png",
                                        "s24.png",
                                        "s25.png",
                                        "s26.png",
                                        "s27.png",
                                        "s28.png",
                                        "s29.png"
        
        };

        int[] OK = new int[29]{2,3,2,6,3,5,6,2,3,3,2,2,6,5,4,1,3,5,6,2,5,6,1,4,2,6,3,1,5};
        int count = 0;
        bool flag = false;
        string[] answers = new string[29]; //массив ответов тестового задания

        int index = 0;  //индекс номера вопроса
        int indexAn = 0;  //индекс тестовых ответов
        string path = "";
        int index2 = 0; 
        

        public IntPot()
        {
            InitializeComponent();
            button7.Visible = false;
       
        }
        //
        private void IntPot_Load(object sender, EventArgs e)
        {

        }


        private void Way(int ind)  //функция устанавливает путь до картинки и загружает её в PictureBox
        {   
            try
            {
            path = AppDomain.CurrentDomain.BaseDirectory;
            path = Path.Combine(path, "Icons");
            path = Path.Combine(path, mainP[ind]);
            Bitmap image1 = new Bitmap(path);
            pictureBox1.Image = (image1);
            }
            catch (IndexOutOfRangeException ty)
            {
              //  MessageBox.Show("Больше не жмите эту кнопку!", ty.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
            if (flag == false) //если false, то выполняются тренировочные задания
            {
                if (index == -1)
                {
                    answers[indexAn] = "+";
                    indexAn++;
                }
                else
                {
                    answers[indexAn] = "-";
                    indexAn++;
                }
                if (index < 3) index++; else button7.Visible = true;
                path = AppDomain.CurrentDomain.BaseDirectory;
                path = Path.Combine(path, "Icons");
                path = Path.Combine(path, pictur[index]);
                Bitmap image1 = new Bitmap(path);
                pictureBox1.Image = (image1);
            }
            else
            {
                if (1 == OK[index])
                {
                    count++;
                    index++;
                    index2++;
                }

                else
                {
                    index++;
                    index2++;
                }
                Way(index);
                if (index2 == 29) button7.Enabled = true;
            
            }
            
        }
            catch (IndexOutOfRangeException ty)
            {
              //  MessageBox.Show("Больше не жмите эту кнопку!", ty.Message);
            } 
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    if (index == -1)
                    {
                        answers[indexAn] = "+";
                        indexAn++;
                    }
                    else
                    {
                        answers[indexAn] = "-";
                        indexAn++;
                    }
                    if (index < 3) index++; else button7.Visible = true;
                    path = AppDomain.CurrentDomain.BaseDirectory;
                    path = Path.Combine(path, "Icons");
                    path = Path.Combine(path, pictur[index]);
                    Bitmap image1 = new Bitmap(path);
                    pictureBox1.Image = (image1);
                }
                else
                {
                    if (2 == OK[index])
                    {
                        count++;
                        index++;
                        index2++;
                    }

                    else
                    {
                        index++;
                        index2++;
                    }
                    Way(index);
                    if (index2 == 29) button7.Enabled = true;

                }
            }
            catch (IndexOutOfRangeException ty)
            {
                //  MessageBox.Show("Больше не жмите эту кнопку!", ty.Message);
            } 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    if (index == 3)
                    {
                        answers[indexAn] = "+";
                        indexAn++;
                    }
                    else
                    {
                        answers[indexAn] = "-";
                        indexAn++;
                    }
                    if (index < 3) index++; else button7.Visible = true;
                    path = AppDomain.CurrentDomain.BaseDirectory;
                    path = Path.Combine(path, "Icons");
                    path = Path.Combine(path, pictur[index]);
                    Bitmap image1 = new Bitmap(path);
                    pictureBox1.Image = (image1);
                }
                else
                {
                    if (3 == OK[index])
                    {
                        count++;
                        index++;
                        index2++;
                    }

                    else
                    {
                        index++;
                        index2++;
                    }
                    Way(index);
                    if (index2 == 29) button7.Enabled = true;

                }
            }
            catch (IndexOutOfRangeException ty)
            {
                //  MessageBox.Show("Больше не жмите эту кнопку!", ty.Message);
            } 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    if ((index == 1) || (index == 2))
                    {
                        answers[indexAn] = "+";
                        indexAn++;
                    }
                    else
                    {
                        answers[indexAn] = "-";
                        indexAn++;
                    }
                    if (index < 3) index++; else button7.Visible = true;
                    path = AppDomain.CurrentDomain.BaseDirectory;
                    path = Path.Combine(path, "Icons");
                    path = Path.Combine(path, pictur[index]);
  
                    Bitmap image1 = new Bitmap(path);
                    pictureBox1.Image = (image1);

                }
                else
                {
                    if (4 == OK[index])
                    {
                        count++;
                        index++;
                        index2++;
                    }

                    else
                    {
                        index++;
                        index2++;
                    }
                    Way(index);
                    if (index2 == 29) button7.Enabled = true;
                }
            }
            catch (IndexOutOfRangeException ty)
            {
                //  MessageBox.Show("Больше не жмите эту кнопку!", ty.Message);
            } 
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    if (index == -1)
                    {
                        answers[indexAn] = "+";
                        indexAn++;
                    }
                    else
                    {
                        answers[indexAn] = "-";
                        indexAn++;
                    }
                    if (index < 3) index++; else button7.Visible = true;
                    path = AppDomain.CurrentDomain.BaseDirectory;
                    path = Path.Combine(path, "Icons");
                    path = Path.Combine(path, pictur[index]);
                    Bitmap image1 = new Bitmap(path);
                    pictureBox1.Image = (image1);
                }
                else
                {
                    if (5 == OK[index])
                    {
                        count++;
                        index++;
                        index2++;
                    }

                    else
                    {
                        index++;
                        index2++;
                    }
                    Way(index);
                    if (index2 == 29) button7.Enabled = true;
                }
            }
            catch (IndexOutOfRangeException ty)
            { }
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    if (index == 0)
                    {
                        answers[indexAn] = "+";
                        indexAn++;
                    }
                    else
                    {
                        answers[indexAn] = "-";
                        indexAn++;
                    }
                    if (index < 3) index++; else button7.Visible = true;
                    path = AppDomain.CurrentDomain.BaseDirectory;
                    path = Path.Combine(path, "Icons");
                    path = Path.Combine(path, pictur[index]);
                    Bitmap image1 = new Bitmap(path);
                    pictureBox1.Image = (image1);
                }
                else
                {
                    if (6 == OK[index])
                    {
                        count++;
                        index++;
                        index2++;
                    }

                    else
                    {
                        index++;
                        index2++;
                    }
                    Way(index);
                    if (index2 == 29) button7.Enabled = true;
                  //  if (index == 28) button7.Enabled = true;
                }
            }
            catch (IndexOutOfRangeException ty)
            {
                //  MessageBox.Show("Больше не жмите эту кнопку!", ty.Message);
            } 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {

                Properties.Settings.Default.t1 = answers[0];
                Properties.Settings.Default.t2 = answers[1];
                Properties.Settings.Default.t3 = answers[2];
                Properties.Settings.Default.t4 = answers[3];

                IntPot2 IP2 = new IntPot2();
                IP2.Show();
            }
            else
            {
                string temp = Convert.ToString(count);
                if (count < 10) MessageBox.Show(string.Format("Количество правильных ответов {0}.Уровень интеллекта низкий.",temp),"Результат теста");
                if ((count > 10) && (count < 16)) MessageBox.Show(string.Format("Количество правильных ответов {0}.Уровень интеллекта сниженный.", temp), "Результат теста");
                if ((count > 15) && (count < 21)) MessageBox.Show(string.Format("Количество правильных ответов {0}.Уровень интеллекта средний.", temp), "Результат теста");
                if ((count > 20) && (count < 26)) MessageBox.Show(string.Format("Количество правильных ответов {0}.Уровень интеллекта высокий.", temp), "Результат теста");
                if (count > 25) MessageBox.Show(string.Format("Количество правильных ответов {0}.Уровень интеллекта очень высокий.", temp), "Результат теста");
                   
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            flag = true;
            index = 0;
            path = AppDomain.CurrentDomain.BaseDirectory;
            path = Path.Combine(path, "Icons");
            path = Path.Combine(path, mainP[index]);
            Bitmap image1 = new Bitmap(path);
            pictureBox1.Image = (image1);
            button8.Enabled = false;
            button7.Visible = true;
            button7.Enabled = false;

        }


    }
}
