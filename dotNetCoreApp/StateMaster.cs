using System;
using System.Collections.Generic;

namespace dotNetCoreApp;

public partial class StateMaster
{
    public byte StateId { get; set; }

    public string StateCode { get; set; } = null!;

    public string? ShortName { get; set; }

    public string StateName { get; set; } = null!;

    public bool StateOrUt { get; set; }

    public string? GstinorUin { get; set; }

    public int? StateAdminId { get; set; }

    public decimal? PreviousYearTurnOver { get; set; }

    public decimal? PreviousQuarterTurnOver { get; set; }

    public string? GstnuserName { get; set; }

    public string? StateAddress { get; set; }

    public string? GstinonTds { get; set; }

    public string? EmailId { get; set; }

    public string? Statename1 { get; set; }

    public string? Statename2 { get; set; }

    public string? Brcode { get; set; }

    public string? GstnonTdsuserName { get; set; }

    public string? EwayUserN { get; set; }

    public string? EwayUserP { get; set; }

    public string? Gstnisd6userName { get; set; }

    public string? Gstinisd6 { get; set; }

    public string? Isdgstin { get; set; }

    public DateTime? LastImsFetchedOn { get; set; }

    public decimal? Isdrate { get; set; }
}
