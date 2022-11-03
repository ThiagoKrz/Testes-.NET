using Calculadora.Models;

string option;
bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite aqui a opção selecionada:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    option = Console.ReadLine();
    switch(option)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu=false;
            // Environment.Exit(0);
            break;
            default:

            Console.WriteLine("Opção inválida");
            break;
    }
}

Console.WriteLine("O programa se encerrou.");


// int soma=0, numero = 0;
// do
// {
//     Console.WriteLine("Digite um número(0 para parar):");
//     numero = Convert.ToInt32(Console.ReadLine());
//     soma += numero;

// } while(numero != 0);
// Console.WriteLine($"Total da soma dos números digitados é:{soma}");

// int n1 = 5;
// int contador = 0;
// while(contador<=10)
// {
//     Console.WriteLine($"{contador+1}º Execução: {n1} x {contador} = {n1 * contador}");
//     contador++;

//     if(contador == 6)
//     {
//         break;
//     }
// }

// int n1= 2;
// for(int contador = 0; contador <= 100; contador++){
// Console.WriteLine($"{n1} x {contador} = {n1 * contador}");
// }

// Calculador calc = new Calculador();
// calc.Potencia(3,3);
// calc.Somar(1,2);
// calc.Subtrair(5,2);
// calc.Dividir(50,2);
// calc.Multiplicar(5,2);
