// arrayqueue.c

#include "arrayqueue.h"

#include <stdlib.h>

arrayqueue_t *aq_new(unsigned int capacity)
{
    arrayqueue_t *q = malloc(sizeof(arrayqueue_t));
    q->capacity = capacity;
    q->data = malloc(capacity * sizeof(void*));
    q->front = 0;
    q->rear = 0;
    q->full = false;
    return q;
}

void aq_del(arrayqueue_t *q)
{
    free(q->data);
    free(q);
}

unsigned int aq_size(arrayqueue_t *q)
{
    if (q->full)
        return q->capacity;
    return (q->capacity + q->rear - q->front) % q->capacity;
}

bool aq_empty(arrayqueue_t *q)
{
    return aq_size(q) == 0;
}

void *aq_front(arrayqueue_t *q)
{
    if (aq_empty(q))
        return NULL;
    return *(q->data + q->front);
}

bool aq_enqueue(arrayqueue_t *q, void *element)
{
    if (aq_size(q) == q->capacity)
        return false;
    *(q->data + q->rear) = element;
    q->rear = (q->rear + 1) % q->capacity;
    if (q->front == q->rear)
        q->full = true;
    return true;
}

void *aq_dequeue(arrayqueue_t *q)
{
    if (aq_empty(q))
        return NULL;
    void *element = *(q->data + q->front);
    *(q->data + q->front) = NULL;
    q->front = (q->front + 1) % q->capacity;
    if (q->full)
        q->full = false;
    return element;
}
