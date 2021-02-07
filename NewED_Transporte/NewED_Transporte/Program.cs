using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Transporte
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jornada = false;

            List<Transporte> transporte = new List<Transporte>();
            Veiculos veiculos = new Veiculos();
            Garagem garagem = new Garagem();
            List<Veiculos> veiculos2 = new List<Veiculos>();
            Garagens garagens = new Garagens();
            Viagens viagens = new Viagens();

            Veiculo[] o_veiculo = new Veiculo[8];
            Garagem[] a_garagem = new Garagem[2];

            for (int i = 0; i < 8; i++)
            {
                o_veiculo[i] = new Veiculo();

                o_veiculo[i].Id = i+1;
                o_veiculo[i].Placa = ("ABC" + (i+1));

                veiculos.Incluir(o_veiculo[i]);
            }

            for (int i = 0; i < 2; i++)
            {
                a_garagem[i] = new Garagem();

                a_garagem[i].Id = i + 1;
                if(i==1)
                {
                    a_garagem[i].Local = "Congonhas";
                }
                else
                {
                    a_garagem[i].Local = "Guarulhos";
                }

                garagens.Incluir(a_garagem[i]);
            }

            int aux;

            Console.WriteLine("0 - Finalizar processo");
            Console.WriteLine("1 - Cadastrar veiculo");
            Console.WriteLine("2 - Cadastrar garagem");
            Console.WriteLine("3 - Iniciar jornada");
            Console.WriteLine("4 - Encerrar jornada");
            Console.WriteLine("5 - Liberar viagem de uma determinada origem para um determinado destino");
            Console.WriteLine("6 - Listar veiculos em determinada garagem");
            Console.WriteLine("7 - Informar quantidade de viagens efetuadas de uma determinada origem para um determinado destino");
            Console.WriteLine("8 - Listar viagens efetuadas de uma determinada origem para um determinado destino");
            Console.WriteLine("9 - Informar quantidade de passageiros transportados de uma determinada origem para um determinado destino");
            Console.WriteLine("Escolha uma opção: ");

            aux = int.Parse(Console.ReadLine());

            while (aux != 0)
            {
                if (aux == 1)
                {
                    
                    if (jornada == true)
                    {
                        Console.WriteLine("Inclusão negada. Existe uma jornada ativa.");
                    }
                    else
                    {
                        Veiculo o_veiculo2 = new Veiculo();

                        int aux2 = 1;
                        while (aux2 != 0)
                        {
                            Console.WriteLine("Digite o ID: ");
                            o_veiculo2.Id = int.Parse(Console.ReadLine());
                            if (o_veiculo2.Id == 1 || o_veiculo2.Id == 2 || o_veiculo2.Id == 3 || o_veiculo2.Id == 4 || o_veiculo2.Id == 5 || o_veiculo2.Id == 6 || o_veiculo2.Id == 7 || o_veiculo2.Id == 8)
                            {
                                Console.WriteLine("Digite um ID com numeração diferente dos números de 1 à 8...");
                                aux2 = 1;
                            }
                            else
                            {
                                aux2 = 0;
                            }

                        }

                        Console.WriteLine("Digite a PLACA: ");
                        o_veiculo2.Placa = Console.ReadLine();

                        Console.WriteLine("Digite o LOTACAO: ");
                        o_veiculo2.Lotacao = int.Parse(Console.ReadLine());

                        veiculos.Incluir(o_veiculo2);
                    }
                }
                if (aux == 2)
                {
                    Garagem a_garagem2 = new Garagem();

                    int aux2 = 1;
                    while (aux2 != 0)
                    {
                        Console.WriteLine("Digite o ID: ");
                        a_garagem2.Id = int.Parse(Console.ReadLine());

                        if (a_garagem2.Id == 1 || a_garagem2.Id == 2)
                        {
                            Console.WriteLine("Digite um ID com numeração diferente dos números 1 e 2...");
                            aux2 = 1;
                        }
                        else
                        {
                            aux2 = 0;
                        }

                    }

                    Console.WriteLine("Digite a LOCAL: ");
                    a_garagem2.Local = Console.ReadLine();

                    garagens.Incluir(a_garagem2);
                }
                if (aux == 3)
                {
                    garagens.IniciarJornada();
                    Console.WriteLine("Jornada Iniciada!");
                    jornada = true;

                    int aux2 = 1;

                    do
                    {
                        if (garagem.Equals()) ;
                    }
                    while (aux2 == 1);
                }
                if (aux == 4)
                {
                    garagens.EncerrarJornada(transporte);
                    Console.WriteLine("Jornada Encerrada!");
                    jornada = false;
                }
                if (aux == 5)
                {
                    string placa;
                    string lugar;
                    Viagem viagem = new Viagem();
                    Garagem origem_garagem = new Garagem();
                    Garagem destino_garagem = new Garagem();
                    Veiculo veiculo = new Veiculo();

                    Console.WriteLine("Digite o local da garagem de origem:");
                    lugar = Console.ReadLine();

                    origem_garagem.Local = lugar;

                    foreach (Garagem g in garagens.O_Garagens)
                    {
                        if (g.Equals(origem_garagem))
                        {
                            origem_garagem = g;
                        }
                    }

                    Console.WriteLine("Digite o local da garagem de destino:");
                    lugar = Console.ReadLine();
                    destino_garagem.Local = lugar;

                    foreach (Garagem g in garagens.O_Garagens)
                    {
                        if (g.Equals(destino_garagem))
                        {
                            destino_garagem = g;
                        }
                    }

                    Console.WriteLine("Digite a placa do veiculo:");
                    placa = Console.ReadLine();
                    veiculo.Placa = placa;

                    foreach (Veiculo v in veiculos.O_Veiculos)
                    {
                        if (v.Equals(veiculo))
                        {
                            veiculo = v;
                        }
                    }
                    viagem.Origem = origem_garagem;
                    viagem.Destino = destino_garagem;
                    viagem.Veiculo = veiculo;
                    viagens.Incluir(viagem);
                }
                if (aux == 6)
                {

                }
                if (aux == 7)
                {

                }
                if (aux == 8)
                {

                }
                if (aux == 9)
                {

                }

                Console.WriteLine("0 - Finalizar processo");
                Console.WriteLine("1 - Cadastrar veiculo");
                Console.WriteLine("2 - Cadastrar garagem");
                Console.WriteLine("3 - Iniciar jornada");
                Console.WriteLine("4 - Encerrar jornada");
                Console.WriteLine("5 - Liberar viagem de uma determinada origem para um determinado destino");
                Console.WriteLine("6 - Listar veiculos em determinada garagem");
                Console.WriteLine("7 - Informar quantidade de viagens efetuadas de uma determinada origem para um determinado destino");
                Console.WriteLine("8 - Listar viagens efetuadas de uma determinada origem para um determinado destino");
                Console.WriteLine("9 - Informar quantidade de passageiros transportados de uma determinada origem para um determinado destino");
                Console.WriteLine("Escolha uma opção: ");

                aux = int.Parse(Console.ReadLine());
            }
        }
    }
}
