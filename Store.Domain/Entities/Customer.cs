﻿namespace Store.Domain.Entities;

public class Costumer : Entity
{
    public Costumer(string name, string email)
    {
        Name = name;
        Email = email;
    }
    public string Name { get; private set; }
    public string Email { get; private set; }
}