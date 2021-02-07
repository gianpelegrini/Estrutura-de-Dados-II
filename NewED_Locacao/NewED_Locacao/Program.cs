using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewED_Locacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux;

            Contratos contratos = new Contratos();
            Equipamentos equipamentos = new Equipamentos();

            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Cadastrar tipo de equipamento");
            Console.WriteLine("2 - Consultar tipo de equipamento");
            Console.WriteLine("3 - Cadastrar equipamento");
            Console.WriteLine("4 - Registrar Contrato de Locação");
            Console.WriteLine("5 - Consultar Contratos de Locação");
            Console.WriteLine("6 - Liberar de Contrato de Locação");
            Console.WriteLine("7 - Consultar Contratos de Locação liberados");
            Console.WriteLine("8 - Devolver equipamentos de Contrato de Locação liberado");

            Console.WriteLine("Escolha uma opção: ");
            aux = int.Parse(Console.ReadLine());

            while (aux != 0)
            {
                if (aux == 1)
                {
                    string tipo;
                    Tipos o_tipo = new Tipos();

                    Console.WriteLine("Digite o tipo de equipamento:");
                    tipo = Console.ReadLine();

                    o_tipo.Tipo = tipo;
                    equipamentos.incluir(o_tipo);
                }
                if (aux == 2)
                {
                    string tipo;
                    Tipos o_tipo = new Tipos();

                    Console.WriteLine("Digite o tipo de equipamento:");
                    tipo = Console.ReadLine();

                    o_tipo.Tipo = tipo;
                    foreach (Tipos t in equipamentos.Estoque)
                    {
                        if (t.Equals(o_tipo))
                        {
                            Console.WriteLine("Tipo:" + o_tipo.Tipo);
                            foreach (Equipamento e in t.Itens)
                            {
                                Console.WriteLine("Id:" + e.Id);
                                Console.WriteLine("Avariado: " + (e.Avariado?"Sim":"Não"));
                                Console.WriteLine("Disponivel:" + (e.Locado? "Sim" : "Não"));
                            }
                        }
                    }
                }
                if (aux == 3)
                {
                    string tipo;
                    Tipos o_tipo = new Tipos();

                    Console.WriteLine("Digite o tipo de equipamento: ");
                    tipo = Console.ReadLine();

                    o_tipo.Tipo = tipo;

                    foreach (Tipos t in equipamentos.Estoque)
                    {
                        if (t.Equals(o_tipo))
                        {
                            Console.WriteLine("Quantos equipamentos deseja cadastrar: ");
                            int qtdE = int.Parse(Console.ReadLine());
                            for (int i = 0; i < qtdE; i++)
                            {
                                Equipamento e = new Equipamento();
                                e.Locado = false;
                                e.Avariado = false;
                                t.incluir(e);
                            }
                        }
                    }
                }
                if (aux == 4)
                {
                    string aux2 = "";
                    string dt_saida;
                    string dt_retorno;
                    Contrato contrato = new Contrato();

                    Console.WriteLine("Digite a data de saida: ");
                    dt_saida = Console.ReadLine();
                    Console.WriteLine("Digite a data de retorno: ");
                    dt_retorno = Console.ReadLine();

                    contrato.Dt_saida = DateTime.Parse(dt_saida);
                    contrato.Dt_retorno = DateTime.Parse(dt_retorno);


                    while (aux2 != "0")
                    {
                        string tipo;
                        Tipos o_tipo = new Tipos();

                        Console.WriteLine("Digite o tipo de equipamento: ");
                        tipo = Console.ReadLine();

                        Console.WriteLine("Quantos equipamentos deseja cadastrar: ");
                        int qtde = int.Parse(Console.ReadLine());

                        o_tipo.Tipo = tipo;

                        for (int i = 0; i < qtde; i++)
                        {
                            Equipamento e = new Equipamento();
                            e.Locado = false;
                            e.Avariado = false;

                            o_tipo.incluir(e);

                            foreach (Tipos tipos in equipamentos.Estoque)
                            {
                                if (equipamentos.Estoque.Equals(o_tipo))
                                {
                                    foreach (Equipamento o_e in tipos.Itens)
                                    {
                                        if (o_e.Equals(e))
                                        {
                                            o_e.Locado = true;
                                        }
                                    }
                                }
                            }

                        }
                        contrato.incluir(o_tipo);

                        Console.WriteLine("Digite 0 se não quiser cadastrar outro equipamento: ");
                        aux2 = Console.ReadLine();
                    }

                    contratos.incluir(contrato);

                }
                if (aux == 5)
                {
                    int o_contrato;
                    Contrato contrato = new Contrato();

                    Console.WriteLine("Digite o codigo do Contrato:");
                    o_contrato = int.Parse(Console.ReadLine());

                    contrato.Id = o_contrato;

                    foreach (Contrato c in contratos.O_contratos)
                    {
                        if (c.Equals(contrato))
                        {
                            contrato = c;
                            foreach (Tipos t in contrato.Itens)
                            {
                                Console.WriteLine("Tipo:" + t.Tipo);
                                foreach (Equipamento e in t.Itens)
                                {
                                    Console.WriteLine("Id:" + e.Id);
                                    Console.WriteLine("Avariado:" + (e.Avariado ? "Sim" : "Não"));
                                    Console.WriteLine("Disponivel:" + (e.Locado ? "Sim" : "Não"));

                                }
                            }
                        }
                    }
                }
                if (aux == 6)
                {
                    int o_contrato;
                    Contrato contrato = new Contrato();

                    Console.WriteLine("Digite o codigo do Contrato:");
                    o_contrato = int.Parse(Console.ReadLine());
                    
                    contrato.Id = o_contrato;

                    foreach (Contrato c in contratos.O_contratos)
                    {
                        if (c.Equals(contrato))
                        {
                            c.Liberado = true;
                        }
                    }
                }
                if (aux == 7)
                {
                    foreach (Contrato c in contratos.O_contratos)
                    {
                        if (c.Liberado == true)
                        {
                            Console.WriteLine("Id: " + c.Id);
                            Console.WriteLine("DataSaida: " + c.Dt_saida);
                            Console.WriteLine("DataRetorno: " + c.Dt_retorno);
                        }
                        foreach (Tipos t in c.Itens)
                        {
                            Console.WriteLine("Tipo: " + t.Tipo);
                            foreach (Equipamento e in t.Itens)
                            {
                                Console.WriteLine("Id: " + e.Id);
                                Console.WriteLine("Avariado:" + (e.Avariado ? "Sim" : "Não"));
                                Console.WriteLine("Disponivel:" + (e.Locado ? "Sim" : "Não"));
                            }
                        }
                    }
                }
                if (aux == 8)
                {
                    int o_contrato;
                    Contrato contrato = new Contrato();

                    Console.WriteLine("Digite o codigo do Contrato: ");
                    o_contrato = int.Parse(Console.ReadLine());

                    contrato.Id = o_contrato;

                    foreach (Contrato c in contratos.O_contratos)
                    {
                        if (c.Equals(contrato))
                        {
                            contrato = c;
                            foreach (Tipos t in contrato.Itens)
                            {
                                foreach (Tipos t1 in equipamentos.Estoque)
                                {
                                    if (t == t1)
                                    {
                                        foreach (Equipamento e in t.Itens)
                                        {
                                            foreach (Equipamento e1 in t1.Itens)
                                            {
                                                if (e == e1)
                                                {
                                                    e.Locado = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }

                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Cadastrar tipo de equipamento");
                Console.WriteLine("2 - Consultar tipo de equipamento");
                Console.WriteLine("3 - Cadastrar equipamento");
                Console.WriteLine("4 - Registrar Contrato de Locação");
                Console.WriteLine("5 - Consultar Contratos de Locação");
                Console.WriteLine("6 - Liberar de Contrato de Locação");
                Console.WriteLine("7 - Consultar Contratos de Locação liberados");
                Console.WriteLine("8 - Devolver equipamentos de Contrato de Locação liberado");

                Console.WriteLine("Escolha uma opção: ");
                aux = int.Parse(Console.ReadLine());
            }

        }
    }
}
