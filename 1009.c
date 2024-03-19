#include <stdio.h>
#define MAX 50
 
int main() {
 
    double fixo, total_vendas, total_receber;
    char nome[MAX];
    
    fgets(nome, MAX, stdin); 
    scanf("%lf\n%lf", &fixo, &total_vendas);
    total_receber = fixo + 0.15*total_vendas;
    printf("TOTAL = R$ %.2lf\n", total_receber);
    return 0;
}
