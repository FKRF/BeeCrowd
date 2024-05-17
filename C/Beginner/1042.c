#include <stdio.h>
 
int main() {
    
    int i, j, a, b, c, abc[3], aux;

    scanf("%d %d %d", &a, &b, &c);
    abc[0] = a;
    abc[1] = b;
    abc[2] = c;

    for(i=0; i<3; i++) {
        for(j=i+1;j<3;j++) {
            if (abc[j] > abc[i]) {
                aux = abc[i];
                abc[i] = abc[j];
                abc[j] = aux;
            }
        }
    }
    
    for(i=2;i>=0; i--) printf("%d\n", abc[i]);
    printf("\n");
    printf("%d\n%d\n%d\n", a, b, c);
    return 0;
}