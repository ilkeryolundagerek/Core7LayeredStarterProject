﻿using System;
using System.Collections.Generic;

namespace Core.Concretes.Entities;

/// <summary>
/// Current version number of the AdventureWorks 2014 sample database. 
/// </summary>
public partial class AwbuildVersion
{
    /// <summary>
    /// Primary key for AWBuildVersion records.
    /// </summary>
    public byte SystemInformationId { get; set; }

    /// <summary>
    /// Version number of the database in 9.yy.mm.dd.00 format.
    /// </summary>
    public string DatabaseVersion { get; set; } = null!;

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime VersionDate { get; set; }

    /// <summary>
    /// Date and time the record was last updated.
    /// </summary>
    public DateTime ModifiedDate { get; set; }
}
