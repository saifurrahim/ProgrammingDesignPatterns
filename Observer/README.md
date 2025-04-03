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
2. Scalability\
3. Decoupling\

### Cons
1. Complexity\
2. Overhead\
3. Synchronization Problem\

### So, when to NOT use Observer?
1. Simple Code and Logic
2. Critical Performance
3. Undynamic Code