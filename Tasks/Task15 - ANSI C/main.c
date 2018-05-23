#include <stdio.h>
#include <stdlib.h>

#include <math.h>

int a, b, c, shouldRepeat = 1;

int main()
{
    printf("Vitejte v programu pro reseni kvadraticke rovnice\nve tvaru ax^2 + bx + c = 0");

    while (shouldRepeat == 1)
    {
        printf("\n\n");
        setupCoefficients();
        computeRoots();

        printf("\n\nPrejete si zadat nove koeficienty? (1 - ano, 0 - ne)");
        shouldRepeat = getInteger();
    }

    return 0;
}

void setupCoefficients()
{
    printf("Zadejte koeficient a: ");
    a = getInteger();

    printf("Zadejte koeficient b: ");
    b = getInteger();

    printf("Zadejte koeficient c: ");
    c = getInteger();
}

void computeRoots()
{
    float out1, out2, tmp;

    if (a == 0)
    {
        if (b == 0)
        {
            if (c == 0)
            {
                printf("Resenim jsou vsechna realna cisla.");
            }
            else
            {
                printf("Resenim je prazdna mnozina.");
            }
        }
        else if (c == 0)
        {
            printf("Resenim je 0.");
        }
        else
        {
            out1 = - ((float)c / (float)b);
            printf("Resenim je %.2f", out1);
        }
    }
    else if (c == 0)
    {
        if (b == 0)
        {
            printf("Resenim je 0");
        }
        else
        {
            out1 = - ((float)b / (float)a);
            printf("Resenim je 0 a %.2f", out1);
        }
    }
    else if (b == 0)
    {
        out1 = - ((float)c / (float)a);
        if (out1 < 0)
        {
            printf("Reseni se nachazi v oboru komplexnich cisel.");
        }
        else
        {
            out1 = sqrt(out1);
            printf("Resenim je %.2f a %.2f", out1, -out1);
        }
    }
    else
    {
        tmp = b * b - 4 * a * c;
        if (tmp < 0)
        {
            printf("Reseni se nachazi v oboru komplexnich cisel.");
        }
        else if (tmp == 0)
        {
            out1 = - ((float)b / (float)(2 * a));
            printf("Resenim je %.2f", out1);
        }
        else
        {
            out1 = (float)(-b + sqrt(tmp)) / (float)(2 * a);
            out2 = (float)(-b - sqrt(tmp)) / (float)(2 * a);

            printf("Resenim je %.2f a %.2f", out1, out2);
        }
    }
}

int getInteger()
{
    char *end_char, buffer[50];
    int num;

    while (fgets(buffer, sizeof(buffer), stdin)) {
        num = strtol(buffer, &end_char, 10);
        if (end_char == buffer || *end_char != '\n') {
            printf("Zadal(a) jste neplatne cislo.\nOpakujte prosim akci: ");
        } else break;
    }

    return num;
}
