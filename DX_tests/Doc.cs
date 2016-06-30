using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace DX_tests
{
    class Doc
    {

        private static string ZAKL = "Test_link";

        private static string DOC_NAME = "Print.dot";
        private static string DOC_NAME_PROF = "PrintProf.dot";

        public static void Act(string str)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path = Path.Combine(path, DOC_NAME);

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            try
            {
                Microsoft.Office.Interop.Word.Document doc = word.Documents.Add(path);

                doc.Bookmarks[ZAKL].Range.Text = str;

                try
                {
                    word.Visible = true;
                    word.Activate(); 
                }
                catch (Exception e)
                {
                    ExceptionUtils.ShowEx(e);
                }
            }
            catch (Exception e)
            {

            //    word.Documents.Close();
                ExceptionUtils.ShowEx(e);
            }
        }

        public static void CharacterAndProf(string[] result)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            path = Path.Combine(path, DOC_NAME_PROF);

            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            try
            {
                Microsoft.Office.Interop.Word.Document doc = word.Documents.Add(path);

               doc.Bookmarks["I"].Range.Text = Convert.ToString(result[0]);
               doc.Bookmarks["II"].Range.Text = Convert.ToString(result[1]);
               doc.Bookmarks["III"].Range.Text = Convert.ToString(result[2]);
               doc.Bookmarks["IV"].Range.Text = Convert.ToString(result[3]);
               doc.Bookmarks["V"].Range.Text = Convert.ToString(result[4]);
               doc.Bookmarks["VI"].Range.Text = Convert.ToString(result[5]);
               doc.Bookmarks["VII"].Range.Text = Convert.ToString(result[6]);
               doc.Bookmarks["VIII"].Range.Text = Convert.ToString(result[7]);

                try
                {
                    word.Visible = true;
                    word.Activate();
                }
                catch (Exception e)
                {
                    ExceptionUtils.ShowEx(e);
                }
            }
            catch (Exception e)
            {

                //    word.Documents.Close();
                ExceptionUtils.ShowEx(e);
            }
        }
    }
}
