using System;

public class Button
{
    public delegate void ClickHandler();

    // Event based on the delegate
    public event ClickHandler OnClick;

    // Method to simulate button click
    public void Click()
    {
        // Trigger the event if there are any subscribers
        if (OnClick != null)
        {
            OnClick();
        }
    }
}

public class MainClass
{
    public static void Main()
    {
        Button button = new Button();

        // Subscribe to the OnClick event
        button.OnClick += ButtonClicked;

        // Simulate button click
        button.Click();
    }

    // Event handler method
    public static void ButtonClicked()
    {
        Console.WriteLine("Button was clicked!");
    }
}

