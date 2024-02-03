#pragma warning disable 0649
using System.Collections.Generic;
using UnityEngine;

public class PipeVideoOutput : PipeOutput
{
    List<PipeInput> inputs = new List<PipeInput>();
    public override void Connect(PipeInput input)
    {
    }

    public override void Disconnect(PipeInput input)
    {
    }
}
