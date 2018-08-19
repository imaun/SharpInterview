using System;
using System.Collections.Generic;
namespace SharpInterview.Algorithms {
    public interface IStack<T> {
        void Push(T item);
        T Pop();
        T Peek();
        bool IsEmpty();
        List<T> GetAll();
    }

    public class Stack<T> : IStack<T> {
        private int top = -1;
        public int Capacity { get; set; }
        private T[] Items { get; set; }

        public Stack(int capacity) {
            Capacity = capacity;
        }

        public T Peek() {
            if (IsEmpty())
                return default(T);
            return Items[top];
        }

        public T Pop() {
            if (IsEmpty())
                return default(T);
            return Items[top--];
        }

        public void Push(T item) {
            if (top == Capacity - 1)
                throw new StackOverflowException("Stack is full!");
            else {
                Items[++top] = item;
            }
        }

        public bool IsEmpty() {
            return top == -1;
        }

        public List<T> GetAll() {
            if (IsEmpty())
                return null;
            var result = new List<T>();
            for(int i = top; i > -1; i--) {
                result.Add(Items[i]);
            }
            return result;
        }
    }
}
