public class SecureNote
{
    private string content;
    private string password;

    public SecureNote(string password)
    {
        this.password = password;
    }

    public void WriteNote(string content, string enteredPassword)
    {
        if (enteredPassword == password)
        {
            this.content = content;
        }
        else
        {
            throw new Exception("Senha incorreta!");
        }
    }

    public string ReadNote(string enteredPassword)
    {
        if (enteredPassword == password)
        {
            return content;
        }
        else
        {
            throw new Exception("Senha incorreta!");
        }
    }
}
