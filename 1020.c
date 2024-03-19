#include <stdio.h>
 
int main() {
 
    int tempo, anos, meses, dias;
    
    scanf("%d", &tempo);
    anos = tempo / 365;
    tempo = tempo % 365;
    meses = tempo / 30;
    dias = tempo % 30;
    
    printf("%d ano(s)\n%d mes(es)\n%d dia(s)\n", anos, meses, dias);
    return 0;
}