# Why?
In some languages, we don't care about the type. Instead, we just read in JSON as an object and go. 

In C# we could do this with a dynmaic type, but we don't have to. This is a very simple little 
program to demonstrate reading in JSON that has schemas for validation.

Note: I've created the schemas with matching C# objects. You wouldn't normally do this! Instead, 
you would generate the schemas from the C# objects themselves. But this is for education purposes 
and it helps to see the schemas.
