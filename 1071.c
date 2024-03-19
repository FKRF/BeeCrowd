#include <stdio.h>
#include <stdlib.h>
 
int main() {
 
    int n1, n2, i, soma, aux;

    scanf("%d\n%d", &n1, &n2);
    if(n1>n2) {
        aux = n1;
        n1 = n2;
        n2 = aux;
    }

    soma = 0;
    for(i=n1+1;i<n2;i++) {
        if(abs(i) % 2 == 1) {
            soma += i;
        }
    }

    printf("%d\n", soma);
        
            
 
    return 0;
}