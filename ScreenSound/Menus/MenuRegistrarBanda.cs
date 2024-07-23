using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegistrarBanda : Menu
{

    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda novaBanda = new(nomeDaBanda);
        bandasRegistradas.Add(novaBanda.Nome, novaBanda);
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
