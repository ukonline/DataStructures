// test_arraystack.c

#include <CUnit/Basic.h>
#include <stdbool.h>

#include "arraystack.h"
#include "wrapper.h"

void test_as_new()
{
    
}

void test_as_del()
{
    
}

void test_as_size()
{
    
}

void test_as_empty()
{
    
}

void test_as_top()
{
    
}

void test_as_push()
{
    
}

void test_as_pop()
{
    
}

CU_pSuite test_arraystack()
{
    CU_pSuite pSuite = NULL;

    if ((pSuite = CU_add_suite("arraystack test suite", NULL, NULL)) == NULL) {
        return NULL;
    }

    if (CU_add_test(pSuite, "test of test_as_new", test_as_new) == NULL ||
        CU_add_test(pSuite, "test of test_as_del", test_as_del) == NULL ||
        CU_add_test(pSuite, "test of test_as_size", test_as_size) == NULL ||
        CU_add_test(pSuite, "test of test_as_empty", test_as_empty) == NULL ||
        CU_add_test(pSuite, "test of test_as_top", test_as_top) == NULL ||
        CU_add_test(pSuite, "test of test_as_push", test_as_push) == NULL ||
        CU_add_test(pSuite, "test of test_as_pop", test_as_pop) == NULL)
    {
        return NULL;
    }

    return pSuite;
}
