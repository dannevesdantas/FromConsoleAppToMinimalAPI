using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace FromConsoleAppToMinimalAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o servidor web Kestrel...\n");

            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", (HttpContext httpContext) =>
            {
                return "Hello, World!";
            });

            app.Run();

            Console.WriteLine("\nO servidor web foi encerrado.");

            // Acesse a aplicação web em http://localhost:5000
        }
    }
}
