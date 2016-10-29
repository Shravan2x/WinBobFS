namespace WinBobFS
{
    public static class InputBox
    {
        public static string Show(string message)
        {
            InputForm inputForm = new InputForm(message);
            inputForm.ShowDialog();
            return inputForm.Input;
        }
    }
}
