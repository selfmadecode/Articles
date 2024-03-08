# Dependency Injection Design Pattern in C#

Dependency injection design pattern is a popularly used design pattern in software development
to achieve loose coupling and improve the testability, maintainability, and scalability of software
applications. In c#, DI (Dependency Injection) is often implemented using frameworks like .NET
or third-party libraries (Unity, Ninject and others).

Before we dive in, let talk about loose coupling and tight coupling.

**Tight coupling** is a scenario where components within a system are highly dependent on each other,
making them difficult to change independently, if you decide to change the dependent object, then you
also need to change the classes where this dependent object is being used.

**Loose Coupling** means components within a system are independent of each other. That means if we change 
one object then it will not affect any other object that depends on it.

Imagine trying to permanently change your skin color — it is challenging because it’s tightly coupled to
your body. Now, picture changing your outfit. Much easier, right? That’s the beauty of loose coupling.

## What is Dependency Injection?
Dependency Injection is a pattern that involves injecting dependencies (services or objects) into a class
that depends on the objects or services, rather than having the class create the dependencies itself.

Read the full article and practical example [here](https://medium.com/@anyanwuraphaelc/dependency-injection-design-patterns-in-c-b982c141dcb2)
