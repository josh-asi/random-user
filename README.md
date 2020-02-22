# Random User

[![Build Status](https://travis-ci.com/josh-asi/random-user.svg?token=M4v3im2oWiwKUJqLzCYB&branch=master)](https://travis-ci.com/josh-asi/random-user)

This project is meant to emulate the Api for [https://randomuser.me/](https://randomuser.me).

Created by **Josh Asi**

- [Random User](#random-user)
  - [Requirements](#requirements)
  - [Technologies](#technologies)
  - [Setup](#setup)
  - [Architecture](#architecture)
  - [Domain](#domain)
  - [Use Cases](#use-cases)
    - [GetUsers](#getusers)
    - [GetUser](#getuser)
    - [UpdateUser](#updateuser)
    - [DeleteUser](#deleteuser)
  - [Known Limitations / To Do](#known-limitations--to-do)
  - [License](#license)

## Requirements

- Visual Studio
- .NET Core 3.1.x

## Technologies

- C#
- .NET Core
- Entity Framework Core
- Sqlite

## Setup

`git clone https://github.com/josh-asi/random-user.git`

Open Visual Studio and run the project RandomUser.WebApi. Swagger will open by default.

## Architecture

I have tried to implement the **Ports and Adapter Pattern/Hexagonal Architecture**. I also try to closely follow Domain Driven Design and have implemented as to how I understand it.

## Domain

- ID: The identifier which would link to a specific user
- Email: The user's e-mail address
- Name: The name of a user which includes title, first and last name
- Date of Birth: The year the person was born
- Phone Number: A seven digit number representing the phone number of a user
- Profile Images: A link to the profile image

## Use Cases

1. GetUsers
2. GetUser
3. UpdateUser
4. DeleteUser

### GetUsers

Returns all the users. Filters can be applied such a number limit or by name.

**Limit**: `GET /api/users/{limit}`

**First Name**: `GET /api/users/first-name/{name}`

**Last Name**: `GET /api/users/last-name/{name}`

### GetUser

Returns a user based on the id.

`GET /api/user/{userId}`

### UpdateUser

Updates the name of a user based on the request body.

`POST /api/user/name`

### DeleteUser

Deletes the user from the database based on the id.

`DELETE /api/user/{userId}`

## Known Limitations / To Do

- Currently, only names can be updated
- When updating a name, a User object is returned. The e-mail and phone number will not have any values as they are private properties
- Data seeding has not been tested
- No tests for the WebAPI project yet

## License

This project is licensed under the ISC license, Copyright (c) 2020 Josh Asi. For more information see [LICENSE.md](License.MD).
