// arrayqueue.c

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>

typedef struct queue {
    void **data;
    unsigned int front;
    unsigned int rear;
    unsigned int capacity;
    unsigned int size;
} arrayqueue_t;

arrayqueue_t *queueNew(unsigned int capacity)
{
    arrayqueue_t *queue = malloc(sizeof(arrayqueue_t));
    queue->data = malloc(capacity * sizeof(void*));
    queue->front = 0;
    queue->rear = 0;
    queue->capacity = capacity;
    queue->size = 0;
    return queue;
}

int queueSize(arrayqueue_t *queue)
{
    return queue->size;
}

bool queueEmpty(arrayqueue_t *queue)
{
    return queueSize(queue) == 0;
}

void *queueFront(arrayqueue_t *queue)
{
    if (queueEmpty(queue))
        return NULL;
    return queue->data + queue->front;
}

bool queueEnqueue (arrayqueue_t *queue, void *element)
{
    if (queueSize(queue) == queue->capacity)
        return false;
    memcpy(queue->data + queue->rear, element, sizeof(element));
    queue->rear = (queue->rear + 1) % queue->capacity;
    queue->size += 1;
    return true;
}

void *queueDequeue(arrayqueue_t *queue)
{
    if (queueEmpty(queue))
        return NULL;
    void *element = malloc(sizeof(void*));
    memcpy(element, queue->data + queue->front, sizeof(element));
    queue->data[queue->front] = NULL;
    queue->front = (queue->front + 1) % queue->capacity;
    queue->size -= 1;
    return element;
}

void queueFree(arrayqueue_t *queue)
{
    free(queue->data);
    free(queue);
}
