# Random User

- [Random User](#random-user)
  - [Requirements](#requirements)
  - [Setup](#setup)
  - [Architecture](#architecture)
  - [Domain](#domain)
  - [Use Cases](#use-cases)
    - [GetUserList](#getuserlist)
    - [GetUser](#getuser)
    - [UpdateUser](#updateuser)
    - [DeleteUser](#deleteuser)

## Requirements

- Visual Studio
- .NET Core

## Setup

`git clone https://github.com/josh-asi/random-user.git`

## Architecture

I have tried to implement the **Ports and Adapter Pattern/Hexagonal Architecture**. I also try to closelow follow Domain Driven Design and have implemented as to how I understand it.

## Domain

- Email: The user's e-mail address
- Name: The name of a user which includes title, first and last name
- Date of Birth: The year the person was born, including the age
- Phone Number: A seven digit number representing the phone number of a user
- Profile Images: A link to the profile image
- ID: The identifier which would link to a specific user

## Use Cases

1. GetUserList
2. GetUser
3. UpdateUser
4. DeleteUser

### GetUserList

Returns all the users. Filters can be applied such a number limit or by name.

**Limit**: `GET /api/users/limit/{number}`

**First Name**: `GET /api/users/first-name/{name}`

**Last Name**: `GET /api/users/last-name/{name}`

### GetUser

Returns a user based on the id.

`GET /api/user/{id}`

### UpdateUser

Updates the details of a user based on the request body.

`POST /api/user/update`

### DeleteUser

Deletes the user from the database based on the id.

`DELETE /api/user/delete/{id}`
