using System;

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        var random = new Random();
        var availableWords = Words.Where(word => !word.IsHidden).ToList();
        int wordsToHide = Math.Min(count, availableWords.Count); // Adjust count if fewer words are available

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(availableWords.Count);
            availableWords[index].Hide();
            availableWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{Reference}\n{string.Join(' ', Words)}";
    }
}

