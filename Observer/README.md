## Observer
Observer is a design pattern that allow an object to observe and respond to a change of other object. This pattern dividing the object that observing (observer) from the object that observed (subject), so it can enhance flexibility and scalability.

### Components
1. Subject\
    The observed object that updating the observer object when there is a change.
2. Observer\
    The object that tracking the subject and responding to the changes.
3. Interface\
    The interface that used by the subject to update the observer.

### How It Works
1. Subject updating the data and calling the ```notifyObserver()``` method to update the observer.\
2. Observer receive the changes via ```update()``` method and do some action regarding the changes.

### Pros
1. Flexibility\
    Observer can be added and removed dynamically.
2. Scalability\
    This pattern allow adding observer without affecting the subject.
3. Decoupling\
    Subject and Observer are divided, so it is possible to change only one of them without affecting the other.

### Cons
1. Complexity\
    Design pattern always adding complexity to the code.
2. Overhead\
    Updating the observer is consuming times and resources.
3. Synchronization Problem\
    Observer can updating the data without complying synchronization, so synchronization mechanism must be added.

### So, when to NOT use Observer?
1. Simple Code and Logic\
    If the code is simple enough that doesn't need a flexibility and scalability, then no need to use this pattern. 
2. Critical Performance\
    If the performance is the number one priority and the overhead can affect the performance, then this pattern shouldn't be used.