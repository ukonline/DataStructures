# Makefile

IDIR=include
CC=gcc
CFLAGS=-I$(IDIR) -std=c99 -pedantic -Wall -O3 -Wshadow -Wextra -Werror

SDIR=src
TDIR=tests
ODIR=obj
BDIR=bin
OUT_DIR=$(ODIR) $(BDIR)

LIBNAME=datastructures.a
TESTNAME=tests/test_lib.o

_DEPS=arrayqueue.h wrapper.h
DEPS=$(patsubst %,$(IDIR)/%,$(_DEPS))

_LOBJ=arrayqueue.o arraystack.o wrapper.o
LOBJ=$(patsubst %,$(ODIR)/%,$(_LOBJ))

$(ODIR)/%.o: $(SDIR)/%.c $(DEPS)
	$(CC) -c $< -o $@ $(CFLAGS)

$(ODIR)/%.o: $(TDIR)/%.c
	$(CC) -c $< -o $@ $(CFLAGS)

$(OUT_DIR):
	mkdir -p $(OUT_DIR)

lib: $(OUT_DIR) $(LOBJ)
	ar rcs $(BDIR)/$(LIBNAME) $(LOBJ)

tests: lib $(TESTNAME)
	$(CC) $(TESTNAME) $(BDIR)/$(LIBNAME) -lcunit -o $(BDIR)/test
	$(BDIR)/test

all: lib tests

.PHONY: clean

clean:
	rm -rf $(BDIR)
	rm -rf $(ODIR)
