namespace TGL_Practice2_HW.Services.Interfaces
{
    internal interface IUserDialog
    {
        public void StartUpInfo();
        public void Inform(string _info);
        public string AskString(string _question, string[] _answers);
        public bool AskBool(string _question);

        public void Clear();

    }
}
