const express = require('express')
const socketio = require('socket.io')
const http = require('http')
const path = require('path')
const app = express()
const server = http.Server(app)
const io = socketio(server)

app.get('/', (req, res) => {
  res.sendFile(path.join(__dirname + '/index.html'))
})

server.listen(3000, () => {
  console.log('listening on 3000')
})

io.on('connection', (socket) => {
  socket.on('test', data => {
    console.log(data)
  })

  setInterval(() => {
    let time = new Date()
    socket.emit('test-2', 'hello from server ' + time)
  }, 1000)

})