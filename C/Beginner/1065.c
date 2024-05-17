#include <stdio.h>
 
int main() {
 
    int i, n, qtd;

    for(i=0, qtd=0 ;i<5;i++) {
        scanf("%d", &n);
        if(n % 2 == 0) {
            qtd++;
        }
            
    }
    printf("%d valores pares\n", qtd); 
    return 0;
}