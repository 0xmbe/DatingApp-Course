using System;

namespace API.DTOs;

public class DeleteDto
{
    public required string Username { get; set; }

    public required string Password { get; set; }
}
