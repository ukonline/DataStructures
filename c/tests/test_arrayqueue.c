// test_arrayqueue.c

#include <CUnit/Basic.h>
#include <stdbool.h>

#include "arrayqueue.h"
#include "wrapper.h"

void test_aq_new()
{
    arrayqueue_t *q = aq_new(3);
    CU_ASSERT_NOT_EQUAL(q, NULL);
    CU_ASSERT_EQUAL(q->capacity, 3);
    CU_ASSERT_NOT_EQUAL(q->data, NULL);
    CU_ASSERT_EQUAL(q->front, 0);
    CU_ASSERT_EQUAL(q->rear, 0);
    CU_ASSERT_EQUAL(q->full, false);

    aq_del(q);
}

void test_aq_del()
{
    
}

void test_aq_size()
{
    arrayqueue_t *q = aq_new(3);
    CU_ASSERT_EQUAL(aq_size(q), 0);

    aq_enqueue(q, Int(1));
    CU_ASSERT_EQUAL(aq_size(q), 1);

    aq_enqueue(q, Int(2));
    CU_ASSERT_EQUAL(aq_size(q), 2);
    
    aq_enqueue(q, Int(3));
    CU_ASSERT_EQUAL(aq_size(q), 3);
    CU_ASSERT_EQUAL(q->full, true);
    
    aq_enqueue(q, Int(4));
    CU_ASSERT_EQUAL(aq_size(q), 3);
    CU_ASSERT_EQUAL(q->full, true);

    aq_front(q);
    CU_ASSERT_EQUAL(aq_size(q), 3);

    aq_dequeue(q);
    CU_ASSERT_EQUAL(aq_size(q), 2);
    CU_ASSERT_EQUAL(q->full, false);

    aq_dequeue(q);
    CU_ASSERT_EQUAL(aq_size(q), 1);

    aq_dequeue(q);
    CU_ASSERT_EQUAL(aq_size(q), 0);

    aq_dequeue(q);
    CU_ASSERT_EQUAL(aq_size(q), 0);

    aq_del(q);
}

void test_aq_empty()
{
    arrayqueue_t *q = aq_new(3);
    CU_ASSERT_EQUAL(aq_empty(q), true);

    aq_enqueue(q, Int(1));
    CU_ASSERT_EQUAL(aq_empty(q), false);

    aq_dequeue(q);
    CU_ASSERT_EQUAL(aq_empty(q), true);

    aq_enqueue(q, Int(1));
    aq_enqueue(q, Int(2));
    aq_enqueue(q, Int(3));
    CU_ASSERT_EQUAL(aq_empty(q), false);

    aq_del(q);
}

void test_aq_front()
{
    arrayqueue_t *q = aq_new(3);
    CU_ASSERT_EQUAL(aq_front(q), NULL);

    int *val[2] = {Int(1), Int(2)};
    aq_enqueue(q, val[0]);
    CU_ASSERT_EQUAL(aq_front(q), val[0]);
    CU_ASSERT_EQUAL(aq_size(q), 1);

    aq_enqueue(q, val[1]);
    CU_ASSERT_EQUAL(aq_front(q), val[0]);
    CU_ASSERT_EQUAL(aq_size(q), 2);

    CU_ASSERT_EQUAL(aq_dequeue(q), val[0]);
    CU_ASSERT_EQUAL(aq_front(q), val[1]);
    CU_ASSERT_EQUAL(aq_size(q), 1);

    aq_del(q);
}

void test_aq_enqueue()
{
    arrayqueue_t *q = aq_new(3);
    int *val = Int(1);
    CU_ASSERT_EQUAL(aq_enqueue(q, val), true);

    CU_ASSERT_EQUAL(aq_front(q), val);
    CU_ASSERT_EQUAL(aq_size(q), 1);

    CU_ASSERT_EQUAL(aq_enqueue(q, Int(2)), true);
    CU_ASSERT_EQUAL(aq_front(q), val);

    CU_ASSERT_EQUAL(aq_enqueue(q, Int(3)), true);
    CU_ASSERT_EQUAL(aq_front(q), val);

    CU_ASSERT_EQUAL(aq_enqueue(q, Int(4)), false);
    CU_ASSERT_EQUAL(aq_size(q), 3);
    CU_ASSERT_EQUAL(aq_front(q), val);

    aq_del(q);
}

void test_aq_dequeue()
{
    arrayqueue_t *q = aq_new(3);
    CU_ASSERT_EQUAL(aq_dequeue(q), NULL);

    int *val = Int(1);
    aq_enqueue(q, val);
    CU_ASSERT_EQUAL(aq_dequeue(q), val);
    CU_ASSERT_EQUAL(aq_size(q), 0);

    aq_enqueue(q, val);
    aq_enqueue(q, Int(2));
    aq_enqueue(q, Int(3));

    CU_ASSERT_EQUAL(aq_dequeue(q), val);

    aq_del(q);
}

int main()
{
    CU_pSuite pSuite = NULL;

    if (CU_initialize_registry() != CUE_SUCCESS)
        return CU_get_error();

    if ((pSuite = CU_add_suite("arrayqueue test suite", NULL, NULL)) == NULL) {
        CU_cleanup_registry();
        return CU_get_error();
    }

    if (CU_add_test(pSuite, "test of test_aq_new", test_aq_new) == NULL ||
        CU_add_test(pSuite, "test of test_aq_del", test_aq_del) == NULL ||
        CU_add_test(pSuite, "test of test_aq_size", test_aq_size) == NULL ||
        CU_add_test(pSuite, "test of test_aq_empty", test_aq_empty) == NULL ||
        CU_add_test(pSuite, "test of test_aq_front", test_aq_front) == NULL ||
        CU_add_test(pSuite, "test of test_aq_enqueue", test_aq_enqueue) == NULL ||
        CU_add_test(pSuite, "test of test_aq_dequeue", test_aq_dequeue) == NULL)
    {
        CU_cleanup_registry();
        return CU_get_error();
    }

    CU_basic_set_mode(CU_BRM_VERBOSE);
    CU_basic_run_tests();
    CU_cleanup_registry();

    return CU_get_error();
}
