﻿namespace TwitterCloneBackend.Entities.Models;

public class Replies : Base
{

    public Tweet Tweet { get; set; }

    public string RepliedComment { get; set; }
}