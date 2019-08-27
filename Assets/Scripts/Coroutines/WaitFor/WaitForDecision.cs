﻿namespace PimPamPum
{
    public class WaitForDecision : WaitForTimer
    {
        private const Decision startDecision = Decision.Pending;
        private Decision timeOutDecision;
        private bool decisionMade;

        public Decision Decision
        {
            get; private set;
        }

        public override bool MoveNext()
        {
            bool res = base.MoveNext() && !decisionMade;
            if (!res && !decisionMade)
            {
                MakeDecision(timeOutDecision);
            }
            return res;
        }

        public WaitForDecision() : this(Decision.Pending) { }

        protected WaitForDecision(Decision timeOutDecision) : base()
        {
            this.timeOutDecision = timeOutDecision;
            Decision = startDecision;
        }

        public override void MakeDecision(Decision decision, Card card = null)
        {
            Decision = decision;
            decisionMade = decision != startDecision;
        }
    }
}