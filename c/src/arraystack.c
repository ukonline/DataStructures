// arraystack.c

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>

typedef struct stack
{
	void **data;
	unsigned int top;
	unsigned int capacity;
} arraystack_t;

arraystack_t *stackNew (unsigned int capacity)
{
	arraystack_t *stack = malloc (sizeof (arraystack_t));
	stack->data = malloc (capacity * sizeof (void*));
	stack->top = -1;
	stack->capacity = capacity;
	return stack;
}

int stackSize (arraystack_t *stack)
{
	return stack->top + 1;
}

bool stackEmpty (arraystack_t *stack)
{
	return stackSize (stack) == 0;
}

void *stackTop (arraystack_t *stack)
{
	if (stackEmpty (stack))
	{
		return NULL;
	}
	return stack->data + stack->top;
}

bool stackPush (arraystack_t *stack, void *element)
{
	if (stackSize (stack) == stack->capacity)
	{
		return false;
	}
	stack->top += 1;
	memcpy (stack->data + stack->top, element, sizeof (element));
	return true;
}

void *stackPop (arraystack_t *stack)
{
	if (stackEmpty(stack))
	{
		return NULL;
	}
	void *element = malloc (sizeof (void*));
	memcpy (element, stack->data + stack->top, sizeof (element));
	stack->data[stack->top] = NULL;
	stack->top -= 1;
	return element;
}

void stackFree(arraystack_t *stack)
{
	free (stack->data);
	free (stack);
}

int *Int (int opt)
{
	int *ret = malloc (sizeof (opt));
	*ret = opt;
	return ret;
}
