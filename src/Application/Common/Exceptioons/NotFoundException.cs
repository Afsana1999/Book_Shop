﻿namespace BookShop.Application.Common.Exceptioons;

public class NotFoundException:Exception
{
	public NotFoundException():base("Entity was not found"){}
	public NotFoundException(string message):base(message){}
	public NotFoundException(string message, Exception innerException):base(message, innerException){}
    public NotFoundException(string name, object key) : base($"Entity \"{name}\" {key} was not found") {}

}
