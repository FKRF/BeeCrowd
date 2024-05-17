#include <stdio.h>
 
int main() {
 
    int HI, HF, duracao;

    scanf("%d %d", &HI, &HF);

    if(HF > HI)
        duracao = HF - HI;
    if(HF == HI)
        duracao = 24;
    if(HF < HI)
        duracao = 24 - HI + HF;

    printf("O JOGO DUROU %d HORA(S)\n", duracao);
    return 0;
}