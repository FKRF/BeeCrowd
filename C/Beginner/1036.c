#include <stdio.h>
#include <math.h>

void fBhaskara(float a, float b, float c, float* r1, float* r2) {

    float delta;

    delta = b*b - 4*a*c;

    if (delta < 0 || a == 0) {
        printf("Impossivel calcular\n");
        *r1 = 0;
        *r2 = 0;
    }
    else {
        *r1 = (- b + sqrt(delta) ) / (2*a);
        *r2 = (- b - sqrt(delta) ) / (2*a);
        printf("R1 = %.5f\n", *r1);
        printf("R2 = %.5f\n", *r2);
    }
}
int main() {

    float A, B, C, R1, R2;

    scanf("%f %f %f", &A, &B, &C);
    fBhaskara(A, B, C, &R1, &R2);

    return 0;

}
