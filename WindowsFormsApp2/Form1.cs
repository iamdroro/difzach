using System;
using System.Collections.Generic;

using System.Data;

using System.Linq;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp2;

namespace difzacehet
{
    public partial class Form1 : Form
    {
         List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
           
        }
      
        private void SaveToFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Файл (*.txt |*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter rt = new StreamWriter(fileName))
                    {
                        foreach (Student student in students)
                        {
                            rt.WriteLine($"{student.idd}, {student.namee}, {student.sc11}, {student.sc22}, {student.sc33}");
                        }
                    }
                    MessageBox.Show("Данны сохранены", "Сообщение");
                 
                }
                catch
                {
                    MessageBox.Show($"Ошибка загрузки данных из файла");
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл (*.txt |*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                try
                {
                    string[] lines = File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');
                        int id = int.Parse(parts[0]);
                        string name = parts[1];
                        int scorefirst = int.Parse(parts[2]);
                        int scoresecond = int.Parse(parts[3]);
                        int scorethird = int.Parse(parts[4]);
                        Student newStudent = new Student(id, name, scorefirst, scoresecond, scorethird);
                        students.Add(newStudent);
                        MessageBox.Show($"{parts[2]+parts[3]+parts[4]}","Собщение",MessageBoxButtons.OK);
                    }
                    MessageBox.Show("Данные загружены", "Сообщения");
                  
                }
                catch
                {
                    MessageBox.Show($"Ошибка загрузки данных");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int id = rnd.Next(1, 100);
                string name = textBox2.Text;
                int scorefirst = int.Parse(textBox3.Text);
                int scoresecond = int.Parse(textBox4.Text);
                int scorethird = int.Parse(textBox5.Text);


                if (scorefirst >= 0 && scorefirst < 100)
                {
                    if (scoresecond >= 0 && scoresecond < 100)
                    {
                        if (scorethird >= 0 && scorethird < 100)
                        {
                            Student newStudent = new Student(id, name, scorefirst, scoresecond, scorethird);
                            students.Add(newStudent);
                            SaveToFile();
                        }
                        else { MessageBox.Show("Вы ввели неточное значение баллов", "Ошибка"); }
                    }
                    else { MessageBox.Show("Вы ввели неточное значение баллов", "Ошибка"); }
                }
                else { MessageBox.Show("Вы ввели неточное значение баллов", "Ошибка"); }

            }
            catch
            {
                MessageBox.Show("Ошибка добавление в файл", "Ошибка");
            }
        }
    }
}
