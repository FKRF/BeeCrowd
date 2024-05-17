#include <stdio.h>
 
int main() {
 
    int i, pos;
    float n, media;

    for(i=0, pos=0, media=0;i<6;i++) {
        scanf("%f", &n);
        if(n>0) {
            pos++;
            media += n;
        }
            
    }
    printf("%d valores positivos\n", pos);
    printf("%.1f\n", media/pos);
 
    return 0;
}