#include <stdio.h>
 
int main() {
 
    float a, b, c, calc, abc[3], aux;
    int i, j;
    scanf("%f %f %f", &a, &b, &c);

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

    a = abc[0];
    b = abc[1];
    c = abc[2];
    if (a >= b + c)
        printf("Area = %.1f\n", (a+b)*0.5*c);
    else
        printf("Perimetro = %.1f\n", a+b+c);
 
    return 0;
}