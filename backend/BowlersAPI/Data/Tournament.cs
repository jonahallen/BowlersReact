﻿using System;
using System.Collections.Generic;

namespace BowlersAPI.Data;

public partial class Tournament
{
    public int TourneyId { get; set; }

    public DateOnly? TourneyDate { get; set; }

    public string? TourneyLocation { get; set; }

    public virtual ICollection<TourneyMatch> TourneyMatches { get; set; } = new List<TourneyMatch>();
}