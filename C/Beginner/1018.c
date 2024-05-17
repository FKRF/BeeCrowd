#include <stdio.h>

void fzero_array(int* A, int l) {

    int i;

    for(i=0;i<l;i++) {
        A[i] = 0;
    }
}
int main() {

    int N, i;
    int notas[7] = {100, 50, 20, 10, 5, 2, 1};
    int qnotas[7];

    //fzero_array(&qnotas, 8);

    scanf("%d", &N);

    printf("%d\n", N);

    for (i=0;i<7;i++) {
        //printf("qnotas[%d] = %i\n", i, qnotas[i]);
        //printf("%d\n", i);
        qnotas[i] = N/notas[i];
        printf("%d nota(s) de R$ %d,00\n", qnotas[i], notas[i]);
        N = N % notas[i];
        //printf("%d\n", N);
    }

    return 0;

}

