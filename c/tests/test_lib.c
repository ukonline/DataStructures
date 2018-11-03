// test_lib.c

#include <CUnit/Basic.h>

#include "test_arrayqueue.c"
#include "test_arraystack.c"

int main()
{
    if (CU_initialize_registry() != CUE_SUCCESS)
        return CU_get_error();

    if (test_arrayqueue() == NULL ||
        test_arraystack() == NULL)
    {
        CU_cleanup_registry();
        return CU_get_error();
    }

    CU_basic_set_mode(CU_BRM_VERBOSE);
    CU_basic_run_tests();
    CU_cleanup_registry();

    return CU_get_error();
}
