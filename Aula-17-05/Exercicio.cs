// Aula 03: Operadores aritméticos, relacionais e lógicos, Estrutura de decisões, estrutura de Repetição.

// Exercicio1 : Criar uma calculadora com as 4 operaçoes
// em que o usuario passe 2 numeros e a operacao que deseja.

Console.WriteLine("Informe o primeiro numero: ");
decimal primeiro = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe o segundo numero: ");
decimal segundo = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe a operação:");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtracao");
Console.WriteLine("3 - Multiplicacão");
Console.WriteLine("4 - Divisão");
int op = Convert.ToInt32(Console.ReadLine());

decimal resultado;
if (op == 1)
{
    resultado = primeiro + segundo;
}
else if (op == 2)
{
    resultado = primeiro - segundo;
}
else if (op == 3)
{
    resultado = primeiro * segundo;
}
else if (op == 4)
{
    resultado = primeiro / segundo;
}
else
{
    resultado = -1;
}

Console.WriteLine($"O Resultado é: {resultado}");

//Exercicio2: Faça um menu

//1 - Add nome
//2 - Add Data de nascimento
//3 - Add Estado Civil
//4 - Liste todos os nomes
//5 - Liste todas as datas de nascimento
//6 - Liste todos os estados civil
//7 - Sair

int option = -1;
List<string> nameList = new List<string>();
List<DateTime> dataList = new List<DateTime>();
List<string> stateList = new List<string>();
do
{
    Console.WriteLine("** Menu **");
    Console.WriteLine("Informe uma opcão:");
    Console.WriteLine("1 - Add nome");
    Console.WriteLine("2 - Add Data de nascimento");
    Console.WriteLine("3 - Add Estado Civil");
    Console.WriteLine("4 - Liste todos os nomes");
    Console.WriteLine("5 - Liste todas as datas de nascimento");
    Console.WriteLine("6 - Liste todos os estados civil");
    Console.WriteLine("7 - Sair");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            string optionContinue = "s";
            do
            {
                Console.WriteLine("Você escolheu a opcão de adicionar um nome.");
                Console.WriteLine("Qual o nome que gostaria de informar?");
                string nome = Console.ReadLine();
                nameList.Add(nome);
                Console.WriteLine("Gostaria de informar outro nome? (s/n)");
                optionContinue = Console.ReadLine();
            } while (optionContinue == "s");
            break;
        case 2:
            string optionContinueData = "s";
            do
            {
                Console.WriteLine("Você escolheu a opcão de adicionar uma Data de nascimento.");
                Console.WriteLine("Qual data que gostaria de informar? (dia-mes-ano)");
                string data = Console.ReadLine();
                dataList.Add(DateTime.Parse(data));
                Console.WriteLine("Gostaria de informar outra data? (s/n)");
                optionContinueData = Console.ReadLine();
            } while (optionContinueData == "s");
            break;
        case 3:
            string optionContinueCivil = "s";
            do
            {
                Console.WriteLine("Você escolheu a opcão de adicionar um Estado Civil.");
                Console.WriteLine("Qual estado que gostaria de informar?");
                string civil = Console.ReadLine();
                stateList.Add(civil);
                Console.WriteLine("Gostaria de informar outro estado civil? (s/n)");
                optionContinueCivil = Console.ReadLine();
            } while (optionContinueCivil == "s");
            break;
        case 4:
            Console.WriteLine("A lista de nomes é: ");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            break;
        case 5:
            Console.WriteLine("A lista de Datas é: ");
            foreach (var item in dataList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            break;
        case 6:
            Console.WriteLine("A lista de Estados civil é: ");
            foreach (var item in stateList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            break;

        default:
            if (option != 7)
                Console.WriteLine("Informe uma opção valida!");
            break;
    }

} while (option != 7);








