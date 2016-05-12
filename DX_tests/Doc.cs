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
    }
}
