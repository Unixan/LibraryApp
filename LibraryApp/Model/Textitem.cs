using System.Windows;
using System.Windows.Controls;

namespace LibraryApp.Model;

public class Textitem : TextBlock
{
    public Textitem(string text, int fontsize = 14, bool title = false)
    {
        Margin = new Thickness(5, 1, 5, 1);
        Text = text;
        FontSize = fontsize;
        if (title) FontWeight = FontWeights.Bold;
    }
}