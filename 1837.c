#include <stdio.h>

void mod_pos(int a, int b, int *q, int *r);
void mod_aneg(int a, int b, int *q, int *r);
void mod_bneg(int a, int b, int *q, int *r);
void mod_abneg(int a, int b, int *q, int *r);

int main() {
 
    int a, b, q, r;

    scanf("%d %d", &a, &b);

    if (a > 0 && b > 0)
        mod_pos(a, b, &q, &r);
    if (a < 0 && b > 0)
        mod_aneg(a, b, &q, &r);
    if (a > 0 && b < 0)
        mod_bneg(a, b, &q, &r);
    if (a < 0 && b < 0)
        mod_abneg(a, b, &q, &r);
    if (a == 0)
        q = r = 0;
    if (b == 0) {
        q = 0;
        r = a;
    }

    printf("%d %d\n", q, r);
    //printf("%d = %d x %d + %d\n", a, b, q, r);

    return 0;
}

void mod_pos(int a, int b, int *q, int *r){ 
    int i, j, k;
    j = k = 0;
    for(i=0; i<a;i++) {
        j += 1;
        
        if (j==b) {
            j = 0;
            k += 1;
        }    
        //printf("%d\n", j);
    }
    *q = k;
    *r = j;

}

void mod_aneg(int a, int b, int *q, int *r) {
    int i, j, k;
    j = k = 0;
    for(i=0; i<a*(-1);i++) {
        j -= 1;
        
        if (j==-1) {
            j = b-1;
            k += 1;
        }   
        //printf("%d\n", j);
    }
    *q = (-1)*k;
    *r = j;

}

void mod_bneg(int a, int b, int *q, int *r) {
    int i, j, k;
    j = k = 0;
    b *= -1;
    for(i=0; i<a;i++) {
        j += 1;
        
        if (j==b) {
            j = 0;
            k += 1;
        }    
        //printf("%d\n", j);
    }
    *q = (-1)*k;
    *r = j;

}

void mod_abneg(int a, int b, int *q, int *r){ 
    int i, j, k;
    j = k = 0;
    b *= -1;
    for(i=0; i<a*(-1);i++) {
        j -= 1;
        
        if (j==-1) {
            j = b-1;
            k += 1;
        }   
        //printf("%d\n", j);
    }
    *q = k;
    *r = j;

}