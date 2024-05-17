#include <stdio.h>
#define MAX 20 
int main() {
 
    char str1[MAX], str2[MAX], str3[MAX];

    fgets(str1, MAX, stdin);
    fgets(str2, MAX, stdin);
    fgets(str3, MAX, stdin);

    if(str1[0]=='v' && str2[0]=='a' && str3[0] == 'c')
        printf("aguia\n");
    if(str1[0]=='v' && str2[0]=='a' && str3[0] == 'o')
        printf("pomba\n");
    if(str1[0]=='v' && str2[0]=='m' && str3[0] == 'o')
        printf("homem\n");
    if(str1[0]=='v' && str2[0]=='m' && str3[0] == 'h')
        printf("vaca\n");
    if(str1[0]=='i' && str2[0]=='i' && str3[2] == 'm')
        printf("pulga\n");
    if(str1[0]=='i' && str2[0]=='i' && str3[2] == 'r')
        printf("lagarta\n");
    if(str1[0]=='i' && str2[0]=='a' && str3[0] == 'h')
        printf("sanguessuga\n");
    if(str1[0]=='i' && str2[0]=='a' && str3[0] == 'o')
        printf("minhoca\n");

 
    return 0;
}