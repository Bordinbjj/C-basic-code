public class HangmanGame
{
    private string wordToGuess;
    private List<char> guessedLetters;

    public HangmanGame(string word)
    {
        wordToGuess = word.ToUpper();
        guessedLetters = new List<char>();
    }

    public bool GuessLetter(char letter)
    {
        letter = char.ToUpper(letter);

        if (guessedLetters.Contains(letter))
        {
            return false; // Letra já foi tentada
        }

        guessedLetters.Add(letter);

        return wordToGuess.Contains(letter);
    }

    public bool IsWordGuessed()
    {
        return wordToGuess.All(letter => guessedLetters.Contains(letter));
    }
}
