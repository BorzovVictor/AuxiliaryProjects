## XML Serialization
The main idea is serialize an object graph into memory and then deserialize it back to an object.


#### Pros:
Full control over what we clone.

#### Cons:
if copied class has a constructor with parameters and hasn't default constructor we'll get an error