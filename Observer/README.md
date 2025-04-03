## Observer
Observer is a design pattern that allow an object to observe and respond to a change of other object. This pattern dividing the object that observing (observer) from the object that observed (subject), so it can enhance flexibility and scalability.

### Components
1. Subject\
    The observed object that updating the observer object when there is a change.

2. Observer\
    The object that tracking the subject and responding to the changes.

3. Interface\
    The interface that used by the subject to update the observer. 