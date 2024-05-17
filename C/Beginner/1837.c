#include <stdio.h>
 
 int divE(int a, int b ) {
    int q = a/b;
    int r = a%b;
    printf("q = %d r = %d\n", q, r);
    if (r < 0) { // se a for negativo, r sera negativo
        if (b > 0) 
            q = q-1;  //  caso a = -7 b = 3
        else // 
            q = q+1; //  caso a = -7 b = -3
    }

    return q;
}

int modE(int a, int b ) {
    int r = a%b;
    if (r < 0) {
        if (b > 0) 
            r = r + b; // caso a = -7 b = 3
        else 
            r = r - b; // caso a = -7 b = -3
    }

    return r;
}

int main() {

    int a, b, q, r;

    scanf("%d %d", &a, &b);
    q = divE(a, b);
    r = modE(a, b);
    printf("q = %d r = %d\n", q, r);



}

