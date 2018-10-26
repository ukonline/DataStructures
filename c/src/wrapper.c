// weapper.c

int *Int(int val)
{
    int *ret = malloc(sizeof(int));
    *ret = val;
    return ret;
}
