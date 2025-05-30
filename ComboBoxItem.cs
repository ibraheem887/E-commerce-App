public class ComboBoxItem
{
    public string Text { get; set; }
    public string Value { get; set; }

    public override string ToString()
    {
        return Text; // Ensures that the `Text` property is displayed in the ComboBox
    }
}
