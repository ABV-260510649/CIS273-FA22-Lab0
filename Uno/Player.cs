using System;
using System.Reflection.Metadata.Ecma335;

namespace Uno
{
	public class Player
	{
		public string Name { get; set; }
        public List<Card> Hand { get; set; }


        public Player()
		{
			Name = "";
			Hand = new List<Card>();
		}

         public bool HasPlayableCard(Card card)
		{
			 foreach (Card item in Hand)
			{ 
				bool value = Card.PlaysOn(item, card);
				if (value == true)
				{
					return true;
				} 
			}
			return false;
        } 

        public Card? GetFirstPlayableCard(Card card)
		{
			foreach(Card item in Hand)
			{
                if (Card.PlaysOn(item,card) == true)
                {
					Card playableCard = item;
					return playableCard;
                }
            }

			return null;
		}

        public Color MostCommonColor()
		{
            Dictionary<Uno.Color, int> commonColor= new Dictionary<Uno.Color, int>();
			commonColor.Add(Uno.Color.Red, 0);
            commonColor.Add(Uno.Color.Yellow, 0);
            commonColor.Add(Uno.Color.Blue, 0);
            commonColor.Add(Uno.Color.Green, 0);
			foreach (var card in Hand)
			{			
				commonColor.Add(card.Color, +1);
			}
            foreach (KeyValuePair<Uno.Color, int> pair in commonColor){
				if (pair.Value == commonColor.Values.Max()){
					return pair.Key;
				}				
			}
			return new Color();
        }

    }
}

