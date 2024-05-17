#include <stdio.h>
#include <math.h>

int fGreaterNumber (int N1, int N2) {

return ((N1+N2+abs(N1-N2))/2);

}
int main() {

    int A, B, C, MAIOR;

    scanf("%d %d %d", &A, &B, &C);
    MAIOR = fGreaterNumber(A, B);
    MAIOR = fGreaterNumber(MAIOR, C);

    printf("%d eh o maior\n", MAIOR);

        return 0;

}
