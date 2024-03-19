#include <stdio.h>
 
int main() {
 
    int item, qtd;
    float valor;

    scanf("%d %d", &item, &qtd);
    switch (item)
    {
    case 1:
        valor = qtd*4.0;
        break;
    case 2:
        valor = qtd*4.5;
        break;
    case 3:
        valor = qtd*5;
        break;
    case 4:
        valor = qtd*2.0;
        break;
    case 5:
        valor = qtd*1.5;
        break;
    default:
        break;
    }
    printf("Total: R$ %.2f\n", valor);
 
    return 0;
}