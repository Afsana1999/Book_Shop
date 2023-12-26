﻿namespace BookShop.Application.Feutures.Address.Dtos;

public class AddressDetailDto:IMapFrom<BSDE.Address>
{
    public int Id { get; set; }
    public string? AddressName { get; set; }
    public string? Appartment { get; set; }
    public string? ZIPCode { get; set; }

    //One to Many
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public int StateId { get; set; }
    public State State { get; set; }
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
}
