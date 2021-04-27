namespace Eadent.DataTransferObjects
{
    public class EMailSettingsDto
    {
        public string HostName { get; set; }

        public int HostPort { get; set; }

        public string SenderEMailAddress { get; set; }

        public string SenderPassword { get; set; }

        public string FromEMailName { get; set; }

        public string FromEMailAddress { get; set; }
    }
}
