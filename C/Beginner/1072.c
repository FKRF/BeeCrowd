#include <stdio.h>
 
int main() {
 
    int x, i, n, in, out;

    scanf("%d", &x);
    in = out = 0;

    for(i=0;i<x;i++) {
        scanf("%d", &n);
        if (n >= 10 && n <= 20)
            in++;
        else
            out++;
    }
    
    printf("%d in\n", in);
    printf("%d out\n", out);
    
    return 0;
}