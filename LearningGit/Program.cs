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
            Console.WriteLine();
            Console.WriteLine("Até aqui fizemos apenas gits em repositórios locais com auxílio do Git Bash.");
            Console.WriteLine();
            Console.WriteLine("No GitHub, criar um repositório remoto. Para associar ele, usa-se git remote" +
                " add origin <URI>. Existe uma linha no GitHub pronta para ser copiada e colada no GB.");
            Console.WriteLine();
            Console.WriteLine("Agora os repositórios estão associados. Para subir o repositório, faremos" +
                " git push -u origin master. É mais fácil 'viajar' pelas versões de commit no GitHub." +
                "Vale ressaltar a importância de estar no e-mail certo no git config --global user.name/email.");
            Console.WriteLine();
            Console.WriteLine("E do repositório remoto para o local? Usamos git clone <URI>. Fará o download" +
                "do repositório com as versões em detalhes. Caso já tenha copiado o projeto, mas ele tenha sido" +
                "atualizado, usa-se o comando git push. Fornecer os dados do usuário." +
                "Para atualizar o repositório local (ex.: teu colega programou algo), basta fazer git pull" +
                " origin master");
            Console.WriteLine();
            Console.WriteLine("Aqui termina todo o básico de Git. Que fique registrado como o primeiro git =)");
            
           



        }
    }
}
