#include <stdio.h>

int main() {
 
    double a, b, c, abc[3], aux;
    
    scanf("%lf %lf %lf", &abc[0], &abc[1], &abc[2]);

    for(int i=0; i<3; i++) {
        for(int j=i+1;j<3;j++) {
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
    if(a >= b + c)
        printf("NAO FORMA TRIANGULO\n");
    else {
        if(a*a  == b*b + c*c)
            printf("TRIANGULO RETANGULO\n");
        if(a*a > b*b + c*c)
            printf("TRIANGULO OBTUSANGULO\n");
        if(a*a < b*b + c*c)
            printf("TRIANGULO ACUTANGULO\n");
        if(a == b & b == c)
            printf("TRIANGULO EQUILATERO\n");
        else if(a == b || b == c || a == c)
            printf("TRIANGULO ISOSCELES\n");
    }
    
    return 0;
}