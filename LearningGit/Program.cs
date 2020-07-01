using System;

namespace LearningGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dia de Aprender a usar Git...");

            Console.WriteLine("Já sei alguns comandos: git init, git config --global user.name/email, git add, " +
                "git status, git commit -m 'mensagem explicativa'");

            Console.WriteLine("Modifiquei algo no programa e acabei me enrolando ou tiver resultado insatisfatório:" +
                " git clean -df e depois git checkout --. Autorizar na IDE voltar ao último commit.");

            Console.ReadLine();


        }
    }
}
