# WebSocket Simple Example

### Projeto

Este é um exemplo bem simples de consumir aplicações em tempo real com ASP.NET utilizando **WebSocket** nativos do .NET.
Neste exemplo temos  duas aplicações, uma que agirá como servidor, onde temos o **WebSocket** e outra como cliente, que irá consumi-los. 
O  **WebSocket** foi implementado em uma Controller, que contém no método Get  um loop infinito com delay de um segundo entre as mensagem.
O cliente é projeto **Console Application** que consome as mensagens do **WebSocket** e imprime na tela.