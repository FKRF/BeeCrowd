#include <stdio.h>
#include <math.h>
 
int main() {
 
    double valor;

    int qnotas[6], qmoedas[6], i, valor_notas, valor_moedas;
    int notas[] = {100, 50, 20, 10, 5, 2};
    int moedas[] = {100, 50, 25, 10, 5, 1};

    scanf("%lf", &valor);
    valor_notas = (int) valor;
    valor_moedas = (int) (((valor - valor_notas)*100));

    printf("NOTAS:\n");
    for(i=0;i<6;i++) {
        qnotas[i] = valor_notas / notas[i]; 
        valor_notas = valor_notas % notas[i];
        printf("%d nota(s) de R$ %d.00\n", qnotas[i], notas[i]);
    }

    valor_moedas += valor_notas*100;
    printf("MOEDAS:\n");
    for(i=0;i<6;i++) {
        qmoedas[i] = valor_moedas / moedas[i]; 
        valor_moedas = valor_moedas % moedas[i];
        printf("%d moeda(s) de R$ %.2f\n", qmoedas[i], (float) moedas[i]/100);
    }
 
    return 0;
}