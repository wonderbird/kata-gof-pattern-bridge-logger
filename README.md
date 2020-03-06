## Requirements

### To display all received messages at a later time the program provides a Logger interface and an implementation which ...

* ... accepts a log message and persists it in memory.
* ... allows to display all messages received so far.

### To support persisting messages in different storage locations and formats, any of the following mechanisms can be configured: The Logger

* ... allows to persist log messages to memory (as above)
* ... allows to persist log messages in a file
* ... allows to persist log messages in a file which only stores the recent 10 messages

### To facilitate decoupling of Log Message recording from Log Message storing, ...

* ... an "async" Logger shall use an asynchronous way of storing the log messages
* ... the user can select the "old, synchrounous" Logger so that she can debug her application easily
