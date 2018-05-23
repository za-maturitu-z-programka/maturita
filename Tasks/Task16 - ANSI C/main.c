#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <limits.h>

#define LEN 6

int compareValues(const void *a, const void *b)
{
    return (*(int*)a - *(int*)b);
}

int main()
{
    int nums[LEN];
    int i, min = INT_MAX, max = INT_MIN, sum = 0;
    float avg, med;

    srand(time(NULL));

    printf("Nahodne vygenerovana cisla jsou:");

    for (i = 0; i < LEN; i++)
    {
        nums[i] = rand();
        printf(" %d", nums[i]);
        if (i != LEN - 1)
        {
            printf(",");
        }

        if (nums[i] < min)
        {
            min = nums[i];
        }

        if (nums[i] > max)
        {
            max = nums[i];
        }

        sum += nums[i];
    }

    qsort(nums, LEN, sizeof(int), compareValues);

    avg = (float)sum / (float)LEN;
    if ((LEN % 2) == 0)
    {
        med = (float)(nums[LEN / 2 - 1] + nums[LEN / 2]) / 2;
    }
    else
    {
        med = nums[(LEN + 1) / 2 - 1];
    }

    printf("\n\n\
Minimum: %d\n\
Maximum: %d\n\
Prumer: %.2f\n\
Median: %.2f", min, max, avg, med);

    return 0;
}
