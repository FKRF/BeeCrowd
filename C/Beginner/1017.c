#include <stdio.h>
 
int main() {
 
    int horas, vmedia;
    float litros;
    
    scanf("%d\n%d", &horas, &vmedia);
    litros = ( vmedia*horas)/12;
    
    printf("%.3f\n", litros);
 
    return 0;
}