﻿namespace BookShop.Domain.Entities;


public class Language:BaseAuditableEntity
{
    public Language()
    {
        Books=new HashSet<Book>();
        Prices=new HashSet<Price>();
    }
    public string Name { get; set; } = null!;
    public virtual ICollection<Book> Books { get; set; }
    public virtual ICollection<Price> Prices { get; set; }
}
