#include <iostream>
#include <string>
using namespace std;

struct Lista
{
	int pront;
	string nome;
	double sal;
	
	struct Lista *prox;
};

Lista* init()
{
	return NULL;
}

int isEmpty(Lista* lista)
{
	return (lista == NULL);
}

Lista* insert(Lista* lista, int i, string i2, double i3)
{	
	Lista* nova = new Lista;
	nova->pront = i;
	nova->nome = i2;
	nova->sal = i3;
	nova->prox = lista;
	
	return nova;
}

void print(Lista* lista)
{
	Lista *aux;
	aux = lista;
	while(aux != NULL)
	{
		cout << "Prontuario: " << aux->pront << " || " << "Nome: " << aux->nome << " || " <<"Salario: " << aux->sal << endl; 
		aux = aux->prox;
	}
}

void soma(Lista* lista)
{
	Lista *aux;
	aux = lista;
	int soma = 0;
	while(aux != NULL)
	{
		soma = soma + aux->sal;
		aux = aux->prox;
	}
	cout << "Soma de salarios: " << soma << endl;
}

void opcoes()
{
	cout << "--------------------" << endl;
	cout << "0 - Sair" << endl;
	cout << "1 - Incluir" << endl;
	cout << "2 - Excluir" << endl; 
	cout << "3 - Pesquisar" << endl; 
	cout << "4 - Listar" << endl;
	cout << "Digite o numero correspondente: ";
} 

Lista* find(Lista* lista, int i)
{
	Lista* aux;
	aux = lista;
	while (aux != NULL && aux->pront != i)
	{
		aux = aux->prox;
	}
	return aux;
}

Lista* remove(Lista* lista, int i)
{
	Lista *ant = NULL;
	Lista *aux;
	
	aux = lista;
	while(aux != NULL && aux->pront != i)
	{
		ant = aux;
		aux = aux->prox;
	}
	if (aux == NULL)
	{
		return lista;
	}
	if (ant == NULL)
	{
		lista = aux->prox;
	}
	else
	{
		ant->prox = aux->prox;
	}
	free(aux);
	return lista;
}

int main(int argc, char** argv)
{
	int opcao;
	int opcao2=1;
	string nome;
	double sal;
	int pront = 1;
	int pront2;
	Lista *minhaLista;
	minhaLista = init();
	
	cout << "Prontuarios automaticos iniciados por 1..." << endl;
	do
	{
		opcoes();
		cin >> opcao;
		
		if(opcao ==1)
		{
			do 
			{
			cout << "Digite o nome do funcionario: ";
			cin >> nome;
			cout << "Digite o salario do funcionario: ";
			cin >> sal;
			minhaLista = insert(minhaLista, pront, nome, sal);

			cout << "Deseja incluir outro funcionario? (Sim = 1 || Nao = 2)" << endl;
			cin >> opcao2;
			pront++;
			}
			while(opcao2 == 1);
		} 
		
		if(opcao == 4)
		{
			cout << "Lista vazia: " << (isEmpty(minhaLista)?"Sim":"Nao") << endl;
			print(minhaLista);
			soma(minhaLista);
		}
		
		if(opcao == 3)
		{
			cout << "Digite o prontuario para a pesquisa: ";
			cin >> pront2;
			Lista *pesquisa = find(minhaLista, pront2);
			if (pesquisa != NULL)
			{
				cout << "Nome: " << pesquisa->nome << " || " <<"Salario: " << pesquisa->sal <<endl;
			}
			else 
			{
				cout << "Funcionario nao encontrado, prontuario invalido..." << endl;
			}
		}
		
		if (opcao == 2)
		{
			cout << "Digite o prontuario para a exclusao: ";
			cin >> pront2;
			remove(minhaLista, pront2);
		}
	}
	while(opcao != 0);
	
	return 0;
}
