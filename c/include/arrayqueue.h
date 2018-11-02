// arrayqueue.h

#ifndef __ARRAYQUEUE_H_
#define __ARRAYQUEUE_H_

#include <stdbool.h>

typedef struct queue {
    unsigned int capacity;
    void **data;
    unsigned int front;
    unsigned int rear;
    bool full;
} arrayqueue_t;

arrayqueue_t *aq_new(unsigned int c);

void aq_del(arrayqueue_t *q);

unsigned int aq_size(arrayqueue_t *q);

bool aq_empty(arrayqueue_t *q);

void *aq_front(arrayqueue_t *q);

bool aq_enqueue(arrayqueue_t *q, void *elem);

void *aq_dequeue(arrayqueue_t *q);

#endif /* __ARRAYQUEUE_H_ */
