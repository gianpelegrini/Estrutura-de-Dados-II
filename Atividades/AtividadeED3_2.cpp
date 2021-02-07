#include <iostream>
using namespace std;

struct No {
	float dado;
	struct No *prox;	
};

struct Pilha {
	No *topo;
};

Pilha* init(){
	Pilha *p = new Pilha;
	p->topo = NULL;
	return p;
}

int isEmpty(Pilha *p) {
	return (p->topo ==NULL);
}

void push(Pilha *p, float v) {
	No *no = new No;
	no->dado =v;
	no->prox = p->topo;
	p->topo = no;
} 

float pop(Pilha *p){
	float ret;
	No *no = p->topo;
	ret = no->dado;
	p->topo = no->prox;
	free(no);
	return ret;
}

void print(Pilha *p){
	No *no;
	no = p->topo;
	while(no != NULL){
		cout << no->dado << endl;
		no = no->prox;
	}
	cout << "-----------------" << endl;
}
int main(int argc, char** argv)
{
	int val[30];
	Pilha *pilhaFloatImpar;
	Pilha *pilhaFloatPar;
	pilhaFloatImpar = init();
	pilhaFloatPar = init();
	int ant = -1;
	int aux = 0;
	
	cout << "Digite os valores: " << endl;
	
	for(int i=0;i<5;i++)
	{
		do
		{
			cin >> val[30];
			if(val[i]<ant){
				cout << "O numero deve ser maior que o anterior, digite novamente: " << endl;
				aux = 1;
			}
			else
			{
				aux = 0;
			}
		}
		while(aux==1);

		
		if(val[i]%2==0)
		{
			push(pilhaFloatPar, val[i]);
		}
		else
		{
			push(pilhaFloatImpar, val[i]);
		}
		
		ant = val[i];

	}
	
	cout << "Exibicao dos numeros de forma decrescente" << endl;
	
	cout << "Valores Pares:" << endl;
	print(pilhaFloatPar);
	cout << "Valores Impares" << endl;
	print(pilhaFloatImpar);
	
	return 0;
}