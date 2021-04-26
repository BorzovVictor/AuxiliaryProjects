## Binary Serialization
The main idea is serialize an object graph into memory and then deserialize it back to an object.
No matter how complex the object is, it will be fully cloned.

##### Requirement
Copied class and all related ones need to be marked with `[Serializable]` attribute.

##### Cons:
There is no choice between shallow and deep copies. 
Only the deep copy option is available for using serialization.

## XML Serialization
The main idea is serialize an object graph into memory and then deserialize it back to an object.

##### Pros:
Full control over what we clone.

##### Cons:
if copied class has a constructor with parameters and hasn't default constructor we'll get an error

## JSON Serialization 
Create a deep Copy of the object. 

##### Cons:
Private members are not cloned using this method.