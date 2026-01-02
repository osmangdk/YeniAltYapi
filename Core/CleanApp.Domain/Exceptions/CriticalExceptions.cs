using System;

namespace CleanApp.Domain.Exceptions;

public class CriticalExceptions(string message) : Exception(message);
