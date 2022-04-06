#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <time.h>



typedef struct stack {

    int sp;
    int v[100];

}Stack;

void Push(Stack* stack, int x);
int Pop(Stack* stack);
void Clear(Stack* stack);
int Is_empty(Stack* stack);
double povrh(double n, double k);
int povrh_na_stogu(Stack* one, Stack* two, int upp, int down);



int main()
{
    time_t t1, t2, t3, t4;
    double broj, rekurzija, stog;

    Stack* one;
    Stack* two;

    one = (Stack*)malloc(sizeof(Stack));
    two = (Stack*)calloc(1, sizeof(Stack));
    printf("Unesi broj: ");
    scanf("%lf", &broj);

    t1 = clock();
    rekurzija = povrh((int)broj, (int)broj / 2);
    t2 = clock();
    t3 = clock();
    stog = povrh_na_stogu(one, two, broj, broj / 2);
    t4 = clock();
    printf("Rekurzija\n");
    printf("%.0lf\t%.0lf\t%ld\n", broj, rekurzija, t2 - t1);
    printf("Stog\n");
    printf("%.0lf\t%.0lf\t%ld\n", broj, stog, t4 - t3);

}


double povrh(double n, double k)
{
    if (k > n)return 0;
    else if (k == 0 || n == k) return 1;
    return povrh(n - 1, k - 1) + povrh(n - 1, k);
}

int povrh_na_stogu(Stack* one, Stack* two, int upp, int down) {

    int n, k;

    Clear(one);

    Clear(two);

    Push(one, upp);

    Push(two, down);

    int povrh = 0;

    do {
        n = Pop(one);

        k = Pop(two);

        if (n == k || n == 1 || k == 0) {

            povrh = povrh + 1;

        }
        else {

            Push(one, n - 1);

            Push(two, k - 1);

            Push(one, n - 1);

            Push(two, k);

        }

    } while (Is_empty(one) == 0);

    return povrh;

}

int Is_empty(Stack* stack) {

    if (stack->sp == 0)

        return 1;

    else return 0;

}






int Pop(Stack* stack) {

    if (stack->sp == 0) {

        printf("Illegal POP. Aborting...");

        exit(EXIT_FAILURE);

    }

    int x = stack->v[stack->sp];

    stack->sp = stack->sp - 1;

    return x;

}

void Push(Stack* stack, int x) {

    if (stack->sp >= (sizeof(stack->v) / sizeof(int))) {

        printf("Pogreška!");

        exit;

    }

    stack->sp += 1;
    stack->v[stack->sp] = x;

}

void Clear(Stack* stack) {

    stack->sp = 0;

}