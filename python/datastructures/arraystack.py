# arraystack.py

class Arraystack:
    def __init__(self, capacity):
        self.__data = [0] * capacity
        self.__top = -1
        self.__capacity = capacity
    
    def size(self):
        return self.__top + 1
    
    def isempty(self):
        return self.size() == 0
    
    def top(self):
        if self.isempty():
            raise EmptyStackException()
        return self.__data[self.__top]
    
    def push(self, element):
        if self.size() == self.__capacity:
            raise FullStackException()
        self.__top += 1
        self.__data[self.__top] = element
    
    def pop(self):
        if self.isempty():
            raise EmptyStackException()
        element = self.__data[self.__top]
        self.__data[self.__top] = None
        self.__top -= 1
        return element