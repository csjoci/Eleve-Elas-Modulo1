
class Aula04
{
    static void Main() // exemplos do uso de try/catch em C#
    {
        try
        {
            int divisor = 0;
            int result = 10 / divisor; // Isso causará uma exceção de divisão por zero

            string path = "nonexistentfile.txt";
            string content = File.ReadAllText(path); // Isso causará uma FileNotFoundException

            PrintMessage(null); // Isso causará uma ArgumentNullException
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Erro: Tentativa de dividir por zero.");
            Console.WriteLine("Detalhes do erro: " + ex.Message);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Arquivo não encontrado: " + ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Argumento nulo: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Trata qualquer outra exceção não específica
            Console.WriteLine("Um erro ocorreu: " + ex.Message);
        }
        finally
        {
            // Código que sempre será executado, independentemente de uma exceção ter sido lançada ou não
            Console.WriteLine("Bloco finally executado.");
        }

        static void PrintMessage(string message)
        {
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message), "O argumento 'message' não pode ser nulo.");
            }

            Console.WriteLine(message);
        }
    }
}

