#include <stdio.h>
 
int main() {
 
    float salario;
    int faixa_indice;
    faixa_indice = 0;
    
    scanf("%f", &salario);
    if (salario <= 2000.00)
        printf("Isento\n");
    if (salario > 2000.00 && salario <= 3000.00)
        printf("R$ %.2f\n", (salario-2000)*0.08);
    if (salario > 3000.00 && salario <= 4500.00)
        printf("R$ %.2f\n", (salario-3000)*0.18 + 1000*0.08);
    if (salario > 4500.00)
        printf("R$ %.2f\n", (salario-4500)*0.28 + 1500*0.18 + 1000*0.08);
    return 0;
}