using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeEvaluator.Testing
{
    public static class InputTest
    {
        public static void PredefinedTest()
        {
            Student s1 = new("Alexandru Marian");
            Student s2 = new("Ioana Popescu");
            Student s3 = new("Andrei Dumitrescu");
            Student s4 = new("Maria Ionescu");
            Student s5 = new("Vlad Georgescu");
            Student s6 = new("Elena Radu");
            Student s7 = new("Cristian Enache");
            Student s8 = new("Bianca Stoica");
            Student s9 = new("Mihai Petrescu");
            Student s10 = new("Ana-Maria Pavel");

            Note n1 = new([8, 9, 9, 9, 10]);
            Note n2 = new([7, 8, 8, 9]);
            Note n3 = new([10, 10, 9, 10]);
            Note n4 = new([6, 7, 7, 8]);
            Note n5 = new([9, 9, 8, 9, 10]);
            Note n6 = new([5, 6, 6, 7]);
            Note n7 = new([10, 9, 10]);
            Note n8 = new([8, 8, 7, 9]);
            Note n9 = new([9, 10, 10, 10]);
            Note n10 = new([7, 8, 7, 9]);

            Materie m1 = new("Matematica Speciala", "Introducere in matematica trista", n1);
            Materie m2 = new("Programare Orientata pe Obiecte", "Principiile OOP in C#", n2);
            Materie m3 = new("Structuri de Date", "Liste, stive, cozi si arbori binari", n3);
            Materie m4 = new("Algoritmica Avansata", "Analiza complexitatii si optimizarea algoritmilor", n4);
            Materie m5 = new("Baze de Date", "Modelarea datelor si limbajul SQL", n5);
            Materie m6 = new("Retele de Calculatoare", "Proiectarea si functionarea retelelor TCP/IP", n6);
            Materie m7 = new("Inteligenta Artificiala", "Introducere in algoritmi AI si machine learning", n7);
            Materie m8 = new("Sisteme de Operare", "Procese, threaduri si managementul memoriei", n8);
            Materie m9 = new("Ingineria Software", "Ciclul de viata al dezvoltarii software", n9);
            Materie m10 = new("Calcul Numeric", "Metode numerice si aproximari", n10);

            PachetAn an1 = new(1, new List<Materie>());
            PachetAn an2 = new(1, new List<Materie>());
            PachetAn an3 = new(1, new List<Materie>());

            an1.AddMaterieToPachetAn(m1);
            an1.AddMaterieToPachetAn(m2);
            an1.AddMaterieToPachetAn(m3);
            an1.AddMaterieToPachetAn(m4);
            an1.AddMaterieToPachetAn(m5);
            an2.AddMaterieToPachetAn(m6);
            an2.AddMaterieToPachetAn(m7);
            an2.AddMaterieToPachetAn(m8);
            an2.AddMaterieToPachetAn(m9);
            an2.AddMaterieToPachetAn(m10);


            Catalog catalog = new();
            catalog.AddSituatie(s1, an1);
            catalog.AddSituatie(s2, an1);
            catalog.AddSituatie(s3, an1);
            catalog.AddSituatie(s4, an1);
            catalog.AddSituatie(s5, an1);
            catalog.AddSituatie(s6, an2);
            catalog.AddSituatie(s7, an2);
            catalog.AddSituatie(s8, an2);
            catalog.AddSituatie(s9, an2);
            catalog.AddSituatie(s10, an2);


            University university = new(catalog, "Harvard");

            Console.WriteLine(university.GetAverageForAllStudents());
        }

        public static void UserInputTest()
        {


            Catalog catalog = new();

            Console.Write("Numele universitatii: ");
            string uniName = Console.ReadLine() ?? "Universitate";

            int numStudents = ReadInt("Cate inregistrari de studenti vrei sa introduci? ", min: 1);

            for (int i = 0; i < numStudents; i++)
            {
                Console.Write($"\nNumele studentului #{i + 1}: ");
                string studentName = ReadNonEmpty("Nume obligatoriu! Reincearca: ");

                Student student = new(studentName);

                int year = ReadInt("Anul de studiu (1-3): ", min: 1, max: 3);
                PachetAn pachet = new(year, new List<Materie>());

                int numSubjects = ReadInt("Cate materii are acest student? ", min: 1);

                for (int j = 0; j < numSubjects; j++)
                {
                    Console.Write($"\nNumele materiei #{j + 1}: ");
                    string matName = ReadNonEmpty("Nume materie obligatoriu! Reincearca: ");

                    Console.Write("Descriere scurta: ");
                    string descr = Console.ReadLine() ?? "";

                    List<int> grades = ReadGrades("Note (separate prin spatiu/virgula, ex: 7 8 9 10): ");

                    Note note = new(grades);
                    Materie materie = new(matName, descr, note);
                    pachet.AddMaterieToPachetAn(materie);
                }

                catalog.AddSituatie(student, pachet);
                Console.WriteLine($"\n Studentul \"{studentName}\" a fost adaugat.");
            }

            University university = new(catalog, uniName);
            Console.WriteLine($"\nMedia tuturor studentilor: {university.GetAverageForAllStudents()}");

        }

        private static int ReadInt(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                string? s = Console.ReadLine();

                if (int.TryParse(s, out int v) && v >= min && v <= max)
                    return v;

                Console.WriteLine($"Valoare invalida. Introdu un intreg intre {min} si {max}.");
            }
        }

        private static string ReadNonEmpty(string retryPrompt)
        {
            while (true)
            {
                string? s = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(s))
                    return s.Trim();

                Console.Write(retryPrompt);
            }
        }

        private static List<int> ReadGrades(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string line = Console.ReadLine() ?? "";

                string[] tokens = line.Split(new[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                List<int> list = new();

                bool ok = true;
                foreach (string t in tokens)
                {
                    if (int.TryParse(t, out int g) && g >= 1 && g <= 10)
                        list.Add(g);
                    else
                    {
                        ok = false;
                        break;
                    }
                }

                if (ok && list.Count > 0)
                    return list;

                Console.WriteLine("Introdu DOAR numere intre 1 si 10, separate prin spatii/virgule. Minim o nota.");
            }
        }
    }


}
  

