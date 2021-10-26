# BYTAGE

Hash Checker Bypass and Process Hacker

![](https://i.imgur.com/3tHopkL.png)

## Use Case

This project was designed to bypass hash checkers in authentication systems that have their authentication code in a DLL library. Said library is checked for tampering in the main program by comparing the file hashes.

### How the auth systems work

The entire code of the auth system is inside either a .NET or Native DLL library. It includes the essential functions for the authentication system like for example the web requests to the API and the functions for grabbing the hardware identifiers.

But this design has one big flaw: if you would just de-compile the DLL (it doesn't matter if it's obfuscated as all we need  is the method signatures and not the body) and return `true` for example in the `Login(username, password)` method and replace the DLL, the auth would be bypassed completely.

To protect against this rather simple attack, the creators of the auth systems stated to implement a hash check. They simply compare the hash of the DLL file at runtime with the original hash. If it doesn't match, the file has been tampered with and the program terminates.

Of course, if the program isn't obfuscated properly you could just change said hash. But then you could just remove the entire auth as well.

### How BYTAGE bypasses this protection

As stated above, the hash of the DLL file is checked at program startup. So you can't just replace the DLL with a modified version that bypasses the auth. Or can you?

With a little bit of help from this project - BYTAGE - you can.

BYTAGE starts the target process and suspends it after a certain amount of time, after the hash check succeeded. It then replaces the DLL with a modified one that replaces the auth. But as the hash check only gets called once at the start and the DLL gets replaced later, we can just swap it and should be able to log in with any credentials.