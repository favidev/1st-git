using System;

namespace LearningGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dia de Aprender a usar Git...");
            Console.WriteLine();
            Console.WriteLine("Já sei alguns comandos: git init, git config --global user.name/email, git add, " +
                "git status, git commit -m 'mensagem explicativa'");
            Console.WriteLine();
            Console.WriteLine("Modifiquei algo no programa e acabei me enrolando ou tiver resultado insatisfatório:" +
                " git clean -df e depois git checkout --. Autorizar na IDE a volta ao último commit.");
            Console.WriteLine();
            Console.WriteLine("git reset --soft HEAD~1 desfaz o commit sem alterar o arquivo. se usar hard," +
                "cuidado, pois desfará as alterações no programa também.");
            Console.WriteLine();
            Console.WriteLine("Se desejar inspecionar as versões anteriores: git checkout 'código do commit'. " +
                "Para que não haja erro, não pode ter nada pendente no stage (a ser commitado)." + " Para" + 
                " voltarmos ao ultimo commit, basta git checkout 'nome do branch', normalmente branch = master.");

            Console.ReadLine();


        }
    }
}
