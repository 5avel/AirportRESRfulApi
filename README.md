# AirportRESRfulApi
ASP.NET Core Web API for Airport

How to compile
==============

1. Install software

- Git
  https://git-for-windows.github.io/
  Select a file summarized as "Full installer for official Git for Windows"
   with the highest version
- Visual Studio
  http://www.visualstudio.com/downloads/download-visual-studio-vs
  Select "Visual Studio Community 2017 for Windows Desktop" version 15.7.5 or newer.
- Microsoft .NET Core 2.1

2. Check out

- Create an empty folder anywhere
- In explorer left click and select "Git Clone"
  set URL https://github.com/5avel/AirportRESRfulApi.git
  OK

3. Build

- Open ParkingWebAPI.sln with Visual Studio 2017 for windows desktop.
- Compile.

4. Use

-Open Postman (https://www.getpostman.com/) or Fiddler (https://www.telerik.com/fiddler)
## Endpoints API
Type |         Method        | Description                                                          | Sample
------|-----------------------|---------------------------------------------------------------------|--------------------------
GET   | /api/Tickets          | Список всіх бiлетiв                                                 |
GET   | /api/Tickets/{id}     | Один бiлет по id                                                    | /api/Tickets/2
GET   | /api/Tickets/{flightId}/{flightDate} | Вiльнi бiлети по рейсу на дату                       | /api/Tickets/QW11/2018-07-13T08:22:56.6404304+03:00
GET   | /api/Tickets/Bay/{id}  | Покупка бiлета                                                     | /api/Tickets/Bay/2
GET   | /api/Tickets/Return/{id}| Повернення бiлета                                                 | /api/Tickets/Return/2
GET   | /api/Stewardesses | Список всіх стюардес                                                    | /api/Stewardesses
GET   | /api/Stewardesses/{id}   | Одна по id                                                       | /api/Stewardesses/2
POST  | /api/Stewardesses   | Додати стюардессу                                                     | /api/Stewardesses
PUT   | /api/Stewardesses/{id}   | Оновити стюардессу                                               | /api/Stewardesses/2
DELETE| /api/Stewardesses/{id}    | Видалити стюардессу                                             | /api/Stewardesses/2
GET   | /api/Pilots | Список всіх стюардес                                                        | /api/Pilots
GET   | /api/Pilots/{id}     | Однин по id                                                        | /api/Pilots/2
POST  | /api/Pilots          | Додати пiлота                                                      | /api/Pilots
PUT   | /api/Pilots/{id}     | Оновити пiлота                                                     | /api/Pilots/2
DELETE| /api/Pilots/{id}     | Видалити пiлота                                                    | /api/Pilots/2
GET   | /api/PlaneTypes | Список всіх стюардес                                                        | /api/PlaneTypes
GET   | /api/PlaneTypes/{id}     | Однин по id                                                        | /api/PlaneTypes/2
POST  | /api/PlaneTypes          | Додати тип лiтака                                                      | /api/PlaneTypes
PUT   | /api/PlaneTypes/{id}     | Оновити тип лiтака                                                     | /api/PlaneTypes/2
DELETE| /api/PlaneTypes/{id}     | Видалити тип лiтака                                                    | /api/PlaneTypes/2
GET   | /api/Planes | Список всіх стюардес                                                        | /api/Planes
GET   | /api/Planes/{id}     | Однин по id                                                        | /api/Planes/2
POST  | /api/Planes          | Додати лiтак                                                      | /api/PlPlanesaneTypes
PUT   | /api/Planes/{id}     | Оновити лiтак                                                     | /api/Planes/2
DELETE| /api/Planes/{id}     | Видалити лiтак                                                    | /api/Planes/2

![REST](https://github.com/5avel/AirportRESRfulApi/blob/develop/123.jpg)
