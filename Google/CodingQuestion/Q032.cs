﻿/*Flatter iterations
 * https://techdevguide.withgoogle.com/resources/former-interview-question-flatten-iterators/#!
 Former interview question: flatten iterators
If you like tongue twisters and a challenge that tests your creativity, sink your teeth into this former Google interview question where you'll be asked to implement a unique type of iterator.
 
 The Challenge
Given an iterator of iterators, implement an interleaving iterator
Background: Iterator defined

In object-oriented programming, the iterator pattern is a design pattern in which an iterator is used to traverse a container and access the container's elements. The iterator pattern decouples algorithms from containers; in some cases, algorithms are necessarily container-specific and thus cannot be decoupled. This code snippet illustrates:

Copy
int[] arr = [1, 2, 3];
Iterator<Integer> it = arr.iterator();
while(it.hasNext()){
  print it.next();
}
// 123
hasNext() // returns whether or not the iterator has additional elements
next() // returns next element in iterator, throws NoSuchElementException otherwise.
    
Your challenge, should you choose to accept it...
Given an iterator of iterators, implement an interleaving iterator that takes in an iterator of iterators, and emits elements from the nested iterators in interleaved order. That is, if we had the iterators i and j iterating over the elements [ia, ib, ic] and [ja, jb] respectively, the order in which your interleaving iterator should emit the elements would be [ia, ja, ib, jb, ic].

Your interleaving iterator should implement the Iterator interface, take in the iterator of iterators in its constructor, and provide the next and hasNext methods. Assume that there are no additional methods offered by the iterator.

Given the following three iterators put into an array of iterators…

Copy
int[] arr1 = [1, 2, 3];
int[] arr2 = [4, 5];
int[] arr3 = [6, 7, 8, 9];
Iterator<Integer> a = arr1.iterator();
Iterator<Integer> b = arr2.iterator();
Iterator<Integer> c = arr3.iterator();
Iterator<Integer>[] iterlist = [a, b, c];
    
… build an “Interleaving Flattener” (IF), which works much like an iterator:

Copy
IF itfl = new IF(iterlist);
while(IF.hasNext()){
  print IF.next();
}
// 1 4 6 2 5 7 3 8 9
    
To assist you, here’s a skeleton for the class:

Copy
class IF{
  public IF(Iterator<T>[] iterlist){
  }
  public T next(){
  }
  
  public boolean hasNext(){
  }
}
    
Learning objectives
This question gives you the chance to practice with iterators, iteration, data structures, classes, and nesting. It calls for thoughtful problem-solving and optimizing your solution. If you write it successfully in one language, try it again in a second.
 */