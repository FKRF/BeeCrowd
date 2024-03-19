#include <stdio.h>
 
int main() {
 
    int i, pos;
    float n;

    for(i=0, pos=0;i<6;i++) {
        scanf("%f", &n);
        if(n>0)
            pos++;
    }
    printf("%d valores positivos\n", pos);
 
    return 0;
}