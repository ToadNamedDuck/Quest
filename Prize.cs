using System;

namespace Quest
{
    public class Prize
    {
        private string _text;

        public Prize(string text)
        {
            _text = text;
        }

        public void ShowPrize(Adventurer adv)
        {
            if (adv.Awesomeness > 0)
            {
                for (int i = 0; i < adv.Awesomeness; i++)
                {
                    Console.WriteLine(_text);
                }
            }
            else
            {
                Console.WriteLine("No prize! Unlucky and sad!");
            }
        }
    }
}