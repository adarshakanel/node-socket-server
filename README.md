# Node.js Socket.io Server

## Installation

Download Unity Socket.io Library from here [https://github.com/Rocher0724/socket.io-unity/releases]

In Unity, navigate to

```
Build Settings > Player Settings > Other Settings > Configuration
```

and change

```
Api Compatibility Level: .NET 4.x
```


Also, note that npm socket.io library only works with v2.x, instead of 3.x or higher.


## Setup

Install nmp packages in the terminal

```
npm install
```

Then, start server.js

```
node server.js
```

Then, access to http://localhost:3000/

You should be able to see the following log in the terminal

```
listening on 3000
hello
```

and you should be able to see the following log in the browser web inspector

```
hello from server Thu Mar 04 2021 12:44:49 GMT-0700
hello from server Thu Mar 04 2021 12:44:50 GMT-0700
hello from server Thu Mar 04 2021 12:44:51 GMT-0700
...
```