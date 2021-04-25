##Binary Serialization
The main idea is serialize an object graph into memory and then deserialize it back to an object.
No matter how complex the object is, it will be fully cloned.

####Requirement
Copied class and all related ones need to be marked with `[Serializable]` attribute.

#### Cons:
There is no choice between shallow and deep copies. 
Only the deep copy option is available for using serialization.