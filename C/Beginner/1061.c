#include <stdio.h>
 
int main() {
 
    int diai, hi, mi, si, diaf, hf, mf, sf;
    int dias, horas, minutos, segundos;

    scanf("Dia %d", &diai);
    scanf("%d:%d:%d", &hi, &mi, &si);
    fflush(stdin);
    scanf("Dia %d", &diaf);
    scanf("%d:%d:%d", &hi, &mi, &si);

    printf("%d %d %d\n", hi, mi, si);
    printf("%d\n", diai);

    dias = 0;
    segundos = 60 - si + sf;
    if (segundos >= 60) {
        minutos++;
        segundos = segundos % 60;
    }
    minutos = minutos + 60 - mi + mf;
    if (minutos >= 60) {
        horas++;
        minutos = minutos % 60;
    }
    horas = horas + 24 - hi + hf;
    if (horas >= 24) {
        dias++;
        horas = horas % 24;
    }
    dias = dias - diai + diaf - 1;


    printf("%d dia(s)\n%d hora(s)\n%d minuto(s)\n%d segundo(s)\n", dias, horas, minutos, segundos);
    return 0;
}