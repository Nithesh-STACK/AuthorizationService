﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AuthorizationService.KaniniModel
{
    public partial class BookingT
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string MoviePoster { get; set; }
    }
}
