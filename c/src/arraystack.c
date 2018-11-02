// arraystack.c

#include "arraystack.h"

#include <stdlib.h>

arraystack_t *as_new(unsigned int capacity)
{
    arraystack_t *s = malloc(sizeof(arraystack_t));
    s->capacity = capacity;
    s->data = malloc(capacity * sizeof(void*));
    s->top = -1;
    return s;
}

void as_del(arraystack_t *s)
{
    free(s->data);
    free(s);
}

unsigned int as_size(arraystack_t *s)
{
    return s->top + 1;
}

bool as_empty(arraystack_t *s)
{
    return as_size(s) == 0;
}

void *as_top(arraystack_t *s)
{
    if (as_empty(s))
        return NULL;
    return *(s->data + s->top);
}

bool as_push(arraystack_t *s, void *elem)
{
    if (as_size(s) == s->capacity)
        return false;
    s->top += 1;
    *(s->data + s->top) = elem;
    return true;
}

void *as_pop(arraystack_t *s)
{
    if (as_empty(s))
        return NULL;
    void *element = *(s->data + s->top);
    *(s->data + s->top) = NULL;
    s->top -= 1;
    return element;
}
