using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnboundLib;
using UnboundLib.Cards;
using UnityEngine;
using RarityLib.Utils;
using Luck;

namespace BindingOfRounds.Cards.Items.Qual0
{
    class AQuarter : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats, CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            //UnityEngine.Debug.Log($"[{SimplyCards.ModInitials}][Card] {GetTitle()} has been setup.");
            
            Luck luck = cardInfo.GetOrAddComponent<Luck>();
            luck.LuckAdd = 0.25;
        }
        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
            //UnityEngine.Debug.Log($"[{SimplyCards.ModInitials}][Card] {GetTitle()} has been added to player {player.playerID}.");

        }
        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data, HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
            //UnityEngine.Debug.Log($"[{SimplyCards.ModInitials}][Card] {GetTitle()} has been removed from player {player.playerID}.");

        }


        protected override string GetTitle()
        {
            return "A Quarter";
        }
        protected override string GetDescription()
        {
            return "25 Cents";
        }
        protected override GameObject GetCardArt()
        {
            return null;
        }
        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Common;
        }
        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Luck",
                    amount = "Larger",
                    simepleAmount = CardInfoStat.SimpleAmount.notAssigned
                }
            };
        }
        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.ColdBlue;
        }
        public override string GetModName()
        {
            return BindingOfRounds.ModInitials;
        }
    }
}
