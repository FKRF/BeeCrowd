#include <stdio.h>
#include <curses.h>
 
int main() {
 
    int c, flag;
    int vt[2], i;

    i = 0;    
    flag = 1;
    while(flag != 0) {
        c = getch();
        if (c == EOF) {
            flag = 0;
            break;
        }
        else {
            if (c != ' ')
                vt[i++] = c;
                
        }
        if (i == 2) i = 0;
    printf("v e t sao %d %d\n", vt[0], vt[1]);
    }
    
    

    return 0;
}
