﻿using Core.Entities;
using System;

namespace Entities.Concreate
{
    public class Rental : IEntity
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
