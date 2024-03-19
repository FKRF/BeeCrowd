#include <stdio.h>
 
int main() {
 
    float old_salary, new_salary;
    int faixa_indice;
    faixa_indice = 0;
    
    scanf("%f", &old_salary);
    if (old_salary <= 400.00)
        faixa_indice = 15;
    else if (old_salary > 400.00 && old_salary <= 800.00)
        faixa_indice = 12;
    else if (old_salary > 800.00 && old_salary <= 1200.00)
         faixa_indice = 10;
    else if (old_salary > 1200.00 && old_salary <= 2000.00)
        faixa_indice = 7;
    else if (old_salary > 2000.00)
        faixa_indice = 4;

    printf("Novo salario: %.2f\n", old_salary*(1.0 + faixa_indice/100.0));
    printf("Reajuste ganho: %.2f\n", old_salary*(faixa_indice/100.0));
    printf("Em percentual: %d %%\n", faixa_indice);
    return 0;
}