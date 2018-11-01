// wrapper.c

#include "wrapper.h"

#include <stdlib.h>

int *Int(int val)
{
    int *ret = malloc(sizeof(int));
    *ret = val;
    return ret;
}
