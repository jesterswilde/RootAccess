#pragma warning disable 0649
using System.Collections.Generic;

public interface IFlagEnabled{
    List<Requirement> Requirements { get; }
    void SetEnabled(bool enabled);
}
