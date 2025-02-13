using System;

class TextEditorState
{
    public string Content { get; set; }
    public TextEditorState Prev { get; set; }
    public TextEditorState Next { get; set; }

    public TextEditorState(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextEditorState currentState;
    private int maxHistory = 10; // Limit history size
    private int stateCount = 0;

    public void AddState(string content)
    {
        TextEditorState newState = new TextEditorState(content);

        if (currentState != null)
        {
            currentState.Next = newState;
            newState.Prev = currentState;
        }
        currentState = newState;
        stateCount++;

        // Ensure history limit
        if (stateCount > maxHistory)
        {
            TextEditorState temp = currentState;
            while (temp.Prev != null) temp = temp.Prev;
            temp.Next.Prev = null;
        }
    }

    public void Undo()
    {
        if (currentState != null && currentState.Prev != null)
        {
            currentState = currentState.Prev;
            Console.WriteLine("Undo: " + currentState.Content);
        }
        else
            Console.WriteLine("No previous state.");
    }

    public void Redo()
    {
        if (currentState != null && currentState.Next != null)
        {
            currentState = currentState.Next;
            Console.WriteLine("Redo: " + currentState.Content);
        }
        else
            Console.WriteLine("No next state.");
    }

    public void DisplayCurrentState()
    {
        Console.WriteLine("Current Text: " + (currentState != null ? currentState.Content : "No text available."));
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");
        editor.DisplayCurrentState();

        editor.Undo();
        editor.Undo();
        editor.Redo();
        editor.DisplayCurrentState();
    }
}
