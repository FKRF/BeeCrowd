#include <stdio.h>
 
int main() {
 
    int flag, m, n, i, sum;

    flag = 1;

    while (flag != 0) {
        scanf("%d %d", &m, &n);
        if (m <= 0 || n <= 0)
            flag = 0;
        else {
            if (m > n) {
                i = m;
                m = n;
                n = i;
            }
            for(i=m, sum=0; i<=n; i++) {
                printf("%d ", i);
                sum += i;
            }
            printf("Sum=%d\n", sum);
        }
    }
 
    return 0;
}