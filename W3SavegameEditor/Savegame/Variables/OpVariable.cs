﻿namespace W3SavegameEditor.Savegame.Variables
{
    public class OpVariable : TypedVariable
    {
        public override string ToString()
        {
            return "OP " + base.ToString();
        }
    }
}