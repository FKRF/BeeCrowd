# include <stdio.h>

int main() {

    int N, i;

    scanf("%d", &N);

    int vetor[N];
    vetor[0] = 0;
    vetor[1] = 1;

    /*
    if (N==1) {
        printf("%d", vetor[0]);
    }
    if (N==2) {
        printf("%d ", vetor[0]);
        printf("%d", vetor[1]);
    }
    if (N>2) {
        printf("%d ", vetor[0]);
        printf("%d", vetor[1]);

        for (i=2;i<N;i++) {
            vetor[i] = vetor[i-2] + vetor[i-1];
            printf(" %d", vetor[i]);
        }
    }

    printf("\n");
    */

    printf("%d ", vetor[0]);
    printf("%d", vetor[1]);

    for (i=2;i<N;i++) {
        vetor[i] = vetor[i-2] + vetor[i-1];
        printf(" %d", vetor[i]);
    }
    return 0;
}
