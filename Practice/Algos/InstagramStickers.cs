namespace HackerRank.Practice.Algos
{
    public class InstagramStickers
    {
        static int stickers_for(string phrase)
        {
            int count = 0;
            string instagram = "instagram";

            string[] words = phrase.Split(null);

            foreach (string word in words)
            {
                foreach (var letter in instagram)
                {
                    if (word.Contains(letter))
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
    }
}