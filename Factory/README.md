## Factory
Factory is a design pattern that allow object creation without knowing the concrete class that will be created. Like its name, this design pattern act as factory that create object based on the given parameters.

### Pros
1. Increasing flexibility

    Factory allows variety of object creations based on parameter.

2. Reduce code repetition

  Place the creation logic in a class to be used again and again.

3. Increase code maintainability

  All your object creation logic in one place.

### Cons
1. Increasing complexity

  Added an abstraction layer to the code.

2. Reduce readability

  Concrete classes are not directly visible, and possible that programmer only look at the factory or abstract class more often.

3. Increasing abstraction dependency

  If you change/add the abstraction method, likely you will need to adjust all the concrete classes.

### So, When to NOT use Factory?
1. Simple logic

  If your logic don't require flexibility.

2. Unchanged class

  If the your object's class doesn't need to change.

3. Fast pace development

  No flexible logic required and the code need to be delivered quickly 
