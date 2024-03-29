﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Player
    {
        public NeoFighter NeoFighter { get; private set; }
        public Agent Agent { get; private set; }

        public void SetNeoFighter(NeoFighter fighter)
        {
            this.NeoFighter = fighter;
        }
        public void SetAgent(AgentType agentType)
        {
            this.Agent = new Agent(agentType);
        }
    }
}
