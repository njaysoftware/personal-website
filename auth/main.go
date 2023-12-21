package main

import (
	"github.com/gin-gonic/gin"
)

var Router *gin.Engine

/*
This service's responsibilities are below
1. Authenticate the user
2. Store information about that user
3. Make that information available to other services
4. Be reusable so have multiple services that can subscribe to it
5. have the ability for other services to authenticate themselves to it
6. All network communication will take place over HTTP
Possible Endpoints and their responsibilities
1. POST /auth/user/login
** Would like to make this happen over srp so that username and password are not sent over plain text
** Request:
** {
    username:
    password:
}
Response {
    status: 'auth_passed', 'auth_failed', 'auth_success'
    message: 'blah'
    accessToken: 'jwt'
    refreshToken: 'jwt'
    authRequestDate: unix timestmap
    authRequestId: long nanoid
}
2. /auth/machine
3. POST /data/user/create
Request:
** username
** password
User data
    - id PK
    - publicId unique nanoId
    - username unique hashed not stored in plain text
    - password also hashed salted and peppered
    - salt
    - createdAt
    - updatedAt
    - authDisabled
UserAuthEvents
    - id PK
    - userId FK -> User
    - Type FAILED_USERNAME_NOT_FOUND, FAILED_PASSWORD_WRONG, SUCCESS
    - createAt
UserCurrentTokens
    - id PK
    - expiresAt timestamp
    - token store this as a hash of the actual token
    - Active | Deactivated
    - type REFRESH | ACCESS
    - UserParentRefreshToken null when type is REFRESH and FK -> id on this table. This is so we can track access tokens to refresh tokens.
4. GET /data/user/<publicUserId>
Response: {
    username
}
4. POST /data/machine/create
Machine
    - id
    - publicId
    - ApiKey this is the machines api key which is scoped to all users to start but will want to change that in the future. This will be for machines and unique to them.
4. POST /auth/refresh/token/
Request {
    RefreshToken:
}
Response {
    RefreshToken:
    AccessToken:
    expireIn
}
5. POST /auth/machine/logout
Makes all authTokens disabled if they are tried to be used then they are black listed
{AccessToken}
6. POST /auth/machine/logout/user
    - Note only available to machines
7. GET /auth/jwks
    This should be something than be cached but should rotate everyonce in a while
8. POST /auth/user/disabled_token
Request {
    AccessToken
    This is supposed to see if the token has been disabled or not
}
RESPONSE {
    status: 'good' | 'disabled'

}
*/
func main() {
	Router = gin.Default()
	api := Router.Group("/api")
	{
		api.GET("/test", func(ctx *gin.Context) {
			ctx.JSON(200, gin.H{
				"message": "test successful",
			})
		})
	}
	Router.Run(":5000")
}
