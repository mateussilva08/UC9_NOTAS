string [,] alunos = new string [5, 7];
int linha;
int coluna;

for (linha = 0; linha <= 4; linha++)
{
    Console.Clear();
    Console.WriteLine("Informe o nome do aluno");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine(" Informe o numero de aulas dadas");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe o numero de faltas");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota da prova 1");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota da prova 2");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota da prova 3");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Informe a nota do trabalho");
    alunos[linha, coluna++] = Console.ReadLine();

    coluna = 0;
}