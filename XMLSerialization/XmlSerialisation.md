## XML Serialization
The main idea is serialize an object graph into memory and then deserialize it back to an object.
No matter how complex the object is, it will be fully cloned.

#### Pros:
Full control over what we clone.

#### Cons:
Copy constructors must be implemented in every class included in the object graph, 
but for now, it's work without any constructors