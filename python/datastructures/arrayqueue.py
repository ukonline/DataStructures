# arrayqueue.py

class EmptyQueueException(Exception):
    pass

class FullQueueException(Exception):
    pass

class Arrayqueue:
    def __init__(self, capacity):
        self.__data = [0] * capacity
        self.__front = 0
        self.__rear = 0
        self.__capacity = capacity
    
    def size(self):
        return (self.__capacity - self.__front + self.__rear) % self.__capacity
    
    def isempty(self):
        return self.size() == 0
    
    def front(self):
        if self.isempty():
            raise EmptyQueueException()
        return self.__data[self.__front]
    
    def enqueue(self, element):
        if self.size() == self.__capacity - 1:
            raise FullQueueException()
        self.__data[self.__rear] = element
        self.__rear = (self.__rear + 1) % self.__capacity
    
    def dequeue(self):
        if self.isempty():
            raise EmptyQueueException()
        element = self.__data[self.__front]
        self.__data[self.__front] = None
        self.__front = (self.__front + 1) % self.__capacity
        return element