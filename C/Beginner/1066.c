#include <stdio.h>
#include <stdlib.h>
 
int main() {
 
    int i, n, qtd_par, qtd_impar, qtd_pos, qtd_neg;

    qtd_par = qtd_impar = qtd_pos = qtd_neg = 0;
    for(i=0;i<5;i++) {
        scanf("%d", &n);
        if(n % 2 == 0)
            qtd_par++;
        if(abs(n) % 2 == 1)
            qtd_impar++;
        if(n > 0)
            qtd_pos++;
        if(n < 0)
            qtd_neg++;       
    }
    printf("%d valor(es) par(es)\n", qtd_par);
    printf("%d valor(es) impar(es)\n", qtd_impar); 
    printf("%d valor(es) positivo(s)\n", qtd_pos); 
    printf("%d valor(es) negativo(s)\n", qtd_neg); 

    return 0;
}