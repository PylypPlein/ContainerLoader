﻿namespace ContainerLoaderSimulator;

public class HazardousOperationException : Exception
{
    public HazardousOperationException(string message) : base(message)
    {
    }
}