﻿using Domain.Entities;


namespace Domain.Ports
{
    public interface IGuestRepository
    {
        Task<Guest> Get(int id);
        Task<int> Save(Guest guest);
    }
}
