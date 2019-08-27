﻿using System.Collections;

{
    public class Gatling : Card
    {
        public override void BeginCardDrag(PlayerController pc)
        {
            base.BeginCardDrag(pc);
            pc.SelfTargetCard();
        }

        protected override IEnumerator CardEffect(PlayerController pc, int player, Drop drop, int cardIndex)
        {
            yield return base.CardEffect(pc, player, drop, cardIndex);
            pc.CheckNoCards();
            yield return pc.Gatling();
        }

        public override IEnumerator CardUsed(PlayerController pc)
        {
            yield return GameController.Instance.UsedCard<Gatling>(pc);
        }

        public override string ToString()
        {
            return "Gatling";
        }
    }
}