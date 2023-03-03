string[,] alunos = new string[5, 7];
string pergunta = "";
int linha;
int coluna;
double prova1 = 0;
double prova2 = 0;
double prova3 = 0;
double trabalho = 0;
int aulas = 0;
int faltas = 0;

for (linha = 0; linha <= 4; linha++)
{
    for (coluna = 0; coluna <= 6; coluna++)
    {

        if (coluna == 0)
        {
            pergunta = "Informe o nome do aluno";
        }
        if (coluna == 1)
        {
            pergunta = "Informe o numero de aulas dadas";
        }
        if (coluna == 2)
        {
            pergunta = "Informe o numero de faltas";
        }
        if (coluna == 3)
        {
            pergunta = "Informe a nota da aula 1";
        }
        if (coluna == 4)
        {
            pergunta = "Informe a nota da aula 2";
        }
        if (coluna == 5)
        {
            pergunta = "Informe a nota da aula 3";
        }
        if (coluna == 6)
        {
            pergunta = "Informe a nota do trabalho";

            Console.WriteLine(pergunta);
            alunos[linha, coluna] = Console.ReadLine();
        }

        for (linha = 0; linha <= 4; linha++)
        {
            for (coluna = 0; coluna <= 3; coluna++)
            {
                Console.Write(" -- " + alunos[linha, coluna] + " -- ");
            }
            Console.WriteLine("");
        }
    }
}




