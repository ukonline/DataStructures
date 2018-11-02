// arraystack.h

#ifndef __ARRAYSTACK_H_
#define __ARRAYSTACK_H_

#include <stdbool.h>

typedef struct stack {
    unsigned int capacity;
    void **data;
    unsigned int top;
} arraystack_t;

arraystack_t *as_new(unsigned int c);

void as_del(arraystack_t *s);

unsigned int as_size(arraystack_t *s);

bool as_empty(arraystack_t *s);

void *as_top(arraystack_t *s);

bool as_push(arraystack_t *s, void *elem);

void *as_pop(arraystack_t *s);

#endif /* __ARRAYSTACK_H_ */
