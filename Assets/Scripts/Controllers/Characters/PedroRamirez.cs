﻿using System.Collections;

namespace PimPamPum
{
    public class PedroRamirez : PlayerController
    {
        protected override IEnumerator DrawPhase1()
        {
            if (GameController.HasDiscardStackCards)
            {
                GameController.Instance.SetPhaseOneDiscardClickable(PlayerNumber);
                WaitForPhaseOneChoice phaseOneChoice = new WaitForPhaseOneChoice(PlayerNumber);
                yield return phaseOneChoice;
                switch (phaseOneChoice.PhaseOneOption)
                {
                    case PhaseOneOption.Deck:
                        yield return base.DrawPhase1();
                        break;
                    case PhaseOneOption.Discard:
                        Card discard = GameController.Instance.GetDiscardTopCard();
                        AddCard(discard);
                        Draw();
                        break;
                }
            }
            else
            {
                yield return base.DrawPhase1();
            }
        }
    }
}