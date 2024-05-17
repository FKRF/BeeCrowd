#include <stdio.h>
 
int main() {
 
    int c1, p1, c2, p2;
    float un1, un2, valor;
    
    scanf("%d %d %f\n%d %d %f", &c1, &p1, &un1, &c2, &p2, &un2);
    valor = p1*un1 + p2*un2;
    printf("VALOR A PAGAR: R$ %.2f\n", valor);
 
    return 0;
}
