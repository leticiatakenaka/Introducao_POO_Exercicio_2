using Introducao_POO_Exercicio_2;

Funcionario f1 = new()
{
    Nome = "Carlos Silva",
    Salario = 6300.00
};

Funcionario f2 = new()
{
    Nome = "Ana Marques",
    Salario = 6700.00
};

Console.WriteLine($"Dados do primeiro funcionário:\nNome: {f1.Nome}\nSalário: {f1.Salario}");
Console.WriteLine($"Dados do segundo funcionário:\nNome: {f2.Nome}\nSalário: {f2.Salario}");

Console.WriteLine($"Salário médio = {(f1.Salario + f2.Salario) / 2}");