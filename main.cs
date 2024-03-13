using System;

class Program
{

    int valorSorteado;
    int valorAnterior;
    int valorSomado;

    Random numeroAleatorio = new Random();

    public static void Main()
    {

        Program prgm = new Program();

        Console.WriteLine("Neste jogo você deve acertar o número que o computador escolheu entre 1 e 20. Caso erre, você podera tentar novamente mas o numero será a soma do número anterior somado ao novo número sorteado. Boa sorte!");
        Console.WriteLine("Vamos iniciar!");

        prgm.Start();
    }

    public void Start()
    {
        valorAnterior = 0;
        valorSomado = 0;
        valorSorteado = 0;

        Sorteios();
    }

    public void Sorteios()
    {
        int rnd = numeroAleatorio.Next(1, 20);

        valorSorteado = rnd;

        //Console.WriteLine("Valor sorteado: " + valorSorteado);//

        SomarValores();
    }

    public void SomarValores()
    {
        valorSomado = valorAnterior + valorSorteado;

        InputJogador();
    }
    public void InputJogador()
    {
        Console.Write("De seu Palpite: ");
        string palpite = Console.ReadLine();

        if (palpite == valorSomado.ToString())
        {
            Console.WriteLine("Parabéns, você acertou!");
            EncerrarAplicacao();
        }
        else
        {
            if (valorSomado >= 100)
            {
                Console.WriteLine("Vitória do Computador!");
                EncerrarAplicacao();
                return;
            }

            Console.WriteLine("Errou. Tente agora adivinhar o valor somado dos Sorteios");
            valorAnterior = valorSomado;
            Sorteios();
        }
    }
    public void EncerrarAplicacao()
    {
        Environment.Exit(0);
    }
}
