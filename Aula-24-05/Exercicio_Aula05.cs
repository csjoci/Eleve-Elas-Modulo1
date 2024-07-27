//Você deve criar um programa que simula o processamento de pedidos em um restaurante. 
//Cada pedido é representado por um número de pedido. 
//O restaurante tem uma fila de pedidos a serem preparados e uma pilha de pedidos concluídos.
//O programa deve oferecer as seguintes funcionalidades:
//Adicionar Pedido: Adiciona um novo pedido à fila de pedidos a serem preparados.
//Preparar Pedido: Move o pedido da fila de pedidos a serem preparados para a pilha de pedidos concluídos.
//Visualizar Pedidos Pendentes: Mostra os pedidos que ainda estão na fila de pedidos a serem preparados.
//Visualizar Pedidos Concluídos: Mostra os pedidos que foram concluídos e movidos para a pilha de pedidos concluídos.


int option = -1;
Queue<string> listaPedidos = new Queue<string>();
Stack<string> pedidosConcluidos = new Stack<string>();

do
{
    Console.WriteLine("** Menu **");
    Console.WriteLine("Informe uma opcão:");
    Console.WriteLine("1 - Adicionar Pedido");
    Console.WriteLine("2 - Preparar Pedido");
    Console.WriteLine("3 - Visualizar pedidos pendentes");
    Console.WriteLine("4 - Visualizar pedidos concluidos");
    Console.WriteLine("5 - Sair");
    option = Convert.ToInt32(Console.ReadLine());

    switch (option)
    {
        case 1:
            string optionContinue = "s";
            do
            {
                Console.WriteLine("Você escolheu a opcão de Adicionar Pedido.");
                Console.WriteLine("O que gostaria de pedir?");
                string pedido = Console.ReadLine();
                listaPedidos.Enqueue(pedido);
                Console.WriteLine("Gostaria de adicionar outro pedido? (s/n)");
                optionContinue = Console.ReadLine();
            } while (optionContinue == "s");
            break;
        case 2:
            string optionContinuePrepare = "s";
            do
            {
                Console.WriteLine("Você escolheu a opcão de Preparar Pedido.");
                if (listaPedidos.Count > 0)
                {
                    Console.WriteLine("Os ultimos pedidos realizados foram:");
                    foreach (var item in listaPedidos)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("----------------");
                    var ultimo = listaPedidos.Peek();
                    Console.WriteLine($"deseja preparar? {ultimo} (s/n)");
                    string order = Console.ReadLine();
                    if (order == "s")
                    {
                        listaPedidos.Dequeue();
                        pedidosConcluidos.Push(ultimo);
                    }
                 }
                else
                {
                    Console.WriteLine("Nada há preparar! Lista de pedidos vazia!");
                }
                Console.WriteLine("Gostaria de preparar outro pedido? (s/n)");
                optionContinuePrepare = Console.ReadLine();
            } while (optionContinuePrepare == "s");
            break;
        case 3:
            if (listaPedidos.Count > 0)
            {
                Console.WriteLine("Os ultimos pedidos realizados foram:");
                foreach (var item in listaPedidos)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("----------------");
            }
            else
            {
                Console.WriteLine("Nada há preparar! Lista de pedidos vazia!");
            }
            break;
        case 4:
            if (pedidosConcluidos.Count > 0)
            {
                Console.WriteLine("Os ultimos pedidos concluidos foram:");
                foreach (var item in pedidosConcluidos)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("----------------");
            }
            else
            {
                Console.WriteLine("Lista de concluidos vazia!");
            }
            break;


        default:
            if (option != 5)
                Console.WriteLine("Informe uma opção valida!");
            break;
    }

} while (option != 5);
