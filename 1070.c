#include <stdio.h>
 
int main() {
 
    int n, i, impares;

    impares=0;

    scanf("%d", &n);

    for(i=n;impares<6;i++) {
        if(i % 2 == 1) {
            printf("%d\n", i);
            impares++;
        }
    }
        
            
 
    return 0;
}