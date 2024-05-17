#include <stdio.h>
 
int main() {
 
    int HI, HF, MI, MF, dhoras, dminutos;

    scanf("%d %d %d %d", &HI, &MI, &HF, &MF);

    if(HF >= HI) {
        if (MF >= MI) {
            dminutos = MF - MI;
            dhoras = HF - HI;
        }   
        else {
            dminutos = 60 - MI + MF;
            dhoras = HF - HI - 1;
        }
    }
    if (HF == HI) {
        if (MF > MI){
            dminutos = MF - MI;
            dhoras = 0;
        }
        if (MF == MI) {
            dminutos = 0;
            dhoras = 24;
        }
        if (MF < MI) {
            dminutos = 60 - MI + MF;
            dhoras = 23;
        }
        
    }
    if (HF < HI) {
        if (MF >= MI){
            dminutos = MF - MI;
            dhoras = 24 - HI + HF;
        }
        else {
            dminutos = 60 - MI + MF;
            dhoras = 24 - HI + HF - 1;
        }
    }
        
    printf("O JOGO DUROU %d HORA(S) E %d MINUTO(S)\n", dhoras, dminutos);
    return 0;
}