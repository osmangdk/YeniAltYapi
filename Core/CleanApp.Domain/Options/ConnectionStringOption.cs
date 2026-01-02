using System;

namespace CleanApp.Domain.Options;

public class ConnectionStringOption
 {
     public const string Key = "ConnectionStrings";
     public string PostgreServer { get; set; } = default!;
 }
