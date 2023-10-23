using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace OpenDeposco.Builder.Controllers;

/// <summary>
/// Enables you to add, update, and retrieve users in Deposco
/// </summary>
[ApiController]
[Route("integration/{code}/users")]
public class UserController : ControllerBase
{
    /// <summary>
    /// Use the PUT method to create a user with the user API.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="code">Company code for your Deposco environment</param>
    /// <returns></returns>
    [HttpPut("")]
    [Consumes("application/json", "application/xml")]
    [Produces("application/json", "application/xml")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(User.UserType))]
    public IActionResult CreateUser(
        [Required, FromBody] User.UserType request,
        [Required, FromRoute] string code) =>
        throw new NotImplementedException();

    /// <summary>
    /// Use the POST method to update a user with the user API
    /// </summary>
    /// <param name="request"></param>
    /// <param name="code">Company code for your Deposco environment</param>
    /// <returns></returns>
    [HttpPost("")]
    [Consumes("application/json", "application/xml")]
    [Produces("application/json", "application/xml")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User.UserType))]
    public IActionResult UpdateUser(
        [Required, FromBody] User.UserType request,
        [Required, FromRoute] string code) =>
            throw new NotImplementedException();

    /// <summary>
    /// Use the GET method to retrieve all active users with the user API
    /// </summary>
    /// <param name="code">Company code for your Deposco environment</param>
    /// <returns></returns>
    [HttpGet("")]
    [Consumes("application/json", "application/xml")]
    [Produces("application/json", "application/xml")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User.UserCollection))]
    public IActionResult GetUsers([Required, FromRoute] string code) =>
        throw new NotImplementedException();

    /// <summary>
    /// Use the GET method to retrieve a specific user with the user API
    /// </summary>
    /// <param name="code">Company code for your Deposco environment</param>
    /// <param name="username">Username of the user to retrieve</param>
    /// <returns></returns>
    [HttpGet("{username}")]
    [Consumes("application/json", "application/xml")]
    [Produces("application/json", "application/xml")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User.UserType))]
    public IActionResult GetUser([Required, FromRoute] string code, [Required, FromRoute] string username) =>
        throw new NotImplementedException();
}
