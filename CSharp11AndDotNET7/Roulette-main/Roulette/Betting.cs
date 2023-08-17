using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Roulette
{
    public class Betting
    {
        public List<Bet> bets { get; set; } 
        public Betting()
        {
            bets = new List<Bet>();   
        } 

        // -1 for red, -2 for black
        public int CalculateWinning(int number)
        {
            Color color = Color.Empty;
            int winning = 0;

            if(number <= 10)
            {
                if (number % 2 == 0)
                {
                    color = Color.Red;
                }

                else
                {
                    color = Color.Black;
                }
            }
            

            if (number > 10 && number <= 18) 
            {
                if(number % 2 == 0)
                {
                    color = Color.Black;
                }
                else
                {
                    color = Color.Red;
                }
            }

            if (number > 18 && number <= 28)
            {
                if(number % 2 == 0)
                {
                    color = Color.Red;
                }
                else
                {
                    color = Color.Black;
                }
            }

            if (number > 28 && number <= 36)
            {
                if (number % 2 == 0)
                {
                    color = Color.Black;
                }
                else
                {
                    color = Color.Red;
                }
            }

            foreach (Bet bet in bets)
            {
                if(bet.Number == number)
                {
                    winning += bet.Amount * 35;
                }

                if(bet.Number == -2)
                {
                    if(color == Color.Black)
                    {
                        winning += bet.Amount * 2;
                    }          
                }

                if(bet.Number == -1)
                {
                    if(color == Color.Red)
                    {
                        winning += bet.Amount * 2;
                    }
                }
            }

            return winning;
        }   
        public void RemoveLastBet(Wallet w)
        {
            Bet bet = bets[bets.Count - 1];
            w.addValue(bet.Amount);
            bets.RemoveAt(bets.Count - 1);
        }
        public void RemoveAllBets(Wallet w)
        {
            for(int i = bets.Count - 1; i >= 0; i--)
            {
                w.addValue(bets[i].Amount);
                bets.RemoveAt(i);
            }
        }
    }
}
