# C# - Unexpected Code Execution After Exception Handling

This example demonstrates a common error in C# exception handling.  After catching an exception, subsequent code might execute even if the previous operation failed. This can lead to unexpected results or data inconsistencies. 

The `bug.cs` file contains code that shows this behavior; the `bugSolution.cs` demonstrates an improved approach that addresses potential issues. 